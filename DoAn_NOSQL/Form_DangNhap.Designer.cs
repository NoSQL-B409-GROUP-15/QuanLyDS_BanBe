
namespace DoAn_NOSQL
{
    partial class Form_DangNhap
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txTenDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txMatKhau = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnHuyBo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(86, 31);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(218, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "QUẢN LÝ DỮ LIỆU BẠN BÈ FACEBOOK";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // txTenDangNhap
            // 
            this.txTenDangNhap.Location = new System.Drawing.Point(161, 70);
            this.txTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txTenDangNhap.Name = "txTenDangNhap";
            this.txTenDangNhap.Size = new System.Drawing.Size(164, 23);
            this.txTenDangNhap.TabIndex = 1;
            this.txTenDangNhap.Text = "user02";
            // 
            // txMatKhau
            // 
            this.txMatKhau.Location = new System.Drawing.Point(161, 120);
            this.txMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txMatKhau.Name = "txMatKhau";
            this.txMatKhau.Size = new System.Drawing.Size(164, 23);
            this.txMatKhau.TabIndex = 2;
            this.txMatKhau.Text = "123456789";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(23, 70);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Tên đăng nhập";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(23, 120);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Mật khẩu";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(161, 168);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(84, 33);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Values.Text = "Hủy bỏ";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(261, 168);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(84, 33);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Values.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(50, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đăng kí";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txMatKhau);
            this.Controls.Add(this.txTenDangNhap);
            this.Controls.Add(this.kryptonLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_DangNhap";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txTenDangNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txMatKhau;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHuyBo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangNhap;
        private System.Windows.Forms.Button button1;
    }
}

