namespace AntdUIDemo.Views
{
    partial class UploadDraggerDemo
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
            this.uploadDragger = new AntdUI.UploadDragger();
            this.label3 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.uploadDragger);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 468);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // uploadDragger
            // 
            this.uploadDragger.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.uploadDragger.Location = new System.Drawing.Point(3, 33);
            this.uploadDragger.Name = "uploadDragger";
            this.uploadDragger.Size = new System.Drawing.Size(744, 155);
            this.uploadDragger.TabIndex = 36;
            this.uploadDragger.Text = "Click or drag file to this area to upload";
            this.uploadDragger.TextDesc = "Support for a single or bulk upload. Strictly prohibited from uploading company d" +
    "ata or other banned files.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "基本用法";
            // 
            // header1
            // 
            this.header1.Description = "文件选择上传和拖拽上传控件。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "UploadDragger 上传";
            this.header1.UseTitleFont = true;
            // 
            // UploadDraggerDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "UploadDraggerDemo";
            this.Size = new System.Drawing.Size(750, 542);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.UploadDragger uploadDragger;
        private AntdUI.PageHeader header1;
    }
}
