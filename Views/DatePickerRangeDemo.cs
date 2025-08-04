using AntdUI;
using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class DatePickerRangeDemo : UserControl
    {
        public DatePickerRangeDemo()
        {
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            datePickerRange.PresetsClickChanged += DatePickerRange_PresetsClickChanged;
        }

        private void DatePickerRange_PresetsClickChanged(object sender, ObjectNEventArgs e)
        {
            DateTime today = DateTime.Today;
            string str = e.Value.ToString();
            DateTime start;
            DateTime end;
            switch (str)
            {
                case "本周":
                    int daysToMonday = (int)today.DayOfWeek - (int)DayOfWeek.Monday;
                    if (daysToMonday < 0)
                        daysToMonday += 7;
                    start = today.AddDays(-daysToMonday);
                    end = start.AddDays(6);
                    datePickerRange.Value = new DateTime[] { start, end };
                    break;
                case "上周":
                    daysToMonday = (int)today.DayOfWeek - (int)DayOfWeek.Monday;
                    if (daysToMonday < 0)
                        daysToMonday += 7;
                    start = today.AddDays(-daysToMonday - 7);
                    end = start.AddDays(6);
                    datePickerRange.Value = new DateTime[] { start, end };
                    break;
                case "本月":
                    start = new DateTime(today.Year, today.Month, 1);
                    end = start.AddMonths(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { start, end };
                    break;
                case "上月":
                    start = new DateTime(today.Year, today.Month, 1).AddMonths(-1);
                    end = start.AddMonths(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { start, end };
                    break;
                case "本年":
                    start = new DateTime(today.Year, 1, 1);
                    end = start.AddYears(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { start, end };
                    break;
                case "去年":
                    start = new DateTime(today.Year - 1, 1, 1);
                    end = start.AddYears(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { start, end };
                    break;
            }
        }
    }
}
