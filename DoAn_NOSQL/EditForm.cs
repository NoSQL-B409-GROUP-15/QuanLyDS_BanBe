using DoAn_NOSQL.CloudService;
using DoAn_NOSQL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public int _SomeEvent { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }
        public event EventHandler SomeEvent;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void EditForm_Load(object sender, EventArgs e)
        {
            textBTen.Text = userActive.name;
            textBoxMail.Text = userActive.mail;
            textBoxSDT.Text = userActive.phoneNumber;
            LoadImgFromUrl(userActive.image);
        }

        ServiceConfig ServiceConfig;
        CloudIService CloudIService;
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            pcBox.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
        }
        public string UploadImage(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            return CloudIService.UploadImage(path);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            UploadImage(PathThumbail);
            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(PathThumbail);
            string linkHolder = "Nike-application/" + fileNameWithoutExtension;
            await neo4J.UpdateUserAsync(userActive.user_id, textBTen.Text,  textBoxSDT.Text, textBoxMail.Text,linkHolder);
            MessageBox.Show("Đã chỉnh sửa thành công");
            _SomeEvent = 1;
            SomeEvent.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        public string linkHolder { get; set; }
        public string PathThumbail { get; set; }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp",
                Title = "Chọn một hình ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pcBox.Image = Image.FromFile(openFileDialog.FileName);
                PathThumbail = Path.GetFullPath(openFileDialog.FileName);             
            }
        }
    }
}
