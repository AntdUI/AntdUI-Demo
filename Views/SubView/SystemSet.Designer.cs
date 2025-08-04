namespace AntdUIDemo.Controls
{
    partial class SystemSet
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
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            this.tabs = new AntdUI.Tabs();
            this.tabPage1 = new AntdUI.TabPage();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.stackPanel5 = new AntdUI.StackPanel();
            this.switch_scrollbar = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.stackPanel4 = new AntdUI.StackPanel();
            this.switch_shadow = new AntdUI.Switch();
            this.label3 = new AntdUI.Label();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.switch_animation = new AntdUI.Switch();
            this.label2 = new AntdUI.Label();
            this.tabPage2 = new AntdUI.TabPage();
            this.stackPanel6 = new AntdUI.StackPanel();
            this.stackPanel8 = new AntdUI.StackPanel();
            this.input_offset = new AntdUI.InputNumber();
            this.label6 = new AntdUI.Label();
            this.stackPanel7 = new AntdUI.StackPanel();
            this.switch_showinwindow = new AntdUI.Switch();
            this.label5 = new AntdUI.Label();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.stackPanel1.SuspendLayout();
            this.stackPanel5.SuspendLayout();
            this.stackPanel4.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.stackPanel6.SuspendLayout();
            this.stackPanel8.SuspendLayout();
            this.stackPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tabs.Gap = 12;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(6);
            this.tabs.Name = "tabs";
            this.tabs.Pages.Add(this.tabPage1);
            this.tabs.Pages.Add(this.tabPage2);
            this.tabs.SelectedIndex = 1;
            this.tabs.Size = new System.Drawing.Size(598, 396);
            this.tabs.Style = styleLine1;
            this.tabs.TabIndex = 0;
            this.tabs.Text = "tabs1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stackPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tabPage1.Location = new System.Drawing.Point(-502, -384);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(502, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stackPanel5);
            this.stackPanel1.Controls.Add(this.stackPanel4);
            this.stackPanel1.Controls.Add(this.stackPanel3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(502, 384);
            this.stackPanel1.TabIndex = 1;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stackPanel5
            // 
            this.stackPanel5.Controls.Add(this.switch_scrollbar);
            this.stackPanel5.Controls.Add(this.label4);
            this.stackPanel5.Location = new System.Drawing.Point(3, 79);
            this.stackPanel5.Name = "stackPanel5";
            this.stackPanel5.Size = new System.Drawing.Size(496, 32);
            this.stackPanel5.TabIndex = 3;
            this.stackPanel5.Text = "stackPanel5";
            // 
            // switch_scrollbar
            // 
            this.switch_scrollbar.CheckedText = "";
            this.switch_scrollbar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch_scrollbar.Location = new System.Drawing.Point(189, 3);
            this.switch_scrollbar.Name = "switch_scrollbar";
            this.switch_scrollbar.Size = new System.Drawing.Size(60, 26);
            this.switch_scrollbar.TabIndex = 1;
            this.switch_scrollbar.Text = "switch4";
            this.switch_scrollbar.UnCheckedText = "";
            this.switch_scrollbar.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.LocalizationText = "scrollbarhide";
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "隐藏滚动条";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.switch_shadow);
            this.stackPanel4.Controls.Add(this.label3);
            this.stackPanel4.Location = new System.Drawing.Point(3, 41);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(496, 32);
            this.stackPanel4.TabIndex = 2;
            this.stackPanel4.Text = "stackPanel4";
            // 
            // switch_shadow
            // 
            this.switch_shadow.Checked = true;
            this.switch_shadow.CheckedText = "";
            this.switch_shadow.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch_shadow.Location = new System.Drawing.Point(189, 3);
            this.switch_shadow.Name = "switch_shadow";
            this.switch_shadow.Size = new System.Drawing.Size(60, 26);
            this.switch_shadow.TabIndex = 1;
            this.switch_shadow.Text = "switch3";
            this.switch_shadow.UnCheckedText = "";
            this.switch_shadow.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.LocalizationText = "shadowon";
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "启用阴影";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.switch_animation);
            this.stackPanel3.Controls.Add(this.label2);
            this.stackPanel3.Location = new System.Drawing.Point(3, 3);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(496, 32);
            this.stackPanel3.TabIndex = 1;
            this.stackPanel3.Text = "stackPanel3";
            // 
            // switch_animation
            // 
            this.switch_animation.Checked = true;
            this.switch_animation.CheckedText = "";
            this.switch_animation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch_animation.Location = new System.Drawing.Point(189, 3);
            this.switch_animation.Name = "switch_animation";
            this.switch_animation.Size = new System.Drawing.Size(60, 26);
            this.switch_animation.TabIndex = 1;
            this.switch_animation.Text = "switch2";
            this.switch_animation.UnCheckedText = "";
            this.switch_animation.WaveSize = 0;
            // 
            // label2
            // 
            this.label2.LocalizationText = "animationon";
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "开启动画";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stackPanel6);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(90, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(502, 384);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "消息配置";
            // 
            // stackPanel6
            // 
            this.stackPanel6.Controls.Add(this.stackPanel8);
            this.stackPanel6.Controls.Add(this.stackPanel7);
            this.stackPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel6.Location = new System.Drawing.Point(0, 0);
            this.stackPanel6.Name = "stackPanel6";
            this.stackPanel6.Size = new System.Drawing.Size(502, 384);
            this.stackPanel6.TabIndex = 0;
            this.stackPanel6.Text = "stackPanel6";
            this.stackPanel6.Vertical = true;
            // 
            // stackPanel8
            // 
            this.stackPanel8.Controls.Add(this.input_offset);
            this.stackPanel8.Controls.Add(this.label6);
            this.stackPanel8.Location = new System.Drawing.Point(3, 41);
            this.stackPanel8.Name = "stackPanel8";
            this.stackPanel8.Size = new System.Drawing.Size(496, 32);
            this.stackPanel8.TabIndex = 5;
            this.stackPanel8.Text = "stackPanel8";
            // 
            // input_offset
            // 
            this.input_offset.Location = new System.Drawing.Point(189, 3);
            this.input_offset.Name = "input_offset";
            this.input_offset.Size = new System.Drawing.Size(60, 26);
            this.input_offset.TabIndex = 1;
            this.input_offset.Text = "0";
            this.input_offset.WaveSize = 0;
            // 
            // label6
            // 
            this.label6.LocalizationText = "windowOffsetXY";
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "边界偏移量";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stackPanel7
            // 
            this.stackPanel7.Controls.Add(this.switch_showinwindow);
            this.stackPanel7.Controls.Add(this.label5);
            this.stackPanel7.Location = new System.Drawing.Point(3, 3);
            this.stackPanel7.Name = "stackPanel7";
            this.stackPanel7.Size = new System.Drawing.Size(496, 32);
            this.stackPanel7.TabIndex = 4;
            this.stackPanel7.Text = "stackPanel7";
            // 
            // switch_showinwindow
            // 
            this.switch_showinwindow.CheckedText = "";
            this.switch_showinwindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch_showinwindow.Location = new System.Drawing.Point(189, 3);
            this.switch_showinwindow.Name = "switch_showinwindow";
            this.switch_showinwindow.Size = new System.Drawing.Size(60, 26);
            this.switch_showinwindow.TabIndex = 1;
            this.switch_showinwindow.Text = "switch5";
            this.switch_showinwindow.UnCheckedText = "";
            this.switch_showinwindow.WaveSize = 0;
            // 
            // label5
            // 
            this.label5.LocalizationText = "showinwindow";
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "窗口内弹出";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SystemSet
            // 
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SystemSet";
            this.Size = new System.Drawing.Size(598, 396);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel5.ResumeLayout(false);
            this.stackPanel4.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.stackPanel6.ResumeLayout(false);
            this.stackPanel8.ResumeLayout(false);
            this.stackPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Tabs tabs;
        private AntdUI.TabPage tabPage1;
        private AntdUI.TabPage tabPage2;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.StackPanel stackPanel5;
        private AntdUI.Switch switch_scrollbar;
        private AntdUI.Label label4;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.Switch switch_shadow;
        private AntdUI.Label label3;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.Switch switch_animation;
        private AntdUI.Label label2;
        private AntdUI.StackPanel stackPanel6;
        private AntdUI.StackPanel stackPanel7;
        private AntdUI.Switch switch_showinwindow;
        private AntdUI.Label label5;
        private AntdUI.StackPanel stackPanel8;
        private AntdUI.Label label6;
        private AntdUI.InputNumber input_offset;
    }
}
