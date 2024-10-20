using System;
using System.Drawing;
using System.Windows.Forms;
using DoAn_NOSQL.CloudService;
using DoAn_NOSQL.Model;
namespace DoAn_NOSQL
{
    public partial class u_Post : UserControl
    {
        private bool isLiked = false;
        public User userActive { get; set; }
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public Post Post { get; set; }
        public int user_action { get; set; }
        public u_Post()
        {
            InitializeComponent();
            user_action = 0;
            btnLike.Click += BtnLike_Click;
            btnBinhLuan.Click += BtnBinhLuan_Click;
            btnXoaBai.Click += BtnXoaBai_Click;
        }

        private async void BtnXoaBai_Click(object sender, EventArgs e)
        {
            bool flag = await neo4J.DeletePost(Post.post_id);
            if(flag)
            {
                MessageBox.Show("Xóa thành công");
                user_action = 1;
                if (EventClick != null)
                {
                    EventClick.Invoke(this, EventArgs.Empty);
                }
            
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public event EventHandler EventClick;
        private async void BtnBinhLuan_Click(object sender, EventArgs e)
        {
            if (txtBinhLuan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn đang bỏ trống nội dung");
                return;
            }
            else
            {
                bool flag = await neo4J.CreateCommentPost(userActive.user_id, Post.post_id, txtBinhLuan.Text.Trim());
                if (flag)
                {
                    MessageBox.Show("Đã bình luận");
                    user_action = 1;
                    if (EventClick != null)
                    {
                        EventClick.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }
        ServiceConfig ServiceConfig;
        CloudIService CloudIService;
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            pcBox.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
        }
        public void PaintData(Post post, User user)
        {
            userActive = user;
            Post = post;
            LoadImgFromUrl(user.image);
            if (post.isLike)
            {
                isLiked = false;
                btnLike.BackgroundImage = Properties.Resources._4926585;
            }
            else
            {
                btnLike.BackgroundImage = Properties.Resources.unlike;
                isLiked = true;
            }
            btnXoaBai.Visible = true;
            lblNoiDungBaiDang.Text = post.content;
            lblName.Text = user.name;
            lblNgayDang.Text = post.created_at;
            lblNumberLike.Text = post.countLikes.ToString();
            lblSoBinhLuan.Text = post.Comments.Count.ToString();
            foreach (var item in post.Comments)
            {
                u_comment u = new u_comment()
                {
                    Width = this.panel_binhluan.Width - 10
                };
                u.EventXoaBinhLuan += U_EventXoaBinhLuan;
                u.PaintData(item);
                this.panel_binhluan.Controls.Add(u);
            }
        }
        public void PaintDataViewInfor(Post post, User user)
        {
            userActive = user;
            Post = post;
            if (post.isLike)
            {
                isLiked = false;
                btnLike.BackgroundImage = Properties.Resources._4926585;
            }
            else
            {
                btnLike.BackgroundImage = Properties.Resources.unlike;
                isLiked = true;
            }
            btnXoaBai.Visible = false;
            lblNoiDungBaiDang.Text = post.content;
            lblName.Text = user.name;
            lblNgayDang.Text = post.created_at;
            lblNumberLike.Text = post.countLikes.ToString();
            lblSoBinhLuan.Text = post.Comments.Count.ToString();
            foreach (var item in post.Comments)
            {

                u_comment u = new u_comment()
                {
                    Width = this.panel_binhluan.Width - 10
                };
                if (item.commenter.user_id == user.user_id)
                {
                    u.EventXoaBinhLuan += U_EventXoaBinhLuan;
                    u.PaintData(item);
                 
                }
                else
                {
                    u.PaintDataViewInfo(item);
                }
                this.panel_binhluan.Controls.Add(u);


            }
        }
        private void U_EventXoaBinhLuan(object sender, EventArgs e)
        {
            u_comment u_ = (u_comment)sender;
            if (u_.someChange == 1)
            {
                user_action = 1;
                if (EventClick != null)
                {
                    EventClick.Invoke(this, EventArgs.Empty);
                }
            }
        }
        private async void BtnLike_Click(object sender, EventArgs e)
        {
            isLiked = !isLiked;
            Button btn = sender as Button;
            if (isLiked)
            {
                btn.BackgroundImage = Properties.Resources.unlike;
                bool flag = await neo4J.DeleteRelationshipLike(userActive.user_id, Post.post_id);
                if (flag)
                {
                    user_action = 1;
                }
            }
            else
            {
                btn.BackgroundImage = Properties.Resources._4926585;
                bool flag = await neo4J.CreateRelationshipLike(userActive.user_id, Post.post_id);
                if (flag)
                {
                    user_action = 1;
                }
            }
            EventClick.Invoke(this, EventArgs.Empty);
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
    }
}
