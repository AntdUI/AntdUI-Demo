using AntdUI;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class SelectDemo : UserControl
    {
        public SelectDemo()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            select_custom.Items.Clear();
            select_custom.Items.AddRange(new object[] {

                new SelectItem("在线状态"){
                    Online = 1,
                },
                new SelectItem("禁用状态"){
                    Enable = false,
                },
                new DividerSelectItem(),
                new SelectItem("红色"){
                    IconSvg = "<svg t=\"1725181270538\" class=\"icon\" viewBox=\"0 0 1024 1024\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" p-id=\"4470\" width=\"200\" height=\"200\"><path d=\"M85.333333 85.333333m53.333334 0l746.666666 0q53.333333 0 53.333334 53.333334l0 746.666666q0 53.333333-53.333334 53.333334l-746.666666 0q-53.333333 0-53.333334-53.333334l0-746.666666q0-53.333333 53.333334-53.333334Z\" fill=\"#ff0000\" p-id=\"4471\"></path></svg>",
                },

                new SelectItem("子菜单")
                {
                    Sub = new List<object>
                    {
                        new SelectItem("子菜单1"),
                        new SelectItem("子菜单2"),
                        new SelectItem("子菜单3"),
                    }
                },
                new SelectItem("主文本")
                {
                    SubText = "子文本"
                }
            });
        }
    }
}
