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
    public partial class MenuForm : Form
    {
        Util util = new Util();
        public User userActive { get; set; }
        public MenuForm()
        {
            InitializeComponent();
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }
        bool sidebarExpland = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpland)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 60)
                {
                    sidebarExpland = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 200)
                {
                    sidebarExpland = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_friend_Click(object sender, EventArgs e)
        {
            Form_DsBanBe bb = new Form_DsBanBe();
            bb.userActivce=userActive;
            bb.EventClick += Bb_EventClick;
            util.OpenChildForm(bb, panelBody);

        }

        private void Bb_EventClick(object sender, EventArgs e)
        {
            Form_DsBanBe bb = (Form_DsBanBe)sender;
            if(bb.userClick==1)
            {
                ViewProfileUserForm viewShowProfile = new ViewProfileUserForm();
                viewShowProfile.PaintData(bb.DataSelected, userActive);
                util.OpenChildForm(viewShowProfile, panelBody); 
            }
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            PostForm post = new PostForm();
            post.userActive = userActive;
            util.OpenChildForm(post, panelBody);
        }

        //private void btn_order_Click(object sender, EventArgs e)
        //{
        //    PersonalForm personal = new PersonalForm();
        //    personal.userActive = userActive;
        //    util.OpenChildForm(personal, panelBody);
        //}
    }
}
