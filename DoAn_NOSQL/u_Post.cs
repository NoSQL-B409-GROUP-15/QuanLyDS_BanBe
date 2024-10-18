using System;
using System.Drawing;
using System.Windows.Forms;
using DoAn_NOSQL.Model;
namespace DoAn_NOSQL
{
    public partial class u_Post : UserControl
    {
        private bool isLiked = false;

        public u_Post()
        {
            InitializeComponent();
            btnLike.Click += BtnLike_Click;
        }
        public void PaintData(Post post)
        {
            lblNoiDungBaiDang.Text = post.content;
            foreach (var item in post.Comments)
            {
                u_comment u = new u_comment();
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
