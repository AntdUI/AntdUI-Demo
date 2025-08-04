using AntdUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class InputDemo : UserControl
    {
        public InputDemo()
        {
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
            InitInputTable();
        }

        private void BindEventHandler()
        {
            button_loading.Click += Button_loading_Click;
            input_status.TextChanged += Input_status_TextChanged;
        }

        private void Input_status_TextChanged(object sender, EventArgs e)
        {
            var text = input_status.Text;
            // 判断是否空
            if (string.IsNullOrEmpty(text))
            {
                input_status.Status = TType.None;
                return;
            }
            bool containsLetter = ValidateString(text);
            if (!containsLetter)
            {
                input_status.Status = TType.Error;
            }
            else
            {
                input_status.Status = TType.None;
            }

        }

        private async void Button_loading_Click(object sender, EventArgs e)
        {
            button_loading.Loading = true;
            await Task.Delay(3000);
            button_loading.Loading = false;
        }

        private bool ValidateString(string input)
        {
            // 逐个字符检查是否为英文字母
            foreach (char c in input)
            {
                if (!Regex.IsMatch(c.ToString(), @"[a-zA-Z]"))
                {
                    return false;
                }
            }
            return true;
        }



        #region Input+Popover+Table 
        
        Form form;
        /// <summary>
        /// 小蚂蚁QQ:897252348
        /// </summary>
        private void InitInputTable()
        {
            var customerInput = new InputTable<Customer>
            {
                Dock = DockStyle.Fill,
                Columns =
                {
                    new Column("Code", "客户编号"),
                    new Column("Name", "客户名称"),
                    new Column("Address", "联系地址")
                },
                DisplayTextFormatter = c => $"{c.Code} - {c.Name}",
                DataSource = GetCustomers()
            };

            customerInput.SelectedItemChanged += (s, e) =>
            {
                if (customerInput.SelectedItem != null)
                {
                    AntdUI.Message.info(form, $"选中客户：{customerInput.SelectedItem.Code}", autoClose: 3);
                }
            };
            customerInput.SearchButtonClick += (s, e) =>
            {
                if (customerInput.SelectedItem != null)
                {
                    AntdUI.Message.success(form, $"选中客户：{customerInput.SelectedItem.Code}", autoClose: 3);
                }
            };
            customerInput.Size = new Size(300, 50);
            customerInput.Location = new Point(label1.Location.X, label1.Location.Y+20);
            panel2.Controls.Add(customerInput);
        }

        //集合
        List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer
                {
                    Address = $"地址{i}",
                    Code = i.ToString(),
                    Name = $"名字{i}",
                });
            }
            return customers;
        }


        // 定义实体类
        public class Customer
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
        #endregion
    }
}
