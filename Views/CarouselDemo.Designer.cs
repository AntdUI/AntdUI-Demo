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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.carousel3 = new AntdUI.Carousel();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.carousel2 = new AntdUI.Carousel();
            this.carousel1 = new AntdUI.Carousel();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
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
            this.header1.TabIndex = 27;
            this.header1.Text = "Carousel 走马灯";
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
            this.stackPanel1.Size = new System.Drawing.Size(750, 425);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.carousel3);
            this.flowPanel2.Location = new System.Drawing.Point(3, 237);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 168);
            this.flowPanel2.TabIndex = 29;
            this.flowPanel2.Text = "flowPanel2";
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
            this.carousel3.SelectIndex = 1;
            this.carousel3.Size = new System.Drawing.Size(320, 162);
            this.carousel3.TabIndex = 1;
            this.carousel3.Text = "carousel3";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "自动轮播";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.carousel2);
            this.flowPanel1.Controls.Add(this.carousel1);
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 168);
            this.flowPanel1.TabIndex = 27;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // carousel2
            // 
            this.carousel2.DotMargin = 24;
            this.carousel2.DotPosition = AntdUI.TAlignMini.Right;
            this.carousel2.DotSize = new System.Drawing.Size(60, 8);
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
            this.carousel2.Text = "carousel2";
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
            this.carousel1.Text = "carousel1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "基本用法";
            // 
            // CarouselDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "CarouselDemo";
            this.Size = new System.Drawing.Size(750, 499);
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
        private AntdUI.Carousel carousel1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Carousel carousel3;
        private AntdUI.Label label4;
        private AntdUI.Carousel carousel2;
    }
}
