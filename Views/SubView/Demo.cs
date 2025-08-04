using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class Demo : UserControl
    {
        public Demo()
        {
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_close.Click += button_close_Click;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
