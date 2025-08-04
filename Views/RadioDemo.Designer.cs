namespace AntdUIDemo.Views
{
    partial class RadioDemo
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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.radio3 = new AntdUI.Radio();
            this.radio4 = new AntdUI.Radio();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.radio2 = new AntdUI.Radio();
            this.radio1 = new AntdUI.Radio();
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
            this.stackPanel1.Size = new System.Drawing.Size(750, 377);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.radio3);
            this.flowPanel2.Controls.Add(this.radio4);
            this.flowPanel2.Location = new System.Drawing.Point(3, 107);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 14;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // radio3
            // 
            this.radio3.AutoCheck = true;
            this.radio3.Checked = true;
            this.radio3.Enabled = false;
            this.radio3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio3.Location = new System.Drawing.Point(99, 3);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(90, 32);
            this.radio3.TabIndex = 1;
            this.radio3.Text = "Radio";
            // 
            // radio4
            // 
            this.radio4.AutoCheck = true;
            this.radio4.Enabled = false;
            this.radio4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio4.Location = new System.Drawing.Point(3, 3);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(90, 32);
            this.radio4.TabIndex = 0;
            this.radio4.Text = "Radio";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "禁用状态";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.radio2);
            this.flowPanel1.Controls.Add(this.radio1);
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 12;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // radio2
            // 
            this.radio2.AutoCheck = true;
            this.radio2.Checked = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio2.Location = new System.Drawing.Point(99, 3);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(90, 32);
            this.radio2.TabIndex = 1;
            this.radio2.Text = "Radio";
            // 
            // radio1
            // 
            this.radio1.AutoCheck = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio1.Location = new System.Drawing.Point(3, 3);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(90, 32);
            this.radio1.TabIndex = 0;
            this.radio1.Text = "Radio";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "基本类型";
            // 
            // header1
            // 
            this.header1.Description = "用于在多个备选项中选中单个状态。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Radio 单选框";
            this.header1.UseTitleFont = true;
            // 
            // RadioDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "RadioDemo";
            this.Size = new System.Drawing.Size(750, 451);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Label label3;
        private AntdUI.Radio radio1;
        private AntdUI.Radio radio2;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Radio radio3;
        private AntdUI.Radio radio4;
        private AntdUI.Label label4;
        private AntdUI.PageHeader header1;
    }
}
