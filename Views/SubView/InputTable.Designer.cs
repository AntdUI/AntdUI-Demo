using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo
{
    partial class InputTable<T>
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

   

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.InputSearch = new AntdUI.Panel();
            this.txtSearch = new AntdUI.Input();
            this.btnSearch = new AntdUI.Button();
            this.InputSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputSearch
            // 
            this.InputSearch.Controls.Add(this.txtSearch);
            this.InputSearch.Controls.Add(this.btnSearch);
            this.InputSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputSearch.Location = new System.Drawing.Point(0, 0);
            this.InputSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(255, 37);
            this.InputSearch.TabIndex = 3;
            this.InputSearch.Text = "panel1";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.IconRatio = 1F;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "输入点什么搜索";
            this.txtSearch.Size = new System.Drawing.Size(216, 37);
            this.txtSearch.SuffixSvg = "";
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.IconRatio = 1F;
            this.btnSearch.IconSvg = "SearchOutlined";
            this.btnSearch.Location = new System.Drawing.Point(216, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Type = AntdUI.TTypeMini.Info;
            // 
            // InputTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.InputSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputTable";
            this.Size = new System.Drawing.Size(255, 37);
            this.InputSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel InputSearch;
        private AntdUI.Input txtSearch;
        private AntdUI.Button btnSearch;
    }
}
