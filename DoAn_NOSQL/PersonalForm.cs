
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
using DoAn_NOSQL.CloudService;
namespace DoAn_NOSQL
{
    public partial class PersonalForm : Form
    {
        CloudIService CloudIService;
        ServiceConfig ServiceConfig;
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
            LoadImgFromUrl(userActive.image);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.userActive = userActive;
            editForm.SomeEvent += EditForm_SomeEvent;
            editForm.Show();
        }
        public int Event { get; set; }
        public event EventHandler SomeEvent;
        private void EditForm_SomeEvent(object sender, EventArgs e)
        {
            EditForm editForm = (EditForm)sender;
            if(editForm._SomeEvent==1)
            {
                Event = 1;
                paintData();
                SomeEvent.Invoke(this, EventArgs.Empty);
            }
        }
        public async void paintData()
        {
            User user = await neo4J.GetUsers(userActive.user_id);
            userActive = user;
            lbname.Text = user.name;
            lbGmail.Text = user.mail;
            LoadImgFromUrl(userActive.image);
            lbPhone.Text = user.phoneNumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.userActive = userActive;
            changePass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_DangNhap form_DangNhap = new Form_DangNhap();

            form_DangNhap.Show();
            this.Hide();
            Application.Exit();
        }
     
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            pcBox.ImageLocation = CloudIService.GetImageUrlByPublicId(path);        

        }


    }
}
