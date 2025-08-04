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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.stackPanel2 = new AntdUI.StackPanel();
            this.flowPanel = new AntdUI.FlowPanel();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.buttonCZ = new AntdUI.Button();
            this.buttonDEL = new AntdUI.Button();
            this.buttonADD = new AntdUI.Button();
            this.stackPanel6 = new AntdUI.StackPanel();
            this.switch_autoscroll = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.stackPanel5 = new AntdUI.StackPanel();
            this.input_gap = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.stackPanel4 = new AntdUI.StackPanel();
            this.select_align = new AntdUI.Select();
            this.label10 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.stackPanel6.SuspendLayout();
            this.stackPanel5.SuspendLayout();
            this.stackPanel4.SuspendLayout();
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
            this.header1.TabIndex = 27;
            this.header1.Text = "FlowPanel 流动布局";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 422);
            this.stackPanel1.TabIndex = 1;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.flowPanel);
            this.stackPanel2.Controls.Add(this.stackPanel3);
            this.stackPanel2.Location = new System.Drawing.Point(3, 3);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(744, 279);
            this.stackPanel2.TabIndex = 7;
            this.stackPanel2.Text = "stackPanel2";
            // 
            // flowPanel
            // 
            this.flowPanel.Badge = "";
            this.flowPanel.Location = new System.Drawing.Point(259, 3);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(462, 273);
            this.flowPanel.TabIndex = 1;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.buttonCZ);
            this.stackPanel3.Controls.Add(this.buttonDEL);
            this.stackPanel3.Controls.Add(this.buttonADD);
            this.stackPanel3.Controls.Add(this.stackPanel6);
            this.stackPanel3.Controls.Add(this.stackPanel5);
            this.stackPanel3.Controls.Add(this.stackPanel4);
            this.stackPanel3.Location = new System.Drawing.Point(3, 3);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(250, 273);
            this.stackPanel3.TabIndex = 0;
            this.stackPanel3.Text = "stackPanel3";
            this.stackPanel3.Vertical = true;
            // 
            // buttonCZ
            // 
            this.buttonCZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCZ.Location = new System.Drawing.Point(3, 193);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(244, 32);
            this.buttonCZ.TabIndex = 37;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // buttonDEL
            // 
            this.buttonDEL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDEL.Location = new System.Drawing.Point(3, 155);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(244, 32);
            this.buttonDEL.TabIndex = 36;
            this.buttonDEL.Text = "删除 Button";
            this.buttonDEL.Type = AntdUI.TTypeMini.Error;
            this.buttonDEL.WaveSize = 0;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonADD.Location = new System.Drawing.Point(3, 117);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(244, 32);
            this.buttonADD.TabIndex = 35;
            this.buttonADD.Text = "添加 Button";
            this.buttonADD.Type = AntdUI.TTypeMini.Info;
            this.buttonADD.WaveSize = 0;
            // 
            // stackPanel6
            // 
            this.stackPanel6.Controls.Add(this.switch_autoscroll);
            this.stackPanel6.Controls.Add(this.label4);
            this.stackPanel6.Location = new System.Drawing.Point(3, 79);
            this.stackPanel6.Name = "stackPanel6";
            this.stackPanel6.Size = new System.Drawing.Size(244, 32);
            this.stackPanel6.TabIndex = 11;
            this.stackPanel6.Text = "stackPanel6";
            // 
            // switch_autoscroll
            // 
            this.switch_autoscroll.AutoCheck = true;
            this.switch_autoscroll.Location = new System.Drawing.Point(97, 3);
            this.switch_autoscroll.Name = "switch_autoscroll";
            this.switch_autoscroll.Size = new System.Drawing.Size(50, 26);
            this.switch_autoscroll.TabIndex = 5;
            this.switch_autoscroll.Text = "switch1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "AutoScroll";
            // 
            // stackPanel5
            // 
            this.stackPanel5.Controls.Add(this.input_gap);
            this.stackPanel5.Controls.Add(this.label3);
            this.stackPanel5.Location = new System.Drawing.Point(3, 41);
            this.stackPanel5.Name = "stackPanel5";
            this.stackPanel5.Size = new System.Drawing.Size(244, 32);
            this.stackPanel5.TabIndex = 10;
            this.stackPanel5.Text = "stackPanel5";
            // 
            // input_gap
            // 
            this.input_gap.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_gap.Location = new System.Drawing.Point(97, 3);
            this.input_gap.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_gap.Name = "input_gap";
            this.input_gap.Size = new System.Drawing.Size(145, 26);
            this.input_gap.TabIndex = 5;
            this.input_gap.Text = "0";
            this.input_gap.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gap";
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.select_align);
            this.stackPanel4.Controls.Add(this.label10);
            this.stackPanel4.Location = new System.Drawing.Point(3, 3);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(244, 32);
            this.stackPanel4.TabIndex = 9;
            this.stackPanel4.Text = "stackPanel4";
            // 
            // select_align
            // 
            this.select_align.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_align.List = true;
            this.select_align.Location = new System.Drawing.Point(97, 3);
            this.select_align.Name = "select_align";
            this.select_align.Size = new System.Drawing.Size(145, 26);
            this.select_align.TabIndex = 11;
            this.select_align.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Align";
            // 
            // FlowPanelDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "FlowPanelDemo";
            this.Size = new System.Drawing.Size(750, 496);
            this.Load += new System.EventHandler(this.FlowPanelDemo_Load);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel6.ResumeLayout(false);
            this.stackPanel5.ResumeLayout(false);
            this.stackPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.FlowPanel flowPanel;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.Label label10;
        private AntdUI.Select select_align;
        private AntdUI.StackPanel stackPanel5;
        private AntdUI.InputNumber input_gap;
        private AntdUI.Label label3;
        private AntdUI.StackPanel stackPanel6;
        private AntdUI.Label label4;
        private AntdUI.Button buttonDEL;
        private AntdUI.Button buttonADD;
        private AntdUI.Button buttonCZ;
        private AntdUI.Switch switch_autoscroll;
    }
}
