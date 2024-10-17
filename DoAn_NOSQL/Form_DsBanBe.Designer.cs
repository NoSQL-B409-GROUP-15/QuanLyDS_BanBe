
namespace DoAn_NOSQL
{
    partial class Form_DsBanBe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listFriend = new System.Windows.Forms.TabPage();
            this.dataFriend = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.listIsNotFriend = new System.Windows.Forms.TabPage();
            this.dataIsNotFriend = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tabControl1.SuspendLayout();
            this.listFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFriend)).BeginInit();
            this.listIsNotFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIsNotFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listFriend);
            this.tabControl1.Controls.Add(this.listIsNotFriend);
            this.tabControl1.Location = new System.Drawing.Point(261, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // listFriend
            // 
            this.listFriend.Controls.Add(this.dataFriend);
            this.listFriend.Location = new System.Drawing.Point(4, 29);
            this.listFriend.Name = "listFriend";
            this.listFriend.Padding = new System.Windows.Forms.Padding(3);
            this.listFriend.Size = new System.Drawing.Size(589, 411);
            this.listFriend.TabIndex = 0;
            this.listFriend.Text = "Your friend";
            this.listFriend.UseVisualStyleBackColor = true;
            // 
            // dataFriend
            // 
            this.dataFriend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFriend.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFriend.Location = new System.Drawing.Point(6, 6);
            this.dataFriend.Name = "dataFriend";
            this.dataFriend.RowHeadersWidth = 62;
            this.dataFriend.RowTemplate.Height = 28;
            this.dataFriend.Size = new System.Drawing.Size(577, 399);
            this.dataFriend.TabIndex = 0;
            // 
            // listIsNotFriend
            // 
            this.listIsNotFriend.Controls.Add(this.dataIsNotFriend);
            this.listIsNotFriend.Location = new System.Drawing.Point(4, 29);
            this.listIsNotFriend.Name = "listIsNotFriend";
            this.listIsNotFriend.Padding = new System.Windows.Forms.Padding(3);
            this.listIsNotFriend.Size = new System.Drawing.Size(589, 411);
            this.listIsNotFriend.TabIndex = 1;
            this.listIsNotFriend.Text = "Maybe you know";
            this.listIsNotFriend.UseVisualStyleBackColor = true;
            // 
            // dataIsNotFriend
            // 
            this.dataIsNotFriend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataIsNotFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIsNotFriend.Location = new System.Drawing.Point(13, 6);
            this.dataIsNotFriend.Name = "dataIsNotFriend";
            this.dataIsNotFriend.RowHeadersWidth = 62;
            this.dataIsNotFriend.RowTemplate.Height = 28;
            this.dataIsNotFriend.Size = new System.Drawing.Size(570, 388);
            this.dataIsNotFriend.TabIndex = 1;
            // 
            // Form_DsBanBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_DsBanBe";
            this.Text = "Form_DsBanBe";
            this.Load += new System.EventHandler(this.Form_DsBanBe_Load);
            this.tabControl1.ResumeLayout(false);
            this.listFriend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFriend)).EndInit();
            this.listIsNotFriend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataIsNotFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listFriend;
        private System.Windows.Forms.TabPage listIsNotFriend;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataFriend;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataIsNotFriend;
    }
}