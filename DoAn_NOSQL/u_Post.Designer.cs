
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoiDungBaiDang = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSoBinhLuan = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.haha = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNumberLike = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnLike = new System.Windows.Forms.Button();
            this.lblNgayDang = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBinhLuan = new System.Windows.Forms.RichTextBox();
            this.btnBinhLuan = new System.Windows.Forms.Button();
            this.panel_binhluan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXoaBai = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoaBai);
            this.panel1.Controls.Add(this.panel_binhluan);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblSoBinhLuan);
            this.panel1.Controls.Add(this.haha);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.kryptonLabel3);
            this.panel1.Controls.Add(this.lblNumberLike);
            this.panel1.Controls.Add(this.btnLike);
            this.panel1.Controls.Add(this.lblNgayDang);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1202, 376);
            this.panel1.TabIndex = 0;
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
            // lblSoBinhLuan
            // 
            this.lblSoBinhLuan.Location = new System.Drawing.Point(467, 167);
            this.lblSoBinhLuan.Name = "lblSoBinhLuan";
            this.lblSoBinhLuan.Size = new System.Drawing.Size(22, 29);
            this.lblSoBinhLuan.TabIndex = 23;
            this.lblSoBinhLuan.Values.Text = "0";
            // 
            // haha
            // 
            this.haha.Location = new System.Drawing.Point(101, 167);
            this.haha.Name = "haha";
            this.haha.Size = new System.Drawing.Size(116, 29);
            this.haha.TabIndex = 22;
            this.haha.Values.Text = "Số lượt thích";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNoiDungBaiDang);
            this.panel2.Location = new System.Drawing.Point(18, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 86);
            this.panel2.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "label1";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(372, 167);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(89, 29);
            this.kryptonLabel3.TabIndex = 16;
            this.kryptonLabel3.Values.Text = "Bình luận";
            // 
            // lblNumberLike
            // 
            this.lblNumberLike.Location = new System.Drawing.Point(223, 168);
            this.lblNumberLike.Name = "lblNumberLike";
            this.lblNumberLike.Size = new System.Drawing.Size(116, 29);
            this.lblNumberLike.TabIndex = 15;
            this.lblNumberLike.Values.Text = "Số lượt thích";
            // 
            // btnLike
            // 
            this.btnLike.BackgroundImage = global::DoAn_NOSQL.Properties.Resources._4926585;
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLike.Location = new System.Drawing.Point(21, 162);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(58, 30);
            this.btnLike.TabIndex = 14;
            this.btnLike.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // lblNgayDang
            // 
            this.lblNgayDang.Location = new System.Drawing.Point(23, 40);
            this.lblNgayDang.Name = "lblNgayDang";
            this.lblNgayDang.Size = new System.Drawing.Size(129, 29);
            this.lblNgayDang.TabIndex = 13;
            this.lblNgayDang.Values.Text = "kryptonLabel2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBinhLuan);
            this.panel3.Controls.Add(this.btnBinhLuan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 52);
            this.panel3.TabIndex = 24;
            // 
            // txtBinhLuan
            // 
            this.txtBinhLuan.Location = new System.Drawing.Point(21, 6);
            this.txtBinhLuan.Name = "txtBinhLuan";
            this.txtBinhLuan.Size = new System.Drawing.Size(999, 41);
            this.txtBinhLuan.TabIndex = 21;
            this.txtBinhLuan.Text = "";
            // 
            // btnBinhLuan
            // 
            this.btnBinhLuan.Location = new System.Drawing.Point(1020, 6);
            this.btnBinhLuan.Name = "btnBinhLuan";
            this.btnBinhLuan.Size = new System.Drawing.Size(107, 41);
            this.btnBinhLuan.TabIndex = 20;
            this.btnBinhLuan.Text = "Bình luận";
            this.btnBinhLuan.UseVisualStyleBackColor = true;
            // 
            // panel_binhluan
            // 
            this.panel_binhluan.AutoSize = true;
            this.panel_binhluan.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_binhluan.Location = new System.Drawing.Point(26, 203);
            this.panel_binhluan.Name = "panel_binhluan";
            this.panel_binhluan.Size = new System.Drawing.Size(1163, 100);
            this.panel_binhluan.TabIndex = 25;
            // 
            // btnXoaBai
            // 
            this.btnXoaBai.Location = new System.Drawing.Point(1107, 8);
            this.btnXoaBai.Name = "btnXoaBai";
            this.btnXoaBai.Size = new System.Drawing.Size(85, 37);
            this.btnXoaBai.TabIndex = 26;
            this.btnXoaBai.Values.Text = "Xóa bài";
            this.btnXoaBai.Visible = false;
            // 
            // u_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "u_Post";
            this.Size = new System.Drawing.Size(1210, 384);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSoBinhLuan;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel haha;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoiDungBaiDang;
        private System.Windows.Forms.Label lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNumberLike;
        private System.Windows.Forms.Button btnLike;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNgayDang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtBinhLuan;
        private System.Windows.Forms.Button btnBinhLuan;
        private System.Windows.Forms.FlowLayoutPanel panel_binhluan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoaBai;
    }
}
