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
    public partial class EditForm : Form
    {
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public User userActive
        { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            textBTen.Text = userActive.name;
            textBoxMail.Text = userActive.mail;
            textBoxSDT.Text = userActive.numberPhone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            neo4J.UpdateUserAsync(userActive.user_id, textBTen.Text,  textBoxSDT.Text, textBoxMail.Text);
            MessageBox.Show("Đã chỉnh sửa thành công");
            this.Close();
        }
    }
}
