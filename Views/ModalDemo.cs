using AntdUI;
using AntdUIDemo.Controls;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class ModalDemo : UserControl
    {
        private AntdUI.Window window;
        public ModalDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_base.Click += Button_base_Click;
            button_drag.Click += Button_drag_Click;
            button_nobutton.Click += Button_nobutton_Click;
            button_custombutton.Click += Button_custombutton_Click;
            button_nomask.Click += Button_nomask_Click;
            button_noclose.Click += Button_noclose_Click;
            button_close.Click += Button_close_Click;
            button_sys.Click += Button_sys_Click;
        }

        private void Button_drag_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "Basic Modal", "Some contents...\r\nSome contents...\r\nSome contents...")
            {
                Icon = TType.Info,
                //内边距
                Padding = new Size(24, 20),
                //支持拖拽
                Draggable = true,
            });
        }

        private void Button_sys_Click(object sender, EventArgs e)
        {
            using (var form = new SystemSet(window))
            {
                //AutoDpi(form);
                AntdUI.Modal.open(new AntdUI.Modal.Config(window, "系统设置", form, TType.Info)
                {
                    CloseIcon = true,
                    BtnHeight = 0,
                    Keyboard = false,
                    MaskClosable = false,
                });
            }
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "Basic Modal", "Some contents...\r\nSome contents...\r\nSome contents...")
            {
                CloseIcon = true,
                Keyboard = false,
                MaskClosable = false,
            });
        }

        private void Button_noclose_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "Basic Modal", "Some contents...\r\nSome contents...\r\nSome contents...")
            {
                //禁止使用键盘关闭
                Keyboard = false,
                MaskClosable = false,
            });
        }

        private void Button_nomask_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "Basic Modal", "Some contents...\r\nSome contents...\r\nSome contents...")
            {
                Mask = false,
            });
        }

        private void Button_custombutton_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "Basic Modal", "Some contents...\r\nSome contents...\r\nSome contents...")
            {
                Btns = new Modal.Btn[]{ new AntdUI.Modal.Btn("return", "Return", AntdUI.TTypeMini.Default),
                    new AntdUI.Modal.Btn("submit", "Submit", AntdUI.TTypeMini.Warn) },
                CancelText = null,
                OkText = "Search On Google",
                OnOk = config =>
                {
                    //模拟耗时操作
                    Thread.Sleep(2000);
                    AntdUI.Message.info(window, config.OkText, autoClose: 1);
                    return true;
                },
                OnBtns = button =>
                {
                    //1.6.2起，自定义按钮支持异步委托
                    Thread.Sleep(2000);
                    AntdUI.Message.info(window, button.Text, autoClose: 1);
                    switch (button.Text)
                    {
                        case "Return":
                            return false;
                        case "Submit":
                            return true;
                        default:
                            return true;
                    }
                }
            });
        }

        private void Button_nobutton_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "Basic Modal", "Some contents...\r\nSome contents...\r\nSome contents...")
            {
                BtnHeight = 0,
            });
        }

        private void Button_base_Click(object sender, EventArgs e)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "Basic Modal", "Some contents...\r\nSome contents...\r\nSome contents...")
            {
                Icon = TType.Info,
                //内边距
                Padding = new Size(24, 20),
            });
        }
    }
}
