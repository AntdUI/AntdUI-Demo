namespace AntdUIDemo.Views
{
    partial class TourDemo
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
            this.header1 = new AntdUI.PageHeader();
            this.label3 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.button_base = new AntdUI.Button();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.button3 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.button1 = new AntdUI.Button();
            this.button_custom = new AntdUI.Button();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "用于分步引导用户了解产品功能的气泡组件。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 28;
            this.header1.Text = "Tour 漫游式引导";
            this.header1.UseTitleFont = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(750, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "基本用法";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button_custom);
            this.flowPanel1.Controls.Add(this.button_base);
            this.flowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel1.Location = new System.Drawing.Point(0, 98);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(750, 38);
            this.flowPanel1.TabIndex = 30;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // button_base
            // 
            this.button_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_base.Location = new System.Drawing.Point(3, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(100, 32);
            this.button_base.TabIndex = 1;
            this.button_base.Text = "Begin Tour";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.button3);
            this.flowPanel2.Controls.Add(this.button2);
            this.flowPanel2.Controls.Add(this.button1);
            this.flowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel2.Location = new System.Drawing.Point(0, 136);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(750, 38);
            this.flowPanel2.TabIndex = 31;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.IconSvg = "EllipsisOutlined";
            this.button3.Location = new System.Drawing.Point(175, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 32);
            this.button3.TabIndex = 4;
            this.button3.WaveSize = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(89, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.Type = AntdUI.TTypeMini.Primary;
            this.button2.WaveSize = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Upload";
            this.button1.WaveSize = 0;
            // 
            // button_custom
            // 
            this.button_custom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_custom.Location = new System.Drawing.Point(109, 3);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(100, 32);
            this.button_custom.TabIndex = 5;
            this.button_custom.Text = "Begin Tour";
            this.button_custom.Type = AntdUI.TTypeMini.Primary;
            this.button_custom.WaveSize = 0;
            // 
            // TourDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.flowPanel2);
            this.Controls.Add(this.flowPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.header1);
            this.Name = "TourDemo";
            this.Size = new System.Drawing.Size(750, 531);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button_base;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button button3;
        private AntdUI.Button button2;
        private AntdUI.Button button1;
        private AntdUI.Button button_custom;
    }
}
