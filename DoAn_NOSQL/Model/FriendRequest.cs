using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{
    //FRIENDREQUEST: REQUEST_ID, FROM_USER_ID, TO_USER_ID, STATUS,SENT_AT

    public class FriendRequest
    {
        public int request_id { get; set; }
        public int from_user_id { get; set; }
        public int to_user_id { get; set; }
        public string status { get; set; }
        public string send_at { get; set; }
    }
}
