namespace AntdUIDemo.Views
{
    partial class SpinDemo
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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.label_spin = new AntdUI.Label();
            this.flowPanel = new AntdUI.FlowPanel();
            this.button_window = new AntdUI.Button();
            this.button_custom = new AntdUI.Button();
            this.button_base = new AntdUI.Button();
            this.button_control = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.spin2 = new AntdUI.Spin();
            this.spin1 = new AntdUI.Spin();
            this.label3 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.flowPanel);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 395);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.label_spin);
            this.flowPanel1.Location = new System.Drawing.Point(3, 151);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 61;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // label_spin
            // 
            this.label_spin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_spin.Location = new System.Drawing.Point(3, 3);
            this.label_spin.Name = "label_spin";
            this.label_spin.Size = new System.Drawing.Size(338, 32);
            this.label_spin.TabIndex = 1;
            this.label_spin.Text = "这是一个在FlowPanel里的Label控件";
            this.label_spin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.button_window);
            this.flowPanel.Controls.Add(this.button_custom);
            this.flowPanel.Controls.Add(this.button_base);
            this.flowPanel.Controls.Add(this.button_control);
            this.flowPanel.Location = new System.Drawing.Point(3, 107);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(744, 38);
            this.flowPanel.TabIndex = 60;
            this.flowPanel.Text = "flowPanel1";
            // 
            // button_window
            // 
            this.button_window.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_window.Location = new System.Drawing.Point(261, 3);
            this.button_window.Name = "button_window";
            this.button_window.Size = new System.Drawing.Size(80, 32);
            this.button_window.TabIndex = 8;
            this.button_window.Text = "整个窗口";
            this.button_window.Type = AntdUI.TTypeMini.Primary;
            this.button_window.WaveSize = 0;
            // 
            // button_custom
            // 
            this.button_custom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_custom.Location = new System.Drawing.Point(175, 3);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(80, 32);
            this.button_custom.TabIndex = 7;
            this.button_custom.Text = "当前窗口";
            this.button_custom.Type = AntdUI.TTypeMini.Primary;
            this.button_custom.WaveSize = 0;
            // 
            // button_base
            // 
            this.button_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_base.Location = new System.Drawing.Point(89, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(80, 32);
            this.button_base.TabIndex = 6;
            this.button_base.Text = "容器";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // button_control
            // 
            this.button_control.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_control.Location = new System.Drawing.Point(3, 3);
            this.button_control.Name = "button_control";
            this.button_control.Size = new System.Drawing.Size(80, 32);
            this.button_control.TabIndex = 5;
            this.button_control.Text = "控件";
            this.button_control.Type = AntdUI.TTypeMini.Primary;
            this.button_control.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "基本用法";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.spin2);
            this.flowPanel2.Controls.Add(this.spin1);
            this.flowPanel2.Location = new System.Drawing.Point(3, 33);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 58;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // spin2
            // 
            this.spin2.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.spin2.Location = new System.Drawing.Point(67, 3);
            this.spin2.Name = "spin2";
            this.spin2.Size = new System.Drawing.Size(58, 32);
            this.spin2.TabIndex = 56;
            // 
            // spin1
            // 
            this.spin1.Location = new System.Drawing.Point(3, 3);
            this.spin1.Name = "spin1";
            this.spin1.Size = new System.Drawing.Size(58, 32);
            this.spin1.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "直接使用";
            // 
            // header1
            // 
            this.header1.Description = "用于页面和区块的加载中状态。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Spin 加载中";
            this.header1.UseTitleFont = true;
            // 
            // SpinDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "SpinDemo";
            this.Size = new System.Drawing.Size(750, 469);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Label label_spin;
        private AntdUI.FlowPanel flowPanel;
        private AntdUI.Button button_window;
        private AntdUI.Button button_custom;
        private AntdUI.Button button_base;
        private AntdUI.Button button_control;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Spin spin2;
        private AntdUI.Spin spin1;
        private AntdUI.PageHeader header1;
    }
}
