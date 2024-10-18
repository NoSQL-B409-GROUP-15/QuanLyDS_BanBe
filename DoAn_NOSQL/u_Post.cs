using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn_NOSQL
{
    public partial class u_Post : UserControl
    {
        private bool isLiked = false;

        public u_Post()
        {
            InitializeComponent();
            loadTest();
            btnLike.Click += BtnLike_Click;
        }
        public void loadTest()
        {
            for(int i =0;i<5;i++)
            {
                this.panel_binhluan.Controls.Add(new u_comment() { 
                    Width= this.panel_binhluan.Width-10
            
                });
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
