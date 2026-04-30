namespace AntdUIDemo.Views
{
    partial class TagDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagDemo));
            this.panelMain = new AntdUI.In.Panel();
            this.p3 = new AntdUI.FlowPanel();
            this.tag13 = new AntdUI.Tag();
            this.tag18 = new AntdUI.Tag();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.tag7 = new AntdUI.Tag();
            this.tag8 = new AntdUI.Tag();
            this.tag9 = new AntdUI.Tag();
            this.tag10 = new AntdUI.Tag();
            this.tag11 = new AntdUI.Tag();
            this.tag12 = new AntdUI.Tag();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.tag6 = new AntdUI.Tag();
            this.tag5 = new AntdUI.Tag();
            this.tag4 = new AntdUI.Tag();
            this.tag3 = new AntdUI.Tag();
            this.tag2 = new AntdUI.Tag();
            this.tag1 = new AntdUI.Tag();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p3);
            this.panelMain.Controls.Add(this.h3);
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 340);
            this.panelMain.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Controls.Add(this.tag13);
            this.p3.Controls.Add(this.tag18);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            this.p3.Text = "flowPanel2";
            // 
            // tag13
            // 
            this.tag13.ImageSvg = resources.GetString("tag13.ImageSvg");
            this.tag13.Location = new System.Drawing.Point(175, 3);
            this.tag13.Name = "tag13";
            this.tag13.Size = new System.Drawing.Size(166, 32);
            this.tag13.TabIndex = 2;
            this.tag13.Text = "这是Svg标签";
            // 
            // tag18
            // 
            this.tag18.Image = global::AntdUIDemo.Properties.Resources.head;
            this.tag18.Location = new System.Drawing.Point(3, 3);
            this.tag18.Name = "tag18";
            this.tag18.Size = new System.Drawing.Size(166, 32);
            this.tag18.TabIndex = 1;
            this.tag18.Text = "这是Image标签";
            // 
            // h3
            // 
            this.h3.Dock = System.Windows.Forms.DockStyle.Top;
            this.h3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h3.Location = new System.Drawing.Point(0, 124);
            this.h3.Name = "h3";
            this.h3.PrefixColour = AntdUI.Colour.Primary;
            this.h3.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h3.Size = new System.Drawing.Size(750, 24);
            this.h3.TabIndex = 0;
            this.h3.Text = "自定义";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.tag7);
            this.p2.Controls.Add(this.tag8);
            this.p2.Controls.Add(this.tag9);
            this.p2.Controls.Add(this.tag10);
            this.p2.Controls.Add(this.tag11);
            this.p2.Controls.Add(this.tag12);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            this.p2.Text = "flowPanel1";
            // 
            // tag7
            // 
            this.tag7.CloseIcon = true;
            this.tag7.Location = new System.Drawing.Point(433, 3);
            this.tag7.Name = "tag7";
            this.tag7.Size = new System.Drawing.Size(80, 32);
            this.tag7.TabIndex = 6;
            this.tag7.Text = "Info";
            this.tag7.Type = AntdUI.TTypeMini.Info;
            // 
            // tag8
            // 
            this.tag8.CloseIcon = true;
            this.tag8.Location = new System.Drawing.Point(347, 3);
            this.tag8.Name = "tag8";
            this.tag8.Size = new System.Drawing.Size(80, 32);
            this.tag8.TabIndex = 5;
            this.tag8.Text = "Warn";
            this.tag8.Type = AntdUI.TTypeMini.Warn;
            // 
            // tag9
            // 
            this.tag9.CloseIcon = true;
            this.tag9.Location = new System.Drawing.Point(261, 3);
            this.tag9.Name = "tag9";
            this.tag9.Size = new System.Drawing.Size(80, 32);
            this.tag9.TabIndex = 4;
            this.tag9.Text = "Error";
            this.tag9.Type = AntdUI.TTypeMini.Error;
            // 
            // tag10
            // 
            this.tag10.CloseIcon = true;
            this.tag10.Location = new System.Drawing.Point(175, 3);
            this.tag10.Name = "tag10";
            this.tag10.Size = new System.Drawing.Size(80, 32);
            this.tag10.TabIndex = 3;
            this.tag10.Text = "Success";
            this.tag10.Type = AntdUI.TTypeMini.Success;
            // 
            // tag11
            // 
            this.tag11.CloseIcon = true;
            this.tag11.Location = new System.Drawing.Point(89, 3);
            this.tag11.Name = "tag11";
            this.tag11.Size = new System.Drawing.Size(80, 32);
            this.tag11.TabIndex = 2;
            this.tag11.Text = "Primary";
            this.tag11.Type = AntdUI.TTypeMini.Primary;
            // 
            // tag12
            // 
            this.tag12.CloseIcon = true;
            this.tag12.Location = new System.Drawing.Point(3, 3);
            this.tag12.Name = "tag12";
            this.tag12.Size = new System.Drawing.Size(80, 32);
            this.tag12.TabIndex = 1;
            this.tag12.Text = "Default";
            // 
            // h2
            // 
            this.h2.Dock = System.Windows.Forms.DockStyle.Top;
            this.h2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h2.Location = new System.Drawing.Point(0, 62);
            this.h2.Name = "h2";
            this.h2.PrefixColour = AntdUI.Colour.Primary;
            this.h2.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h2.Size = new System.Drawing.Size(750, 24);
            this.h2.TabIndex = 0;
            this.h2.Text = "关闭按钮";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.tag6);
            this.p1.Controls.Add(this.tag5);
            this.p1.Controls.Add(this.tag4);
            this.p1.Controls.Add(this.tag3);
            this.p1.Controls.Add(this.tag2);
            this.p1.Controls.Add(this.tag1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            this.p1.Text = "flowPanel3";
            // 
            // tag6
            // 
            this.tag6.Location = new System.Drawing.Point(433, 3);
            this.tag6.Name = "tag6";
            this.tag6.Size = new System.Drawing.Size(80, 32);
            this.tag6.TabIndex = 6;
            this.tag6.Text = "Info";
            this.tag6.Type = AntdUI.TTypeMini.Info;
            // 
            // tag5
            // 
            this.tag5.Location = new System.Drawing.Point(347, 3);
            this.tag5.Name = "tag5";
            this.tag5.Size = new System.Drawing.Size(80, 32);
            this.tag5.TabIndex = 5;
            this.tag5.Text = "Warn";
            this.tag5.Type = AntdUI.TTypeMini.Warn;
            // 
            // tag4
            // 
            this.tag4.Location = new System.Drawing.Point(261, 3);
            this.tag4.Name = "tag4";
            this.tag4.Size = new System.Drawing.Size(80, 32);
            this.tag4.TabIndex = 4;
            this.tag4.Text = "Error";
            this.tag4.Type = AntdUI.TTypeMini.Error;
            // 
            // tag3
            // 
            this.tag3.Location = new System.Drawing.Point(175, 3);
            this.tag3.Name = "tag3";
            this.tag3.Size = new System.Drawing.Size(80, 32);
            this.tag3.TabIndex = 3;
            this.tag3.Text = "Success";
            this.tag3.Type = AntdUI.TTypeMini.Success;
            // 
            // tag2
            // 
            this.tag2.Location = new System.Drawing.Point(89, 3);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(80, 32);
            this.tag2.TabIndex = 2;
            this.tag2.Text = "Primary";
            this.tag2.Type = AntdUI.TTypeMini.Primary;
            // 
            // tag1
            // 
            this.tag1.Location = new System.Drawing.Point(3, 3);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(80, 32);
            this.tag1.TabIndex = 1;
            this.tag1.Text = "Default";
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
            this.h1.Text = "基本类型";
            // 
            // header1
            // 
            this.header1.Description = "进行标记和分类的小标签。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Tag 标签";
            this.header1.UseTitleFont = true;
            // 
            // TagDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "TagDemo";
            this.Size = new System.Drawing.Size(750, 414);
            this.panelMain.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Tag tag1;
        private AntdUI.Tag tag3;
        private AntdUI.Tag tag2;
        private AntdUI.Tag tag4;
        private AntdUI.Tag tag6;
        private AntdUI.Tag tag5;
        private AntdUI.FlowPanel p2;
        private AntdUI.Tag tag7;
        private AntdUI.Tag tag8;
        private AntdUI.Tag tag9;
        private AntdUI.Tag tag10;
        private AntdUI.Tag tag11;
        private AntdUI.Tag tag12;
        private AntdUI.Label h2;
        private AntdUI.Label h3;
        private AntdUI.FlowPanel p3;
        private AntdUI.Tag tag18;
        private AntdUI.Tag tag13;
        private AntdUI.PageHeader header1;
    }
}
