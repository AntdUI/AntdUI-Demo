namespace AntdUIDemo.Views
{
    partial class BatteryDemo
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
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.battery14 = new AntdUI.Battery();
            this.battery13 = new AntdUI.Battery();
            this.battery12 = new AntdUI.Battery();
            this.battery11 = new AntdUI.Battery();
            this.battery15 = new AntdUI.Battery();
            this.label5 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.battery16 = new AntdUI.Battery();
            this.battery17 = new AntdUI.Battery();
            this.battery18 = new AntdUI.Battery();
            this.battery19 = new AntdUI.Battery();
            this.battery20 = new AntdUI.Battery();
            this.label6 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.battery3 = new AntdUI.Battery();
            this.battery7 = new AntdUI.Battery();
            this.battery8 = new AntdUI.Battery();
            this.battery9 = new AntdUI.Battery();
            this.battery10 = new AntdUI.Battery();
            this.label3 = new AntdUI.Label();
            this.flowPanel = new AntdUI.FlowPanel();
            this.battery1 = new AntdUI.Battery();
            this.battery2 = new AntdUI.Battery();
            this.battery4 = new AntdUI.Battery();
            this.battery6 = new AntdUI.Battery();
            this.battery5 = new AntdUI.Battery();
            this.label4 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "电量显示";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 23;
            this.header1.Text = "Battery 电池";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.flowPanel);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 407);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.battery14);
            this.flowPanel2.Controls.Add(this.battery13);
            this.flowPanel2.Controls.Add(this.battery12);
            this.flowPanel2.Controls.Add(this.battery11);
            this.flowPanel2.Controls.Add(this.battery15);
            this.flowPanel2.Location = new System.Drawing.Point(3, 255);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 61;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // battery14
            // 
            this.battery14.FillDanger = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(121)))));
            this.battery14.FillFully = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.battery14.FillWarn = System.Drawing.Color.Fuchsia;
            this.battery14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery14.Location = new System.Drawing.Point(267, 3);
            this.battery14.Name = "battery14";
            this.battery14.ShowText = false;
            this.battery14.Size = new System.Drawing.Size(60, 32);
            this.battery14.TabIndex = 10;
            this.battery14.Text = "battery14";
            this.battery14.Value = 100;
            // 
            // battery13
            // 
            this.battery13.FillDanger = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(121)))));
            this.battery13.FillFully = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.battery13.FillWarn = System.Drawing.Color.Fuchsia;
            this.battery13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery13.Location = new System.Drawing.Point(201, 3);
            this.battery13.Name = "battery13";
            this.battery13.ShowText = false;
            this.battery13.Size = new System.Drawing.Size(60, 32);
            this.battery13.TabIndex = 9;
            this.battery13.Text = "battery13";
            this.battery13.Value = 70;
            // 
            // battery12
            // 
            this.battery12.FillDanger = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(121)))));
            this.battery12.FillFully = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.battery12.FillWarn = System.Drawing.Color.Fuchsia;
            this.battery12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery12.Location = new System.Drawing.Point(135, 3);
            this.battery12.Name = "battery12";
            this.battery12.ShowText = false;
            this.battery12.Size = new System.Drawing.Size(60, 32);
            this.battery12.TabIndex = 8;
            this.battery12.Text = "battery12";
            this.battery12.Value = 50;
            // 
            // battery11
            // 
            this.battery11.FillDanger = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(121)))));
            this.battery11.FillFully = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.battery11.FillWarn = System.Drawing.Color.Fuchsia;
            this.battery11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery11.Location = new System.Drawing.Point(69, 3);
            this.battery11.Name = "battery11";
            this.battery11.ShowText = false;
            this.battery11.Size = new System.Drawing.Size(60, 32);
            this.battery11.TabIndex = 7;
            this.battery11.Text = "battery11";
            this.battery11.Value = 30;
            // 
            // battery15
            // 
            this.battery15.FillDanger = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(121)))));
            this.battery15.FillFully = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.battery15.FillWarn = System.Drawing.Color.Fuchsia;
            this.battery15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery15.Location = new System.Drawing.Point(3, 3);
            this.battery15.Name = "battery15";
            this.battery15.ShowText = false;
            this.battery15.Size = new System.Drawing.Size(60, 32);
            this.battery15.TabIndex = 6;
            this.battery15.Text = "battery15";
            this.battery15.Value = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(744, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "自定义颜色";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.battery16);
            this.flowPanel3.Controls.Add(this.battery17);
            this.flowPanel3.Controls.Add(this.battery18);
            this.flowPanel3.Controls.Add(this.battery19);
            this.flowPanel3.Controls.Add(this.battery20);
            this.flowPanel3.Location = new System.Drawing.Point(3, 181);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(744, 38);
            this.flowPanel3.TabIndex = 59;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // battery16
            // 
            this.battery16.DotSize = 10;
            this.battery16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery16.Location = new System.Drawing.Point(267, 3);
            this.battery16.Name = "battery16";
            this.battery16.ShowText = false;
            this.battery16.Size = new System.Drawing.Size(60, 32);
            this.battery16.TabIndex = 10;
            this.battery16.Text = "battery16";
            this.battery16.Value = 100;
            // 
            // battery17
            // 
            this.battery17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery17.Location = new System.Drawing.Point(201, 3);
            this.battery17.Name = "battery17";
            this.battery17.ShowText = false;
            this.battery17.Size = new System.Drawing.Size(60, 32);
            this.battery17.TabIndex = 9;
            this.battery17.Text = "battery17";
            this.battery17.Value = 100;
            // 
            // battery18
            // 
            this.battery18.DotSize = 6;
            this.battery18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery18.Location = new System.Drawing.Point(135, 3);
            this.battery18.Name = "battery18";
            this.battery18.ShowText = false;
            this.battery18.Size = new System.Drawing.Size(60, 32);
            this.battery18.TabIndex = 8;
            this.battery18.Text = "battery18";
            this.battery18.Value = 100;
            // 
            // battery19
            // 
            this.battery19.DotSize = 4;
            this.battery19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery19.Location = new System.Drawing.Point(69, 3);
            this.battery19.Name = "battery19";
            this.battery19.ShowText = false;
            this.battery19.Size = new System.Drawing.Size(60, 32);
            this.battery19.TabIndex = 7;
            this.battery19.Text = "battery19";
            this.battery19.Value = 100;
            // 
            // battery20
            // 
            this.battery20.DotSize = 0;
            this.battery20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery20.Location = new System.Drawing.Point(3, 3);
            this.battery20.Name = "battery20";
            this.battery20.ShowText = false;
            this.battery20.Size = new System.Drawing.Size(60, 32);
            this.battery20.TabIndex = 6;
            this.battery20.Text = "battery20";
            this.battery20.Value = 100;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(744, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "点形状";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.battery3);
            this.flowPanel1.Controls.Add(this.battery7);
            this.flowPanel1.Controls.Add(this.battery8);
            this.flowPanel1.Controls.Add(this.battery9);
            this.flowPanel1.Controls.Add(this.battery10);
            this.flowPanel1.Location = new System.Drawing.Point(3, 107);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 55;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // battery3
            // 
            this.battery3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery3.Location = new System.Drawing.Point(267, 3);
            this.battery3.Name = "battery3";
            this.battery3.ShowText = false;
            this.battery3.Size = new System.Drawing.Size(60, 32);
            this.battery3.TabIndex = 10;
            this.battery3.Text = "battery3";
            this.battery3.Value = 100;
            // 
            // battery7
            // 
            this.battery7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery7.Location = new System.Drawing.Point(201, 3);
            this.battery7.Name = "battery7";
            this.battery7.ShowText = false;
            this.battery7.Size = new System.Drawing.Size(60, 32);
            this.battery7.TabIndex = 9;
            this.battery7.Text = "battery7";
            this.battery7.Value = 70;
            // 
            // battery8
            // 
            this.battery8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery8.Location = new System.Drawing.Point(135, 3);
            this.battery8.Name = "battery8";
            this.battery8.ShowText = false;
            this.battery8.Size = new System.Drawing.Size(60, 32);
            this.battery8.TabIndex = 8;
            this.battery8.Text = "battery8";
            this.battery8.Value = 50;
            // 
            // battery9
            // 
            this.battery9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery9.Location = new System.Drawing.Point(69, 3);
            this.battery9.Name = "battery9";
            this.battery9.ShowText = false;
            this.battery9.Size = new System.Drawing.Size(60, 32);
            this.battery9.TabIndex = 7;
            this.battery9.Text = "battery9";
            this.battery9.Value = 30;
            // 
            // battery10
            // 
            this.battery10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery10.Location = new System.Drawing.Point(3, 3);
            this.battery10.Name = "battery10";
            this.battery10.ShowText = false;
            this.battery10.Size = new System.Drawing.Size(60, 32);
            this.battery10.TabIndex = 6;
            this.battery10.Text = "battery10";
            this.battery10.Value = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "无文字";
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.battery1);
            this.flowPanel.Controls.Add(this.battery2);
            this.flowPanel.Controls.Add(this.battery4);
            this.flowPanel.Controls.Add(this.battery6);
            this.flowPanel.Controls.Add(this.battery5);
            this.flowPanel.Location = new System.Drawing.Point(3, 33);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(744, 38);
            this.flowPanel.TabIndex = 52;
            this.flowPanel.Text = "flowPanel1";
            // 
            // battery1
            // 
            this.battery1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery1.Location = new System.Drawing.Point(267, 3);
            this.battery1.Name = "battery1";
            this.battery1.Size = new System.Drawing.Size(60, 32);
            this.battery1.TabIndex = 10;
            this.battery1.Text = "battery1";
            this.battery1.Value = 100;
            // 
            // battery2
            // 
            this.battery2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery2.Location = new System.Drawing.Point(201, 3);
            this.battery2.Name = "battery2";
            this.battery2.Size = new System.Drawing.Size(60, 32);
            this.battery2.TabIndex = 9;
            this.battery2.Text = "battery2";
            this.battery2.Value = 70;
            // 
            // battery4
            // 
            this.battery4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery4.Location = new System.Drawing.Point(135, 3);
            this.battery4.Name = "battery4";
            this.battery4.Size = new System.Drawing.Size(60, 32);
            this.battery4.TabIndex = 8;
            this.battery4.Text = "battery4";
            this.battery4.Value = 50;
            // 
            // battery6
            // 
            this.battery6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery6.Location = new System.Drawing.Point(69, 3);
            this.battery6.Name = "battery6";
            this.battery6.Size = new System.Drawing.Size(60, 32);
            this.battery6.TabIndex = 7;
            this.battery6.Text = "battery6";
            this.battery6.Value = 30;
            // 
            // battery5
            // 
            this.battery5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.battery5.Location = new System.Drawing.Point(3, 3);
            this.battery5.Name = "battery5";
            this.battery5.Size = new System.Drawing.Size(60, 32);
            this.battery5.TabIndex = 6;
            this.battery5.Text = "battery5";
            this.battery5.Value = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "基本用法";
            // 
            // BatteryDemo
            // 
            
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "BatteryDemo";
            this.Size = new System.Drawing.Size(750, 481);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.FlowPanel flowPanel;
        private AntdUI.Label label4;
        private AntdUI.Battery battery5;
        private AntdUI.Battery battery1;
        private AntdUI.Battery battery2;
        private AntdUI.Battery battery4;
        private AntdUI.Battery battery6;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Battery battery3;
        private AntdUI.Battery battery7;
        private AntdUI.Battery battery8;
        private AntdUI.Battery battery9;
        private AntdUI.Battery battery10;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Battery battery14;
        private AntdUI.Battery battery13;
        private AntdUI.Battery battery12;
        private AntdUI.Battery battery11;
        private AntdUI.Battery battery15;
        private AntdUI.Label label5;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Battery battery16;
        private AntdUI.Battery battery17;
        private AntdUI.Battery battery18;
        private AntdUI.Battery battery19;
        private AntdUI.Battery battery20;
        private AntdUI.Label label6;
    }
}
