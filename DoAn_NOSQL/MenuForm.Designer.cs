
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
            this.btnSaoLuu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPhucHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.panelBody.Location = new System.Drawing.Point(248, 48);
            this.panelBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1202, 570);
            this.panelBody.TabIndex = 8;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.FormLabel);
            this.headerPanel.Controls.Add(this.btn_Menu);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(248, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.headerPanel.Size = new System.Drawing.Size(1202, 48);
            this.headerPanel.TabIndex = 6;
            // 
            // FormLabel
            // 
            this.FormLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.FormLabel.Location = new System.Drawing.Point(75, 12);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(265, 28);
            this.FormLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.FormLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.FormLabel.TabIndex = 1;
            this.FormLabel.Values.Text = "Quản lý danh sách bạn bè";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(22, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(26, 28);
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
            this.sidebar.Controls.Add(this.btnSaoLuu);
            this.sidebar.Controls.Add(this.btnPhucHoi);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(248, 618);
            this.sidebar.TabIndex = 7;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(200, 58);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel1.TabIndex = 6;
            // 
            // btn_friend
            // 
            this.btn_friend.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_friend.Location = new System.Drawing.Point(0, 58);
            this.btn_friend.Margin = new System.Windows.Forms.Padding(0);
            this.btn_friend.Name = "btn_friend";
            this.btn_friend.Palette = this.kryptonPalette1;
            this.btn_friend.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_friend.Size = new System.Drawing.Size(200, 58);
            this.btn_friend.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_friend.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_friend.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_friend.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_friend.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friend.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_friend.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_friend.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_friend.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_friend.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_friend.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_friend.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_friend.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_friend.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_friend.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_friend.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_friend.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_friend.TabIndex = 5;
            this.btn_friend.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_friend.Values.Image")));
            this.btn_friend.Values.Text = "      Bạn bè";
            this.btn_friend.Click += new System.EventHandler(this.btn_friend_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            // 
            // btn_post
            // 
            this.btn_post.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_post.Location = new System.Drawing.Point(0, 116);
            this.btn_post.Margin = new System.Windows.Forms.Padding(0);
            this.btn_post.Name = "btn_post";
            this.btn_post.Palette = this.kryptonPalette1;
            this.btn_post.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_post.Size = new System.Drawing.Size(200, 58);
            this.btn_post.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_post.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_post.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_post.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_post.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_post.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_post.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_post.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_post.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_post.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_post.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_post.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_post.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_post.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_post.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_post.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_post.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_post.TabIndex = 7;
            this.btn_post.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_post.Values.Image")));
            this.btn_post.Values.Text = "      Bài đăng";
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_order
            // 
            this.btn_order.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_order.Location = new System.Drawing.Point(0, 174);
            this.btn_order.Margin = new System.Windows.Forms.Padding(0);
            this.btn_order.Name = "btn_order";
            this.btn_order.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_order.Size = new System.Drawing.Size(248, 58);
            this.btn_order.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_order.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_order.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_order.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_order.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_order.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_order.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_order.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_order.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_order.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_order.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_order.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_order.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_order.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_order.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            // btnSaoLuu
            // 
            this.btnSaoLuu.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btnSaoLuu.Location = new System.Drawing.Point(0, 232);
            this.btnSaoLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnSaoLuu.Size = new System.Drawing.Size(248, 58);
            this.btnSaoLuu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSaoLuu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSaoLuu.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSaoLuu.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btnSaoLuu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaoLuu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaoLuu.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaoLuu.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnSaoLuu.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnSaoLuu.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaoLuu.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnSaoLuu.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnSaoLuu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaoLuu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaoLuu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuu.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaoLuu.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnSaoLuu.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btnSaoLuu.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSaoLuu.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSaoLuu.TabIndex = 9;
            this.btnSaoLuu.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.btnSaoLuu.Values.Text = "Sao lưu";
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btnPhucHoi.Location = new System.Drawing.Point(0, 290);
            this.btnPhucHoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnPhucHoi.Size = new System.Drawing.Size(248, 58);
            this.btnPhucHoi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnPhucHoi.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnPhucHoi.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnPhucHoi.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btnPhucHoi.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPhucHoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPhucHoi.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnPhucHoi.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnPhucHoi.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnPhucHoi.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnPhucHoi.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnPhucHoi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnPhucHoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPhucHoi.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPhucHoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnPhucHoi.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnPhucHoi.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btnPhucHoi.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnPhucHoi.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnPhucHoi.TabIndex = 10;
            this.btnPhucHoi.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton2.Values.Image")));
            this.btnPhucHoi.Values.Text = "Phục hồi";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 618);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebar);
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaoLuu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPhucHoi;
    }
}