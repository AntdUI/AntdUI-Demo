namespace AntdUIDemo.Views
{
    partial class TimelineDemo
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
            AntdUI.TimelineItem timelineItem1 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem2 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem3 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem4 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem5 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem6 = new AntdUI.TimelineItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelineDemo));
            this.timeline1 = new AntdUI.Timeline();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.SuspendLayout();
            // 
            // timeline1
            // 
            this.timeline1.Dock = System.Windows.Forms.DockStyle.Fill;
            timelineItem1.Description = "这是一段描述";
            timelineItem1.Text = "Create a services site 2015-09-01";
            timelineItem1.Type = AntdUI.TTypeMini.Success;
            timelineItem2.Description = "这是一段描述";
            timelineItem2.Text = "Create a services site 2015-09-01";
            timelineItem2.Type = AntdUI.TTypeMini.Warn;
            timelineItem3.Description = "这是一段描述";
            timelineItem3.Text = "Solve initial network problems 1";
            timelineItem3.Type = AntdUI.TTypeMini.Error;
            timelineItem4.Description = "这是一段描述";
            timelineItem4.Text = "Technical testing 1";
            timelineItem5.Description = "";
            timelineItem5.Text = "Solve initial network problems 1";
            timelineItem5.Type = AntdUI.TTypeMini.Default;
            timelineItem6.IconSvg = resources.GetString("timelineItem6.IconSvg");
            timelineItem6.Text = "自定义图标\r\n自定义图标";
            timelineItem6.Type = AntdUI.TTypeMini.Info;
            this.timeline1.Items.Add(timelineItem1);
            this.timeline1.Items.Add(timelineItem2);
            this.timeline1.Items.Add(timelineItem3);
            this.timeline1.Items.Add(timelineItem4);
            this.timeline1.Items.Add(timelineItem5);
            this.timeline1.Items.Add(timelineItem6);
            this.timeline1.Location = new System.Drawing.Point(0, 98);
            this.timeline1.Name = "timeline1";
            this.timeline1.Size = new System.Drawing.Size(750, 411);
            this.timeline1.TabIndex = 1;
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
            // header1
            // 
            this.header1.Description = "垂直展示的时间流信息。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Timeline 时间轴";
            this.header1.UseTitleFont = true;
            // 
            // TimelineDemo
            // 
            this.Controls.Add(this.timeline1);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.header1);
            this.Name = "TimelineDemo";
            this.Size = new System.Drawing.Size(750, 509);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label h1;
        private AntdUI.Timeline timeline1;
        private AntdUI.PageHeader header1;
    }
}
