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
    public partial class Form_DsBanBe : Form
    {
        public User userActivce { get; set; }
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public Form_DsBanBe()
        {
            InitializeComponent();
            this.Load += Form_DsBanBe_Load;
            dataFriend.CellContentClick += DataFriend_CellContentClick;
            dataIsNotFriend.CellContentClick += DataIsNotFriend_CellContentClick;
            dataRevciedFriendRequest.CellContentClick += DataRevciedFriendRequest_CellContentClick;
        }

        private async void DataRevciedFriendRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                var userIdValue = dataRevciedFriendRequest.Rows[e.RowIndex].Cells[0].Value;
                if(userIdValue!=null && userIdValue!=DBNull.Value)
                {
                    int userId = Convert.ToInt32(userIdValue);

                    bool flag = await neo4J.AcceptFriendRequest(userId, userActivce.user_id);
                    if(flag)
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
            if(e.ColumnIndex==4 && e.RowIndex>=0)
            {
                var userIdValue = dataRevciedFriendRequest.Rows[e.RowIndex].Cells[0].Value;
                if (userIdValue != null && userIdValue != DBNull.Value)
                {
                    int userId = Convert.ToInt32(userIdValue);

                    bool flag = await neo4J.CancelFriendRequest(userId, userActivce.user_id);
                    if (flag)
                    {
                        MessageBox.Show("Đã gỡ lời mời kết bạn");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
        }

        private async void DataIsNotFriend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                string action = dataIsNotFriend.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (action.Equals("Kết bạn"))
                {
                    var userIdValue = dataIsNotFriend.Rows[e.RowIndex].Cells[0].Value;
                    if (userIdValue != null && userIdValue != DBNull.Value)
                    {
                        int userId = Convert.ToInt32(userIdValue);

                        bool result = await neo4J.AddFriendRequest(userActivce.user_id, userId);
                        if (result)
                        {
                            MessageBox.Show("Đã gửi lời mời kết bạn thành công");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi.");
                        }
                    }
                }
                else
                {
                    var userIdValue = dataIsNotFriend.Rows[e.RowIndex].Cells[0].Value;
                    if (userIdValue != null && userIdValue != DBNull.Value)
                    {
                        int userId = Convert.ToInt32(userIdValue);

                        bool result = await neo4J.CancelFriendRequest(userActivce.user_id, userId);
                        if (result)
                        {
                            MessageBox.Show("Đã gỡ lời mời kết bạn thành công.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi.");
                        }
                    }
                }

            }
        }

        private async void DataFriend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                var userIdValue = dataFriend.Rows[e.RowIndex].Cells[0].Value;
                if (userIdValue != null && userIdValue != DBNull.Value)
                {
                    int userId = Convert.ToInt32(userIdValue);

                    bool result = await neo4J.DeleteRelationshipFriend(userActivce.user_id, userId);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi.");
                    }
                }
            }
        }

        public async void LoadData()
        {
            if (userActivce != null)
            {
                List<User> friendsList = await neo4J.ListIsFriendOfUser(userActivce.user_id);
                PopulateDataGridViewFriend(friendsList);

                List<User> notFriendList = await neo4J.NotFriendList(userActivce.user_id);
                PopulateDataGridViewIsNotFriend(notFriendList);

                List<User> receivedRequestList = await neo4J.ListFriendRequestRecived(userActivce.user_id);
                PopulateDataGridViewReceivedRequest(receivedRequestList);
            }
        }
        private void Form_DsBanBe_Load(object sender, EventArgs e)
        {
            SetupDataGridViewFriend(dataFriend);
            SetUpDataGridViewIsNotFriend(dataIsNotFriend);
            SetUpDataGridViewReceivedRequest(dataRevciedFriendRequest);
            LoadData();
        }
        private void SetupDataGridViewFriend(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;

            dataGridView.Columns.Add("User ID", "User ID");
            dataGridView.Columns.Add("Name", "Tên");
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Thao tác";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(buttonColumn);
        }
        private void SetUpDataGridViewIsNotFriend(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.Columns.Add("User ID", "User ID");
            dataGridView.Columns.Add("Name", "Tên");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Thao tác",
                Name = "Action",
                UseColumnTextForButtonValue = false
            };
            dataGridView.Columns.Add(buttonColumn);
        }
        private void SetUpDataGridViewReceivedRequest(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.Columns.Add("User ID", "User ID");
            dataGridView.Columns.Add("Name", "Tên");
            dataGridView.Columns.Add("Characteristic", "Số bạn chung");
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Thao tác",
                Name = "Action1",
                Text="Chấp nhận",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn
            {
                HeaderText = "Thao tác",
                Name = "Action2",
                Text="Hủy bỏ",
                UseColumnTextForButtonValue = true
            };
            dataGridView.Columns.Add(buttonColumn);
            dataGridView.Columns.Add(buttonColumn2);
        }
        private void PopulateDataGridViewIsNotFriend(List<User> users)
        {
            try
            {
                dataIsNotFriend.Rows.Clear();
                foreach (var user in users)
                {
                    string action = user.HasSendingRequest ? "Hủy lời mời kết bạn" : "Kết bạn";
                    dataIsNotFriend.Rows.Add(user.user_id, user.username, action);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("đợi tí");
            }
           
        }
        private void PopulateDataGridViewFriend(List<User> users)
        {
            try
            {
                dataFriend.Rows.Clear();
                foreach (var user in users)
                {
                    dataFriend.Rows.Add(user.user_id, user.username);
                }
            }
            catch (Exception)
            {

            }

        }
        private void PopulateDataGridViewReceivedRequest(List<User> users)
        {
            try
            {
                dataRevciedFriendRequest.Rows.Clear();
                if (users.Count == 0)
                {
                    return;
                }
                else
                {

                    foreach (var item in users)
                    {
                        dataRevciedFriendRequest.Rows.Add(item.user_id, item.username, item.mutualFriend);
                    }
                }
            }
            catch (Exception)
            {
               
                MessageBox.Show("đợi tí");
            }

        }
    }
}
