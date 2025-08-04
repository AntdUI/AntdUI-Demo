namespace AntdUIDemo.Views
{
    partial class CalendarDemo
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
            this.calendar = new AntdUI.Calendar();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.switch_showchinese = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.switch_showtoday = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "按照日历形式展示数据的容器。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Calendar 日历";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.calendar);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 476);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // calendar
            // 
            this.calendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.calendar.Full = true;
            this.calendar.Location = new System.Drawing.Point(3, 71);
            this.calendar.Name = "calendar";
            this.calendar.ShowChinese = true;
            this.calendar.Size = new System.Drawing.Size(744, 376);
            this.calendar.TabIndex = 26;
            this.calendar.Text = "calendar1";
            this.calendar.Value = new System.DateTime(2024, 8, 30, 8, 41, 9, 706);
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.switch_showchinese);
            this.flowPanel1.Controls.Add(this.label4);
            this.flowPanel1.Controls.Add(this.switch_showtoday);
            this.flowPanel1.Controls.Add(this.label6);
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 32);
            this.flowPanel1.TabIndex = 25;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // switch_showchinese
            // 
            this.switch_showchinese.AutoCheck = true;
            this.switch_showchinese.Checked = true;
            this.switch_showchinese.Location = new System.Drawing.Point(381, 3);
            this.switch_showchinese.Name = "switch_showchinese";
            this.switch_showchinese.Size = new System.Drawing.Size(50, 26);
            this.switch_showchinese.TabIndex = 13;
            this.switch_showchinese.Text = "switch1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(220, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "ShowChinese";
            // 
            // switch_showtoday
            // 
            this.switch_showtoday.AutoCheck = true;
            this.switch_showtoday.Checked = true;
            this.switch_showtoday.Location = new System.Drawing.Point(164, 3);
            this.switch_showtoday.Name = "switch_showtoday";
            this.switch_showtoday.Size = new System.Drawing.Size(50, 26);
            this.switch_showtoday.TabIndex = 11;
            this.switch_showtoday.Text = "switch1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "ShowButtonToday";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "基本用法";
            // 
            // CalendarDemo
            // 
            
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "CalendarDemo";
            this.Size = new System.Drawing.Size(750, 550);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.Calendar calendar;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Switch switch_showtoday;
        private AntdUI.Label label6;
        private AntdUI.Switch switch_showchinese;
        private AntdUI.Label label4;
    }
}
