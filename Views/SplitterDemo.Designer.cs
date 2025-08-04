namespace AntdUIDemo.Views
{
    partial class SplitterDemo
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
            this.splitter = new AntdUI.Splitter();
            this.button3 = new AntdUI.Button();
            this.button4 = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "自由切分指定区域。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 28;
            this.header1.Text = "Splitter 分隔面板";
            this.header1.UseTitleFont = true;
            // 
            // splitter
            // 
            this.splitter.CollapsePanel = AntdUI.Splitter.ADCollapsePanel.Panel1;
            this.splitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 74);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.button3);
            this.splitter.Panel1MinSize = 0;
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.button4);
            this.splitter.Size = new System.Drawing.Size(750, 209);
            this.splitter.SplitterDistance = 262;
            this.splitter.SplitterSize = 30;
            this.splitter.SplitterWidth = 10;
            this.splitter.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "Button";
            this.button3.Type = AntdUI.TTypeMini.Primary;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(478, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "Button";
            this.button4.Type = AntdUI.TTypeMini.Warn;
            // 
            // SplitterDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.header1);
            this.Name = "SplitterDemo";
            this.Size = new System.Drawing.Size(750, 531);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.Splitter splitter;
        private AntdUI.Button button4;
        private AntdUI.Button button3;
    }
}
