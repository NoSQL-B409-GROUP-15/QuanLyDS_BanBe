using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_NOSQL
{

    public partial class RegisterForm : Form
    {
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            bool isCreated = await neo4J.CreateUser(textBox1.Text, textBox5.Text, textBox4.Text, textBox2.Text, textBox3.Text);
            if (isCreated) { 
                MessageBox.Show("Đã tạo tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }

        }
    }
}
