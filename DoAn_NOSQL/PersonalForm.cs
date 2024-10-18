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
            tBten.Text = user.name;
            tBGmail.Text = user.mail;
            tBDT.Text = user.numberPhone;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
