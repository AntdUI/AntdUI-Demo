namespace AntdUIDemo.Views
{
    partial class PanelDemo
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
            this.panel = new AntdUI.Panel();
            this.gridPanel2 = new AntdUI.GridPanel();
            this.buttonCZ = new AntdUI.Button();
            this.input_shadowOH = new AntdUI.InputNumber();
            this.label12 = new AntdUI.Label();
            this.switch_shadowOA = new AntdUI.Switch();
            this.label13 = new AntdUI.Label();
            this.input_shadowO = new AntdUI.InputNumber();
            this.label11 = new AntdUI.Label();
            this.input_shadowY = new AntdUI.InputNumber();
            this.label9 = new AntdUI.Label();
            this.input_shadowX = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.colorPicker_shadow = new AntdUI.ColorPicker();
            this.label7 = new AntdUI.Label();
            this.select_shadowalign = new AntdUI.Select();
            this.label6 = new AntdUI.Label();
            this.input_shadow = new AntdUI.InputNumber();
            this.label5 = new AntdUI.Label();
            this.select_borderstyle = new AntdUI.Select();
            this.label16 = new AntdUI.Label();
            this.input_borderwidth = new AntdUI.InputNumber();
            this.label15 = new AntdUI.Label();
            this.colorPicker_border = new AntdUI.ColorPicker();
            this.label14 = new AntdUI.Label();
            this.input_radius = new AntdUI.InputNumber();
            this.label4 = new AntdUI.Label();
            this.input_arrowsize = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.select_arrowalign = new AntdUI.Select();
            this.label10 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.gridPanel2.SuspendLayout();
            this.gridPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(491, 74);
            this.panel.Name = "panel";
            this.panel.Shadow = 12;
            this.panel.ShadowOpacityAnimation = true;
            this.panel.Size = new System.Drawing.Size(259, 486);
            this.panel.TabIndex = 2;
            // 
            // gridPanel2
            // 
            this.gridPanel2.Controls.Add(this.buttonCZ);
            this.gridPanel2.Controls.Add(this.input_shadowOH);
            this.gridPanel2.Controls.Add(this.label12);
            this.gridPanel2.Controls.Add(this.switch_shadowOA);
            this.gridPanel2.Controls.Add(this.label13);
            this.gridPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridPanel2.Location = new System.Drawing.Point(247, 74);
            this.gridPanel2.Name = "gridPanel2";
            this.gridPanel2.Size = new System.Drawing.Size(244, 486);
            this.gridPanel2.Span = "40:180 50 100%_N;40:180 100%;40:100%;";
            this.gridPanel2.TabIndex = 1;
            // 
            // buttonCZ
            // 
            this.buttonCZ.Location = new System.Drawing.Point(3, 83);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(238, 34);
            this.buttonCZ.TabIndex = 15;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // input_shadowOH
            // 
            this.input_shadowOH.DecimalPlaces = 2;
            this.input_shadowOH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.input_shadowOH.Location = new System.Drawing.Point(183, 43);
            this.input_shadowOH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_shadowOH.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_shadowOH.Name = "input_shadowOH";
            this.input_shadowOH.Size = new System.Drawing.Size(58, 34);
            this.input_shadowOH.TabIndex = 14;
            this.input_shadowOH.Text = "0.30";
            this.input_shadowOH.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.input_shadowOH.WaveSize = 0;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label12.Location = new System.Drawing.Point(3, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 34);
            this.label12.TabIndex = 0;
            this.label12.Text = "ShadowOpacityHover";
            // 
            // switch_shadowOA
            // 
            this.switch_shadowOA.Checked = true;
            this.switch_shadowOA.Location = new System.Drawing.Point(183, 3);
            this.switch_shadowOA.Name = "switch_shadowOA";
            this.switch_shadowOA.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.switch_shadowOA.Size = new System.Drawing.Size(44, 34);
            this.switch_shadowOA.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 34);
            this.label13.TabIndex = 0;
            this.label13.Text = "ShadowOpacityAnimation";
            // 
            // input_shadowO
            // 
            this.input_shadowO.DecimalPlaces = 2;
            this.input_shadowO.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.input_shadowO.Location = new System.Drawing.Point(143, 443);
            this.input_shadowO.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_shadowO.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_shadowO.Name = "input_shadowO";
            this.input_shadowO.Size = new System.Drawing.Size(101, 34);
            this.input_shadowO.TabIndex = 12;
            this.input_shadowO.Text = "0.20";
            this.input_shadowO.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.input_shadowO.WaveSize = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label11.Location = new System.Drawing.Point(3, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "ShadowOpacity";
            // 
            // input_shadowY
            // 
            this.input_shadowY.Location = new System.Drawing.Point(143, 403);
            this.input_shadowY.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_shadowY.Name = "input_shadowY";
            this.input_shadowY.Size = new System.Drawing.Size(101, 34);
            this.input_shadowY.TabIndex = 11;
            this.input_shadowY.Text = "0";
            this.input_shadowY.WaveSize = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label9.Location = new System.Drawing.Point(3, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "ShadowOffsetY";
            // 
            // input_shadowX
            // 
            this.input_shadowX.Location = new System.Drawing.Point(143, 363);
            this.input_shadowX.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_shadowX.Name = "input_shadowX";
            this.input_shadowX.Size = new System.Drawing.Size(101, 34);
            this.input_shadowX.TabIndex = 10;
            this.input_shadowX.Text = "0";
            this.input_shadowX.WaveSize = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label8.Location = new System.Drawing.Point(3, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "ShadowOffsetX";
            // 
            // colorPicker_shadow
            // 
            this.colorPicker_shadow.Location = new System.Drawing.Point(143, 323);
            this.colorPicker_shadow.Name = "colorPicker_shadow";
            this.colorPicker_shadow.ShowText = true;
            this.colorPicker_shadow.Size = new System.Drawing.Size(101, 34);
            this.colorPicker_shadow.TabIndex = 9;
            this.colorPicker_shadow.Text = "col";
            this.colorPicker_shadow.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.colorPicker_shadow.WaveSize = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label7.Location = new System.Drawing.Point(3, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "ShadowColor";
            // 
            // select_shadowalign
            // 
            this.select_shadowalign.List = true;
            this.select_shadowalign.Location = new System.Drawing.Point(143, 283);
            this.select_shadowalign.Name = "select_shadowalign";
            this.select_shadowalign.Size = new System.Drawing.Size(101, 34);
            this.select_shadowalign.TabIndex = 8;
            this.select_shadowalign.WaveSize = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label6.Location = new System.Drawing.Point(3, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "ShadowAlign";
            // 
            // input_shadow
            // 
            this.input_shadow.Location = new System.Drawing.Point(143, 243);
            this.input_shadow.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_shadow.Name = "input_shadow";
            this.input_shadow.Size = new System.Drawing.Size(101, 34);
            this.input_shadow.TabIndex = 7;
            this.input_shadow.Text = "12";
            this.input_shadow.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.input_shadow.WaveSize = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(3, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Shadow";
            // 
            // select_borderstyle
            // 
            this.select_borderstyle.List = true;
            this.select_borderstyle.Location = new System.Drawing.Point(143, 203);
            this.select_borderstyle.Name = "select_borderstyle";
            this.select_borderstyle.Size = new System.Drawing.Size(101, 34);
            this.select_borderstyle.TabIndex = 6;
            this.select_borderstyle.WaveSize = 0;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label16.Location = new System.Drawing.Point(3, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 34);
            this.label16.TabIndex = 0;
            this.label16.Text = "BorderStyle";
            // 
            // input_borderwidth
            // 
            this.input_borderwidth.DecimalPlaces = 2;
            this.input_borderwidth.Location = new System.Drawing.Point(143, 163);
            this.input_borderwidth.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_borderwidth.Name = "input_borderwidth";
            this.input_borderwidth.Size = new System.Drawing.Size(101, 34);
            this.input_borderwidth.TabIndex = 5;
            this.input_borderwidth.Text = "0.00";
            this.input_borderwidth.WaveSize = 0;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label15.Location = new System.Drawing.Point(3, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "BorderWidth";
            // 
            // colorPicker_border
            // 
            this.colorPicker_border.Location = new System.Drawing.Point(143, 123);
            this.colorPicker_border.Name = "colorPicker_border";
            this.colorPicker_border.ShowText = true;
            this.colorPicker_border.Size = new System.Drawing.Size(101, 34);
            this.colorPicker_border.TabIndex = 4;
            this.colorPicker_border.Text = "col";
            this.colorPicker_border.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.colorPicker_border.WaveSize = 0;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label14.Location = new System.Drawing.Point(3, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "BorderColor";
            // 
            // input_radius
            // 
            this.input_radius.Location = new System.Drawing.Point(143, 83);
            this.input_radius.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_radius.Name = "input_radius";
            this.input_radius.Size = new System.Drawing.Size(101, 34);
            this.input_radius.TabIndex = 3;
            this.input_radius.Text = "6";
            this.input_radius.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.input_radius.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radius";
            // 
            // input_arrowsize
            // 
            this.input_arrowsize.Location = new System.Drawing.Point(143, 43);
            this.input_arrowsize.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_arrowsize.Name = "input_arrowsize";
            this.input_arrowsize.Size = new System.Drawing.Size(101, 34);
            this.input_arrowsize.TabIndex = 2;
            this.input_arrowsize.Text = "8";
            this.input_arrowsize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.input_arrowsize.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "ArrowSize";
            // 
            // select_arrowalign
            // 
            this.select_arrowalign.List = true;
            this.select_arrowalign.Location = new System.Drawing.Point(143, 3);
            this.select_arrowalign.Name = "select_arrowalign";
            this.select_arrowalign.Size = new System.Drawing.Size(101, 34);
            this.select_arrowalign.TabIndex = 1;
            this.select_arrowalign.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "ArrowAlign";
            // 
            // header1
            // 
            this.header1.Description = "普通布局面板";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Panel 面板";
            this.header1.UseTitleFont = true;
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.input_shadowO);
            this.gridPanel1.Controls.Add(this.label11);
            this.gridPanel1.Controls.Add(this.input_shadowY);
            this.gridPanel1.Controls.Add(this.label9);
            this.gridPanel1.Controls.Add(this.input_shadowX);
            this.gridPanel1.Controls.Add(this.label8);
            this.gridPanel1.Controls.Add(this.colorPicker_shadow);
            this.gridPanel1.Controls.Add(this.label7);
            this.gridPanel1.Controls.Add(this.select_shadowalign);
            this.gridPanel1.Controls.Add(this.label6);
            this.gridPanel1.Controls.Add(this.input_shadow);
            this.gridPanel1.Controls.Add(this.label5);
            this.gridPanel1.Controls.Add(this.select_borderstyle);
            this.gridPanel1.Controls.Add(this.label16);
            this.gridPanel1.Controls.Add(this.input_borderwidth);
            this.gridPanel1.Controls.Add(this.label15);
            this.gridPanel1.Controls.Add(this.colorPicker_border);
            this.gridPanel1.Controls.Add(this.label14);
            this.gridPanel1.Controls.Add(this.input_radius);
            this.gridPanel1.Controls.Add(this.label4);
            this.gridPanel1.Controls.Add(this.input_arrowsize);
            this.gridPanel1.Controls.Add(this.label3);
            this.gridPanel1.Controls.Add(this.select_arrowalign);
            this.gridPanel1.Controls.Add(this.label10);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridPanel1.Location = new System.Drawing.Point(0, 74);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(247, 486);
            this.gridPanel1.Span = "40:140 100%;40:140 100%;40:140 100%;40:140 100%;40:140 100%;40:140 100%;40:140 10" +
    "0%;40:140 100%;40:140 100%;40:140 100%;40:140 100%;40:140 100%";
            this.gridPanel1.TabIndex = 1;
            // 
            // PanelDemo
            // 
            this.Controls.Add(this.panel);
            this.Controls.Add(this.gridPanel2);
            this.Controls.Add(this.gridPanel1);
            this.Controls.Add(this.header1);
            this.Name = "PanelDemo";
            this.Size = new System.Drawing.Size(750, 560);
            this.Load += new System.EventHandler(this.PanelDemo_Load);
            this.gridPanel2.ResumeLayout(false);
            this.gridPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.InputNumber input_shadowOH;
        private AntdUI.Label label12;
        private AntdUI.Label label13;
        private AntdUI.InputNumber input_borderwidth;
        private AntdUI.Label label15;
        private AntdUI.ColorPicker colorPicker_border;
        private AntdUI.Label label14;
        private AntdUI.InputNumber input_radius;
        private AntdUI.Label label4;
        private AntdUI.InputNumber input_arrowsize;
        private AntdUI.Label label3;
        private AntdUI.Select select_arrowalign;
        private AntdUI.Label label10;
        private AntdUI.Switch switch_shadowOA;
        private AntdUI.Panel panel;
        private AntdUI.Button buttonCZ;
        private AntdUI.InputNumber input_shadowO;
        private AntdUI.Label label11;
        private AntdUI.InputNumber input_shadowY;
        private AntdUI.Label label9;
        private AntdUI.InputNumber input_shadowX;
        private AntdUI.Label label8;
        private AntdUI.ColorPicker colorPicker_shadow;
        private AntdUI.Label label7;
        private AntdUI.Select select_shadowalign;
        private AntdUI.Label label6;
        private AntdUI.InputNumber input_shadow;
        private AntdUI.Label label5;
        private AntdUI.Select select_borderstyle;
        private AntdUI.Label label16;
        private AntdUI.PageHeader header1;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.GridPanel gridPanel2;
    }
}
