namespace AntdUIDemo.Views
{
    partial class SliderRangeDemo
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
            AntdUI.SliderMarkItem sliderMarkItem1 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem2 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem3 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem4 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem5 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem6 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem7 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem8 = new AntdUI.SliderMarkItem();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.sliderRange6 = new AntdUI.SliderRange();
            this.sliderRange5 = new AntdUI.SliderRange();
            this.sliderRange4 = new AntdUI.SliderRange();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.sliderRange3 = new AntdUI.SliderRange();
            this.sliderRange2 = new AntdUI.SliderRange();
            this.sliderRange1 = new AntdUI.SliderRange();
            this.label3 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 404);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.sliderRange6);
            this.flowPanel2.Controls.Add(this.sliderRange5);
            this.flowPanel2.Controls.Add(this.sliderRange4);
            this.flowPanel2.Gap = 6;
            this.flowPanel2.Location = new System.Drawing.Point(3, 107);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 61);
            this.flowPanel2.TabIndex = 24;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // sliderRange6
            // 
            this.sliderRange6.Location = new System.Drawing.Point(417, 3);
            sliderMarkItem1.Fore = System.Drawing.Color.Orange;
            sliderMarkItem1.Text = "上海";
            sliderMarkItem1.Value = 2;
            sliderMarkItem2.Text = "北京";
            sliderMarkItem2.Value = 8;
            this.sliderRange6.Marks.Add(sliderMarkItem1);
            this.sliderRange6.Marks.Add(sliderMarkItem2);
            this.sliderRange6.MaxValue = 10;
            this.sliderRange6.Name = "sliderRange6";
            this.sliderRange6.ShowValue = true;
            this.sliderRange6.Size = new System.Drawing.Size(195, 55);
            this.sliderRange6.TabIndex = 3;
            this.sliderRange6.Text = "sliderRange6";
            this.sliderRange6.Value = 2;
            this.sliderRange6.Value2 = 8;
            // 
            // sliderRange5
            // 
            this.sliderRange5.Location = new System.Drawing.Point(210, 3);
            sliderMarkItem3.Text = "2℃";
            sliderMarkItem3.Value = 2;
            sliderMarkItem4.Text = "5℃";
            sliderMarkItem4.Value = 5;
            sliderMarkItem5.Text = "8℃";
            sliderMarkItem5.Value = 8;
            this.sliderRange5.Marks.Add(sliderMarkItem3);
            this.sliderRange5.Marks.Add(sliderMarkItem4);
            this.sliderRange5.Marks.Add(sliderMarkItem5);
            this.sliderRange5.MaxValue = 10;
            this.sliderRange5.Name = "sliderRange5";
            this.sliderRange5.ShowValue = true;
            this.sliderRange5.Size = new System.Drawing.Size(195, 55);
            this.sliderRange5.TabIndex = 2;
            this.sliderRange5.Text = "sliderRange5";
            this.sliderRange5.Value2 = 6;
            // 
            // sliderRange4
            // 
            this.sliderRange4.Location = new System.Drawing.Point(3, 3);
            sliderMarkItem6.Value = 20;
            sliderMarkItem7.Value = 50;
            sliderMarkItem8.Value = 75;
            this.sliderRange4.Marks.Add(sliderMarkItem6);
            this.sliderRange4.Marks.Add(sliderMarkItem7);
            this.sliderRange4.Marks.Add(sliderMarkItem8);
            this.sliderRange4.Name = "sliderRange4";
            this.sliderRange4.Size = new System.Drawing.Size(195, 55);
            this.sliderRange4.TabIndex = 1;
            this.sliderRange4.Text = "sliderRange4";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "固定点";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.sliderRange3);
            this.flowPanel1.Controls.Add(this.sliderRange2);
            this.flowPanel1.Controls.Add(this.sliderRange1);
            this.flowPanel1.Gap = 6;
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 22;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // sliderRange3
            // 
            this.sliderRange3.Location = new System.Drawing.Point(417, 3);
            this.sliderRange3.MaxValue = 10;
            this.sliderRange3.Name = "sliderRange3";
            this.sliderRange3.ShowValue = true;
            this.sliderRange3.Size = new System.Drawing.Size(195, 23);
            this.sliderRange3.TabIndex = 2;
            this.sliderRange3.Text = "sliderRange3";
            this.sliderRange3.Value = 5;
            this.sliderRange3.Value2 = 1;
            // 
            // sliderRange2
            // 
            this.sliderRange2.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.sliderRange2.FillActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.sliderRange2.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(34)))));
            this.sliderRange2.Location = new System.Drawing.Point(210, 3);
            this.sliderRange2.Name = "sliderRange2";
            this.sliderRange2.ShowValue = true;
            this.sliderRange2.Size = new System.Drawing.Size(195, 23);
            this.sliderRange2.TabIndex = 1;
            this.sliderRange2.Text = "sliderRange2";
            this.sliderRange2.Value = 50;
            // 
            // sliderRange1
            // 
            this.sliderRange1.Location = new System.Drawing.Point(3, 3);
            this.sliderRange1.Name = "sliderRange1";
            this.sliderRange1.Size = new System.Drawing.Size(195, 23);
            this.sliderRange1.TabIndex = 0;
            this.sliderRange1.Text = "sliderRange1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "基本用法";
            // 
            // header1
            // 
            this.header1.Description = "滑动型范围输入器，展示可选范围。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "SliderRange 滑动范围输入条";
            this.header1.UseTitleFont = true;
            // 
            // SliderRangeDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "SliderRangeDemo";
            this.Size = new System.Drawing.Size(750, 478);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.SliderRange sliderRange3;
        private AntdUI.SliderRange sliderRange2;
        private AntdUI.SliderRange sliderRange1;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.SliderRange sliderRange4;
        private AntdUI.SliderRange sliderRange5;
        private AntdUI.SliderRange sliderRange6;
        private AntdUI.PageHeader header1;
    }
}
