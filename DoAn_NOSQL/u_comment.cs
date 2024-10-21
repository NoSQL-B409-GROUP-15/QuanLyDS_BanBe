using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_NOSQL.CloudService;
using DoAn_NOSQL.Model;
namespace DoAn_NOSQL
{
    public partial class u_comment : UserControl
    {
        public Comment Comment { get; set; }
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public int someChange { get; set; }
        public u_comment()
        {
            InitializeComponent();
            this.MouseDown += U_comment_MouseDown;
            this.MouseLeave += U_comment_MouseLeave;
            contextMenuStrip1.MouseEnter += ContextMenuStrip1_MouseEnter;
        }

        private void ContextMenuStrip1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void U_comment_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Empty ;
        }

        private void U_comment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    this.BackColor = Color.Aquamarine;
                    Point mousePosition = this.PointToClient(MousePosition);
                    contextMenuStrip1.Show(this, mousePosition);
                }
                catch (Exception ex)
                {
                    // Handle specific exceptions as needed
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return;
                }
            }

        }

        public void PaintData(Comment comment)
        {
            Comment = comment;
            LoadImgFromUrl(comment.commenter.image);
            lblNoiDungComment.Text = comment.content;
            lblNguoiCmt.Text = comment.commenter.name;
            lblThoiGianComment.Text = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(comment.created_at))
                                            .ToString("yyyy-MM-dd HH:mm:ss");
        }
        ServiceConfig ServiceConfig;
        CloudIService CloudIService;
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            pcBox.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
        }
        public void PaintDataViewInfo(Comment comment)
        {
            Comment = comment;
            LoadImgFromUrl(comment.commenter.image);
            lblNoiDungComment.Text = comment.content;
            lblNguoiCmt.Text = comment.commenter.name;
            lblThoiGianComment.Text = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(comment.created_at))
                                            .ToString("yyyy-MM-dd HH:mm:ss");
            btnXoaCmt.Visible = false;
        }
        private void u_comment_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler EventXoaBinhLuan;
        private async void btnXoaCmt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bình luận này không?","Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool flag =await neo4J.DeleteRelationshipComment(Comment.comment_id);
                if(flag)
                {
                    MessageBox.Show("Xóa bình luận thành công");
                    someChange = 1;
                    EventXoaBinhLuan.Invoke(this, EventArgs.Empty);
                }
            }
            
        }
        public User commenter { get; set; }
        public event EventHandler EventXemInfo;
        private void xemTrangCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commenter = Comment.commenter;
            EventXemInfo.Invoke(this, EventArgs.Empty);
        }
    }
}
