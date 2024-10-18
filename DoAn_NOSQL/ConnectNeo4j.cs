using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_NOSQL.Model;
using Neo4j.Driver;
namespace DoAn_NOSQL
{
    class ConnectNeo4j
    {
        //     
        IDriver _driver;
        Mapping mapping = new Mapping();
        public ConnectNeo4j()
        {
            try
            {
                var uri = "neo4j+s://02d4ebcb.databases.neo4j.io";
                var user = "neo4j";
                var password = "zZa17l3SncffXr0gu4n9isi1IHkGyxSuIyijNf9Q8Ps";
                _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
                Console.WriteLine("hehe");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<User> LoginAsync(string username, string password)
        {
            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync(
                    "MATCH (u:USER {username: $username, password: $password}) RETURN u",
                    new { username, password });

                var records = await result.ToListAsync();

                if (records.Count > 0)
                {
                    var userNode = records[0]["u"].As<INode>();
                    return mapping.MapUser(userNode);
                }
                return null;
            }
        }
        public async Task<List<User>> ListIsFriendOfUser(int id)
        {
            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync(
                    "MATCH (p:USER{user_id:$id})-[:IS_FRIEND_WITH]-(w:USER) RETURN w;",
                    new { id });

                var records = await result.ToListAsync();
                var users = new List<User>();

                foreach (var record in records)
                {
                    var userNode = record["w"].As<INode>();

                    users.Add(mapping.MapUser(userNode));
                }

                return users;
            }
        }
        /// <summary>
        /// 1 là người chủ động xóa, 2 là ng bị xóa
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        public async Task<bool> DeleteRelationshipFriend(int id1, int id2)
        {
            using (var session = _driver.AsyncSession())
            {
                try
                {
                    var result = await session.RunAsync(
                        "MATCH (u1:USER {user_id: $id1})-[r:IS_FRIEND_WITH]-(u2:USER {user_id: $id2}) " +
                        "DELETE r RETURN COUNT(r) AS deletedCount",
                        new { id1, id2 });
                    if (await result.FetchAsync())
                    {
                        return result.Current["deletedCount"].As<int>() > 0;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// lấy ra danh sách không phải là bạn của thằng đang đăng nhập
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<List<User>> NotFriendList(int id)
        {
            using (var session = _driver.AsyncSession())
            {
                var users = new List<User>();

                try
                {
                    var result = await session.RunAsync(
    "MATCH (u:USER) " +
    "WHERE NOT (u)-[:IS_FRIEND_WITH]-(:USER { user_id: $id }) " +
    "  AND u.user_id <> $id " +
    "  AND NOT (u)-[:SENT_REQUEST]->(:FRIENDREQUEST { from_user_id: u.user_id, to_user_id: $id }) " +
    "OPTIONAL MATCH (fr:FRIENDREQUEST { from_user_id: $id, to_user_id: u.user_id, status: 'SENDING'}) " +
    "RETURN u, fr IS NOT NULL AS hasSending",
    new { id });


                    while (await result.FetchAsync())
                    {
                        var userNode = result.Current["u"].As<INode>();
                        var hasPendingRequest = result.Current["hasSending"].As<bool>();
                        var user = mapping.MapUser(userNode);
                        user.HasSendingRequest = hasPendingRequest;

                        users.Add(user);
                    }
                }
                catch (Exception ex)
                {

                }

                return users;
            }
        }


        /// <summary>
        /// kết bạn , id1 là mình, id2 là ngta =))
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        public async Task<bool> AddFriendRequest(int senderId, int receiverId)
        {
            using (var session = _driver.AsyncSession())
            {
                try
                {
                    int request_id = await GetRequestID() + 1;
                    var result = await session.RunAsync(
                        "MATCH (u1:USER {user_id: $senderId}), (u2:USER {user_id: $receiverId}) " +
                        "MERGE (request:FRIENDREQUEST {from_user_id: $senderId, to_user_id: $receiverId, status: 'SENDING'}) " +
                        "ON CREATE SET request.request_id = $request_id, request.sent_at = timestamp() " +
                        "MERGE (u1)-[:SENT_REQUEST]->(request) " +
                        "MERGE (u2)-[:RECEIVED_REQUEST]->(request) " +
                        "RETURN COUNT(*) AS count",
                        new { senderId, receiverId, request_id });

                    if (await result.FetchAsync())
                    {
                        return result.Current["count"].As<int>() > 0;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public async Task<bool> CancelFriendRequest(int senderId, int receiverId)
        {
            using (var session = _driver.AsyncSession())
            {
                try
                {
                    var result = await session.RunAsync(
                        "MATCH (u:USER {user_id: $senderId})-[:SENT_REQUEST]->(f:FRIENDREQUEST {to_user_id: $receiverId}) " +
                        "DETACH DELETE f " +
                        "RETURN COUNT(*) AS count",
                        new { senderId, receiverId });

                    if (await result.FetchAsync())
                    {
                        return result.Current["count"].As<int>() > 0;
                    }

                    return false;
                }
                catch (Exception ex)
                {

                    return false;
                }
            }
        }

        public async Task<int> GetRequestID()
        {
            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync(
                  "MATCH (n:FRIENDREQUEST) RETURN n;");
                var records = await result.ToListAsync();
                return records.Count;
            }

        }

        public async Task<List<User>> ListFriendRequestRecived(int id)
        {
            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH (fr:FRIENDREQUEST {to_user_id: $id})" +
                    " MATCH(fr) -[:SENT_REQUEST]-(u2: USER) " +
                    "OPTIONAL MATCH(u2)-[:IS_FRIEND_WITH] - (mutualFriend: USER) -[:IS_FRIEND_WITH] - (u: USER { user_id: $id}) " +
                    "RETURN u2, COUNT(mutualFriend) AS mutualFriend", new { id });
                var records = await result.ToListAsync();
                var users = new List<User>();

                foreach (var record in records)
                {
                    var userNode = record["u2"].As<INode>();
                    var user = mapping.MapUser(userNode);
                    user.mutualFriend = record["mutualFriend"].As<int>();
                    users.Add(user);

                }

                return users;
            }
        }
        public async Task<bool> AcceptFriendRequest(int senderId, int receiverId)
        {
            using (var session = _driver.AsyncSession())
            {
                try
                {
                    var result = await session.RunAsync(
                      " MATCH(fr: FRIENDREQUEST { from_user_id: $senderId, to_user_id: $receiverId})" +
                      " MATCH(u1: USER { user_id: $senderId}), (u2: USER { user_id: $receiverId}) " +
                      " CREATE(u1) -[:IS_FRIEND_WITH]->(u2) " +
                      " DETACH DELETE fr RETURN COUNT(*) AS count",
                        new { senderId, receiverId });

                    if (await result.FetchAsync())
                    {
                        return result.Current["count"].As<int>() > 0;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public async Task<bool> CreatePostByUser(int userId, string content)
        {
            using (var session = _driver.AsyncSession())
            {
                try
                {
                    int postId = await GetNextPostId() + 1;

                    var result = await session.RunAsync(
                        "CREATE (p:POST {post_id: $postId, content: $content, created_at: timestamp()}) " +
                        "WITH p " +
                        "MATCH (u:USER {user_id: $userId}) " +
                        "CREATE (u)-[:POSTED]->(p) " +
                        "RETURN p, u",
                        new { userId, postId, content });
                    return await result.FetchAsync();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        private async Task<int> GetNextPostId()
        {

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync(
                  "MATCH (n:POST) RETURN n;");
                var records = await result.ToListAsync();
                return records.Count;
            }
        }
        public async Task<List<Post>> GetPostsWithUser(int id)
        {
            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH (u:USER{user_id:$id})-[:POSTED]-(p:POST) " +
                   "OPTIONAL MATCH (p)-[:Likes]-(l:USER)"+
                    "OPTIONAL MATCH(p) -[:HAS_COMMENT]-(c: COMMENT) " +
                    "OPTIONAL MATCH(c)-[:COMMENTED] - (commenter: USER) " +
                    "RETURN p, c,count(l) as numberLike, commenter ", new { id });

                var posts = new List<Post>();

                while (await result.FetchAsync())
                {
                    var postNode = result.Current["p"].As<INode>();
                    var postId = postNode.Properties["post_id"].As<int>();
                    var countLike = result.Current["numberLike"].As<int>();
                    
                    var post = posts.FirstOrDefault(p => p.post_id == postId);

                    if (post == null)
                    {
                        post = new Post
                        {
                            post_id = postId,
                            content = postNode.Properties["content"].As<string>(),
                            created_at = DateTimeOffset.FromUnixTimeMilliseconds((long)postNode.Properties["created_at"])
                                            .ToString("yyyy-MM-dd HH:mm:ss"),
                            Comments = new List<Comment>()
                        };
                        post.countLikes = countLike;
                        posts.Add(post);
                    }

                    var commentNode = result.Current["c"]?.As<INode>();
                    if (commentNode != null)
                    {
                        var comment = new Comment
                        {
                            comment_id = commentNode.Properties["comment_id"].As<int>(),
                            content = commentNode.Properties["content"].As<string>(),
                            created_at = commentNode.Properties["created_at"].As<string>(),
                            commenter = null
                        };

                        var commenterNode = result.Current["commenter"]?.As<INode>();
                        if (commenterNode != null)
                        {
                            comment.commenter = mapping.MapUser(commenterNode);
                        }

                        post.Comments.Add(comment);
                    }
                }

                return posts;
            }
        }

        public async Task<bool> CreateCommentPost(int userId, int post_id, string content)
        {
            using (var session = _driver.AsyncSession())
            {
                int comment_id = await GetCommentIDNext() + 1;
                try
                {
                    var result = await session.RunAsync(
                        "MATCH (u:USER {user_id: $userId}) " +
                        "MATCH (p:POST {post_id: $post_id}) " +
                        "CREATE (c:COMMENT {comment_id: $comment_id, content: $content, created_at: timestamp()}) " +
                        "MERGE (u)-[:COMMENTED]->(c) " +
                        "MERGE (p)-[:HAS_COMMENT]->(c) " +
                        "RETURN u, p, c",
                        new
                        {
                            userId,
                            post_id,
                            content,
                            comment_id, 
                
                        });

                    return result != null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while creating comment: {ex.Message}");
                    return false;
                }
            }
        }


        public async Task<int> GetCommentIDNext()
        {
            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync("MATCH(N:COMMENT) RETURN COUNT(N)");
                var records = await result.ToListAsync();
                return records.Count;
            }
        }
    }

}
