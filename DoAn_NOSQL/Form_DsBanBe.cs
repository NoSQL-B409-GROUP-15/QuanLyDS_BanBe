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
        public Form_DsBanBe()
        {
            InitializeComponent();
            SetupDataGridViewFriend(dataFriend);
            SetUpDataGridViewIsNotFriend(dataIsNotFriend);
            SetUpDataGridViewReceivedRequest(dataRevciedFriendRequest);
            dataFriend.CellContentClick += DataFriend_CellContentClick;
            dataIsNotFriend.CellContentClick += DataIsNotFriend_CellContentClick;
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
                PopulateDataGridViewFriend(dataFriend, friendsList);

                List<User> notFriendList = await neo4J.NotFriendList(userActivce.user_id);
                PopulateDataGridViewIsNotFriend(dataIsNotFriend, notFriendList);

                List<User> receivedRequestList = await neo4J.ListFriendRequestRecived(userActivce.user_id);
                PopulateDataGridViewReceivedRequest(dataRevciedFriendRequest, receivedRequestList);
            }
        }
        private void Form_DsBanBe_Load(object sender, EventArgs e)
        {
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
        private void PopulateDataGridViewIsNotFriend(DataGridView dataGridView, List<User> users)
        {
            dataGridView.Rows.Clear();
            foreach (var user in users)
            {
                string action = user.HasSendingRequest ? "Hủy lời mời kết bạn" : "Kết bạn";
                dataGridView.Rows.Add(user.user_id, user.name, action);
            }
        }
        private void PopulateDataGridViewFriend(DataGridView dataGridView, List<User> users)
        {
            dataGridView.Rows.Clear();
            foreach (var user in users)
            {
                dataGridView.Rows.Add(user.user_id, user.name);
            }
        }
        private void PopulateDataGridViewReceivedRequest(DataGridView dataGridView,List<User> users)
        {
            if(users.Count==0)
            {
                return;
            }
            else
            {
                foreach (var item in users)
                {
                    dataGridView.Rows.Add(item.user_id, item.name, item.mutualFriend);
                }
            }
        }
    }
}
