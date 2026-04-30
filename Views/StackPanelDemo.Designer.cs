namespace AntdUIDemo.Views
{
    partial class StackPanelDemo
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
            this.stackPanel = new AntdUI.StackPanel();
            this.buttonCZ = new AntdUI.Button();
            this.buttonDEL = new AntdUI.Button();
            this.buttonADD = new AntdUI.Button();
            this.switch_vertical = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.switch_autoscroll = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.input_itemsize = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.input_gap = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.gridPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel
            // 
            this.stackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel.Location = new System.Drawing.Point(220, 74);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(530, 457);
            this.stackPanel.TabIndex = 2;
            this.stackPanel.Vertical = true;
            // 
            // buttonCZ
            // 
            this.buttonCZ.Location = new System.Drawing.Point(3, 243);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(214, 34);
            this.buttonCZ.TabIndex = 7;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // buttonDEL
            // 
            this.buttonDEL.Location = new System.Drawing.Point(3, 203);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(214, 34);
            this.buttonDEL.TabIndex = 6;
            this.buttonDEL.Text = "删除 Button";
            this.buttonDEL.Type = AntdUI.TTypeMini.Error;
            this.buttonDEL.WaveSize = 0;
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(3, 163);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(214, 34);
            this.buttonADD.TabIndex = 5;
            this.buttonADD.Text = "添加 Button";
            this.buttonADD.Type = AntdUI.TTypeMini.Info;
            this.buttonADD.WaveSize = 0;
            // 
            // switch_vertical
            // 
            this.switch_vertical.Checked = true;
            this.switch_vertical.Location = new System.Drawing.Point(91, 123);
            this.switch_vertical.Name = "switch_vertical";
            this.switch_vertical.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.switch_vertical.Size = new System.Drawing.Size(44, 34);
            this.switch_vertical.TabIndex = 4;
            this.switch_vertical.Text = "switch1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vertical";
            // 
            // switch_autoscroll
            // 
            this.switch_autoscroll.Location = new System.Drawing.Point(91, 83);
            this.switch_autoscroll.Name = "switch_autoscroll";
            this.switch_autoscroll.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.switch_autoscroll.Size = new System.Drawing.Size(44, 34);
            this.switch_autoscroll.TabIndex = 3;
            this.switch_autoscroll.Text = "switch1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "AutoScroll";
            // 
            // input_itemsize
            // 
            this.input_itemsize.Location = new System.Drawing.Point(91, 43);
            this.input_itemsize.Name = "input_itemsize";
            this.input_itemsize.PlaceholderText = "数值或百分比";
            this.input_itemsize.Size = new System.Drawing.Size(126, 34);
            this.input_itemsize.TabIndex = 2;
            this.input_itemsize.WaveSize = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "ItemSize";
            // 
            // input_gap
            // 
            this.input_gap.Location = new System.Drawing.Point(91, 3);
            this.input_gap.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_gap.Name = "input_gap";
            this.input_gap.Size = new System.Drawing.Size(126, 34);
            this.input_gap.TabIndex = 1;
            this.input_gap.Text = "0";
            this.input_gap.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gap";
            // 
            // header1
            // 
            this.header1.Description = "将子元素排列成水平或垂直的一行。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "StackPanel 堆叠布局";
            this.header1.UseTitleFont = true;
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.buttonCZ);
            this.gridPanel1.Controls.Add(this.buttonDEL);
            this.gridPanel1.Controls.Add(this.buttonADD);
            this.gridPanel1.Controls.Add(this.switch_vertical);
            this.gridPanel1.Controls.Add(this.label6);
            this.gridPanel1.Controls.Add(this.switch_autoscroll);
            this.gridPanel1.Controls.Add(this.label4);
            this.gridPanel1.Controls.Add(this.input_itemsize);
            this.gridPanel1.Controls.Add(this.label5);
            this.gridPanel1.Controls.Add(this.input_gap);
            this.gridPanel1.Controls.Add(this.label3);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridPanel1.Location = new System.Drawing.Point(0, 74);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(220, 457);
            this.gridPanel1.Span = "40:88 100%;40:88 100%;40:88 50 100%_N;40:88 50 100%_N;40:100%;40:100%;40:100%";
            this.gridPanel1.TabIndex = 1;
            // 
            // StackPanelDemo
            // 
            this.Controls.Add(this.stackPanel);
            this.Controls.Add(this.gridPanel1);
            this.Controls.Add(this.header1);
            this.Name = "StackPanelDemo";
            this.Size = new System.Drawing.Size(750, 531);
            this.Load += new System.EventHandler(this.StackPanelDemo_Load);
            this.gridPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.StackPanel stackPanel;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.InputNumber input_gap;
        private AntdUI.Label label3;
        private AntdUI.Label label5;
        private AntdUI.Input input_itemsize;
        private AntdUI.Button buttonCZ;
        private AntdUI.Button buttonDEL;
        private AntdUI.Button buttonADD;
        private AntdUI.Switch switch_vertical;
        private AntdUI.Label label6;
        private AntdUI.Switch switch_autoscroll;
        private AntdUI.Label label4;
        private AntdUI.PageHeader header1;
    }
}
