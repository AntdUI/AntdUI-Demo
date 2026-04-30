namespace AntdUIDemo.Views
{
    partial class LabelTimeDemo
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
            this.labelTime1 = new AntdUI.LabelTime();
            this.labelTime2 = new AntdUI.LabelTime();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "显示实时日期时间的文本。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "LabelTime 时间标签";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.p1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 393);
            this.panelMain.TabIndex = 29;
            // 
            // p1
            // 
            this.p1.Controls.Add(this.labelTime1);
            this.p1.Controls.Add(this.labelTime2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 76);
            this.p1.TabIndex = 1;
            // 
            // labelTime1
            // 
            this.labelTime1.BadgeSize = 1F;
            this.labelTime1.BadgeSvg = "FieldTimeOutlined";
            this.labelTime1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTime1.Location = new System.Drawing.Point(309, 3);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.ShowTime = false;
            this.labelTime1.Size = new System.Drawing.Size(300, 70);
            this.labelTime1.TabIndex = 2;
            this.labelTime1.Text = "labelTime1";
            // 
            // labelTime2
            // 
            this.labelTime2.Location = new System.Drawing.Point(3, 3);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(300, 70);
            this.labelTime2.TabIndex = 1;
            this.labelTime2.Text = "labelTime2";
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
            this.h1.TabIndex = 26;
            this.h1.Text = "基本用法";
            // 
            // LabelTimeDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "LabelTimeDemo";
            this.Size = new System.Drawing.Size(750, 467);
            this.panelMain.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel p1;
        private AntdUI.LabelTime labelTime1;
        private AntdUI.LabelTime labelTime2;
    }
}
