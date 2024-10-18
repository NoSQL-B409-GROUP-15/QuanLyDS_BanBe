
namespace DoAn_NOSQL
{
    partial class u_Post
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNoiDungBaiDang = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNgayDang = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNumberLike = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.txtBinhLuan = new System.Windows.Forms.RichTextBox();
            this.btnBinhLuan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_binhluan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoiDungBaiDang
            // 
            this.lblNoiDungBaiDang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoiDungBaiDang.Location = new System.Drawing.Point(0, 0);
            this.lblNoiDungBaiDang.Name = "lblNoiDungBaiDang";
            this.lblNoiDungBaiDang.Size = new System.Drawing.Size(1120, 86);
            this.lblNoiDungBaiDang.TabIndex = 0;
            this.lblNoiDungBaiDang.Values.Text = "NỘI DUNG ĐĂNG BÀI";
            // 
            // lblNgayDang
            // 
            this.lblNgayDang.Location = new System.Drawing.Point(19, 35);
            this.lblNgayDang.Name = "lblNgayDang";
            this.lblNgayDang.Size = new System.Drawing.Size(129, 29);
            this.lblNgayDang.TabIndex = 1;
            this.lblNgayDang.Values.Text = "kryptonLabel2";
            // 
            // lblNumberLike
            // 
            this.lblNumberLike.Location = new System.Drawing.Point(86, 163);
            this.lblNumberLike.Name = "lblNumberLike";
            this.lblNumberLike.Size = new System.Drawing.Size(116, 29);
            this.lblNumberLike.TabIndex = 4;
            this.lblNumberLike.Values.Text = "Số lượt thích";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(223, 163);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(89, 29);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Bình luận";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "label1";
            // 
            // btnLike
            // 
            this.btnLike.BackgroundImage = global::DoAn_NOSQL.Properties.Resources._4926585;
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLike.Location = new System.Drawing.Point(22, 162);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(58, 30);
            this.btnLike.TabIndex = 2;
            this.btnLike.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // txtBinhLuan
            // 
            this.txtBinhLuan.Location = new System.Drawing.Point(27, 439);
            this.txtBinhLuan.Name = "txtBinhLuan";
            this.txtBinhLuan.Size = new System.Drawing.Size(999, 41);
            this.txtBinhLuan.TabIndex = 8;
            this.txtBinhLuan.Text = "";
            // 
            // btnBinhLuan
            // 
            this.btnBinhLuan.Location = new System.Drawing.Point(1032, 439);
            this.btnBinhLuan.Name = "btnBinhLuan";
            this.btnBinhLuan.Size = new System.Drawing.Size(107, 34);
            this.btnBinhLuan.TabIndex = 7;
            this.btnBinhLuan.Text = "Bình luận";
            this.btnBinhLuan.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNoiDungBaiDang);
            this.panel1.Location = new System.Drawing.Point(19, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 86);
            this.panel1.TabIndex = 9;
            // 
            // panel_binhluan
            // 
            this.panel_binhluan.AutoScroll = true;
            this.panel_binhluan.Location = new System.Drawing.Point(22, 198);
            this.panel_binhluan.Name = "panel_binhluan";
            this.panel_binhluan.Size = new System.Drawing.Size(1117, 224);
            this.panel_binhluan.TabIndex = 10;
            // 
            // u_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_binhluan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBinhLuan);
            this.Controls.Add(this.btnBinhLuan);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lblNumberLike);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblNgayDang);
            this.Name = "u_Post";
            this.Size = new System.Drawing.Size(1154, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoiDungBaiDang;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNgayDang;
        private System.Windows.Forms.Button btnLike;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNumberLike;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox txtBinhLuan;
        private System.Windows.Forms.Button btnBinhLuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panel_binhluan;
    }
}
