using AntdUI;
using AntdUIDemo.Views.SubView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class TourDemo : UserControl
    {
        private AntdUI.Window window;
        private AntdUI.TourForm tourForm;
        public TourDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_base.Click += Button_base_Click;
            button_custom.Click += Button_custom_Click;
        }

        private void Button_custom_Click(object sender, EventArgs e)
        {
            if (tourForm == null)
            {
                Form popover = null;
                tourForm = AntdUI.Tour.open(window, item =>
                {
                    //显示位置
                    switch (item.Index)
                    {
                        case 0:
                            item.Set(button1);
                            break;
                        case 1:
                            item.Set(button2);
                            break;
                        case 2:
                            item.Set(button3);
                            break;
                        default:
                            item.Close();
                            tourForm = null;
                            break;
                    }
                }, info =>
                {
                    //提示弹窗
                    popover?.Close();
                    popover = null;
                    //也可以弹自定义控件，用法同Popover
                    TourTest tourTest = new TourTest(info, "提示", "Tour Step " + (info.Index + 1), (info.Index + 1), 3);
                    if (info.Rect.HasValue) popover = AntdUI.Popover.open(new AntdUI.Popover.Config(info.Form, tourTest)
                    {
                        Offset = info.Rect.Value,
                        Focus = false,
                        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                    });
                });
            }
            else
                tourForm.Next();
        }

        private void Button_base_Click(object sender, EventArgs e)
        {
            if (tourForm == null)
            {
                Form popover = null;
                tourForm = AntdUI.Tour.open(window, item =>
                {
                    //显示位置
                    switch (item.Index)
                    {
                        case 0:
                            item.Set(button1);
                            break;
                        case 1:
                            item.Set(button2);
                            break;
                        case 2:
                            item.Set(button3);
                            break;
                        default:
                            item.Close();
                            tourForm = null;
                            break;
                    }
                }, info =>
                {
                    //提示弹窗
                    popover?.Close();
                    popover = null;
                    //也可以弹自定义控件，用法同Popover
                    if (info.Rect.HasValue) popover = AntdUI.Popover.open(new AntdUI.Popover.Config(info.Form, "提示", "第"+(info.Index+1)+"步")
                    {
                        Offset = info.Rect.Value,
                        Focus = false,
                        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                    });
                });
            }
            else
                tourForm.Next();
        }
    }
}
