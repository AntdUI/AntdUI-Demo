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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.labelTime1 = new AntdUI.LabelTime();
            this.labelTime2 = new AntdUI.LabelTime();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
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
            this.header1.TabIndex = 28;
            this.header1.Text = "LabelTime 时间标签";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 393);
            this.stackPanel1.TabIndex = 29;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.labelTime1);
            this.flowPanel2.Controls.Add(this.labelTime2);
            this.flowPanel2.Location = new System.Drawing.Point(3, 33);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 76);
            this.flowPanel2.TabIndex = 41;
            this.flowPanel2.Text = "flowPanel2";
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "基本用法";
            // 
            // LabelTimeDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "LabelTimeDemo";
            this.Size = new System.Drawing.Size(750, 467);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.LabelTime labelTime1;
        private AntdUI.LabelTime labelTime2;
    }
}
