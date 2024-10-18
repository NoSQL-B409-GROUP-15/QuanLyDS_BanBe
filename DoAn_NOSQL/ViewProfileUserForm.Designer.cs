
namespace DoAn_NOSQL
{
    partial class ViewProfileUserForm
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
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSoLuongBanChung = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listPost = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pcAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(342, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Values.Text = "kryptonLabel1";
            // 
            // lblSoLuongBanChung
            // 
            this.lblSoLuongBanChung.Location = new System.Drawing.Point(342, 130);
            this.lblSoLuongBanChung.Name = "lblSoLuongBanChung";
            this.lblSoLuongBanChung.Size = new System.Drawing.Size(125, 29);
            this.lblSoLuongBanChung.TabIndex = 2;
            this.lblSoLuongBanChung.Values.Text = "Số bạn chung";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(979, 95);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(163, 49);
            this.kryptonButton1.TabIndex = 3;
            this.kryptonButton1.Values.Text = "Bạn bè ha";
            // 
            // listPost
            // 
            this.listPost.AutoScroll = true;
            this.listPost.Location = new System.Drawing.Point(12, 198);
            this.listPost.Name = "listPost";
            this.listPost.Size = new System.Drawing.Size(1130, 509);
            this.listPost.TabIndex = 4;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(12, 12);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(99, 47);
            this.kryptonButton2.TabIndex = 5;
            this.kryptonButton2.Values.Text = "Back ha";
            // 
            // pcAvatar
            // 
            this.pcAvatar.BackgroundImage = global::DoAn_NOSQL.Properties.Resources.hehe_nosql_drawio;
            this.pcAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcAvatar.Location = new System.Drawing.Point(140, 27);
            this.pcAvatar.Name = "pcAvatar";
            this.pcAvatar.Size = new System.Drawing.Size(175, 132);
            this.pcAvatar.TabIndex = 0;
            this.pcAvatar.TabStop = false;
            // 
            // ViewProfileUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 719);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.listPost);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.lblSoLuongBanChung);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pcAvatar);
            this.Name = "ViewProfileUserForm";
            this.Text = "ViewProfileUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcAvatar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSoLuongBanChung;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.FlowLayoutPanel listPost;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}