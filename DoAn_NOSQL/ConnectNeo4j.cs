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

                    var user = new User
                    {
                        USER_ID = userNode.Properties["user_id"].As<string>(),
                        USERNAME = userNode.Properties["username"].As<string>()
                    };
                    return user;
                }
                return null;
            }
        }
        public async Task<User> ListBanBe(string id)
        {
         
            return null;
        }
    }
    
}
