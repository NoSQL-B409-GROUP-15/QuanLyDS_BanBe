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
    public partial class u_comment : UserControl
    {
        public u_comment()
        {
            InitializeComponent();
        }
        public void PaintData(Comment comment)
        {
            lblNoiDungComment.Text = comment.content;
            lblNguoiCmt.Text = comment.commenter.name;
        }
        private void u_comment_Load(object sender, EventArgs e)
        {

        }

        private void btnXoaCmt_Click(object sender, EventArgs e)
        {

        }
    }
}
