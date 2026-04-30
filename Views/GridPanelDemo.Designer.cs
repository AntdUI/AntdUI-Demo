namespace AntdUIDemo.Views
{
    partial class GridPanelDemo
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
            this.gridPanel = new AntdUI.GridPanel();
            this.label1 = new AntdUI.Label();
            this.buttonCZ = new AntdUI.Button();
            this.stackPanel4 = new AntdUI.StackPanel();
            this.input_gap = new AntdUI.InputNumber();
            this.label4 = new AntdUI.Label();
            this.input_span = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.gridPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "精准划分区域的网格布局容器。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "GridPanel 网格布局";
            this.header1.UseTitleFont = true;
            // 
            // gridPanel
            // 
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(244, 74);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(506, 401);
            this.gridPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 251);
            this.label1.TabIndex = 0;
            this.label1.Text = "Span：以-符号分界。\r\n-前为列宽属性，列宽以 ; 分组，每一组代表一行。\r\n-后为行高属性。\r\n行高属性个数要与行数对应，每个数之间用空格间隔";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // buttonCZ
            // 
            this.buttonCZ.Location = new System.Drawing.Point(3, 107);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(238, 34);
            this.buttonCZ.TabIndex = 3;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // stackPanel4
            // 
            this.stackPanel4.Location = new System.Drawing.Point(3, 60);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(244, 32);
            this.stackPanel4.TabIndex = 18;
            this.stackPanel4.Text = "stackPanel4";
            // 
            // input_gap
            // 
            this.input_gap.Location = new System.Drawing.Point(83, 67);
            this.input_gap.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_gap.Name = "input_gap";
            this.input_gap.Size = new System.Drawing.Size(158, 34);
            this.input_gap.TabIndex = 2;
            this.input_gap.Text = "0";
            this.input_gap.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gap";
            // 
            // input_span
            // 
            this.input_span.Location = new System.Drawing.Point(83, 3);
            this.input_span.Multiline = true;
            this.input_span.Name = "input_span";
            this.input_span.Size = new System.Drawing.Size(158, 58);
            this.input_span.TabIndex = 1;
            this.input_span.Text = "50% 50%;20% 80%;150 200;-20% 30% 50%";
            this.input_span.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Span";
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.label1);
            this.gridPanel1.Controls.Add(this.buttonCZ);
            this.gridPanel1.Controls.Add(this.input_gap);
            this.gridPanel1.Controls.Add(this.label4);
            this.gridPanel1.Controls.Add(this.input_span);
            this.gridPanel1.Controls.Add(this.label3);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridPanel1.Location = new System.Drawing.Point(0, 74);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(244, 401);
            this.gridPanel1.Span = "64:80 100%;40:80 100%;40:100%;100%:100%";
            this.gridPanel1.TabIndex = 1;
            // 
            // GridPanelDemo
            // 
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.gridPanel1);
            this.Controls.Add(this.header1);
            this.Name = "GridPanelDemo";
            this.Size = new System.Drawing.Size(750, 475);
            this.Load += new System.EventHandler(this.GridPanelDemo_Load);
            this.gridPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Input input_span;
        private AntdUI.Label label3;
        private AntdUI.GridPanel gridPanel;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.InputNumber input_gap;
        private AntdUI.Label label4;
        private AntdUI.Button buttonCZ;
        private AntdUI.Label label1;
    }
}
