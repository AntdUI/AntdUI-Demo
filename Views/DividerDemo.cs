using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class DividerDemo : UserControl
    {
        public DividerDemo()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            //或者设计器右键重置Text
            divider_null.Text = null;
        }
    }
}
