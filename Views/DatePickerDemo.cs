using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class DatePickerDemo : UserControl
    {
        public DatePickerDemo()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            DateTime now = DateTime.Now;
            datePicker_badge.BadgeAction = dates =>
            {
                return new List<AntdUI.DateBadge>
                {
                    new AntdUI.DateBadge(now.AddDays(5).ToString("yyyy-MM-dd"),99,Color.Red),
                    new AntdUI.DateBadge(now.AddDays(1).ToString("yyyy-MM-dd"),2,Color.Red),
                    new AntdUI.DateBadge(now.AddDays(-3).ToString("yyyy-MM-dd"),8,Color.FromArgb(14, 176, 201)),
                };
            };
            //设置最小日期为当前日期7天前
            datePicker_mindate.MinDate = now.AddDays(-7);
            //设置最大日期为当前日期的7天后
            datePicker_maxdate.MaxDate = now.AddDays(7);
        }
    }
}
