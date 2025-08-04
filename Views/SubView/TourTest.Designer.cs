namespace AntdUIDemo.Views.SubView
{
    partial class TourTest
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
            this.label1 = new AntdUI.Label();
            this.panel1 = new AntdUI.Panel();
            this.button_previous = new AntdUI.Button();
            this.button_next = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_previous);
            this.panel1.Controls.Add(this.button_next);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 40);
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // button_previous
            // 
            this.button_previous.BorderWidth = 1F;
            this.button_previous.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_previous.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_previous.Location = new System.Drawing.Point(70, 0);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(75, 40);
            this.button_previous.TabIndex = 7;
            this.button_previous.Text = "上一步";
            // 
            // button_next
            // 
            this.button_next.BorderWidth = 1F;
            this.button_next.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_next.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_next.Location = new System.Drawing.Point(145, 0);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 40);
            this.button_next.TabIndex = 6;
            this.button_next.Text = "下一步";
            this.button_next.Type = AntdUI.TTypeMini.Primary;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 74);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 40);
            this.label3.TabIndex = 8;
            // 
            // TourTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TourTest";
            this.Size = new System.Drawing.Size(220, 150);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Panel panel1;
        private AntdUI.Label label3;
        private AntdUI.Button button_previous;
        private AntdUI.Button button_next;
        private AntdUI.Label label2;
    }
}
