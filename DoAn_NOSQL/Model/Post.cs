using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.Model
{
    public class Post
    {
        public int post_id { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
        public List<Comment> Comments { get; set; } // Chú ý sử dụng `Comments` với chữ cái hoa
        public int countLikes { get; set; }
        public Post()
        {
            Comments = new List<Comment>(); // Khởi tạo danh sách comments
        }
    }
}   
