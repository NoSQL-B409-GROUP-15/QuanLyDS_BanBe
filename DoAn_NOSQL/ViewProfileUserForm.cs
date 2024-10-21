using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoAn_NOSQL.CloudService;
using DoAn_NOSQL.Model;
namespace DoAn_NOSQL
{
    public partial class ViewProfileUserForm : Form
    {
        public User InfoUser { get; set; }
        public User UserActive { get; set; }
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public int _eventClick { get; set; }
        public ViewProfileUserForm()
        {
            InitializeComponent();
            _eventClick = 0;
            btnBack.Click += BtnBack_Click;
            btnIsBanBe.Click += BtnIsBanBe_Click;
            btnTuChoi.Click += BtnTuChoi_Click;
        }
        ServiceConfig ServiceConfig;
        CloudIService CloudIService;
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            pcBox.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
        }
        private async void BtnTuChoi_Click(object sender, EventArgs e)
        {
            bool flag = await neo4J.CancelFriendRequest(InfoUser.user_id, UserActive.user_id);
            if (flag)
            {
                MessageBox.Show("Đã gỡ lời mời kết bạn");
                PaintData(InfoUser.user_id, UserActive);
                return;
            }
            else
            {
                MessageBox.Show("Lỗi");
            }

        }
        public void setVisibleBtnBack()
        {
            btnBack.Visible = false;
        }
        private async void BtnIsBanBe_Click(object sender, EventArgs e)
        {
            KryptonButton btn = (KryptonButton)sender;
            switch (btn.Tag)
            {
                case Status.GuiKetBan:
                    // chưa kết bạn thì gửi kết bạn
                    bool resultAdd = await neo4J.AddFriendRequest(UserActive.user_id, InfoUser.user_id);
                    if (resultAdd)
                    {
                        MessageBox.Show("Đã gửi lời mời kết bạn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi.");
                    }
                    break;
                case Status.ChapNhan:
                    // người ta gửi lời mời đến mình
                    bool flagC = await neo4J.AcceptFriendRequest( InfoUser.user_id, UserActive.user_id);
                    if (flagC)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                    break;
                case Status.DaKetBan:
                    // thì xóa kết bạn
                    var result = MessageBox.Show("Bạn có chắc chắn muốn hủy kết bạn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool resultdelete = await neo4J.DeleteRelationshipFriend(UserActive.user_id, InfoUser.user_id);
                        if (resultdelete)
                        {
                            MessageBox.Show("Xóa thành công");                   
                        }
                        else
                        {
                            MessageBox.Show("Lỗi.");
                        }
                    }
                    break;
                case Status.DaGuiLoiMoi:
                    // thì hủy lời mời =))
                    bool flag = await neo4J.CancelFriendRequest( UserActive.user_id, InfoUser.user_id);
                    if (flag)
                    {
                        MessageBox.Show("Đã gỡ lời mời kết bạn");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                    break;
                default:
                    break;
            }
            PaintData(InfoUser.user_id, UserActive);
        }

        public event EventHandler EventClick;

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _eventClick = 1;
            EventClick.Invoke(this, EventArgs.Empty);

        }

        public async void PaintData(int idInfo, User userActive)
        {
            this.listPost.Controls.Clear();
            InfoUser = await neo4J.GetUsers(idInfo);
            UserActive = userActive;

            LoadImgFromUrl(InfoUser.image);
            List<User> listUsers = await neo4J.ListMutalFriend(userActive.user_id, idInfo);

            lblName.Text = InfoUser.name;
            if (listUsers.Count > 0)
            {
                lblSoLuongBanChung.Text = listUsers.Count.ToString()+" Bạn chung";
            }
            else
            {
                lblSoLuongBanChung.Text = "";
            }

            List<Post> isLikePost = await neo4J.GetLikesPosts(userActive.user_id);
            List<Post> posts = await neo4J.GetPostsWithUser(idInfo);
            foreach (var item in posts)
            {
                if (isLikePost.Find(t => t.post_id == item.post_id) != null)
                {
                    item.isLike = true;
                }
                u_Post u_Post = new u_Post()
                {

                };
                u_Post.EventClick += U_Post_EventClick;
                u_Post.PaintDataViewInfor(item, InfoUser,userActive);
                u_Post.LoadImgFromUrl(InfoUser.image);
                this.listPost.Controls.Add(u_Post);
            }
            btnTuChoi.Visible = false;
            bool isFriend = await neo4J.IsFriend(idInfo, userActive.user_id);

            if (isFriend)
            {
                btnIsBanBe.Text = "Bạn bè";
                btnIsBanBe.Tag = Status.DaKetBan;
                return;
            }
            else
            {
                //btnIsBanBe.Text = "Kết bạn";
                //bool check = await neo4J.
                bool isSentRequet = await neo4J.IsSentRequestFriend(userActive.user_id, idInfo);
                if (isSentRequet)
                {
                    btnIsBanBe.Text = "Đã gửi kết bạn";
                    btnIsBanBe.Tag = Status.DaGuiLoiMoi;
                    return;
                }
                else
                {

                    bool youSentRequest = await neo4J.IsSentRequestFriend(idInfo, userActive.user_id);
                    if (youSentRequest)
                    {
                        btnIsBanBe.Text = "Chấp nhận kết bạn";
                        btnIsBanBe.Tag = Status.ChapNhan;
                        btnTuChoi.Visible = true;
                        btnTuChoi.Tag = Status.HuyLoiMoi;
                        return;
                    }
                    else
                    {
                        btnIsBanBe.Text = "Kết bạn";
                        btnIsBanBe.Tag = Status.GuiKetBan;
                        return;
                    }
                }

            }
        }

        private void U_Post_EventClick(object sender, EventArgs e)
        {
            PaintData(InfoUser.user_id, UserActive);
        }

     
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
