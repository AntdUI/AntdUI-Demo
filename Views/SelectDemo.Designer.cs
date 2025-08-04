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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel6 = new AntdUI.FlowPanel();
            this.select_custom = new AntdUI.Select();
            this.label8 = new AntdUI.Label();
            this.flowPanel5 = new AntdUI.FlowPanel();
            this.select15 = new AntdUI.Select();
            this.select16 = new AntdUI.Select();
            this.label7 = new AntdUI.Label();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.select12 = new AntdUI.Select();
            this.select11 = new AntdUI.Select();
            this.select13 = new AntdUI.Select();
            this.label6 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.select8 = new AntdUI.Select();
            this.select9 = new AntdUI.Select();
            this.select10 = new AntdUI.Select();
            this.select7 = new AntdUI.Select();
            this.select6 = new AntdUI.Select();
            this.select5 = new AntdUI.Select();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.select18 = new AntdUI.Select();
            this.select17 = new AntdUI.Select();
            this.select3 = new AntdUI.Select();
            this.select2 = new AntdUI.Select();
            this.select1 = new AntdUI.Select();
            this.select4 = new AntdUI.Select();
            this.label3 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.flowPanel6.SuspendLayout();
            this.flowPanel5.SuspendLayout();
            this.flowPanel4.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel6);
            this.stackPanel1.Controls.Add(this.label8);
            this.stackPanel1.Controls.Add(this.flowPanel5);
            this.stackPanel1.Controls.Add(this.label7);
            this.stackPanel1.Controls.Add(this.flowPanel4);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 479);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel6
            // 
            this.flowPanel6.Controls.Add(this.select_custom);
            this.flowPanel6.Gap = 6;
            this.flowPanel6.Location = new System.Drawing.Point(3, 329);
            this.flowPanel6.Name = "flowPanel6";
            this.flowPanel6.Size = new System.Drawing.Size(744, 38);
            this.flowPanel6.TabIndex = 28;
            this.flowPanel6.Text = "flowPanel6";
            // 
            // select_custom
            // 
            this.select_custom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.select_custom.ListAutoWidth = true;
            this.select_custom.Location = new System.Drawing.Point(3, 3);
            this.select_custom.MaxCount = 6;
            this.select_custom.Name = "select_custom";
            this.select_custom.PlaceholderText = "";
            this.select_custom.Placement = AntdUI.TAlignFrom.TL;
            this.select_custom.Size = new System.Drawing.Size(100, 32);
            this.select_custom.TabIndex = 3;
            this.select_custom.WaveSize = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(744, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "自定义样式";
            // 
            // flowPanel5
            // 
            this.flowPanel5.Controls.Add(this.select15);
            this.flowPanel5.Controls.Add(this.select16);
            this.flowPanel5.Gap = 6;
            this.flowPanel5.Location = new System.Drawing.Point(3, 255);
            this.flowPanel5.Name = "flowPanel5";
            this.flowPanel5.Size = new System.Drawing.Size(744, 38);
            this.flowPanel5.TabIndex = 26;
            this.flowPanel5.Text = "flowPanel5";
            // 
            // select15
            // 
            this.select15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select15.TabIndex = 5;
            this.select15.WaveSize = 0;
            // 
            // select16
            // 
            this.select16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select16.TabIndex = 4;
            this.select16.WaveSize = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(744, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "前/后标签";
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.select12);
            this.flowPanel4.Controls.Add(this.select11);
            this.flowPanel4.Controls.Add(this.select13);
            this.flowPanel4.Gap = 6;
            this.flowPanel4.Location = new System.Drawing.Point(3, 181);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(744, 38);
            this.flowPanel4.TabIndex = 24;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // select12
            // 
            this.select12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select12.TabIndex = 6;
            this.select12.WaveSize = 0;
            // 
            // select11
            // 
            this.select11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select11.TabIndex = 5;
            this.select11.WaveSize = 0;
            // 
            // select13
            // 
            this.select13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select13.TabIndex = 4;
            this.select13.WaveSize = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(744, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "显示数量";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.select8);
            this.flowPanel2.Controls.Add(this.select9);
            this.flowPanel2.Controls.Add(this.select10);
            this.flowPanel2.Controls.Add(this.select7);
            this.flowPanel2.Controls.Add(this.select6);
            this.flowPanel2.Controls.Add(this.select5);
            this.flowPanel2.Gap = 6;
            this.flowPanel2.Location = new System.Drawing.Point(3, 107);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 15;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // select8
            // 
            this.select8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select8.TabIndex = 12;
            this.select8.WaveSize = 0;
            // 
            // select9
            // 
            this.select9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select9.TabIndex = 11;
            this.select9.WaveSize = 0;
            // 
            // select10
            // 
            this.select10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select10.TabIndex = 10;
            this.select10.WaveSize = 0;
            // 
            // select7
            // 
            this.select7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select7.TabIndex = 6;
            this.select7.WaveSize = 0;
            // 
            // select6
            // 
            this.select6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select6.TabIndex = 5;
            this.select6.WaveSize = 0;
            // 
            // select5
            // 
            this.select5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select5.TabIndex = 4;
            this.select5.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "弹出位置";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.select18);
            this.flowPanel1.Controls.Add(this.select17);
            this.flowPanel1.Controls.Add(this.select3);
            this.flowPanel1.Controls.Add(this.select2);
            this.flowPanel1.Controls.Add(this.select1);
            this.flowPanel1.Controls.Add(this.select4);
            this.flowPanel1.Gap = 6;
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 13;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // select18
            // 
            this.select18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select18.TabIndex = 8;
            this.select18.WaveSize = 0;
            // 
            // select17
            // 
            this.select17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select17.TabIndex = 7;
            this.select17.WaveSize = 0;
            // 
            // select3
            // 
            this.select3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select3.TabIndex = 6;
            this.select3.WaveSize = 0;
            // 
            // select2
            // 
            this.select2.AllowClear = true;
            this.select2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select2.TabIndex = 5;
            this.select2.WaveSize = 0;
            // 
            // select1
            // 
            this.select1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select1.TabIndex = 4;
            this.select1.WaveSize = 0;
            // 
            // select4
            // 
            this.select4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.select4.TabIndex = 3;
            this.select4.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "基本用法";
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
            this.header1.TabIndex = 27;
            this.header1.Text = "Select 选择器";
            this.header1.UseTitleFont = true;
            // 
            // SelectDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "SelectDemo";
            this.Size = new System.Drawing.Size(750, 553);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel6.ResumeLayout(false);
            this.flowPanel5.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Select select4;
        private AntdUI.Select select3;
        private AntdUI.Select select2;
        private AntdUI.Select select1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Label label4;
        private AntdUI.Select select5;
        private AntdUI.Select select7;
        private AntdUI.Select select6;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Select select12;
        private AntdUI.Select select11;
        private AntdUI.Select select13;
        private AntdUI.Label label6;
        private AntdUI.Select select8;
        private AntdUI.Select select9;
        private AntdUI.Select select10;
        private AntdUI.Label label7;
        private AntdUI.FlowPanel flowPanel5;
        private AntdUI.Select select16;
        private AntdUI.Select select15;
        private AntdUI.Select select17;
        private AntdUI.Label label8;
        private AntdUI.FlowPanel flowPanel6;
        private AntdUI.Select select_custom;
        private AntdUI.Select select18;
        private AntdUI.PageHeader header1;
    }
}
