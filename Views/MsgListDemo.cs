using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class MsgListDemo : UserControl
    {
        public MsgListDemo()
        {
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            Task.Factory.StartNew(() =>
            {
                msgList.Items.Add(new AntdUI.Chat.MsgItem("WPF / Flutter UI", Properties.Resources.head)
                {
                    Select = true,
                    Text = "AduSkin：我初三就上班啦",
                    Time = DateTime.Now.ToString("HH:mm:ss")
                });
                Thread.Sleep(1000);
                msgList.Items.Add(new AntdUI.Chat.MsgItem("宝宝", Properties.Resources.head)
                {
                    Text = "今天给你买一束花",
                    Time = DateTime.Now.ToString("HH:mm:ss")
                });
                Thread.Sleep(1000);
                msgList.Items.Add(new AntdUI.Chat.MsgItem("AntdUI", Properties.Resources.head)
                {
                    Text = "Tom：❤AntDesign设计语言的Winform界面库",
                    Time = DateTime.Now.ToString("HH:mm:ss")
                });
                Thread.Sleep(1000);
                msgList.Items.Add(new AntdUI.Chat.MsgItem("AntdUI", Properties.Resources.head)
                {
                    Text = "晚上一起 Crazy Day 4",
                    Time = "疯狂星期四"
                });
            });
        }
    }
}
