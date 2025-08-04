using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class CollapseDemo : UserControl
    {
        private AntdUI.Window window;
        public CollapseDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            collapse1.ExpandChanged += Collapse_ExpandChanged;
        }

        private void Collapse_ExpandChanged(object sender, AntdUI.CollapseExpandEventArgs e)
        {
            //关闭和打开都会触发
            string str = e.Expand ? "open" : "close";
            AntdUI.Notification.info(window, str, e.Value.ToString(),autoClose:3);
        }
    }
}
