namespace AntdUIDemo.Views
{
    partial class DatePickerRangeDemo
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
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.datePickerRange = new AntdUI.DatePickerRange();
            this.label3 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.datePickerRange1 = new AntdUI.DatePickerRange();
            this.label4 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "输入或选择范围日期的控件。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "DatePickerRange 日期范围选择器";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 352);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.datePickerRange);
            this.flowPanel1.Location = new System.Drawing.Point(3, 107);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 19;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // datePickerRange
            // 
            this.datePickerRange.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datePickerRange.Location = new System.Drawing.Point(3, 3);
            this.datePickerRange.Name = "datePickerRange";
            this.datePickerRange.Presets.AddRange(new object[] {
            "本周",
            "上周",
            "本月",
            "上月",
            "本年",
            "去年"});
            this.datePickerRange.Size = new System.Drawing.Size(300, 32);
            this.datePickerRange.TabIndex = 0;
            this.datePickerRange.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "预置菜单";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.datePickerRange1);
            this.flowPanel2.Location = new System.Drawing.Point(3, 33);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 17;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // datePickerRange1
            // 
            this.datePickerRange1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datePickerRange1.Location = new System.Drawing.Point(3, 3);
            this.datePickerRange1.Name = "datePickerRange1";
            this.datePickerRange1.PlaceholderEnd = "结束日期";
            this.datePickerRange1.PlaceholderStart = "开始日期";
            this.datePickerRange1.Size = new System.Drawing.Size(300, 32);
            this.datePickerRange1.TabIndex = 0;
            this.datePickerRange1.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "基本用法";
            // 
            // DatePickerRangeDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "DatePickerRangeDemo";
            this.Size = new System.Drawing.Size(750, 426);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.DatePickerRange datePickerRange;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.DatePickerRange datePickerRange1;
        private AntdUI.Label label4;
    }
}
