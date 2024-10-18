
namespace DoAn_NOSQL
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panelBody = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.headerPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.FormLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_friend = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_post = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(165, 31);
            this.panelBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(802, 371);
            this.panelBody.TabIndex = 8;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.FormLabel);
            this.headerPanel.Controls.Add(this.btn_Menu);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(165, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.headerPanel.Size = new System.Drawing.Size(802, 31);
            this.headerPanel.TabIndex = 6;
            // 
            // FormLabel
            // 
            this.FormLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.FormLabel.Location = new System.Drawing.Point(50, 8);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(179, 20);
            this.FormLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.TabIndex = 1;
            this.FormLabel.Values.Text = "Quản lý danh sách bạn bè";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(15, 8);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(17, 18);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.kryptonPanel1);
            this.sidebar.Controls.Add(this.btn_friend);
            this.sidebar.Controls.Add(this.btn_post);
            this.sidebar.Controls.Add(this.btn_order);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(165, 402);
            this.sidebar.TabIndex = 7;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(133, 38);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.TabIndex = 6;
            // 
            // btn_friend
            // 
            this.btn_friend.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_friend.Location = new System.Drawing.Point(0, 38);
            this.btn_friend.Margin = new System.Windows.Forms.Padding(0);
            this.btn_friend.Name = "btn_friend";
            this.btn_friend.Palette = this.kryptonPalette1;
            this.btn_friend.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_friend.Size = new System.Drawing.Size(133, 38);
            this.btn_friend.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_friend.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_friend.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_friend.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_friend.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friend.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_friend.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_friend.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_friend.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_friend.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_friend.TabIndex = 5;
            this.btn_friend.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_friend.Values.Image")));
            this.btn_friend.Values.Text = "      Bạn bè";
            this.btn_friend.Click += new System.EventHandler(this.btn_friend_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            // 
            // btn_post
            // 
            this.btn_post.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_post.Location = new System.Drawing.Point(0, 76);
            this.btn_post.Margin = new System.Windows.Forms.Padding(0);
            this.btn_post.Name = "btn_post";
            this.btn_post.Palette = this.kryptonPalette1;
            this.btn_post.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_post.Size = new System.Drawing.Size(133, 38);
            this.btn_post.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_post.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_post.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_post.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_post.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_post.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_post.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_post.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_post.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_post.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_post.TabIndex = 7;
            this.btn_post.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_post.Values.Image")));
            this.btn_post.Values.Text = "      Bài đăng";
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_order
            // 
            this.btn_order.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_order.Location = new System.Drawing.Point(0, 114);
            this.btn_order.Margin = new System.Windows.Forms.Padding(0);
            this.btn_order.Name = "btn_order";
            this.btn_order.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_order.Size = new System.Drawing.Size(165, 38);
            this.btn_order.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_order.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_order.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_order.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_order.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_order.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_order.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_order.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_order.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_order.TabIndex = 8;
            this.btn_order.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_order.Values.Image")));
            this.btn_order.Values.Text = " Trang cá nhân";
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 402);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelBody;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel headerPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel FormLabel;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_friend;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_post;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_order;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}