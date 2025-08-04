using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class Image3DDemo : UserControl
    {
        Random random = new Random();
        public Image3DDemo()
        {
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            image3D.Click += Image3D_Click;
            image3D_shadow.Click += Image3D_Click;
            image3D_V.Click += Image3D_Click;
            image3D_shadowV.Click += Image3D_Click;
        }

        private void Image3D_Click(object sender, EventArgs e)
        {
            var image = (AntdUI.Image3D)sender;
            var num = random.Next(1, 4);
            switch (num)
            {
                case 1:
                    image.Image = Properties.Resources.bg1;
                    break;
                case 2:
                    image.Image = Properties.Resources.bg2;
                    break;
                case 3:
                    image.Image = Properties.Resources.bg3;
                    break;
                default:
                    break;
            }
        }
    }
}
