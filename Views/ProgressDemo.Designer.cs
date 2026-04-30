namespace AntdUIDemo.Views
{
    partial class ProgressDemo
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
            this.progress19 = new AntdUI.Progress();
            this.progress18 = new AntdUI.Progress();
            this.progress17 = new AntdUI.Progress();
            this.progress16 = new AntdUI.Progress();
            this.progress15 = new AntdUI.Progress();
            this.progress14 = new AntdUI.Progress();
            this.progress12 = new AntdUI.Progress();
            this.h5 = new AntdUI.Label();
            this.progress13 = new AntdUI.Progress();
            this.h4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.progress10 = new AntdUI.Progress();
            this.progress9 = new AntdUI.Progress();
            this.progress11 = new AntdUI.Progress();
            this.h3 = new AntdUI.Label();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.progress8 = new AntdUI.Progress();
            this.progress7 = new AntdUI.Progress();
            this.progress6 = new AntdUI.Progress();
            this.h2 = new AntdUI.Label();
            this.progress5 = new AntdUI.Progress();
            this.progress4 = new AntdUI.Progress();
            this.progress3 = new AntdUI.Progress();
            this.progress2 = new AntdUI.Progress();
            this.progress1 = new AntdUI.Progress();
            this.h1 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.panelMain.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.progress19);
            this.panelMain.Controls.Add(this.progress18);
            this.panelMain.Controls.Add(this.progress17);
            this.panelMain.Controls.Add(this.progress16);
            this.panelMain.Controls.Add(this.progress15);
            this.panelMain.Controls.Add(this.progress14);
            this.panelMain.Controls.Add(this.progress12);
            this.panelMain.Controls.Add(this.h5);
            this.panelMain.Controls.Add(this.progress13);
            this.panelMain.Controls.Add(this.h4);
            this.panelMain.Controls.Add(this.flowPanel1);
            this.panelMain.Controls.Add(this.h3);
            this.panelMain.Controls.Add(this.flowPanel4);
            this.panelMain.Controls.Add(this.h2);
            this.panelMain.Controls.Add(this.progress5);
            this.panelMain.Controls.Add(this.progress4);
            this.panelMain.Controls.Add(this.progress3);
            this.panelMain.Controls.Add(this.progress2);
            this.panelMain.Controls.Add(this.progress1);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 667);
            this.panelMain.TabIndex = 0;
            // 
            // progress19
            // 
            this.progress19.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress19.Loading = true;
            this.progress19.Location = new System.Drawing.Point(0, 492);
            this.progress19.Name = "progress19";
            this.progress19.Shape = AntdUI.TShapeProgress.Steps;
            this.progress19.Size = new System.Drawing.Size(750, 23);
            this.progress19.State = AntdUI.TType.Warn;
            this.progress19.StepGap = 5;
            this.progress19.Steps = 50;
            this.progress19.StepSize = 0;
            this.progress19.TabIndex = 15;
            this.progress19.Text = "progress19";
            this.progress19.Value = 0.3F;
            // 
            // progress18
            // 
            this.progress18.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress18.Location = new System.Drawing.Point(0, 469);
            this.progress18.Name = "progress18";
            this.progress18.Shape = AntdUI.TShapeProgress.Steps;
            this.progress18.Size = new System.Drawing.Size(750, 23);
            this.progress18.State = AntdUI.TType.Warn;
            this.progress18.StepGap = 5;
            this.progress18.Steps = 50;
            this.progress18.StepSize = 2;
            this.progress18.TabIndex = 14;
            this.progress18.Text = "progress18";
            this.progress18.Value = 0.3F;
            // 
            // progress17
            // 
            this.progress17.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress17.Loading = true;
            this.progress17.Location = new System.Drawing.Point(0, 446);
            this.progress17.Name = "progress17";
            this.progress17.Shape = AntdUI.TShapeProgress.Steps;
            this.progress17.Size = new System.Drawing.Size(750, 23);
            this.progress17.StepGap = 8;
            this.progress17.Steps = 20;
            this.progress17.StepSize = 10;
            this.progress17.TabIndex = 13;
            this.progress17.Text = "progress17";
            this.progress17.Value = 0.3F;
            // 
            // progress16
            // 
            this.progress16.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress16.Location = new System.Drawing.Point(0, 423);
            this.progress16.Name = "progress16";
            this.progress16.Shape = AntdUI.TShapeProgress.Steps;
            this.progress16.Size = new System.Drawing.Size(750, 23);
            this.progress16.State = AntdUI.TType.Success;
            this.progress16.Steps = 50;
            this.progress16.StepSize = 2;
            this.progress16.TabIndex = 12;
            this.progress16.Text = "progress16";
            this.progress16.Value = 1F;
            // 
            // progress15
            // 
            this.progress15.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress15.Loading = true;
            this.progress15.Location = new System.Drawing.Point(0, 400);
            this.progress15.Name = "progress15";
            this.progress15.Shape = AntdUI.TShapeProgress.Steps;
            this.progress15.Size = new System.Drawing.Size(750, 23);
            this.progress15.State = AntdUI.TType.Error;
            this.progress15.Steps = 50;
            this.progress15.StepSize = 5;
            this.progress15.TabIndex = 11;
            this.progress15.Text = "progress15";
            this.progress15.Value = 0.7F;
            // 
            // progress14
            // 
            this.progress14.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress14.Loading = true;
            this.progress14.Location = new System.Drawing.Point(0, 377);
            this.progress14.Name = "progress14";
            this.progress14.Shape = AntdUI.TShapeProgress.Steps;
            this.progress14.Size = new System.Drawing.Size(750, 23);
            this.progress14.Steps = 50;
            this.progress14.StepSize = 5;
            this.progress14.TabIndex = 10;
            this.progress14.Text = "progress14";
            this.progress14.Value = 0.5F;
            // 
            // progress12
            // 
            this.progress12.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress12.Location = new System.Drawing.Point(0, 354);
            this.progress12.Name = "progress12";
            this.progress12.Shape = AntdUI.TShapeProgress.Steps;
            this.progress12.Size = new System.Drawing.Size(750, 23);
            this.progress12.Steps = 50;
            this.progress12.StepSize = 5;
            this.progress12.TabIndex = 9;
            this.progress12.TextUnit = "";
            this.progress12.UseSystemText = true;
            this.progress12.Value = 0.3F;
            // 
            // h5
            // 
            this.h5.Dock = System.Windows.Forms.DockStyle.Top;
            this.h5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h5.Location = new System.Drawing.Point(0, 330);
            this.h5.Name = "h5";
            this.h5.PrefixColour = AntdUI.Colour.Primary;
            this.h5.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h5.Size = new System.Drawing.Size(750, 24);
            this.h5.TabIndex = 0;
            this.h5.Text = "步骤进度条";
            // 
            // progress13
            // 
            this.progress13.ContainerControl = this;
            this.progress13.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress13.Loading = true;
            this.progress13.LoadingFull = true;
            this.progress13.Location = new System.Drawing.Point(0, 310);
            this.progress13.Name = "progress13";
            this.progress13.Size = new System.Drawing.Size(750, 20);
            this.progress13.TabIndex = 8;
            // 
            // h4
            // 
            this.h4.Dock = System.Windows.Forms.DockStyle.Top;
            this.h4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h4.Location = new System.Drawing.Point(0, 286);
            this.h4.Name = "h4";
            this.h4.PrefixColour = AntdUI.Colour.Primary;
            this.h4.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h4.Size = new System.Drawing.Size(750, 24);
            this.h4.TabIndex = 0;
            this.h4.Text = "动画铺满";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.progress10);
            this.flowPanel1.Controls.Add(this.progress9);
            this.flowPanel1.Controls.Add(this.progress11);
            this.flowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel1.Gap = 6;
            this.flowPanel1.Location = new System.Drawing.Point(0, 248);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(750, 38);
            this.flowPanel1.TabIndex = 7;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // progress10
            // 
            this.progress10.ContainerControl = this;
            this.progress10.Location = new System.Drawing.Point(179, 3);
            this.progress10.Name = "progress10";
            this.progress10.Shape = AntdUI.TShapeProgress.Mini;
            this.progress10.Size = new System.Drawing.Size(76, 31);
            this.progress10.State = AntdUI.TType.Success;
            this.progress10.TabIndex = 3;
            this.progress10.Text = "Success";
            this.progress10.Value = 1F;
            // 
            // progress9
            // 
            this.progress9.ContainerControl = this;
            this.progress9.Location = new System.Drawing.Point(91, 3);
            this.progress9.Name = "progress9";
            this.progress9.Shape = AntdUI.TShapeProgress.Mini;
            this.progress9.Size = new System.Drawing.Size(76, 31);
            this.progress9.State = AntdUI.TType.Error;
            this.progress9.TabIndex = 2;
            this.progress9.Text = "Error";
            this.progress9.Value = 0.75F;
            // 
            // progress11
            // 
            this.progress11.ContainerControl = this;
            this.progress11.Location = new System.Drawing.Point(3, 3);
            this.progress11.Name = "progress11";
            this.progress11.Shape = AntdUI.TShapeProgress.Mini;
            this.progress11.Size = new System.Drawing.Size(76, 31);
            this.progress11.TabIndex = 1;
            this.progress11.Text = "%";
            this.progress11.Value = 0.75F;
            // 
            // h3
            // 
            this.h3.Dock = System.Windows.Forms.DockStyle.Top;
            this.h3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h3.Location = new System.Drawing.Point(0, 224);
            this.h3.Name = "h3";
            this.h3.PrefixColour = AntdUI.Colour.Primary;
            this.h3.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h3.Size = new System.Drawing.Size(750, 24);
            this.h3.TabIndex = 0;
            this.h3.Text = "mini模式";
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.progress8);
            this.flowPanel4.Controls.Add(this.progress7);
            this.flowPanel4.Controls.Add(this.progress6);
            this.flowPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel4.Gap = 6;
            this.flowPanel4.Location = new System.Drawing.Point(0, 148);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(750, 76);
            this.flowPanel4.TabIndex = 6;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // progress8
            // 
            this.progress8.ContainerControl = this;
            this.progress8.Location = new System.Drawing.Point(179, 3);
            this.progress8.Name = "progress8";
            this.progress8.Shape = AntdUI.TShapeProgress.Circle;
            this.progress8.Size = new System.Drawing.Size(76, 70);
            this.progress8.State = AntdUI.TType.Success;
            this.progress8.TabIndex = 3;
            this.progress8.Text = "%";
            this.progress8.Value = 1F;
            // 
            // progress7
            // 
            this.progress7.ContainerControl = this;
            this.progress7.Location = new System.Drawing.Point(91, 3);
            this.progress7.Name = "progress7";
            this.progress7.Shape = AntdUI.TShapeProgress.Circle;
            this.progress7.Size = new System.Drawing.Size(76, 70);
            this.progress7.State = AntdUI.TType.Error;
            this.progress7.TabIndex = 2;
            this.progress7.Text = "%";
            this.progress7.Value = 0.75F;
            // 
            // progress6
            // 
            this.progress6.ContainerControl = this;
            this.progress6.Location = new System.Drawing.Point(3, 3);
            this.progress6.Name = "progress6";
            this.progress6.Shape = AntdUI.TShapeProgress.Circle;
            this.progress6.Size = new System.Drawing.Size(76, 70);
            this.progress6.TabIndex = 1;
            this.progress6.Text = "%";
            this.progress6.Value = 0.75F;
            // 
            // h2
            // 
            this.h2.Dock = System.Windows.Forms.DockStyle.Top;
            this.h2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h2.Location = new System.Drawing.Point(0, 124);
            this.h2.Name = "h2";
            this.h2.PrefixColour = AntdUI.Colour.Primary;
            this.h2.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h2.Size = new System.Drawing.Size(750, 24);
            this.h2.TabIndex = 0;
            this.h2.Text = "进度圈";
            // 
            // progress5
            // 
            this.progress5.ContainerControl = this;
            this.progress5.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress5.Loading = true;
            this.progress5.Location = new System.Drawing.Point(0, 104);
            this.progress5.Name = "progress5";
            this.progress5.Size = new System.Drawing.Size(750, 20);
            this.progress5.State = AntdUI.TType.Warn;
            this.progress5.TabIndex = 5;
            this.progress5.Value = 0.3F;
            // 
            // progress4
            // 
            this.progress4.ContainerControl = this;
            this.progress4.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress4.Location = new System.Drawing.Point(0, 84);
            this.progress4.Name = "progress4";
            this.progress4.Size = new System.Drawing.Size(750, 20);
            this.progress4.State = AntdUI.TType.Success;
            this.progress4.TabIndex = 4;
            this.progress4.Value = 1F;
            // 
            // progress3
            // 
            this.progress3.ContainerControl = this;
            this.progress3.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress3.Location = new System.Drawing.Point(0, 64);
            this.progress3.Name = "progress3";
            this.progress3.Size = new System.Drawing.Size(750, 20);
            this.progress3.State = AntdUI.TType.Error;
            this.progress3.TabIndex = 3;
            this.progress3.Value = 0.7F;
            // 
            // progress2
            // 
            this.progress2.ContainerControl = this;
            this.progress2.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress2.Loading = true;
            this.progress2.Location = new System.Drawing.Point(0, 44);
            this.progress2.Name = "progress2";
            this.progress2.Size = new System.Drawing.Size(750, 20);
            this.progress2.TabIndex = 2;
            this.progress2.Value = 0.5F;
            // 
            // progress1
            // 
            this.progress1.ContainerControl = this;
            this.progress1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress1.Location = new System.Drawing.Point(0, 24);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(750, 20);
            this.progress1.TabIndex = 1;
            this.progress1.TextUnit = "";
            this.progress1.UseSystemText = true;
            this.progress1.Value = 0.3F;
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
            this.h1.Text = "进度条";
            // 
            // header1
            // 
            this.header1.Description = "展示操作的当前进度。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 0;
            this.header1.Text = "Progress 进度条";
            this.header1.UseTitleFont = true;
            // 
            // ProgressDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "ProgressDemo";
            this.Size = new System.Drawing.Size(750, 741);
            this.panelMain.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.Progress progress1;
        private AntdUI.Progress progress3;
        private AntdUI.Progress progress2;
        private AntdUI.Progress progress5;
        private AntdUI.Progress progress4;
        private AntdUI.Label h2;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Progress progress6;
        private AntdUI.Progress progress8;
        private AntdUI.Progress progress7;
        private AntdUI.Label h3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Progress progress10;
        private AntdUI.Progress progress9;
        private AntdUI.Progress progress11;
        private AntdUI.Label h4;
        private AntdUI.Progress progress13;
        private AntdUI.Progress progress12;
        private AntdUI.Label h5;
        private AntdUI.Progress progress14;
        private AntdUI.Progress progress17;
        private AntdUI.Progress progress16;
        private AntdUI.Progress progress15;
        private AntdUI.Progress progress18;
        private AntdUI.Progress progress19;
        private AntdUI.PageHeader header1;
    }
}
