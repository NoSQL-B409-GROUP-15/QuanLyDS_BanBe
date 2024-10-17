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
    public partial class Form_DangNhap : Form
    {
        ConnectNeo4j _cn;
        public Form_DangNhap()
        {
            InitializeComponent();
      
        }
        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            // logic
            //if()
            _cn = new ConnectNeo4j();
            string username = txTenDangNhap.Text.Trim();
            string password = txMatKhau.Text.Trim();
            var us = await _cn.LoginAsync(username, password);
            if (us != null)
            {
                this.Hide();
                Form_DsBanBe ff = new Form_DsBanBe();
                
                ff.userActivce = us;
                ff.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập bạn ei");
            }
        }
    }
}
