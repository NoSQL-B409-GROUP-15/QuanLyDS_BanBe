﻿
namespace DoAn_NOSQL
{
    partial class u_comment
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaCmt = new System.Windows.Forms.Button();
            this.lblNguoiCmt = new System.Windows.Forms.Label();
            this.lblNoiDungComment = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThoiGianComment = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pcBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoaCmt);
            this.panel2.Location = new System.Drawing.Point(857, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 29);
            this.panel2.TabIndex = 4;
            // 
            // btnXoaCmt
            // 
            this.btnXoaCmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaCmt.Location = new System.Drawing.Point(0, 0);
            this.btnXoaCmt.Name = "btnXoaCmt";
            this.btnXoaCmt.Size = new System.Drawing.Size(64, 29);
            this.btnXoaCmt.TabIndex = 3;
            this.btnXoaCmt.Text = "Xóa";
            this.btnXoaCmt.UseVisualStyleBackColor = true;
            this.btnXoaCmt.Click += new System.EventHandler(this.btnXoaCmt_Click);
            // 
            // lblNguoiCmt
            // 
            this.lblNguoiCmt.AutoSize = true;
            this.lblNguoiCmt.Location = new System.Drawing.Point(28, 10);
            this.lblNguoiCmt.Name = "lblNguoiCmt";
            this.lblNguoiCmt.Size = new System.Drawing.Size(51, 20);
            this.lblNguoiCmt.TabIndex = 0;
            this.lblNguoiCmt.Text = "label1";
            // 
            // lblNoiDungComment
            // 
            this.lblNoiDungComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoiDungComment.Location = new System.Drawing.Point(0, 0);
            this.lblNoiDungComment.Name = "lblNoiDungComment";
            this.lblNoiDungComment.Size = new System.Drawing.Size(685, 42);
            this.lblNoiDungComment.TabIndex = 1;
            this.lblNoiDungComment.Values.Text = "kryptonLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNoiDungComment);
            this.panel1.Location = new System.Drawing.Point(17, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 42);
            this.panel1.TabIndex = 2;
            // 
            // lblThoiGianComment
            // 
            this.lblThoiGianComment.Location = new System.Drawing.Point(268, 6);
            this.lblThoiGianComment.Name = "lblThoiGianComment";
            this.lblThoiGianComment.Size = new System.Drawing.Size(129, 29);
            this.lblThoiGianComment.TabIndex = 5;
            this.lblThoiGianComment.Values.Text = "kryptonLabel1";
            // 
            // pcBox
            // 
            this.pcBox.Location = new System.Drawing.Point(209, 3);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(53, 34);
            this.pcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBox.TabIndex = 28;
            this.pcBox.TabStop = false;
            // 
            // u_comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pcBox);
            this.Controls.Add(this.lblThoiGianComment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNguoiCmt);
            this.Name = "u_comment";
            this.Size = new System.Drawing.Size(924, 108);
            this.Load += new System.EventHandler(this.u_comment_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaCmt;
        private System.Windows.Forms.Label lblNguoiCmt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNoiDungComment;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblThoiGianComment;
        private System.Windows.Forms.PictureBox pcBox;
    }
}
