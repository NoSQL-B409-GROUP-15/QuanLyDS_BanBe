using DoAn_NOSQL.Model;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL
{
   public class Mapping
    {
        public User MapUser(INode userNode)
        {
            return new User
            {
                user_id = userNode.Properties["user_id"].As<int>(),
                username = userNode.Properties["username"].As<string>(),
                created_at = userNode.Properties["created_at"].As<string>(),
                mail = userNode.Properties["mail"].As<string>(),
                name = userNode.Properties["name"].As<string>(),
                password = userNode.Properties["password"].As<string>()
            };
        }

    }
}
