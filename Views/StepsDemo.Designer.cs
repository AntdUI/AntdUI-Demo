namespace AntdUIDemo.Views
{
    partial class StepsDemo
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
            AntdUI.StepsItem stepsItem1 = new AntdUI.StepsItem();
            AntdUI.StepsItem stepsItem2 = new AntdUI.StepsItem();
            AntdUI.StepsItem stepsItem3 = new AntdUI.StepsItem();
            AntdUI.StepsItem stepsItem4 = new AntdUI.StepsItem();
            AntdUI.StepsItem stepsItem5 = new AntdUI.StepsItem();
            AntdUI.StepsItem stepsItem6 = new AntdUI.StepsItem();
            this.stepsv = new AntdUI.Steps();
            this.steph = new AntdUI.Steps();
            this.p1 = new AntdUI.StackPanel();
            this.select_Status = new AntdUI.Select();
            this.label3 = new AntdUI.Label();
            this.input_current = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stepsv
            // 
            this.stepsv.Current = 1;
            this.stepsv.Dock = System.Windows.Forms.DockStyle.Fill;
            stepsItem1.Description = "This is a description.";
            stepsItem1.Title = "Finished";
            stepsItem2.Description = "This is a description.";
            stepsItem2.SubTitle = "Left 00:00:08";
            stepsItem2.Title = "In Progress";
            stepsItem3.Description = "This is a description.";
            stepsItem3.Title = "Waiting";
            this.stepsv.Items.Add(stepsItem1);
            this.stepsv.Items.Add(stepsItem2);
            this.stepsv.Items.Add(stepsItem3);
            this.stepsv.Location = new System.Drawing.Point(0, 202);
            this.stepsv.Name = "stepsv";
            this.stepsv.Padding = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.stepsv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stepsv.Size = new System.Drawing.Size(750, 306);
            this.stepsv.TabIndex = 2;
            this.stepsv.Text = "steps1";
            this.stepsv.Vertical = true;
            // 
            // steph
            // 
            this.steph.Current = 1;
            this.steph.Dock = System.Windows.Forms.DockStyle.Top;
            stepsItem4.Description = "This is a description.";
            stepsItem4.Title = "Finished";
            stepsItem5.Description = "This is a description.";
            stepsItem5.SubTitle = "Left 00:00:08";
            stepsItem5.Title = "In Progress";
            stepsItem6.Description = "This is a description.";
            stepsItem6.Title = "Waiting";
            this.steph.Items.Add(stepsItem4);
            this.steph.Items.Add(stepsItem5);
            this.steph.Items.Add(stepsItem6);
            this.steph.Location = new System.Drawing.Point(0, 130);
            this.steph.Name = "steph";
            this.steph.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.steph.Size = new System.Drawing.Size(750, 72);
            this.steph.TabIndex = 1;
            this.steph.Text = "steps1";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.select_Status);
            this.p1.Controls.Add(this.label3);
            this.p1.Controls.Add(this.input_current);
            this.p1.Controls.Add(this.label8);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 98);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 32);
            this.p1.TabIndex = 1;
            // 
            // select_Status
            // 
            this.select_Status.List = true;
            this.select_Status.Location = new System.Drawing.Point(280, 3);
            this.select_Status.Name = "select_Status";
            this.select_Status.Size = new System.Drawing.Size(90, 26);
            this.select_Status.TabIndex = 2;
            this.select_Status.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(182, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // input_current
            // 
            this.input_current.Location = new System.Drawing.Point(101, 3);
            this.input_current.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.input_current.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_current.Name = "input_current";
            this.input_current.Size = new System.Drawing.Size(75, 26);
            this.input_current.TabIndex = 1;
            this.input_current.Text = "1";
            this.input_current.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_current.WaveSize = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current";
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
            this.h1.Text = "控件配置";
            // 
            // header1
            // 
            this.header1.Description = "引导用户按照流程完成任务的导航条。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Steps 步骤条";
            this.header1.UseTitleFont = true;
            // 
            // StepsDemo
            // 
            this.Controls.Add(this.stepsv);
            this.Controls.Add(this.steph);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.header1);
            this.Name = "StepsDemo";
            this.Size = new System.Drawing.Size(750, 508);
            this.p1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label h1;
        private AntdUI.StackPanel p1;
        private AntdUI.Select select_Status;
        private AntdUI.Label label3;
        private AntdUI.InputNumber input_current;
        private AntdUI.Label label8;
        private AntdUI.Steps stepsv;
        private AntdUI.Steps steph;
        private AntdUI.PageHeader header1;
    }
}
