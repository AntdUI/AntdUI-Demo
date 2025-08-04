using AntdUI;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class CalendarDemo : UserControl
    {
        private AntdUI.Window window;
        public CalendarDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            InitData();

            BindEventHandler();
        }

        private void BindEventHandler()
        {
            calendar.DateChanged += Calendar_DateChanged;
            switch_showtoday.CheckedChanged += Switch_showtoday_CheckedChanged;
            switch_showchinese.CheckedChanged += Switch_showchinese_CheckedChanged;
        }

        private void Switch_showchinese_CheckedChanged(object sender, BoolEventArgs e)
        {
            calendar.ShowChinese = e.Value;
        }

        private void Switch_showtoday_CheckedChanged(object sender, BoolEventArgs e)
        {
            calendar.ShowButtonToDay = e.Value;
        }

        private void Calendar_DateChanged(object sender, DateTimeEventArgs e)
        {
            AntdUI.Message.info(window, e.Value.ToString("yyyy-MM-dd"), autoClose: 1);
        }

        private void InitData()
        {
            calendar.BadgeAction = dates =>
            {
                // dates 参数为 DateTime[] 数组长度固定为2，返回UI上显示的开始日期与结束日期
                // DateTime start_date = dates[0], end_date = dates[1];
                var now = dates[1];
                return new List<DateBadge> {
        new DateBadge(now.ToString("yyyy-MM-dd"),0),
        new DateBadge(now.AddDays(-20).ToString("yyyy-MM-dd"),5),
        new DateBadge(now.AddDays(-14).ToString("yyyy-MM-dd"), "休"),
        new DateBadge(now.AddDays(-7).ToString("yyyy-MM-dd"), "休")
        {
            //圆角支持,默认值是6
            Radius = 12
        },
        new DateBadge(now.AddDays(-6).ToString("yyyy-MM-dd"),998,Color.FromArgb(112, 237, 58)),
    };
            };
            calendar.LoadBadge();
        }
    }
}
