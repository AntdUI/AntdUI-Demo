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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.stepsv = new AntdUI.Steps();
            this.steph = new AntdUI.Steps();
            this.stackPanel2 = new AntdUI.StackPanel();
            this.select_Status = new AntdUI.Select();
            this.label3 = new AntdUI.Label();
            this.input_current = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.label12 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stepsv);
            this.stackPanel1.Controls.Add(this.steph);
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Controls.Add(this.label12);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 434);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stepsv
            // 
            this.stepsv.Current = 1;
            this.stepsv.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.stepsv.Location = new System.Drawing.Point(36, 149);
            this.stepsv.Margin = new System.Windows.Forms.Padding(36, 3, 36, 3);
            this.stepsv.Name = "stepsv";
            this.stepsv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stepsv.Size = new System.Drawing.Size(678, 244);
            this.stepsv.TabIndex = 48;
            this.stepsv.Text = "steps1";
            this.stepsv.Vertical = true;
            // 
            // steph
            // 
            this.steph.Current = 1;
            this.steph.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.steph.Location = new System.Drawing.Point(3, 71);
            this.steph.Name = "steph";
            this.steph.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.steph.Size = new System.Drawing.Size(744, 72);
            this.steph.TabIndex = 47;
            this.steph.Text = "steps1";
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.select_Status);
            this.stackPanel2.Controls.Add(this.label3);
            this.stackPanel2.Controls.Add(this.input_current);
            this.stackPanel2.Controls.Add(this.label8);
            this.stackPanel2.Location = new System.Drawing.Point(3, 33);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(744, 32);
            this.stackPanel2.TabIndex = 44;
            this.stackPanel2.Text = "stackPanel2";
            // 
            // select_Status
            // 
            this.select_Status.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.select_Status.List = true;
            this.select_Status.Location = new System.Drawing.Point(280, 3);
            this.select_Status.Name = "select_Status";
            this.select_Status.Size = new System.Drawing.Size(90, 26);
            this.select_Status.TabIndex = 13;
            this.select_Status.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(182, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // input_current
            // 
            this.input_current.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
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
            this.input_current.TabIndex = 11;
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
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Current";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(744, 24);
            this.label12.TabIndex = 42;
            this.label12.Text = "控件配置";
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
            this.header1.TabIndex = 27;
            this.header1.Text = "Steps 步骤条";
            this.header1.UseTitleFont = true;
            // 
            // StepsDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "StepsDemo";
            this.Size = new System.Drawing.Size(750, 508);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label12;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Select select_Status;
        private AntdUI.Label label3;
        private AntdUI.InputNumber input_current;
        private AntdUI.Label label8;
        private AntdUI.Steps stepsv;
        private AntdUI.Steps steph;
        private AntdUI.PageHeader header1;
    }
}
