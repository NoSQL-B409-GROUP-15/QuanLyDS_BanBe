using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{
    //POST: POST_ID,CONTENT, CREATED_AT

    public class Post
    {
        public int post_id { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
    }
}
