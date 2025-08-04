using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class FlowPanelDemo : UserControl
    {
        private Window window;
        public FlowPanelDemo(Window _window)
        {
            window = _window;
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void FlowPanelDemo_Load(object sender, EventArgs e)
        {
            //初始化FlowPanel
            LoadFlowPanel();
        }

        //初始化panel
        private void LoadFlowPanel()
        {
            flowPanel.Align = (TAlignFlow)select_align.SelectedValue;
            flowPanel.Gap = (int)input_gap.Value;
            flowPanel.AutoScroll = switch_autoscroll.Checked;

            flowPanel.Controls.Clear();
            for (int i = 1; i < 15; i++)
            {
                var control = new AntdUI.Button()
                {
                    Text = "Button" + i,
                    Type = TTypeMini.Primary,
                    WaveSize = 0,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                    Size = new Size(90, 42),

                };
                // 通过主窗口设置DPI控制添加控件保持缩放比例
                window.AutoDpi(control);
                flowPanel.Controls.Add(control);
                control.BringToFront();
            }
        }

        // 设置默认值
        private void InitData()
        {
            select_align.SelectedIndex = 0;
            switch_autoscroll.Checked = false;
            input_gap.Value = 0;
        }

        // 绑定按钮事件
        private void BindEventHandler()
        {
            buttonCZ.Click += buttonCZ_Click;
            buttonADD.Click += buttonADD_Click;
            buttonDEL.Click += buttonDEL_Click;

            select_align.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;

            switch_autoscroll.CheckedChanged += switch_autoscroll_CheckedChanged;

            input_gap.ValueChanged += input_gap_ValueChanged;
        }

        private void switch_autoscroll_CheckedChanged(object sender, BoolEventArgs e)
        {
            if (flowPanel.InvokeRequired)
            {
                flowPanel.Invoke(new Action(() => { flowPanel.AutoScroll = switch_autoscroll.Checked; }));
            }
            else
            {
                flowPanel.AutoScroll = switch_autoscroll.Checked;
            }
        }

        // 初始化下拉框
        private void InitSelectItems()
        {
            //初始化方向
            select_align.Items.Clear();
            foreach (TAlignFlow align in Enum.GetValues(typeof(TAlignFlow)))
            {
                select_align.Items.Add(align);
            }
        }

        #region 事件
        private void select_intvalue_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            if (flowPanel.InvokeRequired)
            {
                flowPanel.Invoke(new Action(() => { flowPanel.Align = (TAlignFlow)select_align.SelectedValue; }));
            }
            else
            {
                flowPanel.Align = (TAlignFlow)select_align.SelectedValue;
            }
        }

        private void input_gap_ValueChanged(object sender, DecimalEventArgs e)
        {
            if (flowPanel.InvokeRequired)
            {
                flowPanel.Invoke(new Action(() => { flowPanel.Gap = (int)input_gap.Value; }));
            }
            else
            {
                flowPanel.Gap = (int)input_gap.Value;
            }
        }
        // 添加按钮
        private void buttonADD_Click(object sender, EventArgs e)
        {
            var control = new AntdUI.Button()
            {
                Text = "Button" + (flowPanel.Controls.Count+1),
                Type = TTypeMini.Primary,
                WaveSize = 0,
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                Size = new Size(90, 42),

            };
            window.AutoDpi(control);
            flowPanel.Controls.Add(control);
            control.BringToFront();
        }

        // 删除按钮
        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (flowPanel.Controls.Count > 0)
            {
                // 删除最后一个控件
                flowPanel.Controls.RemoveAt(0);
            }
        }

        // 重置
        private void buttonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            LoadFlowPanel();
        }
        #endregion
    }
}
