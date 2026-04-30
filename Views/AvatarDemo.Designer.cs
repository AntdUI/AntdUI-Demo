namespace AntdUIDemo.Views
{
    partial class AvatarDemo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvatarDemo));
            this.header1 = new AntdUI.PageHeader();
            this.panelMain = new AntdUI.In.Panel();
            this.p2 = new AntdUI.FlowPanel();
            this.avatar5 = new AntdUI.Avatar();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.avatar4 = new AntdUI.Avatar();
            this.avatar2 = new AntdUI.Avatar();
            this.avatar7 = new AntdUI.Avatar();
            this.avatar6 = new AntdUI.Avatar();
            this.avatar3 = new AntdUI.Avatar();
            this.avatar1 = new AntdUI.Avatar();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "用来代表用户或事物，支持图片、图标或字符展示。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Avatar 头像";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 389);
            this.panelMain.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Controls.Add(this.avatar5);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Gap = 6;
            this.p2.Location = new System.Drawing.Point(0, 124);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 76);
            this.p2.TabIndex = 2;
            this.p2.Text = "flowPanel2";
            // 
            // avatar5
            // 
            this.avatar5.Image = ((System.Drawing.Image)(resources.GetObject("avatar5.Image")));
            this.avatar5.Location = new System.Drawing.Point(3, 3);
            this.avatar5.Name = "avatar5";
            this.avatar5.Padding = new System.Windows.Forms.Padding(8, 6, 8, 10);
            this.avatar5.Round = true;
            this.avatar5.Shadow = 8;
            this.avatar5.Size = new System.Drawing.Size(70, 70);
            this.avatar5.TabIndex = 1;
            this.avatar5.Text = "A";
            // 
            // h2
            // 
            this.h2.Dock = System.Windows.Forms.DockStyle.Top;
            this.h2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h2.Location = new System.Drawing.Point(0, 100);
            this.h2.Name = "h2";
            this.h2.PrefixColour = AntdUI.Colour.Primary;
            this.h2.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h2.Size = new System.Drawing.Size(750, 24);
            this.h2.TabIndex = 0;
            this.h2.Text = "动图";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.avatar4);
            this.p1.Controls.Add(this.avatar2);
            this.p1.Controls.Add(this.avatar7);
            this.p1.Controls.Add(this.avatar6);
            this.p1.Controls.Add(this.avatar3);
            this.p1.Controls.Add(this.avatar1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Gap = 6;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 76);
            this.p1.TabIndex = 1;
            this.p1.Text = "flowPanel1";
            // 
            // avatar4
            // 
            this.avatar4.Image = global::AntdUIDemo.Properties.Resources.关闭;
            this.avatar4.Location = new System.Drawing.Point(413, 3);
            this.avatar4.Name = "avatar4";
            this.avatar4.Padding = new System.Windows.Forms.Padding(6);
            this.avatar4.Size = new System.Drawing.Size(70, 70);
            this.avatar4.TabIndex = 8;
            // 
            // avatar2
            // 
            this.avatar2.ImageSvg = resources.GetString("avatar2.ImageSvg");
            this.avatar2.Location = new System.Drawing.Point(331, 3);
            this.avatar2.Name = "avatar2";
            this.avatar2.Padding = new System.Windows.Forms.Padding(6);
            this.avatar2.Size = new System.Drawing.Size(70, 70);
            this.avatar2.TabIndex = 7;
            // 
            // avatar7
            // 
            this.avatar7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(207)))));
            this.avatar7.Badge = "7";
            this.avatar7.BadgeSize = 1F;
            this.avatar7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.avatar7.Location = new System.Drawing.Point(249, 3);
            this.avatar7.Name = "avatar7";
            this.avatar7.Padding = new System.Windows.Forms.Padding(8, 6, 8, 10);
            this.avatar7.Round = true;
            this.avatar7.Shadow = 8;
            this.avatar7.ShadowOffsetY = 4;
            this.avatar7.Size = new System.Drawing.Size(70, 70);
            this.avatar7.TabIndex = 6;
            this.avatar7.Text = "圆";
            // 
            // avatar6
            // 
            this.avatar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(207)))));
            this.avatar6.Badge = "99";
            this.avatar6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.avatar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.avatar6.Location = new System.Drawing.Point(167, 3);
            this.avatar6.Name = "avatar6";
            this.avatar6.Padding = new System.Windows.Forms.Padding(8);
            this.avatar6.Radius = 6;
            this.avatar6.Shadow = 8;
            this.avatar6.Size = new System.Drawing.Size(70, 70);
            this.avatar6.TabIndex = 5;
            this.avatar6.Text = "方";
            // 
            // avatar3
            // 
            this.avatar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(207)))));
            this.avatar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.avatar3.Location = new System.Drawing.Point(85, 3);
            this.avatar3.Name = "avatar3";
            this.avatar3.Padding = new System.Windows.Forms.Padding(6);
            this.avatar3.Round = true;
            this.avatar3.Size = new System.Drawing.Size(70, 70);
            this.avatar3.TabIndex = 2;
            this.avatar3.Text = "圆";
            // 
            // avatar1
            // 
            this.avatar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(207)))));
            this.avatar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.avatar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.avatar1.Location = new System.Drawing.Point(3, 3);
            this.avatar1.Name = "avatar1";
            this.avatar1.Padding = new System.Windows.Forms.Padding(6);
            this.avatar1.Radius = 6;
            this.avatar1.Size = new System.Drawing.Size(70, 70);
            this.avatar1.TabIndex = 0;
            this.avatar1.Text = "方";
            // 
            // h1
            // 
            this.h1.Dock = System.Windows.Forms.DockStyle.Top;
            this.h1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h1.Location = new System.Drawing.Point(0, 0);
            this.h1.Name = "h1";
            this.h1.PrefixColour = AntdUI.Colour.Primary;
            this.h1.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h1.Size = new System.Drawing.Size(750, 24);
            this.h1.TabIndex = 0;
            this.h1.Text = "基本用法";
            // 
            // AvatarDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "AvatarDemo";
            this.Size = new System.Drawing.Size(750, 463);
            this.panelMain.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Avatar avatar1;
        private AntdUI.Avatar avatar3;
        private AntdUI.FlowPanel p2;
        private AntdUI.Label h2;
        private AntdUI.Avatar avatar5;
        private AntdUI.Avatar avatar7;
        private AntdUI.Avatar avatar6;
        private AntdUI.Avatar avatar4;
        private AntdUI.Avatar avatar2;
    }
}
