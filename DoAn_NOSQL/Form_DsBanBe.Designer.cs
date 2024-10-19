
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listFriend = new System.Windows.Forms.TabPage();
            this.dataFriend = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.listIsNotFriend = new System.Windows.Forms.TabPage();
            this.dataIsNotFriend = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataRevciedFriendRequest = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemTrangCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.listFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFriend)).BeginInit();
            this.listIsNotFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIsNotFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRevciedFriendRequest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cmsView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listFriend);
            this.tabControl1.Controls.Add(this.listIsNotFriend);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(852, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 666);
            this.tabControl1.TabIndex = 0;
            // 
            // listFriend
            // 
            this.listFriend.Controls.Add(this.dataFriend);
            this.listFriend.Location = new System.Drawing.Point(4, 29);
            this.listFriend.Name = "listFriend";
            this.listFriend.Padding = new System.Windows.Forms.Padding(3);
            this.listFriend.Size = new System.Drawing.Size(589, 633);
            this.listFriend.TabIndex = 0;
            this.listFriend.Text = "Bạn bè";
            this.listFriend.UseVisualStyleBackColor = true;
            // 
            // dataFriend
            // 
            this.dataFriend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFriend.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFriend.Location = new System.Drawing.Point(3, 3);
            this.dataFriend.Name = "dataFriend";
            this.dataFriend.RowHeadersWidth = 62;
            this.dataFriend.RowTemplate.Height = 28;
            this.dataFriend.Size = new System.Drawing.Size(583, 627);
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
            this.listIsNotFriend.Text = "Có thể bạn biết";
            this.listIsNotFriend.UseVisualStyleBackColor = true;
            // 
            // dataIsNotFriend
            // 
            this.dataIsNotFriend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataIsNotFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIsNotFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataIsNotFriend.Location = new System.Drawing.Point(3, 3);
            this.dataIsNotFriend.Name = "dataIsNotFriend";
            this.dataIsNotFriend.RowHeadersWidth = 62;
            this.dataIsNotFriend.RowTemplate.Height = 28;
            this.dataIsNotFriend.Size = new System.Drawing.Size(583, 405);
            this.dataIsNotFriend.TabIndex = 1;
            // 
            // dataRevciedFriendRequest
            // 
            this.dataRevciedFriendRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRevciedFriendRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRevciedFriendRequest.Location = new System.Drawing.Point(3, 22);
            this.dataRevciedFriendRequest.Name = "dataRevciedFriendRequest";
            this.dataRevciedFriendRequest.RowHeadersWidth = 62;
            this.dataRevciedFriendRequest.RowTemplate.Height = 28;
            this.dataRevciedFriendRequest.Size = new System.Drawing.Size(740, 641);
            this.dataRevciedFriendRequest.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataRevciedFriendRequest);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 666);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lời mời bạn kết";
            // 
            // cmsView
            // 
            this.cmsView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemTrangCáNhânToolStripMenuItem});
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(234, 36);
            // 
            // xemTrangCáNhânToolStripMenuItem
            // 
            this.xemTrangCáNhânToolStripMenuItem.Name = "xemTrangCáNhânToolStripMenuItem";
            this.xemTrangCáNhânToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.xemTrangCáNhânToolStripMenuItem.Text = "Xem trang cá nhân";
            this.xemTrangCáNhânToolStripMenuItem.Click += new System.EventHandler(this.xemTrangCáNhânToolStripMenuItem_Click);
            // 
            // Form_DsBanBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_DsBanBe";
            this.Text = "Form_DsBanBe";
            this.tabControl1.ResumeLayout(false);
            this.listFriend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFriend)).EndInit();
            this.listIsNotFriend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataIsNotFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRevciedFriendRequest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.cmsView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listFriend;
        private System.Windows.Forms.TabPage listIsNotFriend;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataFriend;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataIsNotFriend;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataRevciedFriendRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip cmsView;
        private System.Windows.Forms.ToolStripMenuItem xemTrangCáNhânToolStripMenuItem;
    }
}