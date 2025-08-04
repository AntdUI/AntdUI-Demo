using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class StackPanelDemo : UserControl
    {
        public StackPanelDemo()
        {
            InitializeComponent();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void StackPanelDemo_Load(object sender, EventArgs e)
        {
            LoadStackPanel();
        }

        private void LoadStackPanel()
        {
            stackPanel.AutoScroll = switch_autoscroll.Checked;
            stackPanel.Gap = (int)input_gap.Value;
            stackPanel.ItemSize = input_itemsize.Text;
            stackPanel.Vertical = switch_vertical.Checked;

            stackPanel.Controls.Clear();
            for (int i = 1; i < 4; i++)
            {
                var control = new AntdUI.Button()
                {
                    Margin = new Padding(0),
                    Padding = new Padding(3),
                    Text = $"Button{i}",
                    Type = TTypeMini.Primary,
                    WaveSize = 0,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                };
                stackPanel.Controls.Add(control);
                control.BringToFront();
            }
        }

        private void BindEventHandler()
        {
            buttonCZ.Click += ButtonCZ_Click;
            buttonADD.Click += ButtonADD_Click;
            buttonDEL.Click += ButtonDEL_Click;

            switch_autoscroll.CheckedChanged += switch_CheckedChanged;
            switch_vertical.CheckedChanged += switch_CheckedChanged;

            input_gap.ValueChanged += input_gap_ValueChanged;

            input_itemsize.TextChanged += input_itemsize_TextChanged;
        }

        private void switch_CheckedChanged(object sender, BoolEventArgs e)
        {
            stackPanel.AutoScroll = switch_autoscroll.Checked;
            stackPanel.Vertical = switch_vertical.Checked;
        }

        private void InitData()
        {
            input_gap.Value = 0;
            switch_autoscroll.Checked = false;
            switch_vertical.Checked = true;
            input_itemsize.Text = "10%";
        }

        #region 事件

        private void input_itemsize_TextChanged(object sender, EventArgs e)
        {
            if (stackPanel.InvokeRequired)
            {
                stackPanel.Invoke(new Action(() =>
                {
                    stackPanel.ItemSize = input_itemsize.Text;
                }));
            }
            else
            {
                stackPanel.ItemSize = input_itemsize.Text;
            }
        }

        private void input_gap_ValueChanged(object sender, DecimalEventArgs e)
        {
            if (stackPanel.InvokeRequired)
            {
                stackPanel.Invoke(new Action(() =>
                {
                    stackPanel.Gap = (int)input_gap.Value;
                }));
            }
            else
            {
                stackPanel.Gap = (int)input_gap.Value;
            }
        }

        private void ButtonDEL_Click(object sender, EventArgs e)
        {
            if (stackPanel.Controls.Count > 0)
            {
                // 删除最后一个控件
                stackPanel.Controls.RemoveAt(0);
            }
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            var control = new AntdUI.Button()
            {
                Margin = new Padding(0),
                Padding = new Padding(3),
                Text = $"Button{stackPanel.Controls.Count + 1}",
                Type = TTypeMini.Primary,
                WaveSize = 0,
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
            };
            stackPanel.Controls.Add(control);
            control.BringToFront();
        }

        private void ButtonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            LoadStackPanel();
        }
        #endregion

    }
}
