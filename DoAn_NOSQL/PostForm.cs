using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_NOSQL.Model;
namespace DoAn_NOSQL
{
    public partial class PostForm : Form
    {
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public User userActive
        { get; set;}
        public PostForm()
        {
            InitializeComponent();
            btnDangBai.Click += BtnDangBai_Click;

        }

        private async void BtnDangBai_Click(object sender, EventArgs e)
        {
            if (txContent.Text.Trim().Length == 0)
            {
                MessageBox.Show("Kh đc để trống!");
                return;
            }
            else
            {
                bool flag = await neo4J.CreatePostByUser(userActive.user_id, txContent.Text.Trim());
                if (flag)
                {
                    MessageBox.Show("Đăng bài thành công");
                    LoadPostData();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    return;
                }
            }
        }

        private void Post_Load(object sender, EventArgs e)
        {
            LoadPostData();
        }
        public async void LoadPostData()
        {
            this.listPost.Controls.Clear();
            List<Post> taskListPost = await neo4J.GetPostsWithUser(userActive.user_id);
            List<Post> isLikePost = await neo4J.GetLikesPosts(userActive.user_id);
          
            foreach (var item in taskListPost)
            {
                if(isLikePost.Find(t=>t.post_id == item.post_id)!=null)
                {
                    item.isLike = true;              
                }
                u_Post u_Post = new u_Post();
                u_Post.EventClick += U_Post_EventClick;
     
                u_Post.PaintData(item, userActive);

                this.listPost.Controls.Add(u_Post);

            }
        }

        private void U_Post_EventClick(object sender, EventArgs e)
        {
            u_Post u_ = (u_Post)sender;
            if (u_.user_action == 1)
            {
                LoadPostData();
            }
        }

   
    }
}
