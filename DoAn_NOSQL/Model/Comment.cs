using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{
    //COMMENT: COMMENT_ID,CONTENT, CREATED_AT

    public class Comment
    {
        public int comment_id { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
    }
}
