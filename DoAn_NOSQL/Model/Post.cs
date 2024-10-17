using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{
    //POST: POST_ID,CONTENT, CREATED_AT

    class Post
    {
        public string POST_ID { get; set; }
        public string CONTENT { get; set; }
        public string CREATED_AT { get; set; }
    }
}
