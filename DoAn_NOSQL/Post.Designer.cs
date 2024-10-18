
namespace DoAn_NOSQL
{
    partial class Post
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangBai = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txContent = new System.Windows.Forms.RichTextBox();
            this.listPost = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangBai);
            this.panel1.Controls.Add(this.txContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 142);
            this.panel1.TabIndex = 3;
            // 
            // btnDangBai
            // 
            this.btnDangBai.Location = new System.Drawing.Point(564, 63);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(138, 44);
            this.btnDangBai.TabIndex = 4;
            this.btnDangBai.Values.Text = "Đăng bài";
            // 
            // txContent
            // 
            this.txContent.Location = new System.Drawing.Point(94, 24);
            this.txContent.Name = "txContent";
            this.txContent.Size = new System.Drawing.Size(431, 96);
            this.txContent.TabIndex = 3;
            this.txContent.Text = "";
            // 
            // listPost
            // 
            this.listPost.AutoScroll = true;
            this.listPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPost.Location = new System.Drawing.Point(0, 142);
            this.listPost.Name = "listPost";
            this.listPost.Size = new System.Drawing.Size(800, 509);
            this.listPost.TabIndex = 4;
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.listPost);
            this.Controls.Add(this.panel1);
            this.Name = "Post";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.Post_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangBai;
        private System.Windows.Forms.RichTextBox txContent;
        private System.Windows.Forms.FlowLayoutPanel listPost;
    }
}