namespace AntdUIDemo.Views
{
    partial class CarouselDemo
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
            AntdUI.CarouselItem carouselItem1 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem2 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem3 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem4 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem5 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem6 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem7 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem8 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem9 = new AntdUI.CarouselItem();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain = new AntdUI.In.Panel();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.carousel3 = new AntdUI.Carousel();
            this.h2 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.carousel2 = new AntdUI.Carousel();
            this.carousel1 = new AntdUI.Carousel();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "一组轮播的区域。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Carousel 走马灯";
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
            this.panelMain.Size = new System.Drawing.Size(750, 425);
            this.panelMain.TabIndex = 0;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.carousel3);
            this.flowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel2.Location = new System.Drawing.Point(0, 216);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(750, 168);
            this.flowPanel2.TabIndex = 2;
            // 
            // carousel3
            // 
            this.carousel3.Autoplay = true;
            this.carousel3.DotPosition = AntdUI.TAlignMini.Bottom;
            carouselItem1.Img = global::AntdUIDemo.Properties.Resources.bg1;
            carouselItem2.Img = global::AntdUIDemo.Properties.Resources.bg2;
            carouselItem3.Img = global::AntdUIDemo.Properties.Resources.bg3;
            this.carousel3.Image.Add(carouselItem1);
            this.carousel3.Image.Add(carouselItem2);
            this.carousel3.Image.Add(carouselItem3);
            this.carousel3.Location = new System.Drawing.Point(3, 3);
            this.carousel3.Name = "carousel3";
            this.carousel3.Radius = 12;
            this.carousel3.SelectIndex = 2;
            this.carousel3.Size = new System.Drawing.Size(320, 162);
            this.carousel3.TabIndex = 0;
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
            this.h2.Text = "自动轮播";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.carousel2);
            this.flowPanel1.Controls.Add(this.carousel1);
            this.flowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(750, 168);
            this.flowPanel1.TabIndex = 1;
            // 
            // carousel2
            // 
            this.carousel2.DotMargin = 24;
            this.carousel2.DotPosition = AntdUI.TAlignMini.Right;
            this.carousel2.DotSize = new System.Drawing.Size(40, 8);
            carouselItem4.Img = global::AntdUIDemo.Properties.Resources.bg1;
            carouselItem5.Img = global::AntdUIDemo.Properties.Resources.bg2;
            carouselItem6.Img = global::AntdUIDemo.Properties.Resources.bg3;
            this.carousel2.Image.Add(carouselItem4);
            this.carousel2.Image.Add(carouselItem5);
            this.carousel2.Image.Add(carouselItem6);
            this.carousel2.Location = new System.Drawing.Point(329, 3);
            this.carousel2.Name = "carousel2";
            this.carousel2.Size = new System.Drawing.Size(320, 162);
            this.carousel2.TabIndex = 1;
            // 
            // carousel1
            // 
            this.carousel1.DotPosition = AntdUI.TAlignMini.Bottom;
            carouselItem7.Img = global::AntdUIDemo.Properties.Resources.bg1;
            carouselItem8.Img = global::AntdUIDemo.Properties.Resources.bg2;
            carouselItem9.Img = global::AntdUIDemo.Properties.Resources.bg3;
            this.carousel1.Image.Add(carouselItem7);
            this.carousel1.Image.Add(carouselItem8);
            this.carousel1.Image.Add(carouselItem9);
            this.carousel1.Location = new System.Drawing.Point(3, 3);
            this.carousel1.Name = "carousel1";
            this.carousel1.Size = new System.Drawing.Size(320, 162);
            this.carousel1.TabIndex = 0;
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
            // CarouselDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "CarouselDemo";
            this.Size = new System.Drawing.Size(750, 499);
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
        private AntdUI.Carousel carousel1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Carousel carousel3;
        private AntdUI.Label h2;
        private AntdUI.Carousel carousel2;
    }
}
