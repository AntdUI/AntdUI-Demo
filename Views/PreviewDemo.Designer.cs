namespace AntdUIDemo.Views
{
    partial class PreviewDemo
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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.button_views = new AntdUI.Button();
            this.button_view = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label4 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 104);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 118);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button_views);
            this.flowPanel1.Controls.Add(this.button_view);
            this.flowPanel1.Location = new System.Drawing.Point(3, 51);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 19;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // button_views
            // 
            this.button_views.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_views.Location = new System.Drawing.Point(84, 3);
            this.button_views.Name = "button_views";
            this.button_views.Size = new System.Drawing.Size(75, 32);
            this.button_views.TabIndex = 2;
            this.button_views.Text = "多图预览";
            this.button_views.Type = AntdUI.TTypeMini.Primary;
            this.button_views.WaveSize = 0;
            // 
            // button_view
            // 
            this.button_view.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_view.Location = new System.Drawing.Point(3, 3);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(75, 32);
            this.button_view.TabIndex = 1;
            this.button_view.Text = "单图预览";
            this.button_view.Type = AntdUI.TTypeMini.Primary;
            this.button_view.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 3);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(744, 12);
            this.divider1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label4.Location = new System.Drawing.Point(0, 74);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 6);
            this.label4.Size = new System.Drawing.Size(750, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Preview没有工具箱控件，使用代码方式调用。";
            // 
            // header1
            // 
            this.header1.Description = "实现简单的图片预览。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Preview 图片预览";
            this.header1.UseTitleFont = true;
            // 
            // PreviewDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.header1);
            this.Name = "PreviewDemo";
            this.Size = new System.Drawing.Size(750, 222);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button_views;
        private AntdUI.Button button_view;
        private AntdUI.Label label3;
        private AntdUI.Divider divider1;
        private AntdUI.PageHeader header1;
    }
}
