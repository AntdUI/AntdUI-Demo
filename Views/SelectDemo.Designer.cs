namespace AntdUIDemo.Views
{
    partial class SelectDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDemo));
            this.panelMain = new AntdUI.In.Panel();
            this.p5 = new AntdUI.FlowPanel();
            this.select_custom = new AntdUI.Select();
            this.h5 = new AntdUI.Label();
            this.p4 = new AntdUI.FlowPanel();
            this.select15 = new AntdUI.Select();
            this.select16 = new AntdUI.Select();
            this.h4 = new AntdUI.Label();
            this.p3 = new AntdUI.FlowPanel();
            this.select12 = new AntdUI.Select();
            this.select11 = new AntdUI.Select();
            this.select13 = new AntdUI.Select();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.select8 = new AntdUI.Select();
            this.select9 = new AntdUI.Select();
            this.select10 = new AntdUI.Select();
            this.select7 = new AntdUI.Select();
            this.select6 = new AntdUI.Select();
            this.select5 = new AntdUI.Select();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.select18 = new AntdUI.Select();
            this.select17 = new AntdUI.Select();
            this.select3 = new AntdUI.Select();
            this.select2 = new AntdUI.Select();
            this.select1 = new AntdUI.Select();
            this.select4 = new AntdUI.Select();
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
            this.panelMain.Size = new System.Drawing.Size(750, 479);
            this.panelMain.TabIndex = 0;
            // 
            // p5
            // 
            this.p5.Controls.Add(this.select_custom);
            this.p5.Dock = System.Windows.Forms.DockStyle.Top;
            this.p5.Gap = 6;
            this.p5.Location = new System.Drawing.Point(0, 272);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(750, 38);
            this.p5.TabIndex = 5;
            // 
            // select_custom
            // 
            this.select_custom.ListAutoWidth = true;
            this.select_custom.Location = new System.Drawing.Point(3, 3);
            this.select_custom.MaxCount = 6;
            this.select_custom.Name = "select_custom";
            this.select_custom.Placement = AntdUI.TAlignFrom.TL;
            this.select_custom.Size = new System.Drawing.Size(100, 32);
            this.select_custom.TabIndex = 1;
            this.select_custom.WaveSize = 0;
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
            this.h5.Text = "自定义样式";
            // 
            // p4
            // 
            this.p4.Controls.Add(this.select15);
            this.p4.Controls.Add(this.select16);
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Gap = 6;
            this.p4.Location = new System.Drawing.Point(0, 210);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(750, 38);
            this.p4.TabIndex = 4;
            // 
            // select15
            // 
            this.select15.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "图标",
            "Tom",
            "Jerry"});
            this.select15.Location = new System.Drawing.Point(115, 3);
            this.select15.Name = "select15";
            this.select15.PlaceholderText = "图标";
            this.select15.PrefixSvg = resources.GetString("select15.PrefixSvg");
            this.select15.Size = new System.Drawing.Size(100, 32);
            this.select15.SuffixSvg = resources.GetString("select15.SuffixSvg");
            this.select15.TabIndex = 2;
            this.select15.WaveSize = 0;
            // 
            // select16
            // 
            this.select16.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "文本",
            "Tom",
            "Jerry"});
            this.select16.Location = new System.Drawing.Point(3, 3);
            this.select16.Name = "select16";
            this.select16.PlaceholderText = "文本";
            this.select16.PrefixText = "+";
            this.select16.Size = new System.Drawing.Size(100, 32);
            this.select16.SuffixText = "$";
            this.select16.TabIndex = 1;
            this.select16.WaveSize = 0;
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
            this.h4.Text = "前/后标签";
            // 
            // p3
            // 
            this.p3.Controls.Add(this.select12);
            this.p3.Controls.Add(this.select11);
            this.p3.Controls.Add(this.select13);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Gap = 6;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            // 
            // select12
            // 
            this.select12.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "5",
            "Tom",
            "Jerry"});
            this.select12.Location = new System.Drawing.Point(227, 3);
            this.select12.MaxCount = 5;
            this.select12.Name = "select12";
            this.select12.PlaceholderText = "5";
            this.select12.Size = new System.Drawing.Size(100, 32);
            this.select12.TabIndex = 3;
            this.select12.WaveSize = 0;
            // 
            // select11
            // 
            this.select11.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "4",
            "Tom",
            "Jerry"});
            this.select11.Location = new System.Drawing.Point(115, 3);
            this.select11.Name = "select11";
            this.select11.PlaceholderText = "4";
            this.select11.Size = new System.Drawing.Size(100, 32);
            this.select11.TabIndex = 2;
            this.select11.WaveSize = 0;
            // 
            // select13
            // 
            this.select13.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "3",
            "Tom",
            "Jerry"});
            this.select13.Location = new System.Drawing.Point(3, 3);
            this.select13.MaxCount = 3;
            this.select13.Name = "select13";
            this.select13.PlaceholderText = "3";
            this.select13.Size = new System.Drawing.Size(100, 32);
            this.select13.TabIndex = 1;
            this.select13.WaveSize = 0;
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
            this.h3.Text = "显示数量";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.select8);
            this.p2.Controls.Add(this.select9);
            this.p2.Controls.Add(this.select10);
            this.p2.Controls.Add(this.select7);
            this.p2.Controls.Add(this.select6);
            this.p2.Controls.Add(this.select5);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Gap = 6;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // select8
            // 
            this.select8.Items.AddRange(new object[] {
            "Jack Jack Jack Jack Jack",
            "Lucy",
            "TL",
            "Tom",
            "Jerry"});
            this.select8.ListAutoWidth = true;
            this.select8.Location = new System.Drawing.Point(563, 3);
            this.select8.Name = "select8";
            this.select8.PlaceholderText = "TL";
            this.select8.Placement = AntdUI.TAlignFrom.TL;
            this.select8.Size = new System.Drawing.Size(100, 32);
            this.select8.TabIndex = 6;
            this.select8.WaveSize = 0;
            // 
            // select9
            // 
            this.select9.Items.AddRange(new object[] {
            "Jack Jack Jack Jack Jack",
            "Lucy",
            "Top",
            "Tom",
            "Jerry"});
            this.select9.ListAutoWidth = true;
            this.select9.Location = new System.Drawing.Point(451, 3);
            this.select9.Name = "select9";
            this.select9.PlaceholderText = "Top";
            this.select9.Placement = AntdUI.TAlignFrom.Top;
            this.select9.Size = new System.Drawing.Size(100, 32);
            this.select9.TabIndex = 5;
            this.select9.WaveSize = 0;
            // 
            // select10
            // 
            this.select10.Items.AddRange(new object[] {
            "Jack Jack Jack Jack Jack",
            "Lucy",
            "TR",
            "Tom",
            "Jerry"});
            this.select10.ListAutoWidth = true;
            this.select10.Location = new System.Drawing.Point(339, 3);
            this.select10.Name = "select10";
            this.select10.PlaceholderText = "TR";
            this.select10.Placement = AntdUI.TAlignFrom.TR;
            this.select10.Size = new System.Drawing.Size(100, 32);
            this.select10.TabIndex = 4;
            this.select10.WaveSize = 0;
            // 
            // select7
            // 
            this.select7.Items.AddRange(new object[] {
            "Jack Jack Jack Jack Jack",
            "Lucy",
            "BR",
            "Tom",
            "Jerry"});
            this.select7.ListAutoWidth = true;
            this.select7.Location = new System.Drawing.Point(227, 3);
            this.select7.Name = "select7";
            this.select7.PlaceholderText = "BR";
            this.select7.Placement = AntdUI.TAlignFrom.BR;
            this.select7.Size = new System.Drawing.Size(100, 32);
            this.select7.TabIndex = 3;
            this.select7.WaveSize = 0;
            // 
            // select6
            // 
            this.select6.Items.AddRange(new object[] {
            "Jack Jack Jack Jack Jack",
            "Lucy",
            "Bottom",
            "Tom",
            "Jerry"});
            this.select6.ListAutoWidth = true;
            this.select6.Location = new System.Drawing.Point(115, 3);
            this.select6.Name = "select6";
            this.select6.PlaceholderText = "Bottom";
            this.select6.Placement = AntdUI.TAlignFrom.Bottom;
            this.select6.Size = new System.Drawing.Size(100, 32);
            this.select6.TabIndex = 2;
            this.select6.WaveSize = 0;
            // 
            // select5
            // 
            this.select5.Items.AddRange(new object[] {
            "Jack Jack Jack Jack Jack",
            "Lucy",
            "BL",
            "Tom",
            "Jerry"});
            this.select5.ListAutoWidth = true;
            this.select5.Location = new System.Drawing.Point(3, 3);
            this.select5.Name = "select5";
            this.select5.PlaceholderText = "BL";
            this.select5.Size = new System.Drawing.Size(100, 32);
            this.select5.TabIndex = 1;
            this.select5.WaveSize = 0;
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
            this.h2.Text = "弹出位置";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.select18);
            this.p1.Controls.Add(this.select17);
            this.p1.Controls.Add(this.select3);
            this.p1.Controls.Add(this.select2);
            this.p1.Controls.Add(this.select1);
            this.p1.Controls.Add(this.select4);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Gap = 6;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // select18
            // 
            this.select18.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "不显示箭头",
            "Tom",
            "Jerry"});
            this.select18.Location = new System.Drawing.Point(563, 3);
            this.select18.Name = "select18";
            this.select18.PlaceholderText = "不显示箭头";
            this.select18.ShowIcon = false;
            this.select18.Size = new System.Drawing.Size(100, 32);
            this.select18.TabIndex = 6;
            this.select18.WaveSize = 0;
            // 
            // select17
            // 
            this.select17.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "超容器显示全部文字可设置自动宽度",
            "Tom",
            "Jerry"});
            this.select17.ListAutoWidth = true;
            this.select17.Location = new System.Drawing.Point(451, 3);
            this.select17.Name = "select17";
            this.select17.PlaceholderText = "超容器文字";
            this.select17.Size = new System.Drawing.Size(100, 32);
            this.select17.TabIndex = 5;
            this.select17.WaveSize = 0;
            // 
            // select3
            // 
            this.select3.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "圆形样式",
            "Tom",
            "Jerry"});
            this.select3.Location = new System.Drawing.Point(339, 3);
            this.select3.Name = "select3";
            this.select3.PlaceholderText = "圆形样式";
            this.select3.Round = true;
            this.select3.Size = new System.Drawing.Size(100, 32);
            this.select3.TabIndex = 4;
            this.select3.WaveSize = 0;
            // 
            // select2
            // 
            this.select2.AllowClear = true;
            this.select2.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "支持清除",
            "Tom",
            "Jerry"});
            this.select2.Location = new System.Drawing.Point(227, 3);
            this.select2.Name = "select2";
            this.select2.PlaceholderText = "支持清除";
            this.select2.Size = new System.Drawing.Size(100, 32);
            this.select2.TabIndex = 3;
            this.select2.WaveSize = 0;
            // 
            // select1
            // 
            this.select1.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "默认支持输入匹配",
            "Tom",
            "Jerry"});
            this.select1.Location = new System.Drawing.Point(115, 3);
            this.select1.Name = "select1";
            this.select1.PlaceholderText = "默认支持输入匹配";
            this.select1.Size = new System.Drawing.Size(100, 32);
            this.select1.TabIndex = 2;
            this.select1.WaveSize = 0;
            // 
            // select4
            // 
            this.select4.Items.AddRange(new object[] {
            "Jack",
            "Lucy",
            "列表模式",
            "Tom",
            "Jerry"});
            this.select4.List = true;
            this.select4.Location = new System.Drawing.Point(3, 3);
            this.select4.Name = "select4";
            this.select4.PlaceholderText = "列表样式";
            this.select4.Size = new System.Drawing.Size(100, 32);
            this.select4.TabIndex = 1;
            this.select4.WaveSize = 0;
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
            this.header1.Description = "下拉选择器。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Select 选择器";
            this.header1.UseTitleFont = true;
            // 
            // SelectDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "SelectDemo";
            this.Size = new System.Drawing.Size(750, 553);
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
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Select select4;
        private AntdUI.Select select3;
        private AntdUI.Select select2;
        private AntdUI.Select select1;
        private AntdUI.FlowPanel p2;
        private AntdUI.Label h2;
        private AntdUI.Select select5;
        private AntdUI.Select select7;
        private AntdUI.Select select6;
        private AntdUI.FlowPanel p3;
        private AntdUI.Select select12;
        private AntdUI.Select select11;
        private AntdUI.Select select13;
        private AntdUI.Label h3;
        private AntdUI.Select select8;
        private AntdUI.Select select9;
        private AntdUI.Select select10;
        private AntdUI.Label h4;
        private AntdUI.FlowPanel p4;
        private AntdUI.Select select16;
        private AntdUI.Select select15;
        private AntdUI.Select select17;
        private AntdUI.Label h5;
        private AntdUI.FlowPanel p5;
        private AntdUI.Select select_custom;
        private AntdUI.Select select18;
        private AntdUI.PageHeader header1;
    }
}
