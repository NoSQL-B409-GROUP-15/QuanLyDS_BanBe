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
    public partial class ViewProfileUserForm : Form
    {
        public User InfoUser { get; set; }
        public User userActive { get; set; }
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public ViewProfileUserForm()
        {
            InitializeComponent();
        }
        public async void PaintData(int idInfo, User userActive)
        {
            InfoUser = await neo4J.GetUsers(idInfo);
            List<User> listUsers = await neo4J.ListMutalFriend(userActive.user_id, idInfo);
            lblName.Text = InfoUser.name;
            if (listUsers.Count > 0)
            {
                lblSoLuongBanChung.Text = listUsers.Count.ToString();
            }
            else
            {
                lblSoLuongBanChung.Text = "";
            }

        }
    }
}
