namespace AntdUIDemo.Views
{
    partial class Image3DDemo
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
            this.panelMain = new AntdUI.In.Panel();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.image3D_shadowV = new AntdUI.Image3D();
            this.image3D_shadow = new AntdUI.Image3D();
            this.h2 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.image3D_V = new AntdUI.Image3D();
            this.image3D = new AntdUI.Image3D();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "显示3D图片";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Image3D 图片3D";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flowPanel2);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.flowPanel1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 480);
            this.panelMain.TabIndex = 0;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.image3D_shadowV);
            this.flowPanel2.Controls.Add(this.image3D_shadow);
            this.flowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel2.Location = new System.Drawing.Point(0, 216);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(750, 168);
            this.flowPanel2.TabIndex = 2;
            // 
            // image3D_shadowV
            // 
            this.image3D_shadowV.Duration = 200;
            this.image3D_shadowV.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D_shadowV.Location = new System.Drawing.Point(329, 3);
            this.image3D_shadowV.Name = "image3D_shadowV";
            this.image3D_shadowV.Padding = new System.Windows.Forms.Padding(12);
            this.image3D_shadowV.Radius = 6;
            this.image3D_shadowV.Shadow = 12;
            this.image3D_shadowV.Size = new System.Drawing.Size(320, 162);
            this.image3D_shadowV.TabIndex = 3;
            this.image3D_shadowV.Text = "image3D2";
            this.image3D_shadowV.Vertical = true;
            // 
            // image3D_shadow
            // 
            this.image3D_shadow.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D_shadow.Location = new System.Drawing.Point(3, 3);
            this.image3D_shadow.Name = "image3D_shadow";
            this.image3D_shadow.Padding = new System.Windows.Forms.Padding(12);
            this.image3D_shadow.Radius = 6;
            this.image3D_shadow.Shadow = 12;
            this.image3D_shadow.Size = new System.Drawing.Size(320, 162);
            this.image3D_shadow.TabIndex = 2;
            this.image3D_shadow.Text = "image3D2";
            // 
            // h2
            // 
            this.h2.Dock = System.Windows.Forms.DockStyle.Top;
            this.h2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h2.Location = new System.Drawing.Point(0, 192);
            this.h2.Name = "h2";
            this.h2.PrefixColour = AntdUI.Colour.Primary;
            this.h2.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h2.Size = new System.Drawing.Size(750, 24);
            this.h2.TabIndex = 0;
            this.h2.Text = "阴影效果";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.image3D_V);
            this.flowPanel1.Controls.Add(this.image3D);
            this.flowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(750, 168);
            this.flowPanel1.TabIndex = 1;
            // 
            // image3D_V
            // 
            this.image3D_V.Duration = 200;
            this.image3D_V.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D_V.Location = new System.Drawing.Point(329, 3);
            this.image3D_V.Name = "image3D_V";
            this.image3D_V.Radius = 6;
            this.image3D_V.Size = new System.Drawing.Size(320, 162);
            this.image3D_V.TabIndex = 1;
            this.image3D_V.Text = "image3D1";
            this.image3D_V.Vertical = true;
            // 
            // image3D
            // 
            this.image3D.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D.Location = new System.Drawing.Point(3, 3);
            this.image3D.Name = "image3D";
            this.image3D.Radius = 6;
            this.image3D.Size = new System.Drawing.Size(320, 162);
            this.image3D.TabIndex = 0;
            this.image3D.Text = "image3D1";
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
            // Image3DDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "Image3DDemo";
            this.Size = new System.Drawing.Size(750, 554);
            this.panelMain.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Image3D image3D;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Image3D image3D_shadow;
        private AntdUI.Label h2;
        private AntdUI.Image3D image3D_shadowV;
        private AntdUI.Image3D image3D_V;
    }
}
