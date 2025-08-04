namespace AntdUIDemo.Views
{
    partial class FloatButtonDemo
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
            this.buttonCZ = new AntdUI.Button();
            this.buttonClose = new AntdUI.Button();
            this.buttonOpen = new AntdUI.Button();
            this.stackPanel8 = new AntdUI.StackPanel();
            this.switch_enabled = new AntdUI.Switch();
            this.label18 = new AntdUI.Label();
            this.colorPicker = new AntdUI.ColorPicker();
            this.label16 = new AntdUI.Label();
            this.stackPanel6 = new AntdUI.StackPanel();
            this.switch_loading = new AntdUI.Switch();
            this.label2 = new AntdUI.Label();
            this.input_badgesize = new AntdUI.InputNumber();
            this.label15 = new AntdUI.Label();
            this.input_badge = new AntdUI.Input();
            this.label17 = new AntdUI.Label();
            this.stackPanel5 = new AntdUI.StackPanel();
            this.switch_round = new AntdUI.Switch();
            this.label14 = new AntdUI.Label();
            this.select_type = new AntdUI.Select();
            this.label13 = new AntdUI.Label();
            this.input_radius = new AntdUI.InputNumber();
            this.label12 = new AntdUI.Label();
            this.label11 = new AntdUI.Label();
            this.stackPanel7 = new AntdUI.StackPanel();
            this.input_gap = new AntdUI.InputNumber();
            this.label20 = new AntdUI.Label();
            this.stackPanel4 = new AntdUI.StackPanel();
            this.switch_topmost = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.input_my = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.input_size = new AntdUI.InputNumber();
            this.label9 = new AntdUI.Label();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.switch_vertical = new AntdUI.Switch();
            this.label5 = new AntdUI.Label();
            this.input_mx = new AntdUI.InputNumber();
            this.label7 = new AntdUI.Label();
            this.select_align = new AntdUI.Select();
            this.label10 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.stackPanel8.SuspendLayout();
            this.stackPanel6.SuspendLayout();
            this.stackPanel5.SuspendLayout();
            this.stackPanel7.SuspendLayout();
            this.stackPanel4.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "悬浮于页面上方的按钮。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.LocalizationDescription = "FloatButton.Description";
            this.header1.LocalizationText = "FloatButton.Text";
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "FloatButton 悬浮按钮";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Controls.Add(this.stackPanel8);
            this.stackPanel1.Controls.Add(this.stackPanel6);
            this.stackPanel1.Controls.Add(this.stackPanel5);
            this.stackPanel1.Controls.Add(this.label11);
            this.stackPanel1.Controls.Add(this.stackPanel7);
            this.stackPanel1.Controls.Add(this.stackPanel4);
            this.stackPanel1.Controls.Add(this.stackPanel3);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 104);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 388);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.buttonCZ);
            this.stackPanel2.Controls.Add(this.buttonClose);
            this.stackPanel2.Controls.Add(this.buttonOpen);
            this.stackPanel2.Location = new System.Drawing.Point(3, 291);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(744, 38);
            this.stackPanel2.TabIndex = 28;
            this.stackPanel2.Text = "stackPanel2";
            // 
            // buttonCZ
            // 
            this.buttonCZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCZ.LocalizationText = "reset";
            this.buttonCZ.Location = new System.Drawing.Point(165, 3);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(75, 32);
            this.buttonCZ.TabIndex = 7;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.LocalizationText = "close";
            this.buttonClose.Location = new System.Drawing.Point(84, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 32);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "关 闭";
            this.buttonClose.Type = AntdUI.TTypeMini.Error;
            this.buttonClose.WaveSize = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpen.LocalizationText = "open";
            this.buttonOpen.Location = new System.Drawing.Point(3, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 32);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "打 开";
            this.buttonOpen.Type = AntdUI.TTypeMini.Success;
            this.buttonOpen.WaveSize = 0;
            // 
            // stackPanel8
            // 
            this.stackPanel8.Controls.Add(this.switch_enabled);
            this.stackPanel8.Controls.Add(this.label18);
            this.stackPanel8.Controls.Add(this.colorPicker);
            this.stackPanel8.Controls.Add(this.label16);
            this.stackPanel8.Gap = 4;
            this.stackPanel8.Location = new System.Drawing.Point(3, 253);
            this.stackPanel8.Name = "stackPanel8";
            this.stackPanel8.Size = new System.Drawing.Size(744, 32);
            this.stackPanel8.TabIndex = 27;
            this.stackPanel8.Text = "stackPanel8";
            // 
            // switch_enabled
            // 
            this.switch_enabled.Location = new System.Drawing.Point(292, 3);
            this.switch_enabled.Name = "switch_enabled";
            this.switch_enabled.Size = new System.Drawing.Size(50, 26);
            this.switch_enabled.TabIndex = 32;
            this.switch_enabled.Text = "switch1";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(190, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 26);
            this.label18.TabIndex = 31;
            this.label18.Text = "Enabled";
            // 
            // colorPicker
            // 
            this.colorPicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.colorPicker.Location = new System.Drawing.Point(105, 3);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(75, 26);
            this.colorPicker.TabIndex = 30;
            this.colorPicker.Text = "colorPicker1";
            this.colorPicker.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.colorPicker.WaveSize = 0;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 26);
            this.label16.TabIndex = 29;
            this.label16.Text = "BadgeBack";
            // 
            // stackPanel6
            // 
            this.stackPanel6.Controls.Add(this.switch_loading);
            this.stackPanel6.Controls.Add(this.label2);
            this.stackPanel6.Controls.Add(this.input_badgesize);
            this.stackPanel6.Controls.Add(this.label15);
            this.stackPanel6.Controls.Add(this.input_badge);
            this.stackPanel6.Controls.Add(this.label17);
            this.stackPanel6.Gap = 4;
            this.stackPanel6.Location = new System.Drawing.Point(3, 215);
            this.stackPanel6.Name = "stackPanel6";
            this.stackPanel6.Size = new System.Drawing.Size(744, 32);
            this.stackPanel6.TabIndex = 25;
            this.stackPanel6.Text = "stackPanel6";
            // 
            // switch_loading
            // 
            this.switch_loading.Location = new System.Drawing.Point(492, 3);
            this.switch_loading.Name = "switch_loading";
            this.switch_loading.Size = new System.Drawing.Size(50, 26);
            this.switch_loading.TabIndex = 30;
            this.switch_loading.Text = "switch1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(390, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Loading";
            // 
            // input_badgesize
            // 
            this.input_badgesize.DecimalPlaces = 1;
            this.input_badgesize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_badgesize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.input_badgesize.Location = new System.Drawing.Point(292, 3);
            this.input_badgesize.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_badgesize.Name = "input_badgesize";
            this.input_badgesize.Size = new System.Drawing.Size(88, 26);
            this.input_badgesize.TabIndex = 13;
            this.input_badgesize.Text = "0.6";
            this.input_badgesize.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.input_badgesize.WaveSize = 0;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(190, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 26);
            this.label15.TabIndex = 12;
            this.label15.Text = "BadgeSize";
            // 
            // input_badge
            // 
            this.input_badge.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_badge.Location = new System.Drawing.Point(105, 3);
            this.input_badge.Name = "input_badge";
            this.input_badge.Size = new System.Drawing.Size(75, 26);
            this.input_badge.TabIndex = 5;
            this.input_badge.WaveSize = 0;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(3, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 26);
            this.label17.TabIndex = 4;
            this.label17.Text = "Badge";
            // 
            // stackPanel5
            // 
            this.stackPanel5.Controls.Add(this.switch_round);
            this.stackPanel5.Controls.Add(this.label14);
            this.stackPanel5.Controls.Add(this.select_type);
            this.stackPanel5.Controls.Add(this.label13);
            this.stackPanel5.Controls.Add(this.input_radius);
            this.stackPanel5.Controls.Add(this.label12);
            this.stackPanel5.Gap = 4;
            this.stackPanel5.Location = new System.Drawing.Point(3, 177);
            this.stackPanel5.Name = "stackPanel5";
            this.stackPanel5.Size = new System.Drawing.Size(744, 32);
            this.stackPanel5.TabIndex = 24;
            this.stackPanel5.Text = "stackPanel5";
            // 
            // switch_round
            // 
            this.switch_round.Location = new System.Drawing.Point(492, 3);
            this.switch_round.Name = "switch_round";
            this.switch_round.Size = new System.Drawing.Size(50, 26);
            this.switch_round.TabIndex = 24;
            this.switch_round.Text = "switch1";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(390, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 26);
            this.label14.TabIndex = 23;
            this.label14.Text = "Round";
            // 
            // select_type
            // 
            this.select_type.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_type.List = true;
            this.select_type.Location = new System.Drawing.Point(292, 3);
            this.select_type.Name = "select_type";
            this.select_type.Size = new System.Drawing.Size(88, 26);
            this.select_type.TabIndex = 22;
            this.select_type.WaveSize = 0;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(190, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 26);
            this.label13.TabIndex = 21;
            this.label13.Text = "Type";
            // 
            // input_radius
            // 
            this.input_radius.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_radius.Location = new System.Drawing.Point(105, 3);
            this.input_radius.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_radius.Name = "input_radius";
            this.input_radius.Size = new System.Drawing.Size(75, 26);
            this.input_radius.TabIndex = 18;
            this.input_radius.Text = "6";
            this.input_radius.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.input_radius.WaveSize = 0;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 26);
            this.label12.TabIndex = 17;
            this.label12.Text = "Radius";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label11.LocalizationText = "button_option";
            this.label11.Location = new System.Drawing.Point(3, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(744, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "按钮配置";
            // 
            // stackPanel7
            // 
            this.stackPanel7.Controls.Add(this.input_gap);
            this.stackPanel7.Controls.Add(this.label20);
            this.stackPanel7.Gap = 4;
            this.stackPanel7.Location = new System.Drawing.Point(3, 109);
            this.stackPanel7.Name = "stackPanel7";
            this.stackPanel7.Size = new System.Drawing.Size(744, 32);
            this.stackPanel7.TabIndex = 22;
            this.stackPanel7.Text = "stackPanel7";
            // 
            // input_gap
            // 
            this.input_gap.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_gap.Location = new System.Drawing.Point(105, 3);
            this.input_gap.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_gap.Name = "input_gap";
            this.input_gap.Size = new System.Drawing.Size(75, 26);
            this.input_gap.TabIndex = 5;
            this.input_gap.Text = "40";
            this.input_gap.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.input_gap.WaveSize = 0;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(3, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 26);
            this.label20.TabIndex = 4;
            this.label20.Text = "Gap";
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.switch_topmost);
            this.stackPanel4.Controls.Add(this.label6);
            this.stackPanel4.Controls.Add(this.input_my);
            this.stackPanel4.Controls.Add(this.label8);
            this.stackPanel4.Controls.Add(this.input_size);
            this.stackPanel4.Controls.Add(this.label9);
            this.stackPanel4.Gap = 4;
            this.stackPanel4.Location = new System.Drawing.Point(3, 71);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(744, 32);
            this.stackPanel4.TabIndex = 17;
            this.stackPanel4.Text = "stackPanel4";
            // 
            // switch_topmost
            // 
            this.switch_topmost.Checked = true;
            this.switch_topmost.Location = new System.Drawing.Point(492, 3);
            this.switch_topmost.Name = "switch_topmost";
            this.switch_topmost.Size = new System.Drawing.Size(50, 26);
            this.switch_topmost.TabIndex = 15;
            this.switch_topmost.Text = "switch1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(390, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "TopMost";
            // 
            // input_my
            // 
            this.input_my.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_my.Location = new System.Drawing.Point(292, 3);
            this.input_my.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_my.Name = "input_my";
            this.input_my.Size = new System.Drawing.Size(88, 26);
            this.input_my.TabIndex = 9;
            this.input_my.Text = "24";
            this.input_my.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.input_my.WaveSize = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(190, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "MarginY";
            // 
            // input_size
            // 
            this.input_size.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_size.Location = new System.Drawing.Point(105, 3);
            this.input_size.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_size.Name = "input_size";
            this.input_size.Size = new System.Drawing.Size(75, 26);
            this.input_size.TabIndex = 5;
            this.input_size.Text = "40";
            this.input_size.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.input_size.WaveSize = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Size";
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.switch_vertical);
            this.stackPanel3.Controls.Add(this.label5);
            this.stackPanel3.Controls.Add(this.input_mx);
            this.stackPanel3.Controls.Add(this.label7);
            this.stackPanel3.Controls.Add(this.select_align);
            this.stackPanel3.Controls.Add(this.label10);
            this.stackPanel3.Gap = 4;
            this.stackPanel3.Location = new System.Drawing.Point(3, 33);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(744, 32);
            this.stackPanel3.TabIndex = 16;
            this.stackPanel3.Text = "stackPanel3";
            // 
            // switch_vertical
            // 
            this.switch_vertical.Checked = true;
            this.switch_vertical.Location = new System.Drawing.Point(492, 3);
            this.switch_vertical.Name = "switch_vertical";
            this.switch_vertical.Size = new System.Drawing.Size(50, 26);
            this.switch_vertical.TabIndex = 19;
            this.switch_vertical.Text = "switch1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(390, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vertical";
            // 
            // input_mx
            // 
            this.input_mx.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_mx.Location = new System.Drawing.Point(292, 3);
            this.input_mx.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_mx.Name = "input_mx";
            this.input_mx.Size = new System.Drawing.Size(88, 26);
            this.input_mx.TabIndex = 17;
            this.input_mx.Text = "24";
            this.input_mx.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.input_mx.WaveSize = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(190, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "MarginX";
            // 
            // select_align
            // 
            this.select_align.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.select_align.List = true;
            this.select_align.Location = new System.Drawing.Point(105, 3);
            this.select_align.Name = "select_align";
            this.select_align.Size = new System.Drawing.Size(75, 26);
            this.select_align.TabIndex = 5;
            this.select_align.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Align";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.LocalizationText = "control_option";
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "控件配置";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.LocalizationText = "FloatButton.Tip";
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label3.Size = new System.Drawing.Size(750, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "FloatButton没有工具箱控件，使用代码方式调用。";
            // 
            // FloatButtonDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.header1);
            this.Name = "FloatButtonDemo";
            this.Size = new System.Drawing.Size(750, 492);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel8.ResumeLayout(false);
            this.stackPanel6.ResumeLayout(false);
            this.stackPanel5.ResumeLayout(false);
            this.stackPanel7.ResumeLayout(false);
            this.stackPanel4.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.InputNumber input_my;
        private AntdUI.Label label8;
        private AntdUI.InputNumber input_size;
        private AntdUI.Label label9;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.Select select_align;
        private AntdUI.Label label10;
        private AntdUI.Label label4;
        private AntdUI.StackPanel stackPanel6;
        private AntdUI.InputNumber input_badgesize;
        private AntdUI.Label label15;
        private AntdUI.Input input_badge;
        private AntdUI.Label label17;
        private AntdUI.StackPanel stackPanel5;
        private AntdUI.Label label11;
        private AntdUI.StackPanel stackPanel7;
        private AntdUI.InputNumber input_gap;
        private AntdUI.Label label20;
        private AntdUI.InputNumber input_radius;
        private AntdUI.Label label12;
        private AntdUI.Switch switch_topmost;
        private AntdUI.Label label6;
        private AntdUI.Switch switch_vertical;
        private AntdUI.Label label5;
        private AntdUI.InputNumber input_mx;
        private AntdUI.Label label7;
        private AntdUI.Switch switch_round;
        private AntdUI.Label label14;
        private AntdUI.Select select_type;
        private AntdUI.Label label13;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.StackPanel stackPanel8;
        private AntdUI.Switch switch_enabled;
        private AntdUI.Label label18;
        private AntdUI.ColorPicker colorPicker;
        private AntdUI.Label label16;
        private AntdUI.Switch switch_loading;
        private AntdUI.Label label2;
        private AntdUI.Button buttonCZ;
        private AntdUI.Button buttonClose;
        private AntdUI.Button buttonOpen;
    }
}
