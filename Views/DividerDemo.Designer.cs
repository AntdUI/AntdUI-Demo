namespace AntdUIDemo.Views
{
    partial class DividerDemo
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
            this.panel1 = new AntdUI.Panel();
            this.divider_null = new AntdUI.Divider();
            this.divider8 = new AntdUI.Divider();
            this.divider7 = new AntdUI.Divider();
            this.divider2 = new AntdUI.Divider();
            this.divider4 = new AntdUI.Divider();
            this.divider6 = new AntdUI.Divider();
            this.divider5 = new AntdUI.Divider();
            this.divider3 = new AntdUI.Divider();
            this.label4 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "区隔内容的分割线。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.LocalizationDescription = "Divider.Description";
            this.header1.LocalizationText = "Divider.Text";
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Divider 分割线";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.panel1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 444);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.divider_null);
            this.panel1.Controls.Add(this.divider8);
            this.panel1.Controls.Add(this.divider7);
            this.panel1.Controls.Add(this.divider2);
            this.panel1.Controls.Add(this.divider4);
            this.panel1.Controls.Add(this.divider6);
            this.panel1.Controls.Add(this.divider5);
            this.panel1.Controls.Add(this.divider3);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 371);
            this.panel1.TabIndex = 60;
            this.panel1.Text = "panel1";
            // 
            // divider_null
            // 
            this.divider_null.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.divider_null.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider_null.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider_null.Location = new System.Drawing.Point(128, 69);
            this.divider_null.Name = "divider_null";
            this.divider_null.Size = new System.Drawing.Size(616, 23);
            this.divider_null.TabIndex = 78;
            this.divider_null.Text = "";
            // 
            // divider8
            // 
            this.divider8.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.divider8.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider8.LocalizationText = "horizontal";
            this.divider8.Location = new System.Drawing.Point(128, 46);
            this.divider8.Name = "divider8";
            this.divider8.Orientation = AntdUI.TOrientation.Right;
            this.divider8.Size = new System.Drawing.Size(616, 23);
            this.divider8.TabIndex = 77;
            this.divider8.Text = "水平分割线";
            // 
            // divider7
            // 
            this.divider7.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.divider7.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider7.LocalizationText = "horizontal";
            this.divider7.Location = new System.Drawing.Point(128, 23);
            this.divider7.Name = "divider7";
            this.divider7.Orientation = AntdUI.TOrientation.Left;
            this.divider7.Size = new System.Drawing.Size(616, 23);
            this.divider7.TabIndex = 76;
            this.divider7.Text = "水平分割线";
            // 
            // divider2
            // 
            this.divider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider2.LocalizationText = "horizontal";
            this.divider2.Location = new System.Drawing.Point(128, 0);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(616, 23);
            this.divider2.TabIndex = 74;
            this.divider2.Text = "水平分割线";
            // 
            // divider4
            // 
            this.divider4.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.divider4.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider4.Location = new System.Drawing.Point(96, 0);
            this.divider4.Name = "divider4";
            this.divider4.Size = new System.Drawing.Size(32, 371);
            this.divider4.TabIndex = 73;
            this.divider4.Vertical = true;
            // 
            // divider6
            // 
            this.divider6.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.divider6.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider6.LocalizationText = "vertical";
            this.divider6.Location = new System.Drawing.Point(64, 0);
            this.divider6.Name = "divider6";
            this.divider6.Orientation = AntdUI.TOrientation.Right;
            this.divider6.Size = new System.Drawing.Size(32, 371);
            this.divider6.TabIndex = 72;
            this.divider6.Text = "垂直分割线";
            this.divider6.Vertical = true;
            // 
            // divider5
            // 
            this.divider5.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.divider5.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider5.LocalizationText = "vertical";
            this.divider5.Location = new System.Drawing.Point(32, 0);
            this.divider5.Name = "divider5";
            this.divider5.Orientation = AntdUI.TOrientation.Left;
            this.divider5.Size = new System.Drawing.Size(32, 371);
            this.divider5.TabIndex = 71;
            this.divider5.Text = "垂直分割线";
            this.divider5.Vertical = true;
            // 
            // divider3
            // 
            this.divider3.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divider3.LocalizationText = "vertical";
            this.divider3.Location = new System.Drawing.Point(0, 0);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(32, 371);
            this.divider3.TabIndex = 70;
            this.divider3.Text = "垂直分割线";
            this.divider3.Vertical = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.LocalizationText = "basicusage";
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "基本用法";
            // 
            // DividerDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "DividerDemo";
            this.Size = new System.Drawing.Size(750, 518);
            this.stackPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label4;
        private AntdUI.Panel panel1;
        private AntdUI.Divider divider4;
        private AntdUI.Divider divider6;
        private AntdUI.Divider divider5;
        private AntdUI.Divider divider3;
        private AntdUI.Divider divider8;
        private AntdUI.Divider divider7;
        private AntdUI.Divider divider2;
        private AntdUI.Divider divider_null;
    }
}
