namespace AntdUIDemo.Views
{
    partial class BadgeDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgeDemo));
            this.header1 = new AntdUI.PageHeader();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel9 = new AntdUI.FlowPanel();
            this.button30 = new AntdUI.Button();
            this.button31 = new AntdUI.Button();
            this.button32 = new AntdUI.Button();
            this.button38 = new AntdUI.Button();
            this.button40 = new AntdUI.Button();
            this.button41 = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.badge12 = new AntdUI.Badge();
            this.badge4 = new AntdUI.Badge();
            this.badge8 = new AntdUI.Badge();
            this.badge9 = new AntdUI.Badge();
            this.badge10 = new AntdUI.Badge();
            this.badge11 = new AntdUI.Badge();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.badge7 = new AntdUI.Badge();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.badge5 = new AntdUI.Badge();
            this.badge3 = new AntdUI.Badge();
            this.badge2 = new AntdUI.Badge();
            this.badge1 = new AntdUI.Badge();
            this.badge6 = new AntdUI.Badge();
            this.label3 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel9.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Description = "图标右上角的圆形徽标数字。";
            this.header1.DividerShow = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header1.Size = new System.Drawing.Size(750, 74);
            this.header1.TabIndex = 21;
            this.header1.Text = "Badge 徽标数";
            this.header1.UseTitleFont = true;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel9);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 74);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(750, 393);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel9
            // 
            this.flowPanel9.Controls.Add(this.button30);
            this.flowPanel9.Controls.Add(this.button31);
            this.flowPanel9.Controls.Add(this.button32);
            this.flowPanel9.Controls.Add(this.button38);
            this.flowPanel9.Controls.Add(this.button40);
            this.flowPanel9.Controls.Add(this.button41);
            this.flowPanel9.Location = new System.Drawing.Point(3, 195);
            this.flowPanel9.Name = "flowPanel9";
            this.flowPanel9.Size = new System.Drawing.Size(744, 44);
            this.flowPanel9.TabIndex = 31;
            this.flowPanel9.Text = "flowPanel9";
            // 
            // button30
            // 
            this.button30.BadgeSvg = "DeleteFilled";
            this.button30.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button30.Location = new System.Drawing.Point(433, 3);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(80, 38);
            this.button30.TabIndex = 5;
            this.button30.Text = "Info";
            this.button30.Type = AntdUI.TTypeMini.Info;
            // 
            // button31
            // 
            this.button31.BadgeSvg = resources.GetString("button31.BadgeSvg");
            this.button31.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button31.Location = new System.Drawing.Point(347, 3);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(80, 38);
            this.button31.TabIndex = 4;
            this.button31.Text = "Error";
            this.button31.Type = AntdUI.TTypeMini.Error;
            // 
            // button32
            // 
            this.button32.Badge = "1";
            this.button32.BadgeAlign = AntdUI.TAlign.BR;
            this.button32.BadgeBack = System.Drawing.Color.Orange;
            this.button32.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button32.Location = new System.Drawing.Point(261, 3);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(80, 38);
            this.button32.TabIndex = 3;
            this.button32.Text = "Warn";
            this.button32.Type = AntdUI.TTypeMini.Warn;
            // 
            // button38
            // 
            this.button38.Badge = "99+";
            this.button38.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button38.Location = new System.Drawing.Point(175, 3);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(80, 38);
            this.button38.TabIndex = 2;
            this.button38.Text = "Success";
            this.button38.Type = AntdUI.TTypeMini.Success;
            // 
            // button40
            // 
            this.button40.Badge = "1";
            this.button40.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button40.Location = new System.Drawing.Point(89, 3);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(80, 38);
            this.button40.TabIndex = 1;
            this.button40.Text = "Primary";
            this.button40.Type = AntdUI.TTypeMini.Primary;
            // 
            // button41
            // 
            this.button41.Badge = "";
            this.button41.Cursor = System.Windows.Forms.Cursors.Default;
            this.button41.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button41.Location = new System.Drawing.Point(3, 3);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(80, 38);
            this.button41.TabIndex = 0;
            this.button41.Text = "Default";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(744, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "控件组合";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.badge12);
            this.flowPanel3.Controls.Add(this.badge4);
            this.flowPanel3.Controls.Add(this.badge8);
            this.flowPanel3.Controls.Add(this.badge9);
            this.flowPanel3.Controls.Add(this.badge10);
            this.flowPanel3.Controls.Add(this.badge11);
            this.flowPanel3.Location = new System.Drawing.Point(3, 121);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(744, 38);
            this.flowPanel3.TabIndex = 29;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // badge12
            // 
            this.badge12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge12.Location = new System.Drawing.Point(193, 3);
            this.badge12.Name = "badge12";
            this.badge12.Size = new System.Drawing.Size(32, 32);
            this.badge12.State = AntdUI.TState.Processing;
            this.badge12.TabIndex = 13;
            // 
            // badge4
            // 
            this.badge4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge4.Location = new System.Drawing.Point(155, 3);
            this.badge4.Name = "badge4";
            this.badge4.Size = new System.Drawing.Size(32, 32);
            this.badge4.State = AntdUI.TState.Warn;
            this.badge4.TabIndex = 10;
            // 
            // badge8
            // 
            this.badge8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge8.Location = new System.Drawing.Point(117, 3);
            this.badge8.Name = "badge8";
            this.badge8.Size = new System.Drawing.Size(32, 32);
            this.badge8.State = AntdUI.TState.Error;
            this.badge8.TabIndex = 8;
            // 
            // badge9
            // 
            this.badge9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge9.Location = new System.Drawing.Point(79, 3);
            this.badge9.Name = "badge9";
            this.badge9.Size = new System.Drawing.Size(32, 32);
            this.badge9.State = AntdUI.TState.Primary;
            this.badge9.TabIndex = 7;
            // 
            // badge10
            // 
            this.badge10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge10.Location = new System.Drawing.Point(41, 3);
            this.badge10.Name = "badge10";
            this.badge10.Size = new System.Drawing.Size(32, 32);
            this.badge10.State = AntdUI.TState.Success;
            this.badge10.TabIndex = 6;
            // 
            // badge11
            // 
            this.badge11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge11.Location = new System.Drawing.Point(3, 3);
            this.badge11.Name = "badge11";
            this.badge11.Size = new System.Drawing.Size(32, 32);
            this.badge11.TabIndex = 5;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.badge7);
            this.flowPanel2.Location = new System.Drawing.Point(3, 77);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(744, 38);
            this.flowPanel2.TabIndex = 28;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // badge7
            // 
            this.badge7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge7.Location = new System.Drawing.Point(3, 3);
            this.badge7.Name = "badge7";
            this.badge7.Size = new System.Drawing.Size(120, 32);
            this.badge7.State = AntdUI.TState.Processing;
            this.badge7.TabIndex = 12;
            this.badge7.Text = "Processing";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.badge5);
            this.flowPanel1.Controls.Add(this.badge3);
            this.flowPanel1.Controls.Add(this.badge2);
            this.flowPanel1.Controls.Add(this.badge1);
            this.flowPanel1.Controls.Add(this.badge6);
            this.flowPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(744, 38);
            this.flowPanel1.TabIndex = 27;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // badge5
            // 
            this.badge5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge5.Location = new System.Drawing.Point(507, 3);
            this.badge5.Name = "badge5";
            this.badge5.Size = new System.Drawing.Size(120, 32);
            this.badge5.State = AntdUI.TState.Warn;
            this.badge5.TabIndex = 10;
            this.badge5.Text = "Warn";
            // 
            // badge3
            // 
            this.badge3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge3.Location = new System.Drawing.Point(381, 3);
            this.badge3.Name = "badge3";
            this.badge3.Size = new System.Drawing.Size(120, 32);
            this.badge3.State = AntdUI.TState.Error;
            this.badge3.TabIndex = 8;
            this.badge3.Text = "Error";
            // 
            // badge2
            // 
            this.badge2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge2.Location = new System.Drawing.Point(255, 3);
            this.badge2.Name = "badge2";
            this.badge2.Size = new System.Drawing.Size(120, 32);
            this.badge2.State = AntdUI.TState.Primary;
            this.badge2.TabIndex = 7;
            this.badge2.Text = "Primary";
            // 
            // badge1
            // 
            this.badge1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge1.Location = new System.Drawing.Point(129, 3);
            this.badge1.Name = "badge1";
            this.badge1.Size = new System.Drawing.Size(120, 32);
            this.badge1.State = AntdUI.TState.Success;
            this.badge1.TabIndex = 6;
            this.badge1.Text = "Success";
            // 
            // badge6
            // 
            this.badge6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.badge6.Location = new System.Drawing.Point(3, 3);
            this.badge6.Name = "badge6";
            this.badge6.Size = new System.Drawing.Size(120, 32);
            this.badge6.TabIndex = 5;
            this.badge6.Text = "Default";
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
            // BadgeDemo
            // 
            
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.header1);
            this.Name = "BadgeDemo";
            this.Size = new System.Drawing.Size(750, 467);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel9.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader header1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Badge badge6;
        private AntdUI.Badge badge5;
        private AntdUI.Badge badge3;
        private AntdUI.Badge badge2;
        private AntdUI.Badge badge1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Badge badge7;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Badge badge4;
        private AntdUI.Badge badge8;
        private AntdUI.Badge badge9;
        private AntdUI.Badge badge10;
        private AntdUI.Badge badge11;
        private AntdUI.Badge badge12;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel9;
        private AntdUI.Button button30;
        private AntdUI.Button button31;
        private AntdUI.Button button32;
        private AntdUI.Button button38;
        private AntdUI.Button button40;
        private AntdUI.Button button41;
    }
}
