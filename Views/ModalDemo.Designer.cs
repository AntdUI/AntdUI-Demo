namespace AntdUIDemo.Views
{
    partial class ModalDemo
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
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.button_sys = new AntdUI.Button();
            this.label6 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.button_close = new AntdUI.Button();
            this.button_noclose = new AntdUI.Button();
            this.button_nomask = new AntdUI.Button();
            this.label5 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.button_custombutton = new AntdUI.Button();
            this.button_nobutton = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.button_base = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.header1 = new AntdUI.PageHeader();
            this.button_drag = new AntdUI.Button();
            this.stackPanel1.SuspendLayout();
            this.flowPanel4.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel4);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 401);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.button_sys);
            this.flowPanel4.Location = new System.Drawing.Point(3, 255);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(744, 38);
            this.flowPanel4.TabIndex = 47;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // button_sys
            // 
            this.button_sys.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_sys.Location = new System.Drawing.Point(3, 3);
            this.button_sys.Name = "button_sys";
            this.button_sys.Size = new System.Drawing.Size(90, 32);
            this.button_sys.TabIndex = 3;
            this.button_sys.Text = "系统设置";
            this.button_sys.Type = AntdUI.TTypeMini.Primary;
            this.button_sys.WaveSize = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(744, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "自定义弹窗";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.button_close);
            this.flowPanel3.Controls.Add(this.button_noclose);
            this.flowPanel3.Controls.Add(this.button_nomask);
            this.flowPanel3.Location = new System.Drawing.Point(3, 181);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(744, 38);
            this.flowPanel3.TabIndex = 45;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.Location = new System.Drawing.Point(195, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(90, 32);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "关闭按钮";
            this.button_close.Type = AntdUI.TTypeMini.Primary;
            this.button_close.WaveSize = 0;
            // 
            // button_noclose
            // 
            this.button_noclose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_noclose.Location = new System.Drawing.Point(99, 3);
            this.button_noclose.Name = "button_noclose";
            this.button_noclose.Size = new System.Drawing.Size(90, 32);
            this.button_noclose.TabIndex = 4;
            this.button_noclose.Text = "外侧禁止关闭";
            this.button_noclose.Type = AntdUI.TTypeMini.Primary;
            this.button_noclose.WaveSize = 0;
            // 
            // button_nomask
            // 
            this.button_nomask.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_nomask.Location = new System.Drawing.Point(3, 3);
            this.button_nomask.Name = "button_nomask";
            this.button_nomask.Size = new System.Drawing.Size(90, 32);
            this.button_nomask.TabIndex = 3;
            this.button_nomask.Text = "无遮罩";
            this.button_nomask.Type = AntdUI.TTypeMini.Primary;
            this.button_nomask.WaveSize = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(744, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "遮罩";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button_custombutton);
            this.flowPanel1.Controls.Add(this.button_nobutton);
            this.flowPanel1.Location = new System.Drawing.Point(3, 107);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 43;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // button_custombutton
            // 
            this.button_custombutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_custombutton.Location = new System.Drawing.Point(99, 3);
            this.button_custombutton.Name = "button_custombutton";
            this.button_custombutton.Size = new System.Drawing.Size(90, 32);
            this.button_custombutton.TabIndex = 4;
            this.button_custombutton.Text = "自定义按钮";
            this.button_custombutton.Type = AntdUI.TTypeMini.Primary;
            this.button_custombutton.WaveSize = 0;
            // 
            // button_nobutton
            // 
            this.button_nobutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_nobutton.Location = new System.Drawing.Point(3, 3);
            this.button_nobutton.Name = "button_nobutton";
            this.button_nobutton.Size = new System.Drawing.Size(90, 32);
            this.button_nobutton.TabIndex = 3;
            this.button_nobutton.Text = "无按钮";
            this.button_nobutton.Type = AntdUI.TTypeMini.Primary;
            this.button_nobutton.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "自定义页脚";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.button_drag);
            this.flowPanel2.Controls.Add(this.button_base);
            this.flowPanel2.Location = new System.Drawing.Point(3, 33);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 41;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // button_base
            // 
            this.button_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_base.Location = new System.Drawing.Point(3, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(90, 32);
            this.button_base.TabIndex = 3;
            this.button_base.Text = "默认";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "基本用法";
            // 
            // header1
            // 
            this.header1.Description = "展示一个对话框，提供标题、内容区、操作区。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 27;
            this.header1.Text = "Modal 对话框";
            this.header1.UseTitleFont = true;
            // 
            // button_drag
            // 
            this.button_drag.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_drag.Location = new System.Drawing.Point(99, 3);
            this.button_drag.Name = "button_drag";
            this.button_drag.Size = new System.Drawing.Size(90, 32);
            this.button_drag.TabIndex = 4;
            this.button_drag.Text = "支持拖拽";
            this.button_drag.Type = AntdUI.TTypeMini.Primary;
            this.button_drag.WaveSize = 0;
            // 
            // ModalDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "ModalDemo";
            this.Size = new System.Drawing.Size(750, 475);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button button_base;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button_nobutton;
        private AntdUI.Button button_custombutton;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Button button_nomask;
        private AntdUI.Label label5;
        private AntdUI.Button button_noclose;
        private AntdUI.Button button_close;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Button button_sys;
        private AntdUI.Label label6;
        private AntdUI.PageHeader header1;
        private AntdUI.Button button_drag;
    }
}
