namespace AntdUIDemo.Views
{
    partial class TableDemo
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
            this.table_base = new AntdUI.Table();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.checkbox_sort = new AntdUI.Checkbox();
            this.checkbox_rowstyle = new AntdUI.Checkbox();
            this.checkbox_border = new AntdUI.Checkbox();
            this.checkbox_columndragsort = new AntdUI.Checkbox();
            this.checkbox_visibleheader = new AntdUI.Checkbox();
            this.checkbox_fixheader = new AntdUI.Checkbox();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.buttonDEL = new AntdUI.Button();
            this.buttonADD = new AntdUI.Button();
            this.h1 = new AntdUI.Label();
            this.panelMain.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "展示行列数据。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Table 表格";
            this.header1.UseTitleFont = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.table_base);
            this.panelMain.Controls.Add(this.flowPanel1);
            this.panelMain.Controls.Add(this.flowPanel3);
            this.panelMain.Controls.Add(this.h1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3);
            this.panelMain.Size = new System.Drawing.Size(750, 565);
            this.panelMain.TabIndex = 0;
            this.panelMain.Text = "stackPanel1";
            // 
            // table_base
            // 
            this.table_base.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            this.table_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_base.EmptyHeader = true;
            this.table_base.Gap = 8;
            this.table_base.Gaps = new System.Drawing.Size(8, 8);
            this.table_base.Location = new System.Drawing.Point(3, 103);
            this.table_base.MultipleRows = true;
            this.table_base.Name = "table_base";
            this.table_base.ShowTip = false;
            this.table_base.Size = new System.Drawing.Size(744, 459);
            this.table_base.TabIndex = 30;
            this.table_base.Text = "table1";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.checkbox_sort);
            this.flowPanel1.Controls.Add(this.checkbox_rowstyle);
            this.flowPanel1.Controls.Add(this.checkbox_border);
            this.flowPanel1.Controls.Add(this.checkbox_columndragsort);
            this.flowPanel1.Controls.Add(this.checkbox_visibleheader);
            this.flowPanel1.Controls.Add(this.checkbox_fixheader);
            this.flowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel1.Location = new System.Drawing.Point(3, 65);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 29;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // checkbox_sort
            // 
            this.checkbox_sort.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_sort.Location = new System.Drawing.Point(392, 0);
            this.checkbox_sort.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_sort.Name = "checkbox_sort";
            this.checkbox_sort.Size = new System.Drawing.Size(52, 28);
            this.checkbox_sort.TabIndex = 21;
            this.checkbox_sort.Text = "排序";
            // 
            // checkbox_rowstyle
            // 
            this.checkbox_rowstyle.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_rowstyle.Location = new System.Drawing.Point(328, 0);
            this.checkbox_rowstyle.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_rowstyle.Name = "checkbox_rowstyle";
            this.checkbox_rowstyle.Size = new System.Drawing.Size(64, 28);
            this.checkbox_rowstyle.TabIndex = 20;
            this.checkbox_rowstyle.Text = "奇偶列";
            // 
            // checkbox_border
            // 
            this.checkbox_border.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_border.Location = new System.Drawing.Point(240, 0);
            this.checkbox_border.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_border.Name = "checkbox_border";
            this.checkbox_border.Size = new System.Drawing.Size(88, 28);
            this.checkbox_border.TabIndex = 19;
            this.checkbox_border.Text = "显示列边框";
            // 
            // checkbox_columndragsort
            // 
            this.checkbox_columndragsort.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_columndragsort.Location = new System.Drawing.Point(152, 0);
            this.checkbox_columndragsort.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_columndragsort.Name = "checkbox_columndragsort";
            this.checkbox_columndragsort.Size = new System.Drawing.Size(88, 28);
            this.checkbox_columndragsort.TabIndex = 18;
            this.checkbox_columndragsort.Text = "列拖拽排序";
            // 
            // checkbox_visibleheader
            // 
            this.checkbox_visibleheader.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_visibleheader.Checked = true;
            this.checkbox_visibleheader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_visibleheader.Location = new System.Drawing.Point(76, 0);
            this.checkbox_visibleheader.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_visibleheader.Name = "checkbox_visibleheader";
            this.checkbox_visibleheader.Size = new System.Drawing.Size(76, 28);
            this.checkbox_visibleheader.TabIndex = 17;
            this.checkbox_visibleheader.Text = "显示表头";
            // 
            // checkbox_fixheader
            // 
            this.checkbox_fixheader.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_fixheader.Checked = true;
            this.checkbox_fixheader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_fixheader.Location = new System.Drawing.Point(0, 0);
            this.checkbox_fixheader.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_fixheader.Name = "checkbox_fixheader";
            this.checkbox_fixheader.Size = new System.Drawing.Size(76, 28);
            this.checkbox_fixheader.TabIndex = 12;
            this.checkbox_fixheader.Text = "固定表头";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.buttonDEL);
            this.flowPanel3.Controls.Add(this.buttonADD);
            this.flowPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel3.Location = new System.Drawing.Point(3, 27);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(744, 38);
            this.flowPanel3.TabIndex = 27;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // buttonDEL
            // 
            this.buttonDEL.Location = new System.Drawing.Point(89, 3);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(80, 32);
            this.buttonDEL.TabIndex = 5;
            this.buttonDEL.Text = "删除";
            this.buttonDEL.Type = AntdUI.TTypeMini.Error;
            this.buttonDEL.WaveSize = 0;
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(3, 3);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(80, 32);
            this.buttonADD.TabIndex = 2;
            this.buttonADD.Text = "新增";
            this.buttonADD.Type = AntdUI.TTypeMini.Primary;
            this.buttonADD.WaveSize = 0;
            // 
            // h1
            // 
            this.h1.Dock = System.Windows.Forms.DockStyle.Top;
            this.h1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.h1.Location = new System.Drawing.Point(3, 3);
            this.h1.Name = "h1";
            this.h1.PrefixColour = AntdUI.Colour.Primary;
            this.h1.PrefixSvg = global::AntdUIDemo.Properties.Resources.icon_divider;
            this.h1.Size = new System.Drawing.Size(744, 24);
            this.h1.TabIndex = 24;
            this.h1.Text = "基本用法";
            // 
            // TableDemo
            // 
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.header1);
            this.Name = "TableDemo";
            this.Size = new System.Drawing.Size(750, 639);
            this.panelMain.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel1.PerformLayout();
            this.flowPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.In.Panel panelMain;
        private AntdUI.Label h1;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Button buttonADD;
        private AntdUI.Button buttonDEL;
        private AntdUI.Table table_base;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Checkbox checkbox_visibleheader;
        private AntdUI.Checkbox checkbox_fixheader;
        private AntdUI.Checkbox checkbox_sort;
        private AntdUI.Checkbox checkbox_rowstyle;
        private AntdUI.Checkbox checkbox_border;
        private AntdUI.Checkbox checkbox_columndragsort;
    }
}
