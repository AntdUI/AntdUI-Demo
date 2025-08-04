namespace AntdUIDemo.Views
{
    partial class CheckBoxDemo
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
            this.checkbox3 = new AntdUI.Checkbox();
            this.checkbox4 = new AntdUI.Checkbox();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.checkbox5 = new AntdUI.Checkbox();
            this.checkbox6 = new AntdUI.Checkbox();
            this.checkbox2 = new AntdUI.Checkbox();
            this.checkbox1 = new AntdUI.Checkbox();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "收集用户的多项选择。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Checkbox 多选框";
            this.header1.UseTitleFont = true;
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
            this.flowPanel2.Controls.Add(this.checkbox3);
            this.flowPanel2.Controls.Add(this.checkbox4);
            this.flowPanel2.Location = new System.Drawing.Point(3, 107);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 11;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // checkbox3
            // 
            this.checkbox3.AutoCheck = true;
            this.checkbox3.Checked = true;
            this.checkbox3.Enabled = false;
            this.checkbox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox3.Location = new System.Drawing.Point(99, 3);
            this.checkbox3.Name = "checkbox3";
            this.checkbox3.Size = new System.Drawing.Size(90, 32);
            this.checkbox3.TabIndex = 1;
            this.checkbox3.Text = "Checkbox";
            // 
            // checkbox4
            // 
            this.checkbox4.AutoCheck = true;
            this.checkbox4.Enabled = false;
            this.checkbox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox4.Location = new System.Drawing.Point(3, 3);
            this.checkbox4.Name = "checkbox4";
            this.checkbox4.Size = new System.Drawing.Size(90, 32);
            this.checkbox4.TabIndex = 0;
            this.checkbox4.Text = "Checkbox";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "禁用状态";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.checkbox5);
            this.flowPanel1.Controls.Add(this.checkbox6);
            this.flowPanel1.Controls.Add(this.checkbox2);
            this.flowPanel1.Controls.Add(this.checkbox1);
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 9;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // checkbox5
            // 
            this.checkbox5.AutoCheck = true;
            this.checkbox5.Checked = true;
            this.checkbox5.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkbox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox5.Location = new System.Drawing.Point(291, 3);
            this.checkbox5.Name = "checkbox5";
            this.checkbox5.Size = new System.Drawing.Size(90, 32);
            this.checkbox5.TabIndex = 3;
            this.checkbox5.Text = "Checkbox";
            // 
            // checkbox6
            // 
            this.checkbox6.AutoCheck = true;
            this.checkbox6.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkbox6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox6.Location = new System.Drawing.Point(195, 3);
            this.checkbox6.Name = "checkbox6";
            this.checkbox6.Size = new System.Drawing.Size(90, 32);
            this.checkbox6.TabIndex = 2;
            this.checkbox6.Text = "Checkbox";
            // 
            // checkbox2
            // 
            this.checkbox2.AutoCheck = true;
            this.checkbox2.Checked = true;
            this.checkbox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox2.Location = new System.Drawing.Point(99, 3);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(90, 32);
            this.checkbox2.TabIndex = 1;
            this.checkbox2.Text = "Checkbox";
            // 
            // checkbox1
            // 
            this.checkbox1.AutoCheck = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox1.Location = new System.Drawing.Point(3, 3);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(90, 32);
            this.checkbox1.TabIndex = 0;
            this.checkbox1.Text = "Checkbox";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "基本用法";
            // 
            // CheckBoxDemo
            // 
            
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "CheckBoxDemo";
            this.Size = new System.Drawing.Size(750, 451);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Checkbox checkbox2;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Checkbox checkbox3;
        private AntdUI.Checkbox checkbox4;
        private AntdUI.Label label4;
        private AntdUI.Checkbox checkbox5;
        private AntdUI.Checkbox checkbox6;
    }
}
