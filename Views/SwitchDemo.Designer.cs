namespace AntdUIDemo.Views
{
    partial class SwitchDemo
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
            this.p3 = new AntdUI.FlowPanel();
            this.switch13 = new AntdUI.Switch();
            this.switch14 = new AntdUI.Switch();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.switch6 = new AntdUI.Switch();
            this.switch5 = new AntdUI.Switch();
            this.switch7 = new AntdUI.Switch();
            this.switch8 = new AntdUI.Switch();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.switch9 = new AntdUI.Switch();
            this.switch10 = new AntdUI.Switch();
            this.switch2 = new AntdUI.Switch();
            this.switch1 = new AntdUI.Switch();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p3);
            this.panelMain.Controls.Add(this.h3);
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 384);
            this.panelMain.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Controls.Add(this.switch13);
            this.p3.Controls.Add(this.switch14);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Gap = 6;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            this.p3.Text = "flowPanel3";
            // 
            // switch13
            // 
            this.switch13.Checked = true;
            this.switch13.Enabled = false;
            this.switch13.Location = new System.Drawing.Point(75, 3);
            this.switch13.Name = "switch13";
            this.switch13.Size = new System.Drawing.Size(60, 32);
            this.switch13.TabIndex = 2;
            this.switch13.Text = "switch13";
            // 
            // switch14
            // 
            this.switch14.Enabled = false;
            this.switch14.Location = new System.Drawing.Point(3, 3);
            this.switch14.Name = "switch14";
            this.switch14.Size = new System.Drawing.Size(60, 32);
            this.switch14.TabIndex = 1;
            this.switch14.Text = "switch14";
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
            this.h3.Text = "禁用";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.switch6);
            this.p2.Controls.Add(this.switch5);
            this.p2.Controls.Add(this.switch7);
            this.p2.Controls.Add(this.switch8);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Gap = 6;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            this.p2.Text = "flowPanel2";
            // 
            // switch6
            // 
            this.switch6.Checked = true;
            this.switch6.CheckedText = "True";
            this.switch6.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch6.Gap = 6;
            this.switch6.Location = new System.Drawing.Point(219, 3);
            this.switch6.Name = "switch6";
            this.switch6.Size = new System.Drawing.Size(60, 32);
            this.switch6.TabIndex = 4;
            this.switch6.Text = "switch6";
            this.switch6.UnCheckedText = "False";
            this.switch6.WaveSize = 0;
            // 
            // switch5
            // 
            this.switch5.CheckedText = "是";
            this.switch5.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch5.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(34)))));
            this.switch5.Gap = 6;
            this.switch5.Location = new System.Drawing.Point(147, 3);
            this.switch5.Name = "switch5";
            this.switch5.Size = new System.Drawing.Size(60, 32);
            this.switch5.TabIndex = 3;
            this.switch5.Text = "switch5";
            this.switch5.UnCheckedText = "否";
            this.switch5.WaveSize = 0;
            // 
            // switch7
            // 
            this.switch7.Checked = true;
            this.switch7.CheckedText = "On";
            this.switch7.Location = new System.Drawing.Point(75, 3);
            this.switch7.Name = "switch7";
            this.switch7.Size = new System.Drawing.Size(60, 32);
            this.switch7.TabIndex = 2;
            this.switch7.Text = "switch7";
            this.switch7.UnCheckedText = "Off";
            // 
            // switch8
            // 
            this.switch8.CheckedText = "开";
            this.switch8.Location = new System.Drawing.Point(3, 3);
            this.switch8.Name = "switch8";
            this.switch8.Size = new System.Drawing.Size(60, 32);
            this.switch8.TabIndex = 1;
            this.switch8.Text = "switch8";
            this.switch8.UnCheckedText = "关";
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
            this.h2.Text = "文字提示";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.switch9);
            this.p1.Controls.Add(this.switch10);
            this.p1.Controls.Add(this.switch2);
            this.p1.Controls.Add(this.switch1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Gap = 6;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            this.p1.Text = "flowPanel1";
            // 
            // switch9
            // 
            this.switch9.Checked = true;
            this.switch9.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch9.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(34)))));
            this.switch9.Gap = 6;
            this.switch9.Location = new System.Drawing.Point(219, 3);
            this.switch9.Name = "switch9";
            this.switch9.Size = new System.Drawing.Size(60, 32);
            this.switch9.TabIndex = 4;
            this.switch9.Text = "switch9";
            this.switch9.WaveSize = 0;
            // 
            // switch10
            // 
            this.switch10.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch10.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(34)))));
            this.switch10.Gap = 6;
            this.switch10.Location = new System.Drawing.Point(147, 3);
            this.switch10.Name = "switch10";
            this.switch10.Size = new System.Drawing.Size(60, 32);
            this.switch10.TabIndex = 3;
            this.switch10.Text = "switch10";
            this.switch10.WaveSize = 0;
            // 
            // switch2
            // 
            this.switch2.Checked = true;
            this.switch2.Location = new System.Drawing.Point(75, 3);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(60, 32);
            this.switch2.TabIndex = 2;
            this.switch2.Text = "switch2";
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(3, 3);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(60, 32);
            this.switch1.TabIndex = 1;
            this.switch1.Text = "switch1";
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
            this.header1.Description = "使用开关切换两种状态之间。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Switch 开关";
            this.header1.UseTitleFont = true;
            // 
            // SwitchDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "SwitchDemo";
            this.Size = new System.Drawing.Size(750, 458);
            this.panelMain.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Switch switch1;
        private AntdUI.Switch switch2;
        private AntdUI.FlowPanel p2;
        private AntdUI.Switch switch7;
        private AntdUI.Switch switch8;
        private AntdUI.Label h2;
        private AntdUI.Switch switch6;
        private AntdUI.Switch switch5;
        private AntdUI.Switch switch9;
        private AntdUI.Switch switch10;
        private AntdUI.FlowPanel p3;
        private AntdUI.Switch switch13;
        private AntdUI.Switch switch14;
        private AntdUI.Label h3;
        private AntdUI.PageHeader header1;
    }
}
