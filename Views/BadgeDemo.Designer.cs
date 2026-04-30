namespace AntdUIDemo.Views
{
    partial class BadgeDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgeDemo));
            this.header1 = new AntdUI.PageHeader();
            this.panelMain = new AntdUI.In.Panel();
            this.p4 = new AntdUI.FlowPanel();
            this.button30 = new AntdUI.Button();
            this.button31 = new AntdUI.Button();
            this.button32 = new AntdUI.Button();
            this.button38 = new AntdUI.Button();
            this.button40 = new AntdUI.Button();
            this.button41 = new AntdUI.Button();
            this.h2 = new AntdUI.Label();
            this.p3 = new AntdUI.FlowPanel();
            this.badge12 = new AntdUI.Badge();
            this.badge4 = new AntdUI.Badge();
            this.badge8 = new AntdUI.Badge();
            this.badge9 = new AntdUI.Badge();
            this.badge10 = new AntdUI.Badge();
            this.badge11 = new AntdUI.Badge();
            this.p2 = new AntdUI.FlowPanel();
            this.badge7 = new AntdUI.Badge();
            this.p1 = new AntdUI.FlowPanel();
            this.badge5 = new AntdUI.Badge();
            this.badge3 = new AntdUI.Badge();
            this.badge2 = new AntdUI.Badge();
            this.badge1 = new AntdUI.Badge();
            this.badge6 = new AntdUI.Badge();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "图标右上角的圆形徽标数字。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Badge 徽标数";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p4);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p3);
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 393);
            this.panelMain.TabIndex = 0;
            // 
            // p4
            // 
            this.p4.Controls.Add(this.button30);
            this.p4.Controls.Add(this.button31);
            this.p4.Controls.Add(this.button32);
            this.p4.Controls.Add(this.button38);
            this.p4.Controls.Add(this.button40);
            this.p4.Controls.Add(this.button41);
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Location = new System.Drawing.Point(0, 162);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(750, 44);
            this.p4.TabIndex = 4;
            // 
            // button30
            // 
            this.button30.BadgeSvg = "DeleteFilled";
            this.button30.Location = new System.Drawing.Point(433, 3);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(80, 38);
            this.button30.TabIndex = 5;
            this.button30.Text = "Info";
            this.button30.Type = AntdUI.TTypeMini.Info;
            // 
            // button31
            // 
            this.button31.BadgeSvg = resources.GetString("button31.BadgeSvg");
            this.button31.Location = new System.Drawing.Point(347, 3);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(80, 38);
            this.button31.TabIndex = 4;
            this.button31.Text = "Error";
            this.button31.Type = AntdUI.TTypeMini.Error;
            // 
            // button32
            // 
            this.button32.Badge = "1";
            this.button32.BadgeAlign = AntdUI.TAlign.BR;
            this.button32.BadgeBack = System.Drawing.Color.Orange;
            this.button32.Location = new System.Drawing.Point(261, 3);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(80, 38);
            this.button32.TabIndex = 3;
            this.button32.Text = "Warn";
            this.button32.Type = AntdUI.TTypeMini.Warn;
            // 
            // button38
            // 
            this.button38.Badge = "99+";
            this.button38.Location = new System.Drawing.Point(175, 3);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(80, 38);
            this.button38.TabIndex = 2;
            this.button38.Text = "Success";
            this.button38.Type = AntdUI.TTypeMini.Success;
            // 
            // button40
            // 
            this.button40.Badge = "1";
            this.button40.Location = new System.Drawing.Point(89, 3);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(80, 38);
            this.button40.TabIndex = 1;
            this.button40.Text = "Primary";
            this.button40.Type = AntdUI.TTypeMini.Primary;
            // 
            // button41
            // 
            this.button41.Badge = "";
            this.button41.Location = new System.Drawing.Point(3, 3);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(80, 38);
            this.button41.TabIndex = 0;
            this.button41.Text = "Default";
            // 
            // h2
            // 
            this.h2.Dock = System.Windows.Forms.DockStyle.Top;
            this.h2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h2.Location = new System.Drawing.Point(0, 138);
            this.h2.Name = "h2";
            this.h2.PrefixColour = AntdUI.Colour.Primary;
            this.h2.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h2.Size = new System.Drawing.Size(750, 24);
            this.h2.TabIndex = 0;
            this.h2.Text = "控件组合";
            // 
            // p3
            // 
            this.p3.Controls.Add(this.badge12);
            this.p3.Controls.Add(this.badge4);
            this.p3.Controls.Add(this.badge8);
            this.p3.Controls.Add(this.badge9);
            this.p3.Controls.Add(this.badge10);
            this.p3.Controls.Add(this.badge11);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 100);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            // 
            // badge12
            // 
            this.badge12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge12.Location = new System.Drawing.Point(193, 3);
            this.badge12.Name = "badge12";
            this.badge12.Size = new System.Drawing.Size(32, 32);
            this.badge12.State = AntdUI.TState.Processing;
            this.badge12.TabIndex = 13;
            // 
            // badge4
            // 
            this.badge4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge4.Location = new System.Drawing.Point(155, 3);
            this.badge4.Name = "badge4";
            this.badge4.Size = new System.Drawing.Size(32, 32);
            this.badge4.State = AntdUI.TState.Warn;
            this.badge4.TabIndex = 10;
            // 
            // badge8
            // 
            this.badge8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge8.Location = new System.Drawing.Point(117, 3);
            this.badge8.Name = "badge8";
            this.badge8.Size = new System.Drawing.Size(32, 32);
            this.badge8.State = AntdUI.TState.Error;
            this.badge8.TabIndex = 8;
            // 
            // badge9
            // 
            this.badge9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge9.Location = new System.Drawing.Point(79, 3);
            this.badge9.Name = "badge9";
            this.badge9.Size = new System.Drawing.Size(32, 32);
            this.badge9.State = AntdUI.TState.Primary;
            this.badge9.TabIndex = 7;
            // 
            // badge10
            // 
            this.badge10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge10.Location = new System.Drawing.Point(41, 3);
            this.badge10.Name = "badge10";
            this.badge10.Size = new System.Drawing.Size(32, 32);
            this.badge10.State = AntdUI.TState.Success;
            this.badge10.TabIndex = 6;
            // 
            // badge11
            // 
            this.badge11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge11.Location = new System.Drawing.Point(3, 3);
            this.badge11.Name = "badge11";
            this.badge11.Size = new System.Drawing.Size(32, 32);
            this.badge11.TabIndex = 5;
            // 
            // p2
            // 
            this.p2.Controls.Add(this.badge7);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 62);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // badge7
            // 
            this.badge7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge7.Location = new System.Drawing.Point(3, 3);
            this.badge7.Name = "badge7";
            this.badge7.Size = new System.Drawing.Size(120, 32);
            this.badge7.State = AntdUI.TState.Processing;
            this.badge7.TabIndex = 12;
            this.badge7.Text = "Processing";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.badge5);
            this.p1.Controls.Add(this.badge3);
            this.p1.Controls.Add(this.badge2);
            this.p1.Controls.Add(this.badge1);
            this.p1.Controls.Add(this.badge6);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // badge5
            // 
            this.badge5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge5.Location = new System.Drawing.Point(507, 3);
            this.badge5.Name = "badge5";
            this.badge5.Size = new System.Drawing.Size(120, 32);
            this.badge5.State = AntdUI.TState.Warn;
            this.badge5.TabIndex = 10;
            this.badge5.Text = "Warn";
            // 
            // badge3
            // 
            this.badge3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge3.Location = new System.Drawing.Point(381, 3);
            this.badge3.Name = "badge3";
            this.badge3.Size = new System.Drawing.Size(120, 32);
            this.badge3.State = AntdUI.TState.Error;
            this.badge3.TabIndex = 8;
            this.badge3.Text = "Error";
            // 
            // badge2
            // 
            this.badge2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge2.Location = new System.Drawing.Point(255, 3);
            this.badge2.Name = "badge2";
            this.badge2.Size = new System.Drawing.Size(120, 32);
            this.badge2.State = AntdUI.TState.Primary;
            this.badge2.TabIndex = 7;
            this.badge2.Text = "Primary";
            // 
            // badge1
            // 
            this.badge1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge1.Location = new System.Drawing.Point(129, 3);
            this.badge1.Name = "badge1";
            this.badge1.Size = new System.Drawing.Size(120, 32);
            this.badge1.State = AntdUI.TState.Success;
            this.badge1.TabIndex = 6;
            this.badge1.Text = "Success";
            // 
            // badge6
            // 
            this.badge6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.badge6.Location = new System.Drawing.Point(3, 3);
            this.badge6.Name = "badge6";
            this.badge6.Size = new System.Drawing.Size(120, 32);
            this.badge6.TabIndex = 5;
            this.badge6.Text = "Default";
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
            // BadgeDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "BadgeDemo";
            this.Size = new System.Drawing.Size(750, 467);
            this.panelMain.ResumeLayout(false);
            this.p4.ResumeLayout(false);
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
        private AntdUI.Badge badge6;
        private AntdUI.Badge badge5;
        private AntdUI.Badge badge3;
        private AntdUI.Badge badge2;
        private AntdUI.Badge badge1;
        private AntdUI.FlowPanel p2;
        private AntdUI.Badge badge7;
        private AntdUI.FlowPanel p3;
        private AntdUI.Badge badge4;
        private AntdUI.Badge badge8;
        private AntdUI.Badge badge9;
        private AntdUI.Badge badge10;
        private AntdUI.Badge badge11;
        private AntdUI.Badge badge12;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel p4;
        private AntdUI.Button button30;
        private AntdUI.Button button31;
        private AntdUI.Button button32;
        private AntdUI.Button button38;
        private AntdUI.Button button40;
        private AntdUI.Button button41;
    }
}
