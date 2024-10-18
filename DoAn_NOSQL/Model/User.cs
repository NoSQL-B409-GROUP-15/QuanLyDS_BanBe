using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{


//USER: USER_ID,NAME, USERNAME, PASSWORD, CREATED_AT, MAIL
    public class User
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string created_at { get; set; }
        public string mail { get; set; }
        public string phoneNumber { get; set; }
        public string image { get; set; }
        public bool HasSendingRequest { get; set; }
        public int mutualFriend { get; set; }
    }
}
