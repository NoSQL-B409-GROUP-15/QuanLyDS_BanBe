using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{
    //FRIENDREQUEST: REQUEST_ID, FROM_USER_ID, TO_USER_ID, STATUS,SENT_AT

    class FriendRequest
    {
        public string REQUEST_ID { get; set; }
        public string FROM_USER_ID { get; set; }
        public string TO_USER_ID { get; set; }
        public string STATUS { get; set; }
        public string SENT_AT { get; set; }
    }
}
