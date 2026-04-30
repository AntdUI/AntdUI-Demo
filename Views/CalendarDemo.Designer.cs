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
            this.calendar = new AntdUI.Calendar();
            this.panelTop = new AntdUI.In.Panel();
            this.switch_showchinese = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.switch_showtoday = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.h1 = new AntdUI.Label();
            this.panelTop.SuspendLayout();
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
            this.header1.TabIndex = 0;
            this.header1.Text = "Calendar 日历";
            this.header1.UseTitleFont = true;
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.calendar.Full = true;
            this.calendar.Location = new System.Drawing.Point(0, 130);
            this.calendar.Name = "calendar";
            this.calendar.ShowChinese = true;
            this.calendar.Size = new System.Drawing.Size(750, 420);
            this.calendar.TabIndex = 2;
            this.calendar.Text = "calendar1";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.switch_showchinese);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.switch_showtoday);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 98);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 32);
            this.panelTop.TabIndex = 1;
            // 
            // switch_showchinese
            // 
            this.switch_showchinese.Checked = true;
            this.switch_showchinese.Location = new System.Drawing.Point(381, 3);
            this.switch_showchinese.Name = "switch_showchinese";
            this.switch_showchinese.Size = new System.Drawing.Size(50, 26);
            this.switch_showchinese.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(220, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "ShowChinese";
            // 
            // switch_showtoday
            // 
            this.switch_showtoday.Checked = true;
            this.switch_showtoday.Location = new System.Drawing.Point(164, 3);
            this.switch_showtoday.Name = "switch_showtoday";
            this.switch_showtoday.Size = new System.Drawing.Size(50, 26);
            this.switch_showtoday.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "ShowButtonToday";
            // 
            // h1
            // 
            this.h1.Dock = System.Windows.Forms.DockStyle.Top;
            this.h1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h1.Location = new System.Drawing.Point(0, 74);
            this.h1.Name = "h1";
            this.h1.PrefixColour = AntdUI.Colour.Primary;
            this.h1.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h1.Size = new System.Drawing.Size(750, 24);
            this.h1.TabIndex = 0;
            this.h1.Text = "基本用法";
            // 
            // CalendarDemo
            // 
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.header1);
            this.Name = "CalendarDemo";
            this.Size = new System.Drawing.Size(750, 550);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.Label h1;
        private AntdUI.Calendar calendar;
        private AntdUI.In.Panel panelTop;
        private AntdUI.Switch switch_showtoday;
        private AntdUI.Label label6;
        private AntdUI.Switch switch_showchinese;
        private AntdUI.Label label4;
    }
}
