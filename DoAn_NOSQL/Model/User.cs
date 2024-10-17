using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{


//USER: USER_ID,NAME, USERNAME, PASSWORD, CREATED_AT, MAIL
    class User
    {
        public string USER_ID { get; set; }
        public string NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string CREATED_AT { get; set; }
        public string MAIL { get; set; }
    }
}
