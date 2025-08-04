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
            AntdUI.BreadcrumbItem breadcrumbItem8 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem9 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem10 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem11 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem12 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem13 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem14 = new AntdUI.BreadcrumbItem();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.breadcrumb2 = new AntdUI.Breadcrumb();
            this.label3 = new AntdUI.Label();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.label4 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
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
            this.header1.TabIndex = 25;
            this.header1.Text = "Breadcrumb 面包屑";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.breadcrumb2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.breadcrumb1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 431);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // breadcrumb2
            // 
            this.breadcrumb2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            breadcrumbItem8.IconSvg = "HomeOutlined";
            breadcrumbItem8.Text = "";
            breadcrumbItem9.IconSvg = "UserOutlined";
            breadcrumbItem9.Text = "Application Center";
            breadcrumbItem10.Text = "Application";
            this.breadcrumb2.Items.Add(breadcrumbItem8);
            this.breadcrumb2.Items.Add(breadcrumbItem9);
            this.breadcrumb2.Items.Add(breadcrumbItem10);
            this.breadcrumb2.Location = new System.Drawing.Point(3, 101);
            this.breadcrumb2.Name = "breadcrumb2";
            this.breadcrumb2.Size = new System.Drawing.Size(744, 32);
            this.breadcrumb2.TabIndex = 49;
            this.breadcrumb2.Text = "breadcrumb2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "图标";
            // 
            // breadcrumb1
            // 
            this.breadcrumb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            breadcrumbItem11.Text = "Home";
            breadcrumbItem12.Text = "Application Center";
            breadcrumbItem13.Text = "Application List";
            breadcrumbItem14.Text = "An Application";
            this.breadcrumb1.Items.Add(breadcrumbItem11);
            this.breadcrumb1.Items.Add(breadcrumbItem12);
            this.breadcrumb1.Items.Add(breadcrumbItem13);
            this.breadcrumb1.Items.Add(breadcrumbItem14);
            this.breadcrumb1.Location = new System.Drawing.Point(3, 33);
            this.breadcrumb1.Name = "breadcrumb1";
            this.breadcrumb1.Size = new System.Drawing.Size(744, 32);
            this.breadcrumb1.TabIndex = 47;
            this.breadcrumb1.Text = "breadcrumb1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "基本用法";
            // 
            // BreadcrumbDemo
            // 
            
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "BreadcrumbDemo";
            this.Size = new System.Drawing.Size(750, 505);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label4;
        private AntdUI.Breadcrumb breadcrumb1;
        private AntdUI.Breadcrumb breadcrumb2;
        private AntdUI.Label label3;
    }
}
