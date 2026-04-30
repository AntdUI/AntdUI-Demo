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
            this.panelMain = new AntdUI.In.Panel();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.label_spin = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.button_window = new AntdUI.Button();
            this.button_custom = new AntdUI.Button();
            this.button_base = new AntdUI.Button();
            this.button_control = new AntdUI.Button();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.spin2 = new AntdUI.Spin();
            this.spin1 = new AntdUI.Spin();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flowPanel1);
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 395);
            this.panelMain.TabIndex = 0;
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.label_spin);
            this.flowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel1.Location = new System.Drawing.Point(0, 124);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(750, 38);
            this.flowPanel1.TabIndex = 0;
            // 
            // label_spin
            // 
            this.label_spin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label_spin.Location = new System.Drawing.Point(3, 3);
            this.label_spin.Name = "label_spin";
            this.label_spin.Size = new System.Drawing.Size(338, 32);
            this.label_spin.TabIndex = 1;
            this.label_spin.Text = "这是一个在FlowPanel里的Label控件";
            this.label_spin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2
            // 
            this.p2.Controls.Add(this.button_window);
            this.p2.Controls.Add(this.button_custom);
            this.p2.Controls.Add(this.button_base);
            this.p2.Controls.Add(this.button_control);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 60;
            // 
            // button_window
            // 
            this.button_window.Location = new System.Drawing.Point(261, 3);
            this.button_window.Name = "button_window";
            this.button_window.Size = new System.Drawing.Size(80, 32);
            this.button_window.TabIndex = 4;
            this.button_window.Text = "整个窗口";
            this.button_window.Type = AntdUI.TTypeMini.Primary;
            this.button_window.WaveSize = 0;
            // 
            // button_custom
            // 
            this.button_custom.Location = new System.Drawing.Point(175, 3);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(80, 32);
            this.button_custom.TabIndex = 3;
            this.button_custom.Text = "当前窗口";
            this.button_custom.Type = AntdUI.TTypeMini.Primary;
            this.button_custom.WaveSize = 0;
            // 
            // button_base
            // 
            this.button_base.Location = new System.Drawing.Point(89, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(80, 32);
            this.button_base.TabIndex = 2;
            this.button_base.Text = "容器";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // button_control
            // 
            this.button_control.Location = new System.Drawing.Point(3, 3);
            this.button_control.Name = "button_control";
            this.button_control.Size = new System.Drawing.Size(80, 32);
            this.button_control.TabIndex = 1;
            this.button_control.Text = "控件";
            this.button_control.Type = AntdUI.TTypeMini.Primary;
            this.button_control.WaveSize = 0;
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
            this.h2.Text = "基本用法";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.spin2);
            this.p1.Controls.Add(this.spin1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 58;
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
            this.h1.Text = "直接使用";
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
            this.header1.TabIndex = 0;
            this.header1.Text = "Spin 加载中";
            this.header1.UseTitleFont = true;
            // 
            // SpinDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "SpinDemo";
            this.Size = new System.Drawing.Size(750, 469);
            this.panelMain.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Label label_spin;
        private AntdUI.FlowPanel p2;
        private AntdUI.Button button_window;
        private AntdUI.Button button_custom;
        private AntdUI.Button button_base;
        private AntdUI.Button button_control;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel p1;
        private AntdUI.Spin spin2;
        private AntdUI.Spin spin1;
        private AntdUI.PageHeader header1;
    }
}
