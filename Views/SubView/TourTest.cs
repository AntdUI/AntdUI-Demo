using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AntdUIDemo.Views.SubView
{
    public partial class TourTest : UserControl
    {
        AntdUI.Tour.Popover popover;
        public TourTest(AntdUI.Tour.Popover _popover, string title, string text, int step, int max)
        {
            popover = _popover;
            InitializeComponent();
            InitData(title, text, step ,max);
            BindEventHandler();
            
        }

        private void InitData(string title,string text,int step ,int max)
        {
            label1.Text = title;
            label2.Text = text;
            label3.Text = step + " / " + max;
            if (step == max)
            {
                button_next.LocalizationText = "Finish";
                button_next.Text = "完成";
            }
            button_previous.Visible = step > 1;
            if (button_previous.Visible)
            {
                int w1 = (int)(label1.PSize.Width / AntdUI.Config.Dpi), w = (int)((label2.PSize.Width + button_previous.PSize.Width + button_next.PSize.Width) / AntdUI.Config.Dpi);
                Width = w1 > w ? w1 : w;
            }
        }

        private void BindEventHandler()
        {
            button_previous.Click += Button_previous_Click;
            button_next.Click += Button_next_Click;
        }

        private void Button_next_Click(object sender, EventArgs e)
        {
            popover.Tour.Next();
        }

        private void Button_previous_Click(object sender, EventArgs e)
        {
            popover.Tour.Previous();
        }
    }
}
