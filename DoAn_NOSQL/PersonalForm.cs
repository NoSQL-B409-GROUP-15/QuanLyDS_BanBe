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
    public partial class PersonalForm : Form
    {
        ConnectNeo4j neo4J = new ConnectNeo4j();
        public User userActive
        { get; set; }
        public PersonalForm()
        {
            InitializeComponent();
        }
        
        private async void PersonalForm_Load(object sender, EventArgs e)
        {
            User user = await neo4J.GetUserByIdAsync(userActive.user_id);
            lbname.Text = user.name;
            lbGmail.Text = user.mail;
            lbPhone.Text = user.phoneNumber;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.userActive = userActive;
            editForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.userActive = userActive;
            changePass.Show();
        }
    }
}
