using AntdUI;
using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class StepsDemo : UserControl
    {
        public StepsDemo()
        {
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            // 设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void InitData()
        {
            input_current.Value = 1;
            select_Status.SelectedIndex = 1;
        }

        private void InitSelectItems()
        {
            //初始化状态
            select_Status.Items.Clear();
            foreach (TStepState stepState in Enum.GetValues(typeof(TStepState)))
            {
                select_Status.Items.Add(stepState);
            }
        }

        private void BindEventHandler()
        {
            select_Status.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            input_current.ValueChanged += Input_decimalvalue_ValeChanged;
        }

        private void LoadSteps()
        {
            steph.Current = (int)input_current.Value;
            stepsv.Current = steph.Current;

            steph.Status = (TStepState)select_Status.SelectedValue;
            stepsv.Status = steph.Status;
        }
        private void Input_decimalvalue_ValeChanged(object sender, DecimalEventArgs e)
        {
            LoadSteps();
        }

        private void select_intvalue_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            LoadSteps();
        }

    }
}
