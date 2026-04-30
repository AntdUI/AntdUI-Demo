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
            this.panelMain = new AntdUI.In.Panel();
            this.uploadDragger = new AntdUI.UploadDragger();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.uploadDragger);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 468);
            this.panelMain.TabIndex = 0;
            // 
            // uploadDragger
            // 
            this.uploadDragger.Dock = System.Windows.Forms.DockStyle.Top;
            this.uploadDragger.Location = new System.Drawing.Point(0, 24);
            this.uploadDragger.Name = "uploadDragger";
            this.uploadDragger.Size = new System.Drawing.Size(750, 155);
            this.uploadDragger.TabIndex = 1;
            this.uploadDragger.Text = "Click or drag file to this area to upload";
            this.uploadDragger.TextDesc = "Support for a single or bulk upload. Strictly prohibited from uploading company d" +
    "ata or other banned files.";
            // 
            // h1
            // 
            this.h1.Dock = System.Windows.Forms.DockStyle.Top;
            this.h1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h1.Location = new System.Drawing.Point(0, 0);
            this.h1.Name = "h1";
            this.h1.PrefixColour = AntdUI.Colour.Primary;
            this.h1.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h1.Size = new System.Drawing.Size(750, 24);
            this.h1.TabIndex = 0;
            this.h1.Text = "基本用法";
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
            this.header1.TabIndex = 0;
            this.header1.Text = "UploadDragger 上传";
            this.header1.UseTitleFont = true;
            // 
            // UploadDraggerDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "UploadDraggerDemo";
            this.Size = new System.Drawing.Size(750, 542);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.UploadDragger uploadDragger;
        private AntdUI.PageHeader header1;
    }
}
