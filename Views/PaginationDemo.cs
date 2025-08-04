using AntdUI;
using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class PaginationDemo : UserControl
    {
        public PaginationDemo()
        {
            InitializeComponent();
            InitData();
            // 绑定事件
            BindEventHandler();
            LoadPagination();
        }

        private void BindEventHandler()
        {
            input_current.ValueChanged += input_decimal_ValueChanged;
            input_total.ValueChanged += input_decimal_ValueChanged;
            input_pagesize.ValueChanged += input_decimal_ValueChanged;
            input_max.ValueChanged += input_decimal_ValueChanged;
            input_gap.ValueChanged += input_decimal_ValueChanged;
            input_radius.ValueChanged += input_decimal_ValueChanged;
            input_size.ValueChanged += input_decimal_ValueChanged;

            input_textdesc.TextChanged += input_textdesc_TextChanged;

            colorPicker.ValueChanged += colorPicker_ValueChanged;

            switch_show.CheckedChanged += switch_CheckedChanged;
            switch_right.CheckedChanged += switch_CheckedChanged;

            selectMultiple.SelectedValueChanged += SelectMultiple_SelectedValueChanged;

            buttonCZ.Click += ButtonCZ_Click;
            pagination.ValueChanged += Pagination_ValueChanged;
        }

        private void Pagination_ValueChanged(object sender, PagePageEventArgs e)
        {
            //与分页交互修改输入值
            input_current.Value = e.Current;
            input_total.Value = e.Total;
            input_pagesize.Value = e.PageSize;
        }

        private void ButtonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            LoadPagination();
        }

        private void SelectMultiple_SelectedValueChanged(object sender, ObjectsEventArgs e)
        {
            LoadPagination();
        }

        private void switch_CheckedChanged(object sender, BoolEventArgs value)
        {
            LoadPagination();
        }

        private void colorPicker_ValueChanged(object sender, ColorEventArgs e)
        {
            LoadPagination();
        }

        private void input_textdesc_TextChanged(object sender, EventArgs e)
        {
            LoadPagination();
        }

        private void input_decimal_ValueChanged(object sender, DecimalEventArgs e)
        {
            LoadPagination();
        }

        private void LoadPagination()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(LoadPagination));
                return;
            }
            pagination.Current = (int)input_current.Value;
            pagination.Total = (int)input_total.Value;
            pagination.PageSize = (int)input_pagesize.Value;
            pagination.MaxPageTotal = (int)input_max.Value;
            pagination.Gap = (int)input_gap.Value;
            pagination.Radius = (int)input_radius.Value;
            pagination.SizeChangerWidth = (int)input_size.Value;

            pagination.TextDesc = input_textdesc.Text;

            pagination.Fill = colorPicker.Value;
            int[] intarr = new int[selectMultiple.SelectedValue.Length];
            for (int i = 0; i < intarr.Length; i++)
            {
                intarr[i] = int.Parse(selectMultiple.SelectedValue[i].ToString());
            }
            pagination.PageSizeOptions = intarr;

            pagination.ShowSizeChanger = switch_show.Checked;
            pagination.RightToLeft = switch_right.Checked ? RightToLeft.Yes : RightToLeft.No;
        }

        private void InitData()
        {
            input_current.Value = 1;
            input_total.Value = 50;
            input_pagesize.Value = 10;
            input_max.Value = 0;
            input_gap.Value = 8;
            input_radius.Value = 6;
            input_size.Value = 85;

            input_textdesc.Text = null;

            colorPicker.Value = Style.Db.Primary;

            switch_show.Checked = true;
            switch_right.Checked = true;
            selectMultiple.SelectedValue = new object[] { "1", "2", "5", "10" };
        }
    }
}
