namespace AntdUIDemo.Views
{
    partial class FlowPanelDemo
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
            this.flowPanel = new AntdUI.FlowPanel();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.buttonCZ = new AntdUI.Button();
            this.buttonDEL = new AntdUI.Button();
            this.buttonADD = new AntdUI.Button();
            this.switch_autoscroll = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.input_gap = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.select_align = new AntdUI.Select();
            this.label10 = new AntdUI.Label();
            this.gridPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "用于对齐的弹性布局容器。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "FlowPanel 流动布局";
            this.header1.UseTitleFont = true;
            // 
            // flowPanel
            // 
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(250, 74);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(500, 422);
            this.flowPanel.TabIndex = 2;
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.buttonCZ);
            this.gridPanel1.Controls.Add(this.buttonDEL);
            this.gridPanel1.Controls.Add(this.buttonADD);
            this.gridPanel1.Controls.Add(this.switch_autoscroll);
            this.gridPanel1.Controls.Add(this.label4);
            this.gridPanel1.Controls.Add(this.input_gap);
            this.gridPanel1.Controls.Add(this.label3);
            this.gridPanel1.Controls.Add(this.select_align);
            this.gridPanel1.Controls.Add(this.label10);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridPanel1.Location = new System.Drawing.Point(0, 74);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(250, 422);
            this.gridPanel1.Span = "40:88 100%;40:88 100%;40:88 50 100%_N;40:100%;40:100%;40:100%";
            this.gridPanel1.TabIndex = 1;
            // 
            // buttonCZ
            // 
            this.buttonCZ.Location = new System.Drawing.Point(3, 203);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(244, 34);
            this.buttonCZ.TabIndex = 6;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // buttonDEL
            // 
            this.buttonDEL.Location = new System.Drawing.Point(3, 163);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(244, 34);
            this.buttonDEL.TabIndex = 5;
            this.buttonDEL.Text = "删除 Button";
            this.buttonDEL.Type = AntdUI.TTypeMini.Error;
            this.buttonDEL.WaveSize = 0;
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(3, 123);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(244, 34);
            this.buttonADD.TabIndex = 4;
            this.buttonADD.Text = "添加 Button";
            this.buttonADD.Type = AntdUI.TTypeMini.Info;
            this.buttonADD.WaveSize = 0;
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
            // input_gap
            // 
            this.input_gap.Location = new System.Drawing.Point(91, 43);
            this.input_gap.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_gap.Name = "input_gap";
            this.input_gap.Size = new System.Drawing.Size(156, 34);
            this.input_gap.TabIndex = 2;
            this.input_gap.Text = "0";
            this.input_gap.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gap";
            // 
            // select_align
            // 
            this.select_align.List = true;
            this.select_align.Location = new System.Drawing.Point(91, 3);
            this.select_align.Name = "select_align";
            this.select_align.Size = new System.Drawing.Size(156, 34);
            this.select_align.TabIndex = 1;
            this.select_align.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Align";
            // 
            // FlowPanelDemo
            // 
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.gridPanel1);
            this.Controls.Add(this.header1);
            this.Name = "FlowPanelDemo";
            this.Size = new System.Drawing.Size(750, 496);
            this.Load += new System.EventHandler(this.FlowPanelDemo_Load);
            this.gridPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.FlowPanel flowPanel;
        private AntdUI.Label label10;
        private AntdUI.Select select_align;
        private AntdUI.InputNumber input_gap;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Button buttonDEL;
        private AntdUI.Button buttonADD;
        private AntdUI.Button buttonCZ;
        private AntdUI.Switch switch_autoscroll;
        private AntdUI.GridPanel gridPanel1;
    }
}
