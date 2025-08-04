using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class FloatButtonDemo : UserControl
    {
        private Window window;
        private FormFloatButton floatButtonForm = null;
        public FloatButtonDemo(Window _window)
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

        private void BindEventHandler()
        {
            buttonOpen.Click += ButtonOpen_Click;
            buttonClose.Click += buttonClose_Click;
            buttonCZ.Click += buttonCZ_Click;

            select_align.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_type.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;

            switch_round.CheckedChanged += Switch_CheckedChanged;
            switch_vertical.CheckedChanged += Switch_CheckedChanged;
            switch_topmost.CheckedChanged += Switch_CheckedChanged;
            switch_enabled.CheckedChanged += Switch_CheckedChanged;
            switch_loading.CheckedChanged += Switch_CheckedChanged;

            input_size.ValueChanged += input_decimalvalue_ValeChanged;
            input_mx.ValueChanged += input_decimalvalue_ValeChanged;
            input_my.ValueChanged += input_decimalvalue_ValeChanged;
            input_gap.ValueChanged += input_decimalvalue_ValeChanged;
            input_radius.ValueChanged += input_decimalvalue_ValeChanged;
            input_badgesize.ValueChanged += input_decimalvalue_ValeChanged;

            input_badge.TextChanged += input_badge_TextChanged;

            colorPicker.ValueChanged += colorPicker_ValueChanged;
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            LoadFloatButton();
        }

        // 初始化下拉框
        private void InitSelectItems()
        {
            //初始化方向
            select_align.Items.Clear();
            foreach (TAlign align in Enum.GetValues(typeof(TAlign)))
            {
                select_align.Items.Add(align);
            }
            //初始化类型
            select_type.Items.Clear();
            foreach (TTypeMini type in Enum.GetValues(typeof(TTypeMini)))
            {
                select_type.Items.Add(type);
            }
        }

        // 设置默认值
        private void InitData()
        {
            select_align.SelectedIndex = 7;
            select_type.SelectedIndex = 0;

            switch_round.Checked = false;
            switch_vertical.Checked = true;
            switch_topmost.Checked = false;
            switch_enabled.Checked = true;
            switch_loading.Checked = false;

            input_size.Value = 40;
            input_mx.Value = 24;
            input_my.Value = 24;
            input_gap.Value = 40;
            input_radius.Value = 6;
            input_badge.Text = "";
            input_badgesize.Value = 0.6m;
            colorPicker.Value = Color.FromArgb(22, 119, 255);
        }

        // 加载浮动按钮
        private void LoadFloatButton()
        {
            if (floatButtonForm == null)
            {
                floatButtonForm = FloatButton.open(new FloatButton.Config(window, new FloatButton.ConfigBtn[]
                {
                   // 使用 svg 图片
                   // ConfigBtn第二个text参数默认设置为IconSvg，或者如下在配置里面设置IconSvg
                   new FloatButton.ConfigBtn("button1","",true)
                   {
                        // isSvg设置为true，text参数会赋值给IconSvg，否则赋值给Text,所以需要单独设置Text
                        Text = "SVG Picture",
                        IconSvg = "<svg viewBox=\"0 0 1024 1024\"><path d=\"M511.878001 1023.989c-62.999385 0-124.098788-11.699886-181.698225-34.999658-55.699456-22.49978-105.798967-54.499468-148.798547-95.599067-43.099579-40.9996-76.899249-88.899132-100.599018-142.198611-24.59976-55.29946-36.999639-114.098886-36.999639-174.698294 0-76.79925 20.699798-152.498511 59.899415-219.197859 37.799631-64.099374 92.299099-119.098837 157.498462-158.598451 14.699856-8.999912 33.899669-4.299958 42.899581 10.499897 8.999912 14.699856 4.299958 33.899669-10.499897 42.899581-56.399449 34.199666-103.498989 81.599203-136.19867 137.098661-33.599672 56.999443-51.1995 121.798811-51.1995 187.39817 0 102.498999 41.99959 199.098056 118.298845 271.697347 76.699251 73.099286 178.798254 113.298894 287.497192 113.298893s210.797941-40.299606 287.497193-113.298893c76.299255-72.799289 118.298845-169.198348 118.298844-271.797346 0-130.298728-68.699329-250.797551-183.798205-322.296852-14.599857-9.099911-19.099813-28.299724-9.999902-42.99958 9.099911-14.599857 28.299724-19.099813 42.99958-9.999903 64.099374 39.799611 117.498853 94.599076 154.59849 158.398453 38.399625 66.099354 58.699427 140.998623 58.699427 217.09788 0 60.599408-12.499878 119.398834-36.999639 174.698294-23.699769 53.299479-57.499438 101.199012-100.599017 142.198612-42.99958 40.899601-93.099091 73.099286-148.798547 95.599066-57.799436 23.099774-118.998838 34.79966-181.998223 34.79966zM511.878001 506.394055c-17.199832 0-31.199695-13.899864-31.199695-31.199696v-443.995664c0-17.199832 13.899864-31.199695 31.199695-31.199695 17.199832 0 31.199695 13.899864 31.199696 31.199695v443.895665c0.099999 17.199832-13.999863 31.299694-31.199696 31.299695z\"></path></svg>",
                        Tooltip = "SVG Button",
                        Round = switch_round.Checked,
                        Type = (TTypeMini)select_type.SelectedValue,
                        Radius = (int)input_radius.Value,
                        Badge = input_badge.Text==""? null:input_badge.Text,
                        BadgeSize = (float)input_badgesize.Value,
                        BadgeBack = colorPicker.Value,
                        Enabled = switch_enabled.Checked,
                        Loading = switch_loading.Checked,
                   },
                   // 使用资源图片
                   new FloatButton.ConfigBtn("button2", Properties.Resources.关闭)
                   {
                        Text = "Resource Picture",
                        Tooltip = "Resource Picture Button",
                        Round = switch_round.Checked,
                        Type = (TTypeMini)select_type.SelectedValue,
                        Radius = (int)input_radius.Value,
                        Badge = input_badge.Text==""? null:input_badge.Text,
                        BadgeSize = (float)input_badgesize.Value,
                        BadgeBack = colorPicker.Value,
                        Enabled = switch_enabled.Checked,
                        Loading = switch_loading.Checked,
                    },
                  // 使用文本
                    new FloatButton.ConfigBtn("button3", "Text")
                    {
                        Tooltip = "Text Button",
                        Round = switch_round.Checked,
                        Type = (TTypeMini)select_type.SelectedValue,
                        Radius = (int)input_radius.Value,
                        Badge = input_badge.Text==""? null:input_badge.Text,
                        BadgeSize = (float)input_badgesize.Value,
                        BadgeBack = colorPicker.Value,
                        Enabled = switch_enabled.Checked,
                        Loading = switch_loading.Checked,
                    },
                    //获取button示例，可以通过button的属性判断点击了哪个按钮，推荐用Name
                }, button =>
                    {
                        //回调事件
                        AntdUI.Message.info(window, "Text:" + button.Text + ", Name:" + button.Name, autoClose: 3);
                    })
                // 浮动全局配置
                {
                    //字体
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                    //附着控件
                    Control = null,
                    //位置
                    Align = (TAlign)select_align.SelectedIndex,
                    //是否垂直方向
                    Vertical = switch_vertical.Checked,
                    //是否置顶
                    TopMost = switch_topmost.Checked,
                    //尺寸大小
                    Size = (int)input_size.Value,
                    //相对于Align位置X轴偏移
                    MarginX = (int)input_mx.Value,
                    //相对于Align位置Y轴偏移
                    MarginY = (int)input_my.Value,
                    //按钮间距
                    Gap = (int)input_gap.Value,
                });
            }
        }

        // 添加清理逻辑
        public void CloseFloatButtonForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CloseFloatButtonForm));
            }
            else
            {
                // Ensure that floatButtonForm is not null before attempting to close it
                if (floatButtonForm != null)
                {
                    floatButtonForm.Close();
                    floatButtonForm.Dispose();
                    floatButtonForm = null;
                }
            }
        }

        #region EventHandler
        private void select_intvalue_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            CloseFloatButtonForm();
            LoadFloatButton();
        }

        private void Switch_CheckedChanged(object sender, BoolEventArgs e)
        {
            CloseFloatButtonForm();
            LoadFloatButton();
        }

        private void colorPicker_ValueChanged(object sender, ColorEventArgs e)
        {
            CloseFloatButtonForm();
            LoadFloatButton();
        }

        private void input_badge_TextChanged(object sender, EventArgs e)
        {
            CloseFloatButtonForm();
            LoadFloatButton();
        }

        private void input_decimalvalue_ValeChanged(object sender, DecimalEventArgs e)
        {
            CloseFloatButtonForm();
            LoadFloatButton();
        }

        // 重置
        private void buttonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            CloseFloatButtonForm();
            LoadFloatButton();
        }

        // 关闭
        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseFloatButtonForm();
        }
        #endregion
    }
}
