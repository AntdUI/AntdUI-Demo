using AntdUI;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class MessageDemo : UserControl
    {
        private AntdUI.Window window;
        public MessageDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_sucess.Click += Button_Click;
            button_error.Click += Button_Click;
            button_info.Click += Button_Click;
            button_warn.Click += Button_Click;

            button_e.Click += Button_loading_Click;
            button_i.Click += Button_loading_Click;
            button_w.Click += Button_loading_Click;
            button_s.Click += Button_loading_Click;

            button_BL.Click += Button_Align_Click;
            button_Bottom.Click += Button_Align_Click;
            button_BR.Click += Button_Align_Click;
            button_TL.Click += Button_Align_Click;
            button_Top.Click += Button_Align_Click;
            button_TR.Click += Button_Align_Click;

            button_clickclose.Click += Button_clickclose_Click;
        }

        private void Button_clickclose_Click(object sender, EventArgs e)
        {
            AntdUI.Message.open(new AntdUI.Message.Config(window, "Hello AntdUI Demo!", TType.Info)
            {
                ClickClose = false
            });
        }

        private void Button_Align_Click(object sender, EventArgs e)
        {
            var button = (AntdUI.Button)sender;
            var text = button.Text;
            var align = TAlignFrom.TR;
            switch (text)
            {
                case "TL":
                    align = TAlignFrom.TL;
                    break;
                case "TR":
                    align = TAlignFrom.TR;
                    break;
                case "Top":
                    align = TAlignFrom.Top;
                    break;
                case "BR":
                    align = TAlignFrom.BR;
                    break;
                case "BL":
                    align = TAlignFrom.BL;
                    break;
                case "Bottom":
                    align = TAlignFrom.Bottom;
                    break;
            }
            AntdUI.Message.open(new AntdUI.Message.Config(window, "Hello AntdUI Demo!", TType.Info)
            {
                AutoClose = 3,
                Align = align
            });
        }

        private void Button_loading_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            button.Loading = true;
            var text = button.Text;
            switch (text)
            {
                case "Success":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        config.Padding = new Size(12, 9);
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.OK("加载成功");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
                case "Error":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        config.Padding = new Size(12, 9);
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.Error("加载失败");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
                case "Info":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        config.Padding = new Size(12, 9);
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.Info("加载提示");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
                case "Warn":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        config.Padding = new Size(12, 9);
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.Warn("加载警告");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            var text = button.Text;
            switch (text)
            {
                //autoClose: 0 不自动关闭, 单位为秒
                case "Success":
                    AntdUI.Message.success(window, "This is a success message", autoClose: 3);
                    break;
                case "Error":
                    AntdUI.Message.error(window, "This is an error message", autoClose: 3);
                    break;
                case "Info":
                    AntdUI.Message.info(window, "This is an info message", autoClose: 3);
                    break;
                case "Warn":
                    AntdUI.Message.warn(window, "This is a warn message", autoClose: 3);
                    break;
            }
        }
    }
}
