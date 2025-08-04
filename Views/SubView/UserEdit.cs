using AntdUIDemo.Models;
using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views.Table
{
    public partial class UserEdit : UserControl
    {
        private AntdUI.Window window;
        private User user;
        public bool submit;
        public UserEdit(AntdUI.Window _window, User _user)
        {
            this.window = _window;
            user = _user;
            InitializeComponent();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_ok.Click += Button_ok_Click;
            button_cancel.Click += Button_cancel_Click;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            submit = false;
            this.Dispose();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            input_name.Status = AntdUI.TType.None;
            //检查输入内容
            if (String.IsNullOrEmpty(input_name.Text))
            {
                input_name.Status = AntdUI.TType.Error;
                AntdUI.Message.warn(window, "姓名不能为空！", autoClose: 3);
                return;
            }
            user.Name = input_name.Text;
            user.Address = input_addr.Text;
            user.Age = (int)input_age.Value;
            submit = true;
            this.Dispose();
        }

        private void InitData()
        {
            input_name.Text = user.Name;
            input_addr.Text = user.Address;
            input_age.Value = user.Age;
        }
    }
}
