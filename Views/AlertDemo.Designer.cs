namespace AntdUIDemo.Views
{
    partial class AlertDemo
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
            this.panelMain = new AntdUI.In.Panel();
            this.alert9 = new AntdUI.Alert();
            this.h4 = new AntdUI.Label();
            this.p3 = new AntdUI.FlowPanel();
            this.alert12 = new AntdUI.Alert();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.alert5 = new AntdUI.Alert();
            this.alert6 = new AntdUI.Alert();
            this.alert7 = new AntdUI.Alert();
            this.alert8 = new AntdUI.Alert();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.alert4 = new AntdUI.Alert();
            this.alert3 = new AntdUI.Alert();
            this.alert2 = new AntdUI.Alert();
            this.alert1 = new AntdUI.Alert();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "警告提示，展现需要关注的信息。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Alert 警告提示";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.alert9);
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
            this.panelMain.Size = new System.Drawing.Size(750, 431);
            this.panelMain.TabIndex = 0;
            // 
            // alert9
            // 
            this.alert9.BackColor = System.Drawing.Color.Pink;
            this.alert9.Dock = System.Windows.Forms.DockStyle.Top;
            this.alert9.Location = new System.Drawing.Point(0, 246);
            this.alert9.Loop = true;
            this.alert9.Name = "alert9";
            this.alert9.Size = new System.Drawing.Size(750, 32);
            this.alert9.TabIndex = 4;
            this.alert9.Text = "I can be a React component, multiple React components, or just some text.";
            // 
            // h4
            // 
            this.h4.Dock = System.Windows.Forms.DockStyle.Top;
            this.h4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h4.Location = new System.Drawing.Point(0, 222);
            this.h4.Name = "h4";
            this.h4.PrefixColour = AntdUI.Colour.Primary;
            this.h4.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h4.Size = new System.Drawing.Size(750, 24);
            this.h4.TabIndex = 0;
            this.h4.Text = "轮播";
            // 
            // p3
            // 
            this.p3.Controls.Add(this.alert12);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 74);
            this.p3.TabIndex = 3;
            this.p3.Text = "flowPanel3";
            // 
            // alert12
            // 
            this.alert12.BorderWidth = 2F;
            this.alert12.Icon = AntdUI.TType.Success;
            this.alert12.Location = new System.Drawing.Point(3, 3);
            this.alert12.Name = "alert12";
            this.alert12.Size = new System.Drawing.Size(498, 68);
            this.alert12.TabIndex = 0;
            this.alert12.Text = "Success Description Success Description Success Description";
            this.alert12.TextTitle = "Success Text";
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
            this.h3.Text = "副文本";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.alert5);
            this.p2.Controls.Add(this.alert6);
            this.p2.Controls.Add(this.alert7);
            this.p2.Controls.Add(this.alert8);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            this.p2.Text = "flowPanel1";
            // 
            // alert5
            // 
            this.alert5.BorderWidth = 2F;
            this.alert5.Icon = AntdUI.TType.Error;
            this.alert5.Location = new System.Drawing.Point(381, 3);
            this.alert5.Name = "alert5";
            this.alert5.Size = new System.Drawing.Size(120, 32);
            this.alert5.TabIndex = 3;
            this.alert5.Text = "Error Text";
            // 
            // alert6
            // 
            this.alert6.BorderWidth = 2F;
            this.alert6.Icon = AntdUI.TType.Warn;
            this.alert6.Location = new System.Drawing.Point(255, 3);
            this.alert6.Name = "alert6";
            this.alert6.Size = new System.Drawing.Size(120, 32);
            this.alert6.TabIndex = 2;
            this.alert6.Text = "Warn Text";
            // 
            // alert7
            // 
            this.alert7.BorderWidth = 2F;
            this.alert7.Icon = AntdUI.TType.Info;
            this.alert7.Location = new System.Drawing.Point(129, 3);
            this.alert7.Name = "alert7";
            this.alert7.Size = new System.Drawing.Size(120, 32);
            this.alert7.TabIndex = 1;
            this.alert7.Text = "Info Text";
            // 
            // alert8
            // 
            this.alert8.BorderWidth = 2F;
            this.alert8.Icon = AntdUI.TType.Success;
            this.alert8.Location = new System.Drawing.Point(3, 3);
            this.alert8.Name = "alert8";
            this.alert8.Size = new System.Drawing.Size(120, 32);
            this.alert8.TabIndex = 0;
            this.alert8.Text = "Success Text";
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
            this.h2.Text = "提示边框";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.alert4);
            this.p1.Controls.Add(this.alert3);
            this.p1.Controls.Add(this.alert2);
            this.p1.Controls.Add(this.alert1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            this.p1.Text = "flowPanel2";
            // 
            // alert4
            // 
            this.alert4.Icon = AntdUI.TType.Error;
            this.alert4.Location = new System.Drawing.Point(381, 3);
            this.alert4.Name = "alert4";
            this.alert4.Size = new System.Drawing.Size(120, 32);
            this.alert4.TabIndex = 3;
            this.alert4.Text = "Error Text";
            // 
            // alert3
            // 
            this.alert3.Icon = AntdUI.TType.Warn;
            this.alert3.Location = new System.Drawing.Point(255, 3);
            this.alert3.Name = "alert3";
            this.alert3.Size = new System.Drawing.Size(120, 32);
            this.alert3.TabIndex = 2;
            this.alert3.Text = "Warn Text";
            // 
            // alert2
            // 
            this.alert2.Icon = AntdUI.TType.Info;
            this.alert2.Location = new System.Drawing.Point(129, 3);
            this.alert2.Name = "alert2";
            this.alert2.Size = new System.Drawing.Size(120, 32);
            this.alert2.TabIndex = 1;
            this.alert2.Text = "Info Text";
            // 
            // alert1
            // 
            this.alert1.Icon = AntdUI.TType.Success;
            this.alert1.Location = new System.Drawing.Point(3, 3);
            this.alert1.Name = "alert1";
            this.alert1.Size = new System.Drawing.Size(120, 32);
            this.alert1.TabIndex = 0;
            this.alert1.Text = "Success Text";
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
            // AlertDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "AlertDemo";
            this.Size = new System.Drawing.Size(750, 505);
            this.panelMain.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Alert alert1;
        private AntdUI.Alert alert4;
        private AntdUI.Alert alert3;
        private AntdUI.Alert alert2;
        private AntdUI.FlowPanel p2;
        private AntdUI.Alert alert5;
        private AntdUI.Alert alert6;
        private AntdUI.Alert alert7;
        private AntdUI.Alert alert8;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel p3;
        private AntdUI.Alert alert12;
        private AntdUI.Label h3;
        private AntdUI.Label h4;
        private AntdUI.Alert alert9;
    }
}
