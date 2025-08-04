using AntdUI;
using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class TabsDemo : UserControl
    {
        private AntdUI.Window window;
        public TabsDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void InitSelectItems()
        {
            select_typeexceed.Items.Clear();
            foreach (TabTypExceed typExceed in Enum.GetValues(typeof(TabTypExceed)))
            {
                select_typeexceed.Items.Add(typExceed);
            }
        }

        private void InitData()
        {
            select_typeexceed.SelectedIndex = 0;
        }

        private void BindEventHandler()
        {
            select_typeexceed.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
        }

        private void select_intvalue_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            if (tabs_typeexceed.InvokeRequired)
            {
                tabs_typeexceed.Invoke(new Action(() => { tabs_typeexceed.TypExceed = (TabTypExceed)select_typeexceed.SelectedValue; }));
            }
            else
            {
                tabs_typeexceed.TypExceed = (TabTypExceed)select_typeexceed.SelectedValue;
            }
        }
    }
}
