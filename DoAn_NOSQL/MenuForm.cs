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
                viewShowProfile.EventClick += ViewShowProfile_EventClick;
                util.OpenChildForm(viewShowProfile, panelBody); 
            }
        }

        private void ViewShowProfile_EventClick(object sender, EventArgs e)
        {
            ViewProfileUserForm viewShowProfile = (ViewProfileUserForm)sender;
            if(viewShowProfile._eventClick==1)
            {
                Form_DsBanBe bb = new Form_DsBanBe();
                bb.userActivce = userActive;
                bb.EventClick += Bb_EventClick;
                util.OpenChildForm(bb, panelBody);
            }
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            PostForm post = new PostForm();
            post.userActive = userActive;
            util.OpenChildForm(post, panelBody);
        }


        private void btn_order_Click(object sender, EventArgs e)
        {
            PersonalForm personal = new PersonalForm();
            personal.userActive = userActive;
            personal.LoadImgFromUrl(userActive.image);
            util.OpenChildForm(personal, panelBody);
        }
        private async void btnSaoLuu_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "JSON Files (*.json)|*.json";
                dialog.Title = "Chọn vị trí tệp sao lưu";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = dialog.FileName;
                    try
                    {
                        ConnectNeo4j neo4j = new ConnectNeo4j();
                        await neo4j.BackupNeo4jData(backupFilePath);
                        
                        MessageBox.Show("Sao lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Sao lưu thất bại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnPhucHoi_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "JSON Files (*.json)|*.json";
                dialog.Title = "Chọn tệp sao lưu để khôi phục";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = dialog.FileName;
                    var confirmResult = MessageBox.Show("Khôi phục dữ liệu sẽ ghi đè lên dữ liệu hiện có. Bạn có muốn tiếp tục không?",
                                                        "Xác nhận khôi phục",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                         ConnectNeo4j neo4j = new ConnectNeo4j();               
                         await neo4j.RestoreNeo4jData(backupFilePath);

                            MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Phục hồi thất bại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
