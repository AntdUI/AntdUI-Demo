namespace AntdUIDemo.Views
{
    partial class DropDownDemo
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
            this.label3 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel7 = new AntdUI.FlowPanel();
            this.dropdown_custom = new AntdUI.Dropdown();
            this.dropdown_enable = new AntdUI.Dropdown();
            this.dropdown_online = new AntdUI.Dropdown();
            this.label12 = new AntdUI.Label();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.dropdown_icon = new AntdUI.Dropdown();
            this.label11 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.dropdown_multi = new AntdUI.Dropdown();
            this.label10 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.dropdown4 = new AntdUI.Dropdown();
            this.dropdown5 = new AntdUI.Dropdown();
            this.dropdown6 = new AntdUI.Dropdown();
            this.label9 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.dropdown3 = new AntdUI.Dropdown();
            this.dropdown1 = new AntdUI.Dropdown();
            this.dropdown2 = new AntdUI.Dropdown();
            this.label6 = new AntdUI.Label();
            this.flowPanel6 = new AntdUI.FlowPanel();
            this.dropdown33 = new AntdUI.Dropdown();
            this.dropdown32 = new AntdUI.Dropdown();
            this.dropdown31 = new AntdUI.Dropdown();
            this.dropdown30 = new AntdUI.Dropdown();
            this.dropdown28 = new AntdUI.Dropdown();
            this.dropdown34 = new AntdUI.Dropdown();
            this.label8 = new AntdUI.Label();
            this.flowPanel5 = new AntdUI.FlowPanel();
            this.dropdown26 = new AntdUI.Dropdown();
            this.dropdown25 = new AntdUI.Dropdown();
            this.label7 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel7.SuspendLayout();
            this.flowPanel4.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel6.SuspendLayout();
            this.flowPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "向下弹出的列表。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Dropdown 下拉菜单";
            this.header1.UseTitleFont = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(750, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "当页面上的操作命令过多时，用此组件可以收纳操作元素。点击或移入触点，会出现一个下拉菜单。可在列表中进行选择，并执行相应的命令。";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label4.Location = new System.Drawing.Point(0, 113);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Size = new System.Drawing.Size(750, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "○ 用于收罗一组命令操作";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label5.Location = new System.Drawing.Point(0, 137);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 6);
            this.label5.Size = new System.Drawing.Size(750, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "○ Select 用于选择，而 Dropdown 是命令集合";
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoScroll = true;
            this.stackPanel1.Controls.Add(this.flowPanel7);
            this.stackPanel1.Controls.Add(this.label12);
            this.stackPanel1.Controls.Add(this.flowPanel4);
            this.stackPanel1.Controls.Add(this.label11);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.label10);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label9);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.flowPanel6);
            this.stackPanel1.Controls.Add(this.label8);
            this.stackPanel1.Controls.Add(this.flowPanel5);
            this.stackPanel1.Controls.Add(this.label7);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 167);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 563);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel7
            // 
            this.flowPanel7.Controls.Add(this.dropdown_custom);
            this.flowPanel7.Controls.Add(this.dropdown_enable);
            this.flowPanel7.Controls.Add(this.dropdown_online);
            this.flowPanel7.Location = new System.Drawing.Point(3, 477);
            this.flowPanel7.Name = "flowPanel7";
            this.flowPanel7.Size = new System.Drawing.Size(744, 38);
            this.flowPanel7.TabIndex = 45;
            this.flowPanel7.Text = "flowPanel7";
            // 
            // dropdown_custom
            // 
            this.dropdown_custom.BorderWidth = 2F;
            this.dropdown_custom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown_custom.Location = new System.Drawing.Point(185, 3);
            this.dropdown_custom.Name = "dropdown_custom";
            this.dropdown_custom.ShowArrow = true;
            this.dropdown_custom.Size = new System.Drawing.Size(85, 32);
            this.dropdown_custom.TabIndex = 6;
            this.dropdown_custom.Text = "自定义";
            this.dropdown_custom.Trigger = AntdUI.Trigger.Hover;
            this.dropdown_custom.WaveSize = 0;
            // 
            // dropdown_enable
            // 
            this.dropdown_enable.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown_enable.Location = new System.Drawing.Point(94, 3);
            this.dropdown_enable.Name = "dropdown_enable";
            this.dropdown_enable.ShowArrow = true;
            this.dropdown_enable.Size = new System.Drawing.Size(85, 32);
            this.dropdown_enable.TabIndex = 5;
            this.dropdown_enable.Text = "启用状态";
            this.dropdown_enable.Trigger = AntdUI.Trigger.Hover;
            this.dropdown_enable.Type = AntdUI.TTypeMini.Primary;
            this.dropdown_enable.WaveSize = 0;
            // 
            // dropdown_online
            // 
            this.dropdown_online.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown_online.Location = new System.Drawing.Point(3, 3);
            this.dropdown_online.Name = "dropdown_online";
            this.dropdown_online.ShowArrow = true;
            this.dropdown_online.Size = new System.Drawing.Size(85, 32);
            this.dropdown_online.TabIndex = 2;
            this.dropdown_online.Text = "在线状态";
            this.dropdown_online.Trigger = AntdUI.Trigger.Hover;
            this.dropdown_online.Type = AntdUI.TTypeMini.Primary;
            this.dropdown_online.WaveSize = 0;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(3, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(744, 24);
            this.label12.TabIndex = 44;
            this.label12.Text = "菜单状态";
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.dropdown_icon);
            this.flowPanel4.Location = new System.Drawing.Point(3, 403);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(744, 38);
            this.flowPanel4.TabIndex = 43;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // dropdown_icon
            // 
            this.dropdown_icon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown_icon.Location = new System.Drawing.Point(3, 3);
            this.dropdown_icon.Name = "dropdown_icon";
            this.dropdown_icon.ShowArrow = true;
            this.dropdown_icon.Size = new System.Drawing.Size(85, 32);
            this.dropdown_icon.TabIndex = 2;
            this.dropdown_icon.Text = "Icon";
            this.dropdown_icon.Trigger = AntdUI.Trigger.Hover;
            this.dropdown_icon.Type = AntdUI.TTypeMini.Primary;
            this.dropdown_icon.WaveSize = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(3, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(744, 24);
            this.label11.TabIndex = 42;
            this.label11.Text = "图标菜单";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.dropdown_multi);
            this.flowPanel3.Location = new System.Drawing.Point(3, 329);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(744, 38);
            this.flowPanel3.TabIndex = 41;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // dropdown_multi
            // 
            this.dropdown_multi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown_multi.Location = new System.Drawing.Point(3, 3);
            this.dropdown_multi.Name = "dropdown_multi";
            this.dropdown_multi.ShowArrow = true;
            this.dropdown_multi.Size = new System.Drawing.Size(85, 32);
            this.dropdown_multi.TabIndex = 2;
            this.dropdown_multi.Text = "Items";
            this.dropdown_multi.Trigger = AntdUI.Trigger.Hover;
            this.dropdown_multi.Type = AntdUI.TTypeMini.Primary;
            this.dropdown_multi.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(744, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "多级菜单";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.dropdown4);
            this.flowPanel2.Controls.Add(this.dropdown5);
            this.flowPanel2.Controls.Add(this.dropdown6);
            this.flowPanel2.Location = new System.Drawing.Point(3, 255);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 39;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // dropdown4
            // 
            this.dropdown4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown4.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown4.Location = new System.Drawing.Point(185, 3);
            this.dropdown4.MaxCount = 5;
            this.dropdown4.Name = "dropdown4";
            this.dropdown4.ShowArrow = true;
            this.dropdown4.Size = new System.Drawing.Size(85, 32);
            this.dropdown4.TabIndex = 4;
            this.dropdown4.Text = "5";
            this.dropdown4.Trigger = AntdUI.Trigger.Hover;
            this.dropdown4.Type = AntdUI.TTypeMini.Primary;
            this.dropdown4.WaveSize = 0;
            // 
            // dropdown5
            // 
            this.dropdown5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown5.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown5.Location = new System.Drawing.Point(94, 3);
            this.dropdown5.Name = "dropdown5";
            this.dropdown5.ShowArrow = true;
            this.dropdown5.Size = new System.Drawing.Size(85, 32);
            this.dropdown5.TabIndex = 3;
            this.dropdown5.Text = "4";
            this.dropdown5.Trigger = AntdUI.Trigger.Hover;
            this.dropdown5.Type = AntdUI.TTypeMini.Primary;
            this.dropdown5.WaveSize = 0;
            // 
            // dropdown6
            // 
            this.dropdown6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown6.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown6.Location = new System.Drawing.Point(3, 3);
            this.dropdown6.MaxCount = 3;
            this.dropdown6.Name = "dropdown6";
            this.dropdown6.ShowArrow = true;
            this.dropdown6.Size = new System.Drawing.Size(85, 32);
            this.dropdown6.TabIndex = 2;
            this.dropdown6.Text = "3";
            this.dropdown6.Trigger = AntdUI.Trigger.Hover;
            this.dropdown6.Type = AntdUI.TTypeMini.Primary;
            this.dropdown6.WaveSize = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(744, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "显示数量";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.dropdown3);
            this.flowPanel1.Controls.Add(this.dropdown1);
            this.flowPanel1.Controls.Add(this.dropdown2);
            this.flowPanel1.Location = new System.Drawing.Point(3, 181);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 37;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // dropdown3
            // 
            this.dropdown3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown3.IsLink = true;
            this.dropdown3.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown3.Location = new System.Drawing.Point(185, 3);
            this.dropdown3.Name = "dropdown3";
            this.dropdown3.ShowArrow = true;
            this.dropdown3.Size = new System.Drawing.Size(85, 32);
            this.dropdown3.TabIndex = 4;
            this.dropdown3.Text = "link Arrow";
            this.dropdown3.Trigger = AntdUI.Trigger.Hover;
            this.dropdown3.Type = AntdUI.TTypeMini.Primary;
            this.dropdown3.WaveSize = 0;
            // 
            // dropdown1
            // 
            this.dropdown1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown1.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown1.Location = new System.Drawing.Point(94, 3);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.ShowArrow = true;
            this.dropdown1.Size = new System.Drawing.Size(85, 32);
            this.dropdown1.TabIndex = 3;
            this.dropdown1.Text = "Arrow";
            this.dropdown1.Trigger = AntdUI.Trigger.Hover;
            this.dropdown1.Type = AntdUI.TTypeMini.Primary;
            this.dropdown1.WaveSize = 0;
            // 
            // dropdown2
            // 
            this.dropdown2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown2.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown2.Location = new System.Drawing.Point(3, 3);
            this.dropdown2.Name = "dropdown2";
            this.dropdown2.Size = new System.Drawing.Size(85, 32);
            this.dropdown2.TabIndex = 2;
            this.dropdown2.Text = "无";
            this.dropdown2.Trigger = AntdUI.Trigger.Hover;
            this.dropdown2.Type = AntdUI.TTypeMini.Primary;
            this.dropdown2.WaveSize = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(744, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "显示箭头";
            // 
            // flowPanel6
            // 
            this.flowPanel6.Controls.Add(this.dropdown33);
            this.flowPanel6.Controls.Add(this.dropdown32);
            this.flowPanel6.Controls.Add(this.dropdown31);
            this.flowPanel6.Controls.Add(this.dropdown30);
            this.flowPanel6.Controls.Add(this.dropdown28);
            this.flowPanel6.Controls.Add(this.dropdown34);
            this.flowPanel6.Location = new System.Drawing.Point(3, 107);
            this.flowPanel6.Name = "flowPanel6";
            this.flowPanel6.Size = new System.Drawing.Size(744, 38);
            this.flowPanel6.TabIndex = 35;
            this.flowPanel6.Text = "flowPanel6";
            // 
            // dropdown33
            // 
            this.dropdown33.BorderWidth = 2F;
            this.dropdown33.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown33.Ghost = true;
            this.dropdown33.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown33.Location = new System.Drawing.Point(458, 3);
            this.dropdown33.Name = "dropdown33";
            this.dropdown33.Placement = AntdUI.TAlignFrom.TR;
            this.dropdown33.Size = new System.Drawing.Size(85, 32);
            this.dropdown33.TabIndex = 7;
            this.dropdown33.Text = "TR";
            this.dropdown33.Trigger = AntdUI.Trigger.Hover;
            this.dropdown33.Type = AntdUI.TTypeMini.Primary;
            this.dropdown33.WaveSize = 0;
            // 
            // dropdown32
            // 
            this.dropdown32.BorderWidth = 2F;
            this.dropdown32.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown32.Ghost = true;
            this.dropdown32.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown32.Location = new System.Drawing.Point(367, 3);
            this.dropdown32.Name = "dropdown32";
            this.dropdown32.Placement = AntdUI.TAlignFrom.Top;
            this.dropdown32.Size = new System.Drawing.Size(85, 32);
            this.dropdown32.TabIndex = 6;
            this.dropdown32.Text = "Top";
            this.dropdown32.Trigger = AntdUI.Trigger.Hover;
            this.dropdown32.Type = AntdUI.TTypeMini.Primary;
            this.dropdown32.WaveSize = 0;
            // 
            // dropdown31
            // 
            this.dropdown31.BorderWidth = 2F;
            this.dropdown31.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown31.Ghost = true;
            this.dropdown31.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown31.Location = new System.Drawing.Point(276, 3);
            this.dropdown31.Name = "dropdown31";
            this.dropdown31.Placement = AntdUI.TAlignFrom.TL;
            this.dropdown31.Size = new System.Drawing.Size(85, 32);
            this.dropdown31.TabIndex = 5;
            this.dropdown31.Text = "TL";
            this.dropdown31.Trigger = AntdUI.Trigger.Hover;
            this.dropdown31.Type = AntdUI.TTypeMini.Primary;
            this.dropdown31.WaveSize = 0;
            // 
            // dropdown30
            // 
            this.dropdown30.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown30.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown30.Location = new System.Drawing.Point(185, 3);
            this.dropdown30.Name = "dropdown30";
            this.dropdown30.Placement = AntdUI.TAlignFrom.BR;
            this.dropdown30.Size = new System.Drawing.Size(85, 32);
            this.dropdown30.TabIndex = 4;
            this.dropdown30.Text = "BR";
            this.dropdown30.Trigger = AntdUI.Trigger.Hover;
            this.dropdown30.Type = AntdUI.TTypeMini.Primary;
            this.dropdown30.WaveSize = 0;
            // 
            // dropdown28
            // 
            this.dropdown28.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown28.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown28.Location = new System.Drawing.Point(94, 3);
            this.dropdown28.Name = "dropdown28";
            this.dropdown28.Placement = AntdUI.TAlignFrom.Bottom;
            this.dropdown28.Size = new System.Drawing.Size(85, 32);
            this.dropdown28.TabIndex = 3;
            this.dropdown28.Text = "Bottom";
            this.dropdown28.Trigger = AntdUI.Trigger.Hover;
            this.dropdown28.Type = AntdUI.TTypeMini.Primary;
            this.dropdown28.WaveSize = 0;
            // 
            // dropdown34
            // 
            this.dropdown34.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown34.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown34.Location = new System.Drawing.Point(3, 3);
            this.dropdown34.Name = "dropdown34";
            this.dropdown34.Size = new System.Drawing.Size(85, 32);
            this.dropdown34.TabIndex = 2;
            this.dropdown34.Text = "BL";
            this.dropdown34.Trigger = AntdUI.Trigger.Hover;
            this.dropdown34.Type = AntdUI.TTypeMini.Primary;
            this.dropdown34.WaveSize = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(744, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "弹出位置";
            // 
            // flowPanel5
            // 
            this.flowPanel5.Controls.Add(this.dropdown26);
            this.flowPanel5.Controls.Add(this.dropdown25);
            this.flowPanel5.Location = new System.Drawing.Point(3, 33);
            this.flowPanel5.Name = "flowPanel5";
            this.flowPanel5.Size = new System.Drawing.Size(744, 38);
            this.flowPanel5.TabIndex = 33;
            this.flowPanel5.Text = "flowPanel5";
            // 
            // dropdown26
            // 
            this.dropdown26.BorderWidth = 2F;
            this.dropdown26.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown26.Ghost = true;
            this.dropdown26.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown26.Location = new System.Drawing.Point(94, 3);
            this.dropdown26.Name = "dropdown26";
            this.dropdown26.Size = new System.Drawing.Size(85, 32);
            this.dropdown26.TabIndex = 3;
            this.dropdown26.Text = "Hover";
            this.dropdown26.Trigger = AntdUI.Trigger.Hover;
            this.dropdown26.Type = AntdUI.TTypeMini.Primary;
            this.dropdown26.WaveSize = 0;
            // 
            // dropdown25
            // 
            this.dropdown25.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dropdown25.Items.AddRange(new object[] {
            "first menu item",
            "second menu item",
            "third menu item",
            "fourth menu item",
            "fifth menu item"});
            this.dropdown25.Location = new System.Drawing.Point(3, 3);
            this.dropdown25.Name = "dropdown25";
            this.dropdown25.Size = new System.Drawing.Size(85, 32);
            this.dropdown25.TabIndex = 2;
            this.dropdown25.Text = "Click";
            this.dropdown25.Type = AntdUI.TTypeMini.Primary;
            this.dropdown25.WaveSize = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(744, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "触发类型";
            // 
            // DropDownDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.header1);
            this.Name = "DropDownDemo";
            this.Size = new System.Drawing.Size(750, 730);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel7.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel6.ResumeLayout(false);
            this.flowPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.FlowPanel flowPanel6;
        private AntdUI.Dropdown dropdown33;
        private AntdUI.Dropdown dropdown32;
        private AntdUI.Dropdown dropdown31;
        private AntdUI.Dropdown dropdown30;
        private AntdUI.Dropdown dropdown28;
        private AntdUI.Dropdown dropdown34;
        private AntdUI.Label label8;
        private AntdUI.FlowPanel flowPanel5;
        private AntdUI.Dropdown dropdown26;
        private AntdUI.Dropdown dropdown25;
        private AntdUI.Label label7;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Dropdown dropdown1;
        private AntdUI.Dropdown dropdown2;
        private AntdUI.Label label6;
        private AntdUI.Dropdown dropdown3;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Dropdown dropdown4;
        private AntdUI.Dropdown dropdown5;
        private AntdUI.Dropdown dropdown6;
        private AntdUI.Label label9;
        private AntdUI.Label label11;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Dropdown dropdown_multi;
        private AntdUI.Label label10;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Dropdown dropdown_icon;
        private AntdUI.FlowPanel flowPanel7;
        private AntdUI.Dropdown dropdown_online;
        private AntdUI.Label label12;
        private AntdUI.Dropdown dropdown_custom;
        private AntdUI.Dropdown dropdown_enable;
    }
}
