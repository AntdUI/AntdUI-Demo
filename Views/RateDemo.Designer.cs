namespace AntdUIDemo.Views
{
    partial class RateDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateDemo));
            this.panelMain = new AntdUI.In.Panel();
            this.p5 = new AntdUI.FlowPanel();
            this.rate8 = new AntdUI.Rate();
            this.rate6 = new AntdUI.Rate();
            this.rate5 = new AntdUI.Rate();
            this.h5 = new AntdUI.Label();
            this.p4 = new AntdUI.FlowPanel();
            this.rate4 = new AntdUI.Rate();
            this.h4 = new AntdUI.Label();
            this.p3 = new AntdUI.FlowPanel();
            this.rate3 = new AntdUI.Rate();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.rate9 = new AntdUI.Rate();
            this.rate10 = new AntdUI.Rate();
            this.rate11 = new AntdUI.Rate();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.rate7 = new AntdUI.Rate();
            this.rate2 = new AntdUI.Rate();
            this.rate1 = new AntdUI.Rate();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.p5.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p5);
            this.panelMain.Controls.Add(this.h5);
            this.panelMain.Controls.Add(this.p4);
            this.panelMain.Controls.Add(this.h4);
            this.panelMain.Controls.Add(this.p3);
            this.panelMain.Controls.Add(this.h3);
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 420);
            this.panelMain.TabIndex = 0;
            // 
            // p5
            // 
            this.p5.Controls.Add(this.rate8);
            this.p5.Controls.Add(this.rate6);
            this.p5.Controls.Add(this.rate5);
            this.p5.Dock = System.Windows.Forms.DockStyle.Top;
            this.p5.Location = new System.Drawing.Point(0, 272);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(750, 38);
            this.p5.TabIndex = 5;
            // 
            // rate8
            // 
            this.rate8.Character = "好";
            this.rate8.Location = new System.Drawing.Point(415, 3);
            this.rate8.Name = "rate8";
            this.rate8.Size = new System.Drawing.Size(200, 32);
            this.rate8.TabIndex = 3;
            this.rate8.Value = 3F;
            // 
            // rate6
            // 
            this.rate6.Character = "A";
            this.rate6.Location = new System.Drawing.Point(209, 3);
            this.rate6.Name = "rate6";
            this.rate6.Size = new System.Drawing.Size(200, 32);
            this.rate6.TabIndex = 2;
            this.rate6.Value = 3F;
            // 
            // rate5
            // 
            this.rate5.Character = resources.GetString("rate5.Character");
            this.rate5.Location = new System.Drawing.Point(3, 3);
            this.rate5.Name = "rate5";
            this.rate5.Size = new System.Drawing.Size(200, 32);
            this.rate5.TabIndex = 1;
            this.rate5.Value = 3F;
            // 
            // h5
            // 
            this.h5.Dock = System.Windows.Forms.DockStyle.Top;
            this.h5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h5.Location = new System.Drawing.Point(0, 248);
            this.h5.Name = "h5";
            this.h5.PrefixColour = AntdUI.Colour.Primary;
            this.h5.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h5.Size = new System.Drawing.Size(750, 24);
            this.h5.TabIndex = 0;
            this.h5.Text = "字符自定义";
            // 
            // p4
            // 
            this.p4.Controls.Add(this.rate4);
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Location = new System.Drawing.Point(0, 210);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(750, 38);
            this.p4.TabIndex = 4;
            // 
            // rate4
            // 
            this.rate4.Location = new System.Drawing.Point(3, 3);
            this.rate4.Name = "rate4";
            this.rate4.Size = new System.Drawing.Size(200, 32);
            this.rate4.TabIndex = 1;
            this.rate4.Tooltips = new string[] {
        "terrible",
        "bad",
        "normal",
        "good",
        "wonderful"};
            this.rate4.Value = 3F;
            // 
            // h4
            // 
            this.h4.Dock = System.Windows.Forms.DockStyle.Top;
            this.h4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h4.Location = new System.Drawing.Point(0, 186);
            this.h4.Name = "h4";
            this.h4.PrefixColour = AntdUI.Colour.Primary;
            this.h4.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h4.Size = new System.Drawing.Size(750, 24);
            this.h4.TabIndex = 0;
            this.h4.Text = "提示信息";
            // 
            // p3
            // 
            this.p3.Controls.Add(this.rate3);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            // 
            // rate3
            // 
            this.rate3.AllowHalf = true;
            this.rate3.Location = new System.Drawing.Point(3, 3);
            this.rate3.Name = "rate3";
            this.rate3.Size = new System.Drawing.Size(200, 32);
            this.rate3.TabIndex = 1;
            this.rate3.Value = 2.5F;
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
            this.h3.Text = "半星";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.rate9);
            this.p2.Controls.Add(this.rate10);
            this.p2.Controls.Add(this.rate11);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // rate9
            // 
            this.rate9.AllowClear = true;
            this.rate9.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rate9.Location = new System.Drawing.Point(415, 3);
            this.rate9.Name = "rate9";
            this.rate9.Size = new System.Drawing.Size(200, 32);
            this.rate9.TabIndex = 2;
            this.rate9.Text = "rate9";
            this.rate9.Value = 3F;
            // 
            // rate10
            // 
            this.rate10.AllowClear = true;
            this.rate10.Location = new System.Drawing.Point(209, 3);
            this.rate10.Name = "rate10";
            this.rate10.Size = new System.Drawing.Size(200, 32);
            this.rate10.TabIndex = 1;
            this.rate10.Value = 3F;
            // 
            // rate11
            // 
            this.rate11.AllowClear = true;
            this.rate11.Count = 3;
            this.rate11.Location = new System.Drawing.Point(3, 3);
            this.rate11.Name = "rate11";
            this.rate11.Size = new System.Drawing.Size(200, 32);
            this.rate11.TabIndex = 0;
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
            this.h2.Text = "允许清除";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.rate7);
            this.p1.Controls.Add(this.rate2);
            this.p1.Controls.Add(this.rate1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // rate7
            // 
            this.rate7.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rate7.Location = new System.Drawing.Point(415, 3);
            this.rate7.Name = "rate7";
            this.rate7.Size = new System.Drawing.Size(200, 32);
            this.rate7.TabIndex = 2;
            this.rate7.Value = 3F;
            // 
            // rate2
            // 
            this.rate2.Location = new System.Drawing.Point(209, 3);
            this.rate2.Name = "rate2";
            this.rate2.Size = new System.Drawing.Size(200, 32);
            this.rate2.TabIndex = 1;
            this.rate2.Value = 3F;
            // 
            // rate1
            // 
            this.rate1.Count = 3;
            this.rate1.Location = new System.Drawing.Point(3, 3);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(200, 32);
            this.rate1.TabIndex = 0;
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
            // header1
            // 
            this.header1.Description = "用于对事物进行评分操作。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Rate 评分";
            this.header1.UseTitleFont = true;
            // 
            // RateDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "RateDemo";
            this.Size = new System.Drawing.Size(750, 494);
            this.panelMain.ResumeLayout(false);
            this.p5.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.FlowPanel p1;
        private AntdUI.Rate rate1;
        private AntdUI.Label h1;
        private AntdUI.Rate rate2;
        private AntdUI.Rate rate7;
        private AntdUI.FlowPanel p5;
        private AntdUI.Rate rate8;
        private AntdUI.Rate rate6;
        private AntdUI.Rate rate5;
        private AntdUI.Label h5;
        private AntdUI.FlowPanel p4;
        private AntdUI.Rate rate4;
        private AntdUI.Label h4;
        private AntdUI.FlowPanel p3;
        private AntdUI.Rate rate3;
        private AntdUI.Label h3;
        private AntdUI.FlowPanel p2;
        private AntdUI.Rate rate9;
        private AntdUI.Rate rate10;
        private AntdUI.Rate rate11;
        private AntdUI.Label h2;
        private AntdUI.PageHeader header1;
    }
}
