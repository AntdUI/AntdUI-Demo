namespace AntdUIDemo.Views
{
    partial class LabelDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelDemo));
            this.header1 = new AntdUI.PageHeader();
            this.panelMain = new AntdUI.In.Panel();
            this.p3 = new AntdUI.FlowPanel();
            this.label8 = new AntdUI.Label();
            this.h3 = new AntdUI.Label();
            this.p2 = new AntdUI.FlowPanel();
            this.label10 = new AntdUI.Label();
            this.label11 = new AntdUI.Label();
            this.h2 = new AntdUI.Label();
            this.p1 = new AntdUI.FlowPanel();
            this.label6 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "字符标签。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Label 标签";
            this.header1.UseTitleFont = true;
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
            this.panelMain.Size = new System.Drawing.Size(750, 390);
            this.panelMain.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Controls.Add(this.label8);
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Gap = 6;
            this.p3.Location = new System.Drawing.Point(0, 148);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(750, 38);
            this.p3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.ColorExtend = "135,#FF0000,#00FF00";
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "渐变标签";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.h3.TabIndex = 33;
            this.h3.Text = "文字渐变";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.label10);
            this.p2.Controls.Add(this.label11);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Gap = 6;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(750, 38);
            this.p2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label10.IconRatio = 0.6F;
            this.label10.Location = new System.Drawing.Point(135, 3);
            this.label10.Name = "label10";
            this.label10.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.label10.PrefixSvg = resources.GetString("label10.PrefixSvg");
            this.label10.Size = new System.Drawing.Size(120, 32);
            this.label10.SuffixColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.label10.SuffixSvg = resources.GetString("label10.SuffixSvg");
            this.label10.TabIndex = 2;
            this.label10.Text = "图标";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Prefix = "♥";
            this.label11.PrefixColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.label11.Size = new System.Drawing.Size(120, 32);
            this.label11.Suffix = "♥";
            this.label11.SuffixColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.label11.TabIndex = 1;
            this.label11.Text = "文本";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.h2.TabIndex = 31;
            this.h2.Text = "前/后标签";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.label6);
            this.p1.Controls.Add(this.label5);
            this.p1.Controls.Add(this.label4);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Gap = 6;
            this.p1.Location = new System.Drawing.Point(0, 24);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 38);
            this.p1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(267, 3);
            this.label6.Name = "label6";
            this.label6.Shadow = 3;
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "标签阴影";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(135, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "标签颜色";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "常规标签";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.h1.TabIndex = 29;
            this.h1.Text = "基本用法";
            // 
            // LabelDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "LabelDemo";
            this.Size = new System.Drawing.Size(750, 464);
            this.panelMain.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.FlowPanel p1;
        private AntdUI.Label h1;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel p2;
        private AntdUI.Label label10;
        private AntdUI.Label label11;
        private AntdUI.FlowPanel p3;
        private AntdUI.Label label8;
        private AntdUI.Label h3;
    }
}
