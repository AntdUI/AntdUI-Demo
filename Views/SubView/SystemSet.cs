using AntdUI;
using AntdUIDemo.Utils;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AntdUIDemo.Controls
{
    public partial class SystemSet : UserControl
    {
        private readonly Window Window;
        public SystemSet(Window _window)
        {
            Window = _window;
            InitializeComponent();
            //设置默认值
            InitData();
            //绑定事件
            BindingEventHandler();
        }

        private void BindingEventHandler()
        {
            switch_animation.CheckedChanged += Switch_animation_CheckedChanged;
            switch_shadow.CheckedChanged += Switch_shadow_CheckedChanged;
            switch_scrollbar.CheckedChanged += Switch_scrollbar_CheckedChanged;
            switch_showinwindow.CheckedChanged += Switch_showinwindow_CheckedChanged;
            input_offset.ValueChanged += Input_offset_ValueChanged;

        }

        private void InitData()
        {
            tabs.SelectedIndex = 0;
            switch_animation.Checked = Config.Animation;
            switch_shadow.Checked = Config.ShadowEnabled;
            switch_scrollbar.Checked = Config.ScrollBarHide;
            switch_showinwindow.Checked = Config.ShowInWindow;
            input_offset.Value = Config.NoticeWindowOffsetXY;

            //global
            tabs.Pages[0].Text = AntdUI.Localization.Get("baseset", "基本设置");
            tabs.Pages[1].Text = AntdUI.Localization.Get("messageconfig", "消息配置");

        }

        #region 事件
        private void Switch_animation_CheckedChanged(object sender, BoolEventArgs e)
        {
            AntdUI.Config.Animation = e.Value;
        }

        private void Input_offset_ValueChanged(object sender, DecimalEventArgs e)
        {
            AntdUI.Config.NoticeWindowOffsetXY = (int)e.Value;
        }

        private void Switch_showinwindow_CheckedChanged(object sender, BoolEventArgs e)
        {
            AntdUI.Config.ShowInWindow = e.Value;
            string text = AntdUI.Localization.Get("switchsuccess", "切换成功！");
            string tip = AntdUI.Localization.Get("tip", "提示");
            AntdUI.Message.success(Window, text, autoClose: 1);
            AntdUI.Notification.success(Window, tip, text, autoClose: 1);
        }

        private void Switch_scrollbar_CheckedChanged(object sender, BoolEventArgs e)
        {
            AntdUI.Config.ScrollBarHide = e.Value;
        }

        private void Switch_shadow_CheckedChanged(object sender, BoolEventArgs e)
        {
            AntdUI.Config.ShadowEnabled = e.Value;
        }
        #endregion


    }
}
