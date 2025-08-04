namespace AntdUIDemo.Views.Table
{
    partial class UserEdit
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
            this.panel1 = new AntdUI.Panel();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.button_ok = new AntdUI.Button();
            this.button_cancel = new AntdUI.Button();
            this.divider1 = new AntdUI.Divider();
            this.input_addr = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.input_age = new AntdUI.InputNumber();
            this.label1 = new AntdUI.Label();
            this.input_name = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.panel1.SuspendLayout();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input_addr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.input_age);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.input_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.divider1);
            this.panel1.Controls.Add(this.stackPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Shadow = 6;
            this.panel1.Size = new System.Drawing.Size(500, 386);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.button_cancel);
            this.stackPanel1.Controls.Add(this.button_ok);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel1.Location = new System.Drawing.Point(18, 18);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stackPanel1.Size = new System.Drawing.Size(464, 44);
            this.stackPanel1.TabIndex = 3;
            this.stackPanel1.Text = "stackPanel1";
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.Location = new System.Drawing.Point(3, 3);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 38);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Submit";
            this.button_ok.Type = AntdUI.TTypeMini.Primary;
            // 
            // button_cancel
            // 
            this.button_cancel.BorderWidth = 1F;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.button_cancel.Ghost = true;
            this.button_cancel.Location = new System.Drawing.Point(84, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 38);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            // 
            // divider1
            // 
            this.divider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider1.Location = new System.Drawing.Point(18, 62);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(464, 12);
            this.divider1.TabIndex = 14;
            // 
            // input_addr
            // 
            this.input_addr.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_addr.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_addr.Location = new System.Drawing.Point(18, 222);
            this.input_addr.Name = "input_addr";
            this.input_addr.Radius = 3;
            this.input_addr.Size = new System.Drawing.Size(464, 38);
            this.input_addr.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "地址";
            // 
            // input_age
            // 
            this.input_age.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_age.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_age.Location = new System.Drawing.Point(18, 160);
            this.input_age.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.input_age.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_age.Name = "input_age";
            this.input_age.Radius = 3;
            this.input_age.Size = new System.Drawing.Size(464, 38);
            this.input_age.TabIndex = 18;
            this.input_age.Text = "0";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "年龄";
            // 
            // input_name
            // 
            this.input_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_name.Location = new System.Drawing.Point(18, 98);
            this.input_name.Name = "input_name";
            this.input_name.Radius = 3;
            this.input_name.Size = new System.Drawing.Size(464, 38);
            this.input_name.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "姓名";
            // 
            // UserEdit
            // 
            
            this.Controls.Add(this.panel1);
            this.Name = "UserEdit";
            this.Size = new System.Drawing.Size(500, 386);
            this.panel1.ResumeLayout(false);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Button button_cancel;
        private AntdUI.Button button_ok;
        private AntdUI.Divider divider1;
        private AntdUI.Input input_addr;
        private AntdUI.Label label2;
        private AntdUI.InputNumber input_age;
        private AntdUI.Label label1;
        private AntdUI.Input input_name;
        private AntdUI.Label label3;
    }
}
