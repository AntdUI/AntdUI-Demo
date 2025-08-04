using AntdUI;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AntdUIDemo.Views.SubView
{
    public partial class Wellcome : UserControl
    {
        private AntdUI.Window window;
        public Wellcome(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
        }

        private void Wellcome_Load(object sender, System.EventArgs e)
        {
            AntdUI.Spin.open(window, new AntdUI.Spin.Config()
            {
                Radius = 6,
                Font = new Font("Microsoft YaHei UI", 12f),//字体可以控制进度圈的大小
            }, (config) =>
            {
                config.Text = "LOADING...";
                //耗时代码，处理数据
                Thread.Sleep(1000);
            }, () =>
            {
                //结束时执行的代码
                label1.Text = "欢迎使用 AntdUI Demo";
            });
        }
    }
}
