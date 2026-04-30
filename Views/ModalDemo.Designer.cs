namespace AntdUIDemo.Views
{
    partial class ModalDemo
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
            this.p4 = new AntdUI.FlowPanel();
            this.button_sys = new AntdUI.Button();
            this.h4 = new AntdUI.Label();
            this.p3 = new AntdUI.FlowPanel();
            this.button_close = new AntdUI.Button();
            this.button_noclose = new AntdUI.Button();
            this.button_nomask = new AntdUI.Button();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.button_custombutton = new AntdUI.Button();
            this.button_nobutton = new AntdUI.Button();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.button_drag = new AntdUI.Button();
            this.button_base = new AntdUI.Button();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p4);
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
            this.panelMain.Size = new System.Drawing.Size(750, 401);
            this.panelMain.TabIndex = 0;
            // 
            // p4
            // 
            this.p4.Controls.Add(this.button_sys);
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Location = new System.Drawing.Point(0, 210);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(750, 38);
            this.p4.TabIndex = 4;
            // 
            // button_sys
            // 
            this.button_sys.Location = new System.Drawing.Point(3, 3);
            this.button_sys.Name = "button_sys";
            this.button_sys.Size = new System.Drawing.Size(90, 32);
            this.button_sys.TabIndex = 1;
            this.button_sys.Text = "系统设置";
            this.button_sys.Type = AntdUI.TTypeMini.Primary;
            this.button_sys.WaveSize = 0;
            // 
            // h4
            // 
            this.h4.Dock = System.Windows.Forms.DockStyle.Top;
            this.h4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h4.Location = new System.Drawing.Point(0, 186);
            this.h4.Name = "h4";
            this.h4.PrefixColour = AntdUI.Colour.Primary;
            this.h4.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h4.Size = new System.Drawing.Size(750, 24);
            this.h4.TabIndex = 0;
            this.h4.Text = "自定义弹窗";
            // 
            // p3
            // 
            this.p3.Controls.Add(this.button_close);
            this.p3.Controls.Add(this.button_noclose);
            this.p3.Controls.Add(this.button_nomask);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(195, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(90, 32);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "关闭按钮";
            this.button_close.Type = AntdUI.TTypeMini.Primary;
            this.button_close.WaveSize = 0;
            // 
            // button_noclose
            // 
            this.button_noclose.Location = new System.Drawing.Point(99, 3);
            this.button_noclose.Name = "button_noclose";
            this.button_noclose.Size = new System.Drawing.Size(90, 32);
            this.button_noclose.TabIndex = 2;
            this.button_noclose.Text = "外侧禁止关闭";
            this.button_noclose.Type = AntdUI.TTypeMini.Primary;
            this.button_noclose.WaveSize = 0;
            // 
            // button_nomask
            // 
            this.button_nomask.Location = new System.Drawing.Point(3, 3);
            this.button_nomask.Name = "button_nomask";
            this.button_nomask.Size = new System.Drawing.Size(90, 32);
            this.button_nomask.TabIndex = 1;
            this.button_nomask.Text = "无遮罩";
            this.button_nomask.Type = AntdUI.TTypeMini.Primary;
            this.button_nomask.WaveSize = 0;
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
            this.h3.Text = "遮罩";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.button_custombutton);
            this.p2.Controls.Add(this.button_nobutton);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // button_custombutton
            // 
            this.button_custombutton.Location = new System.Drawing.Point(99, 3);
            this.button_custombutton.Name = "button_custombutton";
            this.button_custombutton.Size = new System.Drawing.Size(90, 32);
            this.button_custombutton.TabIndex = 2;
            this.button_custombutton.Text = "自定义按钮";
            this.button_custombutton.Type = AntdUI.TTypeMini.Primary;
            this.button_custombutton.WaveSize = 0;
            // 
            // button_nobutton
            // 
            this.button_nobutton.Location = new System.Drawing.Point(3, 3);
            this.button_nobutton.Name = "button_nobutton";
            this.button_nobutton.Size = new System.Drawing.Size(90, 32);
            this.button_nobutton.TabIndex = 1;
            this.button_nobutton.Text = "无按钮";
            this.button_nobutton.Type = AntdUI.TTypeMini.Primary;
            this.button_nobutton.WaveSize = 0;
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
            this.h2.Text = "自定义页脚";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.button_drag);
            this.p1.Controls.Add(this.button_base);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // button_drag
            // 
            this.button_drag.Location = new System.Drawing.Point(99, 3);
            this.button_drag.Name = "button_drag";
            this.button_drag.Size = new System.Drawing.Size(90, 32);
            this.button_drag.TabIndex = 2;
            this.button_drag.Text = "支持拖拽";
            this.button_drag.Type = AntdUI.TTypeMini.Primary;
            this.button_drag.WaveSize = 0;
            // 
            // button_base
            // 
            this.button_base.Location = new System.Drawing.Point(3, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(90, 32);
            this.button_base.TabIndex = 1;
            this.button_base.Text = "默认";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
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
            this.header1.Description = "展示一个对话框，提供标题、内容区、操作区。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Modal 对话框";
            this.header1.UseTitleFont = true;
            // 
            // ModalDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "ModalDemo";
            this.Size = new System.Drawing.Size(750, 475);
            this.panelMain.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Button button_base;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel p2;
        private AntdUI.Button button_nobutton;
        private AntdUI.Button button_custombutton;
        private AntdUI.FlowPanel p3;
        private AntdUI.Button button_nomask;
        private AntdUI.Label h3;
        private AntdUI.Button button_noclose;
        private AntdUI.Button button_close;
        private AntdUI.FlowPanel p4;
        private AntdUI.Button button_sys;
        private AntdUI.Label h4;
        private AntdUI.PageHeader header1;
        private AntdUI.Button button_drag;
    }
}
