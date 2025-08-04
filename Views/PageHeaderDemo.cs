using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class PageHeaderDemo : UserControl
    {
        private AntdUI.Window window;
        public PageHeaderDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            pageHeader_click.Click += PageHeader_click_Click;
        }

        private void PageHeader_click_Click(object sender, EventArgs e)
        {
            AntdUI.Message.info(window, "返回到上一层", autoClose: 1);
        }
    }
}
