namespace AntdUIDemo.Views
{
    partial class InputNumberDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputNumberDemo));
            this.header1 = new AntdUI.PageHeader();
            this.panelMain = new AntdUI.In.Panel();
            this.p3 = new AntdUI.FlowPanel();
            this.inputNumber8 = new AntdUI.InputNumber();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.inputNumber3 = new AntdUI.InputNumber();
            this.inputNumber2 = new AntdUI.InputNumber();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.inputNumber5 = new AntdUI.InputNumber();
            this.inputNumber4 = new AntdUI.InputNumber();
            this.inputNumber1 = new AntdUI.InputNumber();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "通过鼠标或键盘，输入范围内的数值。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "InputNumber 数字输入框";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p3);
            this.panelMain.Controls.Add(this.h3);
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 397);
            this.panelMain.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Controls.Add(this.inputNumber8);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            this.p3.Text = "flowPanel3";
            // 
            // inputNumber8
            // 
            this.inputNumber8.Hexadecimal = true;
            this.inputNumber8.Location = new System.Drawing.Point(3, 3);
            this.inputNumber8.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber8.Name = "inputNumber8";
            this.inputNumber8.Size = new System.Drawing.Size(200, 32);
            this.inputNumber8.TabIndex = 0;
            this.inputNumber8.Text = "0";
            this.inputNumber8.WaveSize = 0;
            // 
            // h3
            // 
            this.h3.Dock = System.Windows.Forms.DockStyle.Top;
            this.h3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h3.Location = new System.Drawing.Point(0, 124);
            this.h3.Name = "h3";
            this.h3.PrefixColour = AntdUI.Colour.Primary;
            this.h3.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h3.Size = new System.Drawing.Size(750, 24);
            this.h3.TabIndex = 0;
            this.h3.Text = "十六进制显示";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.inputNumber3);
            this.p2.Controls.Add(this.inputNumber2);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            this.p2.Text = "flowPanel2";
            // 
            // inputNumber3
            // 
            this.inputNumber3.Location = new System.Drawing.Point(209, 3);
            this.inputNumber3.Name = "inputNumber3";
            this.inputNumber3.PlaceholderText = "图标";
            this.inputNumber3.PrefixSvg = resources.GetString("inputNumber3.PrefixSvg");
            this.inputNumber3.Size = new System.Drawing.Size(200, 32);
            this.inputNumber3.SuffixSvg = resources.GetString("inputNumber3.SuffixSvg");
            this.inputNumber3.TabIndex = 1;
            this.inputNumber3.Text = "0";
            this.inputNumber3.WaveSize = 0;
            // 
            // inputNumber2
            // 
            this.inputNumber2.Location = new System.Drawing.Point(3, 3);
            this.inputNumber2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.inputNumber2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.PlaceholderText = "文本";
            this.inputNumber2.PrefixText = "+";
            this.inputNumber2.Size = new System.Drawing.Size(200, 32);
            this.inputNumber2.SuffixText = "$";
            this.inputNumber2.TabIndex = 0;
            this.inputNumber2.Text = "0";
            this.inputNumber2.WaveSize = 0;
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
            this.h2.Text = "前/后标签";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.inputNumber5);
            this.p1.Controls.Add(this.inputNumber4);
            this.p1.Controls.Add(this.inputNumber1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            this.p1.Text = "flowPanel1";
            // 
            // inputNumber5
            // 
            this.inputNumber5.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber5.Location = new System.Drawing.Point(415, 3);
            this.inputNumber5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputNumber5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber5.Name = "inputNumber5";
            this.inputNumber5.PlaceholderText = "千分位";
            this.inputNumber5.Size = new System.Drawing.Size(200, 32);
            this.inputNumber5.TabIndex = 2;
            this.inputNumber5.Text = "1,000";
            this.inputNumber5.ThousandsSeparator = true;
            this.inputNumber5.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber5.WaveSize = 0;
            // 
            // inputNumber4
            // 
            this.inputNumber4.DecimalPlaces = 1;
            this.inputNumber4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputNumber4.Location = new System.Drawing.Point(209, 3);
            this.inputNumber4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber4.Name = "inputNumber4";
            this.inputNumber4.PlaceholderText = "小数位数";
            this.inputNumber4.Size = new System.Drawing.Size(200, 32);
            this.inputNumber4.TabIndex = 1;
            this.inputNumber4.Text = "0.0";
            this.inputNumber4.ThousandsSeparator = true;
            this.inputNumber4.WaveSize = 0;
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(3, 3);
            this.inputNumber1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputNumber1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(200, 32);
            this.inputNumber1.TabIndex = 0;
            this.inputNumber1.Text = "0";
            this.inputNumber1.WaveSize = 0;
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
            this.h1.Text = "基本类型";
            // 
            // InputNumberDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "InputNumberDemo";
            this.Size = new System.Drawing.Size(750, 471);
            this.panelMain.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.FlowPanel p1;
        private AntdUI.Label h1;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.FlowPanel p2;
        private AntdUI.InputNumber inputNumber2;
        private AntdUI.Label h2;
        private AntdUI.InputNumber inputNumber3;
        private AntdUI.InputNumber inputNumber4;
        private AntdUI.InputNumber inputNumber5;
        private AntdUI.Label h3;
        private AntdUI.FlowPanel p3;
        private AntdUI.InputNumber inputNumber8;
    }
}
