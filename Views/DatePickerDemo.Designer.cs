namespace AntdUIDemo.Views
{
    partial class DatePickerDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatePickerDemo));
            this.header1 = new AntdUI.PageHeader();
            this.panelMain = new AntdUI.In.Panel();
            this.p6 = new AntdUI.FlowPanel();
            this.datePicker14 = new AntdUI.DatePicker();
            this.datePicker15 = new AntdUI.DatePicker();
            this.h6 = new AntdUI.Label();
            this.p5 = new AntdUI.FlowPanel();
            this.datePicker_badge = new AntdUI.DatePicker();
            this.h5 = new AntdUI.Label();
            this.p4 = new AntdUI.FlowPanel();
            this.datePicker8 = new AntdUI.DatePicker();
            this.datePicker9 = new AntdUI.DatePicker();
            this.datePicker12 = new AntdUI.DatePicker();
            this.h4 = new AntdUI.Label();
            this.p3 = new AntdUI.FlowPanel();
            this.datePicker_maxdate = new AntdUI.DatePicker();
            this.datePicker_mindate = new AntdUI.DatePicker();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.datePicker6 = new AntdUI.DatePicker();
            this.datePicker5 = new AntdUI.DatePicker();
            this.datePicker4 = new AntdUI.DatePicker();
            this.datePicker3 = new AntdUI.DatePicker();
            this.datePicker2 = new AntdUI.DatePicker();
            this.datePicker1 = new AntdUI.DatePicker();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.datePicker10 = new AntdUI.DatePicker();
            this.datePicker7 = new AntdUI.DatePicker();
            this.datePicker11 = new AntdUI.DatePicker();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p6.SuspendLayout();
            this.p5.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "输入或选择日期的控件。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "DatePicker 日期选择器";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p6);
            this.panelMain.Controls.Add(this.h6);
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
            this.panelMain.Size = new System.Drawing.Size(750, 439);
            this.panelMain.TabIndex = 0;
            // 
            // p6
            // 
            this.p6.Controls.Add(this.datePicker14);
            this.p6.Controls.Add(this.datePicker15);
            this.p6.Dock = System.Windows.Forms.DockStyle.Top;
            this.p6.Location = new System.Drawing.Point(0, 334);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(750, 38);
            this.p6.TabIndex = 6;
            // 
            // datePicker14
            // 
            this.datePicker14.Format = "yyyy";
            this.datePicker14.Location = new System.Drawing.Point(129, 3);
            this.datePicker14.Name = "datePicker14";
            this.datePicker14.Picker = AntdUI.TDatePicker.Year;
            this.datePicker14.PlaceholderText = "yyyy";
            this.datePicker14.Size = new System.Drawing.Size(80, 32);
            this.datePicker14.TabIndex = 1;
            this.datePicker14.WaveSize = 0;
            // 
            // datePicker15
            // 
            this.datePicker15.Format = "yyyy-MM";
            this.datePicker15.Location = new System.Drawing.Point(3, 3);
            this.datePicker15.Name = "datePicker15";
            this.datePicker15.Picker = AntdUI.TDatePicker.Month;
            this.datePicker15.PlaceholderText = "yyyy-MM";
            this.datePicker15.Size = new System.Drawing.Size(120, 32);
            this.datePicker15.TabIndex = 0;
            this.datePicker15.WaveSize = 0;
            // 
            // h6
            // 
            this.h6.Dock = System.Windows.Forms.DockStyle.Top;
            this.h6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h6.Location = new System.Drawing.Point(0, 310);
            this.h6.Name = "h6";
            this.h6.PrefixColour = AntdUI.Colour.Primary;
            this.h6.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h6.Size = new System.Drawing.Size(750, 24);
            this.h6.TabIndex = 0;
            this.h6.Text = "选择年月";
            // 
            // p5
            // 
            this.p5.Controls.Add(this.datePicker_badge);
            this.p5.Dock = System.Windows.Forms.DockStyle.Top;
            this.p5.Location = new System.Drawing.Point(0, 272);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(750, 38);
            this.p5.TabIndex = 5;
            // 
            // datePicker_badge
            // 
            this.datePicker_badge.Location = new System.Drawing.Point(3, 3);
            this.datePicker_badge.Name = "datePicker_badge";
            this.datePicker_badge.Placement = AntdUI.TAlignFrom.TL;
            this.datePicker_badge.Size = new System.Drawing.Size(107, 32);
            this.datePicker_badge.TabIndex = 0;
            this.datePicker_badge.WaveSize = 0;
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
            this.h5.Text = "日期徽标";
            // 
            // p4
            // 
            this.p4.Controls.Add(this.datePicker8);
            this.p4.Controls.Add(this.datePicker9);
            this.p4.Controls.Add(this.datePicker12);
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Location = new System.Drawing.Point(0, 210);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(750, 38);
            this.p4.TabIndex = 4;
            // 
            // datePicker8
            // 
            this.datePicker8.Location = new System.Drawing.Point(229, 3);
            this.datePicker8.Name = "datePicker8";
            this.datePicker8.PlaceholderText = "图标在左";
            this.datePicker8.PrefixSvg = resources.GetString("datePicker8.PrefixSvg");
            this.datePicker8.ShowIcon = false;
            this.datePicker8.Size = new System.Drawing.Size(107, 32);
            this.datePicker8.TabIndex = 3;
            this.datePicker8.WaveSize = 0;
            // 
            // datePicker9
            // 
            this.datePicker9.Location = new System.Drawing.Point(116, 3);
            this.datePicker9.Name = "datePicker9";
            this.datePicker9.PlaceholderText = "图标在右";
            this.datePicker9.Size = new System.Drawing.Size(107, 32);
            this.datePicker9.SuffixSvg = resources.GetString("datePicker9.SuffixSvg");
            this.datePicker9.TabIndex = 2;
            this.datePicker9.WaveSize = 0;
            // 
            // datePicker12
            // 
            this.datePicker12.Location = new System.Drawing.Point(3, 3);
            this.datePicker12.Name = "datePicker12";
            this.datePicker12.PlaceholderText = "无图标";
            this.datePicker12.ShowIcon = false;
            this.datePicker12.Size = new System.Drawing.Size(107, 32);
            this.datePicker12.TabIndex = 0;
            this.datePicker12.WaveSize = 0;
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
            this.h4.Text = "标签显示";
            // 
            // p3
            // 
            this.p3.Controls.Add(this.datePicker_maxdate);
            this.p3.Controls.Add(this.datePicker_mindate);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            // 
            // datePicker_maxdate
            // 
            this.datePicker_maxdate.Location = new System.Drawing.Point(116, 3);
            this.datePicker_maxdate.Name = "datePicker_maxdate";
            this.datePicker_maxdate.PlaceholderText = "最大日期";
            this.datePicker_maxdate.Size = new System.Drawing.Size(107, 32);
            this.datePicker_maxdate.TabIndex = 1;
            this.datePicker_maxdate.WaveSize = 0;
            // 
            // datePicker_mindate
            // 
            this.datePicker_mindate.Location = new System.Drawing.Point(3, 3);
            this.datePicker_mindate.Name = "datePicker_mindate";
            this.datePicker_mindate.PlaceholderText = "最小日期";
            this.datePicker_mindate.Size = new System.Drawing.Size(107, 32);
            this.datePicker_mindate.TabIndex = 0;
            this.datePicker_mindate.WaveSize = 0;
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
            this.h3.Text = "日期范围";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.datePicker6);
            this.p2.Controls.Add(this.datePicker5);
            this.p2.Controls.Add(this.datePicker4);
            this.p2.Controls.Add(this.datePicker3);
            this.p2.Controls.Add(this.datePicker2);
            this.p2.Controls.Add(this.datePicker1);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // datePicker6
            // 
            this.datePicker6.Location = new System.Drawing.Point(568, 3);
            this.datePicker6.Name = "datePicker6";
            this.datePicker6.PlaceholderText = "TR";
            this.datePicker6.Placement = AntdUI.TAlignFrom.TR;
            this.datePicker6.Size = new System.Drawing.Size(107, 32);
            this.datePicker6.TabIndex = 5;
            this.datePicker6.WaveSize = 0;
            // 
            // datePicker5
            // 
            this.datePicker5.Location = new System.Drawing.Point(455, 3);
            this.datePicker5.Name = "datePicker5";
            this.datePicker5.PlaceholderText = "Top";
            this.datePicker5.Placement = AntdUI.TAlignFrom.Top;
            this.datePicker5.Size = new System.Drawing.Size(107, 32);
            this.datePicker5.TabIndex = 4;
            this.datePicker5.WaveSize = 0;
            // 
            // datePicker4
            // 
            this.datePicker4.Location = new System.Drawing.Point(342, 3);
            this.datePicker4.Name = "datePicker4";
            this.datePicker4.PlaceholderText = "TL";
            this.datePicker4.Placement = AntdUI.TAlignFrom.TL;
            this.datePicker4.Size = new System.Drawing.Size(107, 32);
            this.datePicker4.TabIndex = 3;
            this.datePicker4.WaveSize = 0;
            // 
            // datePicker3
            // 
            this.datePicker3.Location = new System.Drawing.Point(229, 3);
            this.datePicker3.Name = "datePicker3";
            this.datePicker3.PlaceholderText = "BR";
            this.datePicker3.Placement = AntdUI.TAlignFrom.BR;
            this.datePicker3.Size = new System.Drawing.Size(107, 32);
            this.datePicker3.TabIndex = 2;
            this.datePicker3.WaveSize = 0;
            // 
            // datePicker2
            // 
            this.datePicker2.Location = new System.Drawing.Point(116, 3);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.PlaceholderText = "Bottom";
            this.datePicker2.Placement = AntdUI.TAlignFrom.Bottom;
            this.datePicker2.Size = new System.Drawing.Size(107, 32);
            this.datePicker2.TabIndex = 1;
            this.datePicker2.WaveSize = 0;
            // 
            // datePicker1
            // 
            this.datePicker1.Location = new System.Drawing.Point(3, 3);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.PlaceholderText = "BL";
            this.datePicker1.Size = new System.Drawing.Size(107, 32);
            this.datePicker1.TabIndex = 0;
            this.datePicker1.WaveSize = 0;
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
            this.h2.Text = "显示位置";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.datePicker10);
            this.p1.Controls.Add(this.datePicker7);
            this.p1.Controls.Add(this.datePicker11);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // datePicker10
            // 
            this.datePicker10.Format = "yyyy-MM-dd HH:mm:ss";
            this.datePicker10.Location = new System.Drawing.Point(255, 3);
            this.datePicker10.Name = "datePicker10";
            this.datePicker10.PlaceholderText = "yyyy-MM-dd HH:mm:ss";
            this.datePicker10.Size = new System.Drawing.Size(220, 32);
            this.datePicker10.TabIndex = 2;
            this.datePicker10.WaveSize = 0;
            // 
            // datePicker7
            // 
            this.datePicker7.Format = "yyyy/MM/dd";
            this.datePicker7.Location = new System.Drawing.Point(129, 3);
            this.datePicker7.Name = "datePicker7";
            this.datePicker7.PlaceholderText = "yyyy/MM/dd";
            this.datePicker7.Size = new System.Drawing.Size(120, 32);
            this.datePicker7.TabIndex = 1;
            this.datePicker7.WaveSize = 0;
            // 
            // datePicker11
            // 
            this.datePicker11.Location = new System.Drawing.Point(3, 3);
            this.datePicker11.Name = "datePicker11";
            this.datePicker11.PlaceholderText = "yyyy-MM-dd";
            this.datePicker11.Size = new System.Drawing.Size(120, 32);
            this.datePicker11.TabIndex = 0;
            this.datePicker11.WaveSize = 0;
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
            this.h1.Text = "日期格式化";
            // 
            // DatePickerDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "DatePickerDemo";
            this.Size = new System.Drawing.Size(750, 513);
            this.panelMain.ResumeLayout(false);
            this.p6.ResumeLayout(false);
            this.p5.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.FlowPanel p1;
        private AntdUI.DatePicker datePicker7;
        private AntdUI.DatePicker datePicker11;
        private AntdUI.Label h1;
        private AntdUI.DatePicker datePicker10;
        private AntdUI.FlowPanel p2;
        private AntdUI.DatePicker datePicker6;
        private AntdUI.DatePicker datePicker5;
        private AntdUI.DatePicker datePicker4;
        private AntdUI.DatePicker datePicker3;
        private AntdUI.DatePicker datePicker2;
        private AntdUI.DatePicker datePicker1;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel p3;
        private AntdUI.DatePicker datePicker_mindate;
        private AntdUI.Label h3;
        private AntdUI.FlowPanel p4;
        private AntdUI.DatePicker datePicker8;
        private AntdUI.DatePicker datePicker9;
        private AntdUI.DatePicker datePicker12;
        private AntdUI.Label h4;
        private AntdUI.FlowPanel p5;
        private AntdUI.DatePicker datePicker_badge;
        private AntdUI.Label h5;
        private AntdUI.DatePicker datePicker_maxdate;
        private AntdUI.FlowPanel p6;
        private AntdUI.DatePicker datePicker14;
        private AntdUI.DatePicker datePicker15;
        private AntdUI.Label h6;
    }
}
