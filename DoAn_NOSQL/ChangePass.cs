using DoAn_NOSQL.Model;
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
    public partial class ChangePass : Form
    {
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public User userActive
        { get; set; }
        public ChangePass()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp");
                return;
            }
            if ( await neo4J.CheckPass(userActive.user_id, textBox1.Text) == true)
            {
                await neo4J.ChangePass(userActive.user_id, textBox2.Text);
                MessageBox.Show("Đổ thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
