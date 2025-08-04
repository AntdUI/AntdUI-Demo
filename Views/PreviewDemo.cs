using AntdUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class PreviewDemo : UserControl
    {
        private AntdUI.Window window;
        public PreviewDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_view.Click += Button_view_Click;
            button_views.Click += Button_views_Click;
        }

        private void Button_views_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, new List<Image>() {
                Properties.Resources.bg1, Properties.Resources.bg2, Properties.Resources.bg3 }));
        }

        private void Button_view_Click(object sender, EventArgs e)
        {
            Preview.open(new Preview.Config(window, Properties.Resources.bg1));
        }
    }
}
