namespace AntdUIDemo.Views
{
    partial class RadioDemo
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
            this.p2 = new AntdUI.FlowPanel();
            this.radio3 = new AntdUI.Radio();
            this.radio4 = new AntdUI.Radio();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.radio2 = new AntdUI.Radio();
            this.radio1 = new AntdUI.Radio();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 377);
            this.panelMain.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Controls.Add(this.radio3);
            this.p2.Controls.Add(this.radio4);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            this.p2.Text = "flowPanel2";
            // 
            // radio3
            // 
            this.radio3.Checked = true;
            this.radio3.Enabled = false;
            this.radio3.Location = new System.Drawing.Point(99, 3);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(90, 32);
            this.radio3.TabIndex = 2;
            this.radio3.Text = "Radio";
            // 
            // radio4
            // 
            this.radio4.Enabled = false;
            this.radio4.Location = new System.Drawing.Point(3, 3);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(90, 32);
            this.radio4.TabIndex = 1;
            this.radio4.Text = "Radio";
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
            this.h2.Text = "禁用状态";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.radio2);
            this.p1.Controls.Add(this.radio1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            this.p1.Text = "flowPanel1";
            // 
            // radio2
            // 
            this.radio2.Checked = true;
            this.radio2.Location = new System.Drawing.Point(99, 3);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(90, 32);
            this.radio2.TabIndex = 2;
            this.radio2.Text = "Radio";
            // 
            // radio1
            // 
            this.radio1.Location = new System.Drawing.Point(3, 3);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(90, 32);
            this.radio1.TabIndex = 1;
            this.radio1.Text = "Radio";
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
            this.h1.Text = "基本类型";
            // 
            // header1
            // 
            this.header1.Description = "用于在多个备选项中选中单个状态。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Radio 单选框";
            this.header1.UseTitleFont = true;
            // 
            // RadioDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "RadioDemo";
            this.Size = new System.Drawing.Size(750, 451);
            this.panelMain.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.FlowPanel p1;
        private AntdUI.Label h1;
        private AntdUI.Radio radio1;
        private AntdUI.Radio radio2;
        private AntdUI.FlowPanel p2;
        private AntdUI.Radio radio3;
        private AntdUI.Radio radio4;
        private AntdUI.Label h2;
        private AntdUI.PageHeader header1;
    }
}
