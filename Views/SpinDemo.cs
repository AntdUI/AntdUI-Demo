using AntdUI;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class SpinDemo : UserControl
    {
        private AntdUI.Window window;
        public SpinDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_control.Click += Button_control_Click;
            button_base.Click += Button_base_Click;

            button_custom.Click += Button_custom_Click;
            button_window.Click += Button_window_Click;
        }

        private void Button_control_Click(object sender, EventArgs e)
        {
            AntdUI.Spin.open(label_spin, new Spin.Config()
            {
                Back = Color.FromArgb(220, 147, 181, 207),
                Color = Style.Db.Primary,//转圈颜色
                Radius = 6,
                Font = new Font("Microsoft YaHei UI", 7f),//字体可以控制进度圈的大小

            }, (config) =>
            {
                //耗时代码，处理数据
                Thread.Sleep(3000);
            }, () =>
            {
                //结束时执行的代码
            });
        }

        private void Button_window_Click(object sender, EventArgs e)
        {
            AntdUI.Spin.open(window, new AntdUI.Spin.Config()
            {
                Back = Color.FromArgb(220, 147, 181, 207),
                Color = Style.Db.Primary,//转圈颜色
                Radius = 6,
                Fore = Color.Black,//字体颜色
                Font = new Font("Microsoft YaHei UI", 14f),//字体可以控制进度圈的大小
            }, (config) =>
            {
                //耗时代码，处理数据
                config.Text = "正在处理中,当前进度0%...";
                Thread.Sleep(1000);
                //value范围:0-1
                config.Value = 0.2f;
                config.Text = "正在处理中,当前进度20%...";
                Thread.Sleep(1000);
                config.Value = 0.5f;
                config.Text = "正在处理中,当前进度50%...";
                Thread.Sleep(1000);
                config.Value = 1.0f;
                config.Text = "处理完成!";
                Thread.Sleep(1000);
            }, () =>
            {
                //结束时执行的代码
            });
        }

        private void Button_custom_Click(object sender, EventArgs e)
        {
            AntdUI.Spin.open(this, new AntdUI.Spin.Config()
            {
                Back = Color.FromArgb(220, 147, 181, 207),
                Color = Style.Db.Primary,//转圈颜色
                Radius = 6,
                Fore = Color.Black,//字体颜色
                Font = new Font("Microsoft YaHei UI", 14f),//字体可以控制进度圈的大小
            }, (config) =>
            {
                //耗时代码，处理数据
                config.Text = "正在处理中,当前进度0%...";
                Thread.Sleep(1000);
                //value范围:0-1
                config.Value = 0.2f;
                config.Text = "正在处理中,当前进度20%...";
                Thread.Sleep(1000);
                config.Value = 0.5f;
                config.Text = "正在处理中,当前进度50%...";
                Thread.Sleep(1000);
                config.Value = 1.0f;
                config.Text = "处理完成!";
                Thread.Sleep(1000);
            }, () =>
            {
                //结束时执行的代码
            });
        }

        private void Button_base_Click(object sender, EventArgs e)
        {
            AntdUI.Spin.open(flowPanel1, new AntdUI.Spin.Config()
            {
                Back = Color.FromArgb(220, 147, 181, 207),
                Color = Style.Db.Primary,//转圈颜色
                Radius = 6,
                Font = new Font("Microsoft YaHei UI", 7f),//字体可以控制进度圈的大小
            }, (config) =>
            {
                //耗时代码，处理数据
                Thread.Sleep(3000);
            }, () =>
            {
                //结束时执行的代码
            });
        }
    }
}
