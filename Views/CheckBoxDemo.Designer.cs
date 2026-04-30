namespace AntdUIDemo.Views
{
    partial class CheckBoxDemo
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
            this.p2 = new AntdUI.FlowPanel();
            this.checkbox3 = new AntdUI.Checkbox();
            this.checkbox4 = new AntdUI.Checkbox();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.checkbox5 = new AntdUI.Checkbox();
            this.checkbox6 = new AntdUI.Checkbox();
            this.checkbox2 = new AntdUI.Checkbox();
            this.checkbox1 = new AntdUI.Checkbox();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "收集用户的多项选择。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Checkbox 多选框";
            this.header1.UseTitleFont = true;
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
            this.p2.Controls.Add(this.checkbox3);
            this.p2.Controls.Add(this.checkbox4);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // checkbox3
            // 
            this.checkbox3.Checked = true;
            this.checkbox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox3.Enabled = false;
            this.checkbox3.Location = new System.Drawing.Point(99, 3);
            this.checkbox3.Name = "checkbox3";
            this.checkbox3.Size = new System.Drawing.Size(90, 32);
            this.checkbox3.TabIndex = 1;
            this.checkbox3.Text = "Checkbox";
            // 
            // checkbox4
            // 
            this.checkbox4.Enabled = false;
            this.checkbox4.Location = new System.Drawing.Point(3, 3);
            this.checkbox4.Name = "checkbox4";
            this.checkbox4.Size = new System.Drawing.Size(90, 32);
            this.checkbox4.TabIndex = 0;
            this.checkbox4.Text = "Checkbox";
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
            this.p1.Controls.Add(this.checkbox5);
            this.p1.Controls.Add(this.checkbox6);
            this.p1.Controls.Add(this.checkbox2);
            this.p1.Controls.Add(this.checkbox1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // checkbox5
            // 
            this.checkbox5.Checked = true;
            this.checkbox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox5.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkbox5.Location = new System.Drawing.Point(291, 3);
            this.checkbox5.Name = "checkbox5";
            this.checkbox5.Size = new System.Drawing.Size(90, 32);
            this.checkbox5.TabIndex = 3;
            this.checkbox5.Text = "Checkbox";
            // 
            // checkbox6
            // 
            this.checkbox6.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkbox6.Location = new System.Drawing.Point(195, 3);
            this.checkbox6.Name = "checkbox6";
            this.checkbox6.Size = new System.Drawing.Size(90, 32);
            this.checkbox6.TabIndex = 2;
            this.checkbox6.Text = "Checkbox";
            // 
            // checkbox2
            // 
            this.checkbox2.Checked = true;
            this.checkbox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox2.Location = new System.Drawing.Point(99, 3);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(90, 32);
            this.checkbox2.TabIndex = 1;
            this.checkbox2.Text = "Checkbox";
            // 
            // checkbox1
            // 
            this.checkbox1.Location = new System.Drawing.Point(3, 3);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(90, 32);
            this.checkbox1.TabIndex = 0;
            this.checkbox1.Text = "Checkbox";
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
            // CheckBoxDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "CheckBoxDemo";
            this.Size = new System.Drawing.Size(750, 451);
            this.panelMain.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Checkbox checkbox2;
        private AntdUI.FlowPanel p2;
        private AntdUI.Checkbox checkbox3;
        private AntdUI.Checkbox checkbox4;
        private AntdUI.Label h2;
        private AntdUI.Checkbox checkbox5;
        private AntdUI.Checkbox checkbox6;
    }
}
