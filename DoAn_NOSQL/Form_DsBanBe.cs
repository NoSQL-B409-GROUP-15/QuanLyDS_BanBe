﻿using System;
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
        public int userClick { get; set; }
        public int DataSelected { get; set; }
        public Form_DsBanBe()
        {
            InitializeComponent();
            userClick = 0;
            this.Load += Form_DsBanBe_Load;
            dataFriend.CellContentClick += DataFriend_CellContentClick;
            dataFriend.MouseDown += DataFriend_MouseDown;

            dataIsNotFriend.CellContentClick += DataIsNotFriend_CellContentClick;
            dataIsNotFriend.MouseDown += DataIsNotFriend_MouseDown;
            dataRevciedFriendRequest.CellContentClick += DataRevciedFriendRequest_CellContentClick;
            dataRevciedFriendRequest.MouseDown += DataRevciedFriendRequest_MouseDown;

            dataSentRequest.CellContentClick += DataSentRequest_CellContentClick;
            dataSentRequest.MouseDown += DataSentRequest_MouseDown;
        }

        private void DataSentRequest_MouseDown(object sender, MouseEventArgs e)
        {
            if (dataSentRequest.Rows.Count <= 0)
            {
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataSentRequest.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataSentRequest.ClearSelection();
                    dataSentRequest.Rows[hitTestInfo.RowIndex].Selected = true;
                    try
                    {
                        DataSelected = int.Parse(dataSentRequest.Rows[hitTestInfo.RowIndex].Cells[0].Value.ToString());
                        Point mousePosition = dataSentRequest.PointToClient(MousePosition);
                        cmsView.Show(dataSentRequest, mousePosition);
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        private  async void DataSentRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                var userIdValue = dataSentRequest.Rows[e.RowIndex].Cells[0].Value;
                if (userIdValue != null && userIdValue != DBNull.Value)
                {
                    int userId = Convert.ToInt32(userIdValue);

                    bool flag = await neo4J.CancelFriendRequest( userActivce.user_id,userId);
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

        private void DataRevciedFriendRequest_MouseDown(object sender, MouseEventArgs e)
        {
       
            if (dataRevciedFriendRequest.Rows.Count <= 0)
            {
                return; 
            }

            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataRevciedFriendRequest.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataRevciedFriendRequest.ClearSelection();
                    dataRevciedFriendRequest.Rows[hitTestInfo.RowIndex].Selected = true;
                    try
                    {
                        DataSelected = int.Parse(dataRevciedFriendRequest.Rows[hitTestInfo.RowIndex].Cells[0].Value.ToString());
                        Point mousePosition = dataRevciedFriendRequest.PointToClient(MousePosition);
                        cmsView.Show(dataRevciedFriendRequest, mousePosition);
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }


        private void DataIsNotFriend_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataIsNotFriend.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    dataIsNotFriend.ClearSelection();
                    dataIsNotFriend.Rows[hitTestInfo.RowIndex].Selected = true;
                    DataSelected = int.Parse(dataIsNotFriend.Rows[hitTestInfo.RowIndex].Cells[0].Value.ToString());

                    Point mousePosition = dataIsNotFriend.PointToClient(MousePosition);
                    cmsView.Show(dataIsNotFriend, mousePosition);

                }
            }
        }

        private void DataFriend_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataFriend.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    dataFriend.ClearSelection();
                    dataFriend.Rows[hitTestInfo.RowIndex].Selected = true;
                    DataSelected = int.Parse(dataFriend.Rows[hitTestInfo.RowIndex].Cells[0].Value.ToString());

                    Point mousePosition = dataFriend.PointToClient(MousePosition);
                    cmsView.Show(dataFriend, mousePosition);

                }
            }
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

                List<User> sentRequestList = await neo4J.ListFriendSentRequest(userActivce.user_id);
                PopulateDataGridViewSentRequest(sentRequestList);
            }
        }

        

        private void Form_DsBanBe_Load(object sender, EventArgs e)
        {
            SetupDataGridViewFriend(dataFriend);
            SetUpDataGridViewIsNotFriend(dataIsNotFriend);
            SetUpDataGridViewReceivedRequest(dataRevciedFriendRequest);
            SetUpDataGridViewSentRequest(dataSentRequest);
            LoadData();
        }
        private void SetupDataGridViewFriend(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.Columns.Add("User ID", "User ID");
            dataGridView.Columns.Add("Name", "Tên");
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Thao tác";
            buttonColumn.Text = "Xóa kết bạn";
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
            dataGridView.AllowUserToAddRows = false;
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
            dataGridView.AllowUserToAddRows = false;
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

        private void SetUpDataGridViewSentRequest(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.Columns.Add("User ID", "User ID");
            dataGridView.Columns.Add("Name", "Tên");
            dataGridView.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Thao tác",
                Name = "Action1",
                Text = "Gỡ lời mời kết bạn",
                UseColumnTextForButtonValue = true
            };
            dataGridView.Columns.Add(buttonColumn);
        }
        private void PopulateDataGridViewIsNotFriend(List<User> users)
        {
            try
            {
                dataIsNotFriend.Rows.Clear();
                foreach (var user in users)
                {
                    string action = user.HasSendingRequest ? "Gỡ lời mời kết bạn" : "Kết bạn";
                    dataIsNotFriend.Rows.Add(user.user_id, user.name, action);
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
                    dataFriend.Rows.Add(user.user_id, user.name);
                }
            }
            catch (Exception)
            {

            }

        }

        private void PopulateDataGridViewSentRequest(List<User> sentRequestList)
        {
            try
            {
                dataSentRequest.Rows.Clear();
                if (sentRequestList.Count == 0)
                {
                    return;
                }
                else
                {

                    foreach (var item in sentRequestList)
                    {
                        dataSentRequest.Rows.Add(item.user_id, item.name);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("đợi tí");
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
                        dataRevciedFriendRequest.Rows.Add(item.user_id, item.name, item.mutualFriend);
                    }
                }
            }
            catch (Exception)
            {
               
                MessageBox.Show("đợi tí");
            }

        }
        public event EventHandler EventClick;
        private void xemTrangCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userClick = 1;
            EventClick.Invoke(this, EventArgs.Empty);
        }

        private void Form_DsBanBe_Load_1(object sender, EventArgs e)
        {

        }
    }
}
