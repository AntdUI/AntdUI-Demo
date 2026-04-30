namespace AntdUIDemo.Views
{
    partial class DatePickerRangeDemo
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
            this.p4 = new AntdUI.FlowPanel();
            this.datePickerRange4 = new AntdUI.DatePickerRange();
            this.datePickerRange5 = new AntdUI.DatePickerRange();
            this.h4 = new AntdUI.Label();
            this.p3 = new AntdUI.FlowPanel();
            this.datePickerRange3 = new AntdUI.DatePickerRange();
            this.datePickerRange2 = new AntdUI.DatePickerRange();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.datePickerRange = new AntdUI.DatePickerRange();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.datePickerRange1 = new AntdUI.DatePickerRange();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "输入或选择范围日期的控件。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "DatePickerRange 日期范围选择器";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
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
            this.panelMain.Size = new System.Drawing.Size(750, 352);
            this.panelMain.TabIndex = 0;
            // 
            // p4
            // 
            this.p4.Controls.Add(this.datePickerRange4);
            this.p4.Controls.Add(this.datePickerRange5);
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Location = new System.Drawing.Point(0, 210);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(750, 38);
            this.p4.TabIndex = 4;
            // 
            // datePickerRange4
            // 
            this.datePickerRange4.Format = "yyyy-MM-dd HH:mm:ss";
            this.datePickerRange4.InteractiveReset = false;
            this.datePickerRange4.Location = new System.Drawing.Point(269, 3);
            this.datePickerRange4.Name = "datePickerRange4";
            this.datePickerRange4.PlaceholderEnd = "结束时间";
            this.datePickerRange4.PlaceholderStart = "开始时间";
            this.datePickerRange4.Size = new System.Drawing.Size(340, 32);
            this.datePickerRange4.TabIndex = 1;
            this.datePickerRange4.WaveSize = 0;
            // 
            // datePickerRange5
            // 
            this.datePickerRange5.InteractiveReset = false;
            this.datePickerRange5.Location = new System.Drawing.Point(3, 3);
            this.datePickerRange5.Name = "datePickerRange5";
            this.datePickerRange5.PlaceholderEnd = "结束日期";
            this.datePickerRange5.PlaceholderStart = "开始日期";
            this.datePickerRange5.Size = new System.Drawing.Size(260, 32);
            this.datePickerRange5.TabIndex = 0;
            this.datePickerRange5.WaveSize = 0;
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
            this.h4.Text = "交互不重置";
            // 
            // p3
            // 
            this.p3.Controls.Add(this.datePickerRange3);
            this.p3.Controls.Add(this.datePickerRange2);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            // 
            // datePickerRange3
            // 
            this.datePickerRange3.Format = "yyyy-MM-dd HH:mm";
            this.datePickerRange3.Location = new System.Drawing.Point(349, 3);
            this.datePickerRange3.Name = "datePickerRange3";
            this.datePickerRange3.PlaceholderEnd = "结束时间";
            this.datePickerRange3.PlaceholderStart = "开始时间";
            this.datePickerRange3.Size = new System.Drawing.Size(300, 32);
            this.datePickerRange3.TabIndex = 1;
            this.datePickerRange3.WaveSize = 0;
            // 
            // datePickerRange2
            // 
            this.datePickerRange2.Format = "yyyy-MM-dd HH:mm:ss";
            this.datePickerRange2.Location = new System.Drawing.Point(3, 3);
            this.datePickerRange2.Name = "datePickerRange2";
            this.datePickerRange2.PlaceholderEnd = "结束时间";
            this.datePickerRange2.PlaceholderStart = "开始时间";
            this.datePickerRange2.Size = new System.Drawing.Size(340, 32);
            this.datePickerRange2.TabIndex = 0;
            this.datePickerRange2.WaveSize = 0;
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
            this.h3.Text = "时间范围";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.datePickerRange);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // datePickerRange
            // 
            this.datePickerRange.Location = new System.Drawing.Point(3, 3);
            this.datePickerRange.Name = "datePickerRange";
            this.datePickerRange.Presets.AddRange(new object[] {
            "本周",
            "上周",
            "本月",
            "上月",
            "本年",
            "去年"});
            this.datePickerRange.Size = new System.Drawing.Size(260, 32);
            this.datePickerRange.TabIndex = 0;
            this.datePickerRange.WaveSize = 0;
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
            this.h2.Text = "预置菜单";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.datePickerRange1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // datePickerRange1
            // 
            this.datePickerRange1.Location = new System.Drawing.Point(3, 3);
            this.datePickerRange1.Name = "datePickerRange1";
            this.datePickerRange1.PlaceholderEnd = "结束日期";
            this.datePickerRange1.PlaceholderStart = "开始日期";
            this.datePickerRange1.Size = new System.Drawing.Size(260, 32);
            this.datePickerRange1.TabIndex = 0;
            this.datePickerRange1.WaveSize = 0;
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
            // DatePickerRangeDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "DatePickerRangeDemo";
            this.Size = new System.Drawing.Size(750, 426);
            this.panelMain.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.FlowPanel p2;
        private AntdUI.DatePickerRange datePickerRange;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel p1;
        private AntdUI.DatePickerRange datePickerRange1;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p3;
        private AntdUI.DatePickerRange datePickerRange3;
        private AntdUI.DatePickerRange datePickerRange2;
        private AntdUI.Label h3;
        private AntdUI.FlowPanel p4;
        private AntdUI.DatePickerRange datePickerRange4;
        private AntdUI.DatePickerRange datePickerRange5;
        private AntdUI.Label h4;
    }
}
