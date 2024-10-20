
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
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(129, 48);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(324, 29);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "QUẢN LÝ DỮ LIỆU BẠN BÈ FACEBOOK";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // txTenDangNhap
            // 
            this.txTenDangNhap.Location = new System.Drawing.Point(241, 107);
            this.txTenDangNhap.Name = "txTenDangNhap";
            this.txTenDangNhap.Size = new System.Drawing.Size(246, 32);
            this.txTenDangNhap.TabIndex = 1;
            this.txTenDangNhap.Text = "user02";
            // 
            // txMatKhau
            // 
            this.txMatKhau.Location = new System.Drawing.Point(241, 184);
            this.txMatKhau.Name = "txMatKhau";
            this.txMatKhau.PasswordChar = '●';
            this.txMatKhau.Size = new System.Drawing.Size(246, 32);
            this.txMatKhau.TabIndex = 2;
            this.txMatKhau.Text = "123456789";
            this.txMatKhau.UseSystemPasswordChar = true;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(35, 107);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(136, 29);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Tên đăng nhập";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(34, 184);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(90, 29);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Mật khẩu";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(241, 258);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(126, 51);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Values.Text = "Hủy bỏ";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(391, 258);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(126, 51);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Values.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 359);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txMatKhau);
            this.Controls.Add(this.txTenDangNhap);
            this.Controls.Add(this.kryptonLabel1);
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
    }
}

