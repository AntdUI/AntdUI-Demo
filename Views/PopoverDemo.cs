using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class PopoverDemo : UserControl
    {
        private AntdUI.Window window;
        public PopoverDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_base.Click += button_base_Click;
            button_close.Click += button_close_Click;

            button_control.Click += button_control_Click;
            button_calendar.Click += button_calendar_Click;
            button_form.Click += button_form_Click;

            buttonBL.Click += button_popover_Click;
            buttonBottom.Click += button_popover_Click;
            buttonBR.Click += button_popover_Click;
            buttonLeft.Click += button_popover_Click;
            buttonLB.Click += button_popover_Click;
            buttonLT.Click += button_popover_Click;
            buttonRight.Click += button_popover_Click;
            buttonRB.Click += button_popover_Click;
            buttonRT.Click += button_popover_Click;
            buttonTop.Click += button_popover_Click;
            buttonTL.Click += button_popover_Click;
            buttonTR.Click += button_popover_Click;
        }

        private void button_calendar_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            var popovercalendar = new AntdUI.Calendar()
            {
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                Size = new Size(150, 300),
                Full = true,
            };
            window.AutoDpi(popovercalendar);
            Popover.open(new Popover.Config(button, popovercalendar)
            {
                ArrowAlign = TAlign.TL,
                OnControlLoad = () =>
                {
                    popovercalendar.DateChanged += Popovercalendar_DateChanged;
                }
            });
        }

        private void Popovercalendar_DateChanged(object sender, DateTimeEventArgs e)
        {
            var calendar = sender as AntdUI.Calendar;
            AntdUI.Message.info(window, e.Value.ToString("yyyy-MM-dd"), autoClose: 1);
            //点击完成主动释放日历控件
            calendar.Dispose();
        }

        private void button_form_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            var form = new SwitchDemo();
            form.Size = new Size(500, 500);
            Popover.open(new Popover.Config(button, form)
            {
                ArrowAlign = TAlign.TL,
            });
        }

        private void button_control_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            var popoverbutton = new AntdUI.Button()
            {
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                Size = new Size(90, 32),
                WaveSize = 0,
                Text = "PopoverButton",
                Type = TTypeMini.Primary,
            };
            window.AutoDpi(popoverbutton);
            Popover.open(new Popover.Config(button, popoverbutton)
            {
                OnControlLoad = () =>
                {
                    popoverbutton.Click += Popoverbutton_Click;
                }
            });
        }

        private void Popoverbutton_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            AntdUI.Message.info(window, "点击了PopoverButton", autoClose: 1);
            //点击完成主动释放按钮
            button.Dispose();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Popover.open(new Popover.Config(button_close, "Title", "Content\r\nContent\r\nContent")
            {
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                AutoClose = 1
            });
        }

        private void button_base_Click(object sender, EventArgs e)
        {
            Popover.open(new Popover.Config(button_base, "Title", "Content\r\nContent\r\nContent")
            {
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
            });
        }

        private void button_popover_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            var text = button.Text;
            var align = TAlign.Bottom;
            switch (text)
            {
                case "LT":
                    align = TAlign.LT;
                    break;
                case "LB":
                    align = TAlign.LB;
                    break;
                case "RT":
                    align = TAlign.RT;
                    break;
                case "RB":
                    align = TAlign.RB;
                    break;
                case "TL":
                    align = TAlign.TL;
                    break;
                case "TR":
                    align = TAlign.TR;
                    break;
                case "BL":
                    align = TAlign.BL;
                    break;
                case "BR":
                    align = TAlign.BR;
                    break;
                case "Top":
                    align = TAlign.Top;
                    break;
                case "Bottom":
                    align = TAlign.Bottom;
                    break;
                case "Left":
                    align = TAlign.Left;
                    break;
                case "Right":
                    align = TAlign.Right;
                    break;
                default:
                    align = TAlign.Bottom;
                    break;
            }

            Popover.open(new Popover.Config(button, "Title", "Content\r\nContent\r\nContent")
            {
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                AutoClose = 3,
                ArrowSize = 12,
                ArrowAlign = align,
            });

        }
    }
}
