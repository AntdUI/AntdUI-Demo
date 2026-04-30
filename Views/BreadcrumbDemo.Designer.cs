namespace AntdUIDemo.Views
{
    partial class BreadcrumbDemo
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
            AntdUI.BreadcrumbItem breadcrumbItem1 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem2 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem3 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem4 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem5 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem6 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem7 = new AntdUI.BreadcrumbItem();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain = new AntdUI.In.Panel();
            this.breadcrumb2 = new AntdUI.Breadcrumb();
            this.h2 = new AntdUI.Label();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "显示当前页面在系统层级结构中的位置，并能向上返回。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Breadcrumb 面包屑";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.breadcrumb2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.breadcrumb1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 431);
            this.panelMain.TabIndex = 0;
            // 
            // breadcrumb2
            // 
            this.breadcrumb2.Dock = System.Windows.Forms.DockStyle.Top;
            breadcrumbItem1.IconSvg = "HomeOutlined";
            breadcrumbItem2.IconSvg = "UserOutlined";
            breadcrumbItem2.Text = "Application Center";
            breadcrumbItem3.Text = "Application";
            this.breadcrumb2.Items.Add(breadcrumbItem1);
            this.breadcrumb2.Items.Add(breadcrumbItem2);
            this.breadcrumb2.Items.Add(breadcrumbItem3);
            this.breadcrumb2.Location = new System.Drawing.Point(0, 80);
            this.breadcrumb2.Name = "breadcrumb2";
            this.breadcrumb2.Size = new System.Drawing.Size(750, 32);
            this.breadcrumb2.TabIndex = 2;
            // 
            // h2
            // 
            this.h2.Dock = System.Windows.Forms.DockStyle.Top;
            this.h2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h2.Location = new System.Drawing.Point(0, 56);
            this.h2.Name = "h2";
            this.h2.PrefixColour = AntdUI.Colour.Primary;
            this.h2.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h2.Size = new System.Drawing.Size(750, 24);
            this.h2.TabIndex = 0;
            this.h2.Text = "图标";
            // 
            // breadcrumb1
            // 
            this.breadcrumb1.Dock = System.Windows.Forms.DockStyle.Top;
            breadcrumbItem4.Text = "Home";
            breadcrumbItem5.Text = "Application Center";
            breadcrumbItem6.Text = "Application List";
            breadcrumbItem7.Text = "An Application";
            this.breadcrumb1.Items.Add(breadcrumbItem4);
            this.breadcrumb1.Items.Add(breadcrumbItem5);
            this.breadcrumb1.Items.Add(breadcrumbItem6);
            this.breadcrumb1.Items.Add(breadcrumbItem7);
            this.breadcrumb1.Location = new System.Drawing.Point(0, 24);
            this.breadcrumb1.Name = "breadcrumb1";
            this.breadcrumb1.Size = new System.Drawing.Size(750, 32);
            this.breadcrumb1.TabIndex = 1;
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
            // BreadcrumbDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "BreadcrumbDemo";
            this.Size = new System.Drawing.Size(750, 505);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.Breadcrumb breadcrumb1;
        private AntdUI.Breadcrumb breadcrumb2;
        private AntdUI.Label h2;
    }
}
