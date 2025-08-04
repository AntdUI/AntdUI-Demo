using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class GridPanelDemo : UserControl
    {
        public GridPanelDemo()
        {
            InitializeComponent();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void GridPanelDemo_Load(object sender, EventArgs e)
        {
            LoadGridPanel(input_span.Text, input_gap.Value);
        }

        private void InitData()
        {
            input_gap.Value = 0;
            input_span.Text = "50% 50%;20% 80%;150 200;-20% 30% 50%";
        }

        private void BindEventHandler()
        {
            buttonCZ.Click += buttonCZ_Click;

            input_span.TextChanged += input_span_TextChanged;
            input_gap.ValueChanged += input_gap_ValueChanged;
        }

        private void LoadGridPanel(string spantext, decimal gap)
        {
            gridPanel.Controls.Clear();
            if (gridPanel.InvokeRequired)
            {
                gridPanel.Invoke(new Action(() => LoadGridPanel(spantext, gap)));
                return;
            }
            gridPanel.Span = spantext;
            gridPanel.Gap = (int)gap;
            spantext = spantext.Substring(0, spantext.IndexOf('-'));
            string[] array = spantext.Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < array.Length + 1; i++)
            {
                var control = new AntdUI.Button()
                {
                    Text = "Button" + i,
                    Type = TTypeMini.Primary,
                    WaveSize = 0,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                };
                gridPanel.Controls.Add(control);
                control.BringToFront();
            }
        }

        #region 事件
        private void input_gap_ValueChanged(object sender, DecimalEventArgs e)
        {
            LoadGridPanel(input_span.Text, input_gap.Value);
        }

        private void input_span_TextChanged(object sender, EventArgs e)
        {
            LoadGridPanel(input_span.Text, input_gap.Value);
        }

        private void buttonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            LoadGridPanel(input_span.Text, 0);
        }
        #endregion
    }
}
