using System;
using System.Drawing;
using System.Windows.Forms;
using DoAn_NOSQL.Model;
namespace DoAn_NOSQL
{
    public partial class u_Post : UserControl
    {
        private bool isLiked = false;
        public User userActive { get; set; }
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public Post Post { get; set; }
        public u_Post()
        {
            InitializeComponent();
            btnLike.Click += BtnLike_Click;
            btnBinhLuan.Click += BtnBinhLuan_Click;
        }

        public event EventHandler EventBinhLuan;
        private async void BtnBinhLuan_Click(object sender, EventArgs e)
        {
            if(txtBinhLuan.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn đang bỏ trống nội dung");
                return;
            }
            else
            {
                bool flag =await neo4J.CreateCommentPost(userActive.user_id, Post.post_id, txtBinhLuan.Text.Trim());
                if(flag)
                {
                    MessageBox.Show("Đã bình luận");

                    return;
                }
            }
        }

        public void PaintData(Post post,User user)
        {
            userActive = user;
            Post = post;
            lblNoiDungBaiDang.Text = post.content;
            lblName.Text = user.name;
            lblNgayDang.Text = post.created_at;
            lblNumberLike.Text = post.countLikes.ToString();
            lblSoBinhLuan.Text = post.Comments.Count.ToString();
            foreach (var item in post.Comments)
            {
                u_comment u = new u_comment() {
                    Width = this.panel_binhluan.Width - 10
                };

                u.PaintData(item);
                this.panel_binhluan.Controls.Add(u);
            }
        }

        private void BtnLike_Click(object sender, EventArgs e)
        {
            isLiked = !isLiked; // Toggle the like status
            Button btn = sender as Button;

            if (isLiked)
            {
                btn.BackgroundImage = Properties.Resources.unlike;

            }
            else
            {
                btn.BackgroundImage = Properties.Resources._4926585;

            }
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
    }
}
