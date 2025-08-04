namespace AntdUIDemo.Views
{
    partial class DrawerDemo
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
            this.stackPanel3 = new AntdUI.StackPanel();
            this.switch_mc = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.switch_mask = new AntdUI.Switch();
            this.label5 = new AntdUI.Label();
            this.select_align = new AntdUI.Select();
            this.label10 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.button = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.input_displaydealy = new AntdUI.InputNumber();
            this.stackPanel1.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "屏幕边缘滑出的浮层面板。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Drawer 抽屉";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stackPanel3);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 253);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.input_displaydealy);
            this.stackPanel3.Controls.Add(this.label1);
            this.stackPanel3.Controls.Add(this.switch_mc);
            this.stackPanel3.Controls.Add(this.label6);
            this.stackPanel3.Controls.Add(this.switch_mask);
            this.stackPanel3.Controls.Add(this.label5);
            this.stackPanel3.Controls.Add(this.select_align);
            this.stackPanel3.Controls.Add(this.label10);
            this.stackPanel3.Gap = 4;
            this.stackPanel3.Location = new System.Drawing.Point(3, 107);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(744, 32);
            this.stackPanel3.TabIndex = 32;
            this.stackPanel3.Text = "stackPanel3";
            // 
            // switch_mc
            // 
            this.switch_mc.Location = new System.Drawing.Point(463, 3);
            this.switch_mc.Name = "switch_mc";
            this.switch_mc.Size = new System.Drawing.Size(50, 26);
            this.switch_mc.TabIndex = 13;
            this.switch_mc.Text = "switch1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(333, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "MaskClosable";
            // 
            // switch_mask
            // 
            this.switch_mask.Location = new System.Drawing.Point(273, 3);
            this.switch_mask.Name = "switch_mask";
            this.switch_mask.Size = new System.Drawing.Size(50, 26);
            this.switch_mask.TabIndex = 11;
            this.switch_mask.Text = "switch1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(188, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mask";
            // 
            // select_align
            // 
            this.select_align.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.select_align.List = true;
            this.select_align.Location = new System.Drawing.Point(88, 3);
            this.select_align.Name = "select_align";
            this.select_align.Size = new System.Drawing.Size(90, 26);
            this.select_align.TabIndex = 5;
            this.select_align.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Align";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "控件配置";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button);
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 29;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.Location = new System.Drawing.Point(3, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(80, 32);
            this.button.TabIndex = 1;
            this.button.Text = "Open";
            this.button.Type = AntdUI.TTypeMini.Primary;
            this.button.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "基本用法";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(523, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "DisplayDelay";
            // 
            // input_displaydealy
            // 
            this.input_displaydealy.Location = new System.Drawing.Point(653, 3);
            this.input_displaydealy.Name = "input_displaydealy";
            this.input_displaydealy.Size = new System.Drawing.Size(75, 26);
            this.input_displaydealy.TabIndex = 15;
            this.input_displaydealy.WaveSize = 0;
            // 
            // DrawerDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "DrawerDemo";
            this.Size = new System.Drawing.Size(750, 327);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Label label4;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.Select select_align;
        private AntdUI.Label label10;
        private AntdUI.Switch switch_mc;
        private AntdUI.Label label6;
        private AntdUI.Switch switch_mask;
        private AntdUI.Label label5;
        private AntdUI.Button button;
        private AntdUI.InputNumber input_displaydealy;
        private AntdUI.Label label1;
    }
}
