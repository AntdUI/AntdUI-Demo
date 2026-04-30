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
            this.panel1 = new AntdUI.In.Panel();
            this.divider_null = new AntdUI.Divider();
            this.divider8 = new AntdUI.Divider();
            this.divider7 = new AntdUI.Divider();
            this.divider2 = new AntdUI.Divider();
            this.divider4 = new AntdUI.Divider();
            this.divider6 = new AntdUI.Divider();
            this.divider5 = new AntdUI.Divider();
            this.divider3 = new AntdUI.Divider();
            this.h1 = new AntdUI.Label();
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
            this.header1.TabIndex = 0;
            this.header1.Text = "Divider 分割线";
            this.header1.UseTitleFont = true;
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 420);
            this.panel1.TabIndex = 1;
            // 
            // divider_null
            // 
            this.divider_null.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.divider_null.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider_null.Location = new System.Drawing.Point(128, 69);
            this.divider_null.Name = "divider_null";
            this.divider_null.Size = new System.Drawing.Size(622, 23);
            this.divider_null.TabIndex = 0;
            // 
            // divider8
            // 
            this.divider8.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.divider8.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider8.LocalizationText = "horizontal";
            this.divider8.Location = new System.Drawing.Point(128, 46);
            this.divider8.Name = "divider8";
            this.divider8.Orientation = AntdUI.TOrientation.Right;
            this.divider8.Size = new System.Drawing.Size(622, 23);
            this.divider8.TabIndex = 0;
            this.divider8.Text = "水平分割线";
            // 
            // divider7
            // 
            this.divider7.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.divider7.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider7.LocalizationText = "horizontal";
            this.divider7.Location = new System.Drawing.Point(128, 23);
            this.divider7.Name = "divider7";
            this.divider7.Orientation = AntdUI.TOrientation.Left;
            this.divider7.Size = new System.Drawing.Size(622, 23);
            this.divider7.TabIndex = 0;
            this.divider7.Text = "水平分割线";
            // 
            // divider2
            // 
            this.divider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider2.LocalizationText = "horizontal";
            this.divider2.Location = new System.Drawing.Point(128, 0);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(622, 23);
            this.divider2.TabIndex = 0;
            this.divider2.Text = "水平分割线";
            // 
            // divider4
            // 
            this.divider4.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.divider4.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider4.Location = new System.Drawing.Point(96, 0);
            this.divider4.Name = "divider4";
            this.divider4.Size = new System.Drawing.Size(32, 420);
            this.divider4.TabIndex = 0;
            this.divider4.Vertical = true;
            // 
            // divider6
            // 
            this.divider6.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.divider6.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider6.LocalizationText = "vertical";
            this.divider6.Location = new System.Drawing.Point(64, 0);
            this.divider6.Name = "divider6";
            this.divider6.Orientation = AntdUI.TOrientation.Right;
            this.divider6.Size = new System.Drawing.Size(32, 420);
            this.divider6.TabIndex = 0;
            this.divider6.Text = "垂直分割线";
            this.divider6.Vertical = true;
            // 
            // divider5
            // 
            this.divider5.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.divider5.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider5.LocalizationText = "vertical";
            this.divider5.Location = new System.Drawing.Point(32, 0);
            this.divider5.Name = "divider5";
            this.divider5.Orientation = AntdUI.TOrientation.Left;
            this.divider5.Size = new System.Drawing.Size(32, 420);
            this.divider5.TabIndex = 0;
            this.divider5.Text = "垂直分割线";
            this.divider5.Vertical = true;
            // 
            // divider3
            // 
            this.divider3.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider3.LocalizationText = "vertical";
            this.divider3.Location = new System.Drawing.Point(0, 0);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(32, 420);
            this.divider3.TabIndex = 0;
            this.divider3.Text = "垂直分割线";
            this.divider3.Vertical = true;
            // 
            // h1
            // 
            this.h1.Dock = System.Windows.Forms.DockStyle.Top;
            this.h1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h1.LocalizationText = "basicusage";
            this.h1.Location = new System.Drawing.Point(0, 74);
            this.h1.Name = "h1";
            this.h1.PrefixColour = AntdUI.Colour.Primary;
            this.h1.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h1.Size = new System.Drawing.Size(750, 24);
            this.h1.TabIndex = 0;
            this.h1.Text = "基本用法";
            // 
            // DividerDemo
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.header1);
            this.Name = "DividerDemo";
            this.Size = new System.Drawing.Size(750, 518);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.Label h1;
        private AntdUI.In.Panel panel1;
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
