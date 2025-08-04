using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class NotificationDemo : UserControl
    {
        private AntdUI.Window window;
        public NotificationDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_TR.Click += Button_Click;
            button_TL.Click += Button_Click;
            button_Top.Click += Button_Click;
            button_BR.Click += Button_Click;
            button_BL.Click += Button_Click;
            button_Bottom.Click += Button_Click;

            button_error.Click += Button_error_Click;
            button_info.Click += Button_info_Click;
            button_success.Click += Button_success_Click;
            button_warn.Click += Button_warn_Click;

            button_close.Click += Button_close_Click;
            button_clickclose.Click += Button_clickclose_Click;

            button_link.Click += Button_link_Click;
        }

        private void Button_clickclose_Click(object sender, EventArgs e)
        {
            Notification.open(new Notification.Config(window, "Notification", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", TType.Info, TAlignFrom.TR)
            {
                ClickClose = false,
                CloseIcon = false
            });
        }

        private void Button_link_Click(object sender, EventArgs e)
        {
            AntdUI.Notification.open(new AntdUI.Notification.Config(window, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", TType.Info, TAlignFrom.TR)
            {
                Padding = new Size(24, 20),
                CloseIcon = false,
                Link = new Notification.ConfigLink("Link to...", () =>
                {
                    AntdUI.Message.info(window, "Welcome!");
                    return true;
                })
            });
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            AntdUI.Notification.open(new AntdUI.Notification.Config(window, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", TType.Info, TAlignFrom.TR)
            {
                Padding = new Size(24, 20),
                CloseIcon = false,
            });
        }

        private void Button_warn_Click(object sender, EventArgs e)
        {
            AntdUI.Notification.warn(window, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", autoClose: 3, align: TAlignFrom.TR);
        }

        private void Button_success_Click(object sender, EventArgs e)
        {
            AntdUI.Notification.success(window, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", autoClose: 3, align: TAlignFrom.TR);
        }

        private void Button_info_Click(object sender, EventArgs e)
        {
            AntdUI.Notification.info(window, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", autoClose: 3, align: TAlignFrom.TR);
        }

        private void Button_error_Click(object sender, EventArgs e)
        {
            AntdUI.Notification.error(window, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", autoClose: 3, align: TAlignFrom.TR);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = (AntdUI.Button)sender;
            var text = button.Text;
            var align = TAlignFrom.TR;
            switch (text)
            {
                case "TL":
                    align = TAlignFrom.TL;
                    AntdUI.Notification.info(window, $"Notification {align}", "Hello AntdUI Demo!", autoClose: 3, align: align);
                    break;
                case "TR":
                    align = TAlignFrom.TR;
                    AntdUI.Notification.info(window, $"Notification {align}", "Hello AntdUI Demo!", autoClose: 3, align: align);
                    break;
                case "Top":
                    align = TAlignFrom.Top;
                    AntdUI.Notification.info(window, $"Notification {align}", "Hello AntdUI Demo!", autoClose: 3, align: align);
                    break;
                case "BR":
                    align = TAlignFrom.BR;
                    AntdUI.Notification.info(window, $"Notification {align}", "Hello AntdUI Demo!", autoClose: 3, align: align);
                    break;
                case "BL":
                    align = TAlignFrom.BL;
                    AntdUI.Notification.info(window, $"Notification {align}", "Hello AntdUI Demo!", autoClose: 3, align: align);
                    break;
                case "Bottom":
                    align = TAlignFrom.Bottom;
                    AntdUI.Notification.info(window, $"Notification {align}", "Hello AntdUI Demo!", autoClose: 3, align: align);
                    break;
            }
        }


    }
}
