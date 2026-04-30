namespace AntdUIDemo.Views
{
    partial class DrawerDemo
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
            this.panelMain = new AntdUI.In.Panel();
            this.p2 = new AntdUI.StackPanel();
            this.input_displaydealy = new AntdUI.InputNumber();
            this.label1 = new AntdUI.Label();
            this.switch_mc = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.switch_mask = new AntdUI.Switch();
            this.label5 = new AntdUI.Label();
            this.select_align = new AntdUI.Select();
            this.label10 = new AntdUI.Label();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.button = new AntdUI.Button();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "屏幕边缘滑出的浮层面板。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Drawer 抽屉";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 253);
            this.panelMain.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Controls.Add(this.input_displaydealy);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.switch_mc);
            this.p2.Controls.Add(this.label6);
            this.p2.Controls.Add(this.switch_mask);
            this.p2.Controls.Add(this.label5);
            this.p2.Controls.Add(this.select_align);
            this.p2.Controls.Add(this.label10);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Gap = 4;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 32);
            this.p2.TabIndex = 2;
            // 
            // input_displaydealy
            // 
            this.input_displaydealy.Location = new System.Drawing.Point(653, 3);
            this.input_displaydealy.Name = "input_displaydealy";
            this.input_displaydealy.Size = new System.Drawing.Size(75, 26);
            this.input_displaydealy.TabIndex = 15;
            this.input_displaydealy.Text = "0";
            this.input_displaydealy.WaveSize = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(523, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "DisplayDelay";
            // 
            // switch_mc
            // 
            this.switch_mc.Location = new System.Drawing.Point(463, 3);
            this.switch_mc.Name = "switch_mc";
            this.switch_mc.Size = new System.Drawing.Size(50, 26);
            this.switch_mc.TabIndex = 13;
            this.switch_mc.Text = "switch1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label6.Location = new System.Drawing.Point(333, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "MaskClosable";
            // 
            // switch_mask
            // 
            this.switch_mask.Location = new System.Drawing.Point(273, 3);
            this.switch_mask.Name = "switch_mask";
            this.switch_mask.Size = new System.Drawing.Size(50, 26);
            this.switch_mask.TabIndex = 11;
            this.switch_mask.Text = "switch1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(188, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mask";
            // 
            // select_align
            // 
            this.select_align.List = true;
            this.select_align.Location = new System.Drawing.Point(88, 3);
            this.select_align.Name = "select_align";
            this.select_align.Size = new System.Drawing.Size(90, 26);
            this.select_align.TabIndex = 5;
            this.select_align.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Align";
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
            this.h2.Text = "控件配置";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.button);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(3, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(80, 32);
            this.button.TabIndex = 1;
            this.button.Text = "Open";
            this.button.Type = AntdUI.TTypeMini.Primary;
            this.button.WaveSize = 0;
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
            // DrawerDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "DrawerDemo";
            this.Size = new System.Drawing.Size(750, 327);
            this.panelMain.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Label h2;
        private AntdUI.StackPanel p2;
        private AntdUI.Select select_align;
        private AntdUI.Label label10;
        private AntdUI.Switch switch_mc;
        private AntdUI.Label label6;
        private AntdUI.Switch switch_mask;
        private AntdUI.Label label5;
        private AntdUI.Button button;
        private AntdUI.InputNumber input_displaydealy;
        private AntdUI.Label label1;
    }
}
