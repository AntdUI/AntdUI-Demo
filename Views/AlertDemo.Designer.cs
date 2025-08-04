namespace AntdUIDemo.Views
{
    partial class AlertDemo
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
            this.alert9 = new AntdUI.Alert();
            this.label6 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.alert12 = new AntdUI.Alert();
            this.label5 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.alert5 = new AntdUI.Alert();
            this.alert6 = new AntdUI.Alert();
            this.alert7 = new AntdUI.Alert();
            this.alert8 = new AntdUI.Alert();
            this.label4 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.alert4 = new AntdUI.Alert();
            this.alert3 = new AntdUI.Alert();
            this.alert2 = new AntdUI.Alert();
            this.alert1 = new AntdUI.Alert();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "警告提示，展现需要关注的信息。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Alert 警告提示";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoScroll = true;
            this.stackPanel1.Controls.Add(this.alert9);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 431);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // alert9
            // 
            this.alert9.BackColor = System.Drawing.Color.Pink;
            this.alert9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert9.Location = new System.Drawing.Point(3, 287);
            this.alert9.Loop = true;
            this.alert9.Name = "alert9";
            this.alert9.Size = new System.Drawing.Size(744, 32);
            this.alert9.TabIndex = 45;
            this.alert9.Text = "I can be a React component, multiple React components, or just some text.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(744, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "轮播";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.alert12);
            this.flowPanel3.Location = new System.Drawing.Point(3, 181);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(744, 70);
            this.flowPanel3.TabIndex = 43;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // alert12
            // 
            this.alert12.BorderWidth = 2F;
            this.alert12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert12.Icon = AntdUI.TType.Success;
            this.alert12.Location = new System.Drawing.Point(3, 3);
            this.alert12.Name = "alert12";
            this.alert12.Size = new System.Drawing.Size(498, 59);
            this.alert12.TabIndex = 0;
            this.alert12.Text = "Success Description Success Description Success Description";
            this.alert12.TextTitle = "Success Text";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(744, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "副文本";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.alert5);
            this.flowPanel1.Controls.Add(this.alert6);
            this.flowPanel1.Controls.Add(this.alert7);
            this.flowPanel1.Controls.Add(this.alert8);
            this.flowPanel1.Location = new System.Drawing.Point(3, 107);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 41;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // alert5
            // 
            this.alert5.BorderWidth = 2F;
            this.alert5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert5.Icon = AntdUI.TType.Error;
            this.alert5.Location = new System.Drawing.Point(381, 3);
            this.alert5.Name = "alert5";
            this.alert5.Size = new System.Drawing.Size(120, 32);
            this.alert5.TabIndex = 3;
            this.alert5.Text = "Error Text";
            // 
            // alert6
            // 
            this.alert6.BorderWidth = 2F;
            this.alert6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert6.Icon = AntdUI.TType.Warn;
            this.alert6.Location = new System.Drawing.Point(255, 3);
            this.alert6.Name = "alert6";
            this.alert6.Size = new System.Drawing.Size(120, 32);
            this.alert6.TabIndex = 2;
            this.alert6.Text = "Warn Text";
            // 
            // alert7
            // 
            this.alert7.BorderWidth = 2F;
            this.alert7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert7.Icon = AntdUI.TType.Info;
            this.alert7.Location = new System.Drawing.Point(129, 3);
            this.alert7.Name = "alert7";
            this.alert7.Size = new System.Drawing.Size(120, 32);
            this.alert7.TabIndex = 1;
            this.alert7.Text = "Info Text";
            // 
            // alert8
            // 
            this.alert8.BorderWidth = 2F;
            this.alert8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert8.Icon = AntdUI.TType.Success;
            this.alert8.Location = new System.Drawing.Point(3, 3);
            this.alert8.Name = "alert8";
            this.alert8.Size = new System.Drawing.Size(120, 32);
            this.alert8.TabIndex = 0;
            this.alert8.Text = "Success Text";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "提示边框";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.alert4);
            this.flowPanel2.Controls.Add(this.alert3);
            this.flowPanel2.Controls.Add(this.alert2);
            this.flowPanel2.Controls.Add(this.alert1);
            this.flowPanel2.Location = new System.Drawing.Point(3, 33);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 39;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // alert4
            // 
            this.alert4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert4.Icon = AntdUI.TType.Error;
            this.alert4.Location = new System.Drawing.Point(381, 3);
            this.alert4.Name = "alert4";
            this.alert4.Size = new System.Drawing.Size(120, 32);
            this.alert4.TabIndex = 3;
            this.alert4.Text = "Error Text";
            // 
            // alert3
            // 
            this.alert3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert3.Icon = AntdUI.TType.Warn;
            this.alert3.Location = new System.Drawing.Point(255, 3);
            this.alert3.Name = "alert3";
            this.alert3.Size = new System.Drawing.Size(120, 32);
            this.alert3.TabIndex = 2;
            this.alert3.Text = "Warn Text";
            // 
            // alert2
            // 
            this.alert2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert2.Icon = AntdUI.TType.Info;
            this.alert2.Location = new System.Drawing.Point(129, 3);
            this.alert2.Name = "alert2";
            this.alert2.Size = new System.Drawing.Size(120, 32);
            this.alert2.TabIndex = 1;
            this.alert2.Text = "Info Text";
            // 
            // alert1
            // 
            this.alert1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert1.Icon = AntdUI.TType.Success;
            this.alert1.Location = new System.Drawing.Point(3, 3);
            this.alert1.Name = "alert1";
            this.alert1.Size = new System.Drawing.Size(120, 32);
            this.alert1.TabIndex = 0;
            this.alert1.Text = "Success Text";
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
            // AlertDemo
            // 
            
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "AlertDemo";
            this.Size = new System.Drawing.Size(750, 505);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Alert alert1;
        private AntdUI.Alert alert4;
        private AntdUI.Alert alert3;
        private AntdUI.Alert alert2;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Alert alert5;
        private AntdUI.Alert alert6;
        private AntdUI.Alert alert7;
        private AntdUI.Alert alert8;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Alert alert12;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Alert alert9;
    }
}
