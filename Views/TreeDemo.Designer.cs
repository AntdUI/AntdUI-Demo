namespace AntdUIDemo.Views
{
    partial class TreeDemo
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
            AntdUI.TreeItem treeItem1 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem2 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem3 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem4 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem5 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem6 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem7 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem8 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem9 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem10 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem11 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem12 = new AntdUI.TreeItem();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.stackPanel2 = new AntdUI.StackPanel();
            this.tree2 = new AntdUI.Tree();
            this.tree1 = new AntdUI.Tree();
            this.label3 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 403);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.tree2);
            this.stackPanel2.Controls.Add(this.tree1);
            this.stackPanel2.Location = new System.Drawing.Point(3, 33);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(744, 347);
            this.stackPanel2.TabIndex = 17;
            this.stackPanel2.Text = "stackPanel2";
            // 
            // tree2
            // 
            this.tree2.BlockNode = true;
            this.tree2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            treeItem1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            treeItem1.Expand = true;
            treeItem1.PARENTITEM = null;
            treeItem2.Enabled = false;
            treeItem2.Expand = true;
            treeItem2.PARENTITEM = treeItem1;
            treeItem3.Expand = true;
            treeItem3.PARENTITEM = treeItem2;
            treeItem3.Text = "leaf";
            treeItem4.PARENTITEM = treeItem2;
            treeItem4.Text = "leaf";
            treeItem2.Sub.Add(treeItem3);
            treeItem2.Sub.Add(treeItem4);
            treeItem2.Text = "parent1-0";
            treeItem5.Checked = true;
            treeItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem5.Expand = true;
            treeItem5.PARENTITEM = treeItem1;
            treeItem6.Checked = true;
            treeItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem6.Expand = true;
            treeItem6.PARENTITEM = treeItem5;
            treeItem6.Text = "sss";
            treeItem5.Sub.Add(treeItem6);
            treeItem5.Text = "parent1-1";
            treeItem1.Sub.Add(treeItem2);
            treeItem1.Sub.Add(treeItem5);
            treeItem1.Text = "parent1";
            this.tree2.Items.Add(treeItem1);
            this.tree2.Location = new System.Drawing.Point(256, 3);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(247, 341);
            this.tree2.TabIndex = 1;
            this.tree2.Text = "tree2";
            // 
            // tree1
            // 
            this.tree1.Checkable = true;
            this.tree1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            treeItem7.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            treeItem7.Expand = true;
            treeItem7.PARENTITEM = null;
            treeItem8.Enabled = false;
            treeItem8.Expand = true;
            treeItem8.PARENTITEM = treeItem7;
            treeItem9.Expand = true;
            treeItem9.PARENTITEM = treeItem8;
            treeItem9.Text = "leaf";
            treeItem10.PARENTITEM = treeItem8;
            treeItem10.Text = "leaf";
            treeItem8.Sub.Add(treeItem9);
            treeItem8.Sub.Add(treeItem10);
            treeItem8.Text = "parent1-0";
            treeItem11.Checked = true;
            treeItem11.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem11.Expand = true;
            treeItem11.PARENTITEM = treeItem7;
            treeItem12.Checked = true;
            treeItem12.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem12.Expand = true;
            treeItem12.PARENTITEM = treeItem11;
            treeItem12.Text = "sss";
            treeItem11.Sub.Add(treeItem12);
            treeItem11.Text = "parent1-1";
            treeItem7.Sub.Add(treeItem8);
            treeItem7.Sub.Add(treeItem11);
            treeItem7.Text = "parent1";
            this.tree1.Items.Add(treeItem7);
            this.tree1.Location = new System.Drawing.Point(3, 3);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(247, 341);
            this.tree1.TabIndex = 0;
            this.tree1.Text = "tree1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "基本用法";
            // 
            // header1
            // 
            this.header1.Description = "多层次的结构列表。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Tree 树形控件";
            this.header1.UseTitleFont = true;
            // 
            // TreeDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "TreeDemo";
            this.Size = new System.Drawing.Size(750, 477);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Tree tree2;
        private AntdUI.Tree tree1;
        private AntdUI.Label label3;
        private AntdUI.PageHeader header1;
    }
}
