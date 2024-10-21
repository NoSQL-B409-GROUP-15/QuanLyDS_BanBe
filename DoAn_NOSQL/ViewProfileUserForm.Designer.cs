
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
            this.btnIsBanBe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listPost = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pcBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTuChoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSoLuongBanChung = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(378, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Values.Text = "kryptonLabel1";
            // 
            // btnIsBanBe
            // 
            this.btnIsBanBe.Location = new System.Drawing.Point(3, 3);
            this.btnIsBanBe.Name = "btnIsBanBe";
            this.btnIsBanBe.Size = new System.Drawing.Size(163, 49);
            this.btnIsBanBe.TabIndex = 3;
            this.btnIsBanBe.Values.Text = "Bạn bè ha";
            // 
            // listPost
            // 
            this.listPost.AutoScroll = true;
            this.listPost.AutoSize = true;
            this.listPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPost.Location = new System.Drawing.Point(3, 162);
            this.listPost.Name = "listPost";
            this.listPost.Size = new System.Drawing.Size(1148, 554);
            this.listPost.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 47);
            this.btnBack.TabIndex = 5;
            this.btnBack.Values.Text = "<-";
            // 
            // pcBox
            // 
            this.pcBox.BackgroundImage = global::DoAn_NOSQL.Properties.Resources.hehe_nosql_drawio;
            this.pcBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcBox.Location = new System.Drawing.Point(164, 18);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(175, 132);
            this.pcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBox.TabIndex = 0;
            this.pcBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblSoLuongBanChung);
            this.panel1.Controls.Add(this.pcBox);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 153);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnIsBanBe, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTuChoi, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(710, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.Location = new System.Drawing.Point(172, 3);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(152, 49);
            this.btnTuChoi.TabIndex = 6;
            this.btnTuChoi.Values.Text = "Từ chối";
            this.btnTuChoi.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listPost, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1154, 719);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblSoLuongBanChung
            // 
            this.lblSoLuongBanChung.Location = new System.Drawing.Point(363, 121);
            this.lblSoLuongBanChung.Name = "lblSoLuongBanChung";
            this.lblSoLuongBanChung.Size = new System.Drawing.Size(125, 29);
            this.lblSoLuongBanChung.TabIndex = 2;
            this.lblSoLuongBanChung.Values.Text = "Số bạn chung";
            // 
            // ViewProfileUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 719);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewProfileUserForm";
            this.Text = "ViewProfileUserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIsBanBe;
        private System.Windows.Forms.FlowLayoutPanel listPost;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTuChoi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSoLuongBanChung;
    }
}