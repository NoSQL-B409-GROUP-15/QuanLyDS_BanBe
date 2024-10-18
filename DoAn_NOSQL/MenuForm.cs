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
            util.OpenChildForm(bb, panelBody);

        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            util.OpenChildForm(post, panelBody);
        }
    }
}
