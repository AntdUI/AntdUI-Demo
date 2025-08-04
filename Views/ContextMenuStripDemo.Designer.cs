namespace AntdUIDemo.Views
{
    partial class ContextMenuStripDemo
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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel = new AntdUI.FlowPanel();
            this.button_base = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "表示快捷菜单。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "ContextMenuStrip 快捷菜单";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 104);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 394);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.button_base);
            this.flowPanel.Location = new System.Drawing.Point(3, 33);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(744, 38);
            this.flowPanel.TabIndex = 58;
            this.flowPanel.Text = "flowPanel1";
            // 
            // button_base
            // 
            this.button_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_base.Location = new System.Drawing.Point(3, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(80, 32);
            this.button_base.TabIndex = 5;
            this.button_base.Text = "Click";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "基本用法";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 6);
            this.label3.Size = new System.Drawing.Size(750, 30);
            this.label3.TabIndex = 55;
            this.label3.Text = "ContextMenuStrip没有工具箱控件，使用代码方式调用。";
            // 
            // ContextMenuStripDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.header1);
            this.Name = "ContextMenuStripDemo";
            this.Size = new System.Drawing.Size(750, 498);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.FlowPanel flowPanel;
        private AntdUI.Button button_base;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
    }
}
