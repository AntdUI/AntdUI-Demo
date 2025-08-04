namespace AntdUIDemo.Views
{
    partial class IconDemo
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
            AntdUI.SegmentedItem segmentedItem1 = new AntdUI.SegmentedItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconDemo));
            AntdUI.SegmentedItem segmentedItem2 = new AntdUI.SegmentedItem();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1 = new System.Windows.Forms.Panel();
            this.vpanel = new AntdUI.VirtualPanel();
            this.segmented1 = new AntdUI.Segmented();
            this.txt_search = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.segmented1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "语义化的矢量图形。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.LocalizationDescription = "Icon.Description";
            this.header1.LocalizationText = "Icon.Text";
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Icon 图标";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.vpanel);
            this.stackPanel1.Controls.Add(this.segmented1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 104);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.stackPanel1.Size = new System.Drawing.Size(750, 456);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            // 
            // vpanel
            // 
            this.vpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vpanel.Location = new System.Drawing.Point(3, 41);
            this.vpanel.Name = "vpanel";
            this.vpanel.Size = new System.Drawing.Size(744, 412);
            this.vpanel.TabIndex = 20;
            // 
            // segmented1
            // 
            this.segmented1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.segmented1.BarPosition = AntdUI.TAlignMini.Bottom;
            this.segmented1.Controls.Add(this.txt_search);
            this.segmented1.Dock = System.Windows.Forms.DockStyle.Top;
            this.segmented1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.segmented1.IconAlign = AntdUI.TAlignMini.Left;
            segmentedItem1.IconSvg = resources.GetString("segmentedItem1.IconSvg");
            segmentedItem1.Text = "线框风格";
            segmentedItem2.IconSvg = "<svg viewBox=\"0 0 1024 1024\"><path d=\"M864 64H160C107 64 64 107 64 160v704c0 53 4" +
    "3 96 96 96h704c53 0 96-43 96-96V160c0-53-43-96-96-96z\"></path></svg>";
            segmentedItem2.Text = "实底风格";
            this.segmented1.Items.Add(segmentedItem1);
            this.segmented1.Items.Add(segmentedItem2);
            this.segmented1.Location = new System.Drawing.Point(3, 3);
            this.segmented1.Name = "segmented1";
            this.segmented1.SelectIndex = 0;
            this.segmented1.Size = new System.Drawing.Size(744, 38);
            this.segmented1.TabIndex = 18;
            this.segmented1.Text = "segmented1";
            // 
            // txt_search
            // 
            this.txt_search.AllowClear = true;
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_search.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.txt_search.LocalizationPlaceholderText = "search";
            this.txt_search.LocalizationText = "";
            this.txt_search.Location = new System.Drawing.Point(420, 0);
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "搜索";
            this.txt_search.PrefixSvg = "SearchOutlined";
            this.txt_search.Size = new System.Drawing.Size(324, 38);
            this.txt_search.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.LocalizationText = "Icon.Tip";
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 6);
            this.label3.Size = new System.Drawing.Size(750, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Icon没有工具箱控件，用于Svg属性赋值。";
            // 
            // IconDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.header1);
            this.Name = "IconDemo";
            this.Size = new System.Drawing.Size(750, 560);
            this.stackPanel1.ResumeLayout(false);
            this.segmented1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private System.Windows.Forms.Panel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.Segmented segmented1;
        private AntdUI.VirtualPanel vpanel;
        private AntdUI.Input txt_search;
    }
}
