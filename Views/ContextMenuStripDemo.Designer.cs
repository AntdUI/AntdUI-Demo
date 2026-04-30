namespace AntdUIDemo.Views
{
    partial class ContextMenuStripDemo
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
            this.p1 = new AntdUI.FlowPanel();
            this.button_base = new AntdUI.Button();
            this.h1 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "表示快捷菜单。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "ContextMenuStrip 快捷菜单";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 104);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 394);
            this.panelMain.TabIndex = 0;
            // 
            // p1
            // 
            this.p1.Controls.Add(this.button_base);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // button_base
            // 
            this.button_base.Location = new System.Drawing.Point(3, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(80, 32);
            this.button_base.TabIndex = 5;
            this.button_base.Text = "Click";
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
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 6);
            this.label3.Size = new System.Drawing.Size(750, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "ContextMenuStrip没有工具箱控件，使用代码方式调用。";
            // 
            // ContextMenuStripDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.header1);
            this.Name = "ContextMenuStripDemo";
            this.Size = new System.Drawing.Size(750, 498);
            this.panelMain.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.FlowPanel p1;
        private AntdUI.Button button_base;
        private AntdUI.Label h1;
        private AntdUI.Label label3;
    }
}
