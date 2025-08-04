using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class DropDownDemo : UserControl
    {
        public DropDownDemo()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dropdown_multi.Items.Clear();
            dropdown_multi.Items.AddRange(new AntdUI.SelectItem[] {
                new AntdUI.SelectItem("first menu item"),
                new AntdUI.SelectItem("second menu item"),
                new AntdUI.SelectItem("third menu item")
            {
                Sub = new List<object>{
                        new AntdUI.SelectItem("子菜单1"){
                            Sub=new List<object>{ new AntdUI.SelectItem("sub menu") {
                                Sub=new List<object>{
                                    "one st menu item","two nd menu item","three rd menu item"
                                }
                            } }
                        },
                        new AntdUI.SelectItem( "子菜单2")
                    }
            },
                new AntdUI.SelectItem("fourth menu item") { Sub = new List<object> { "five menu item", "six six six menu item" } },
            });

            dropdown_icon.Items.Clear();
            dropdown_icon.Items.AddRange(new AntdUI.SelectItem[] {
                new AntdUI.SelectItem(Properties.Resources.关闭,"first menu item"),
                new AntdUI.SelectItem("second menu item"){
                    IconSvg = "<svg viewBox=\"64 64 896 896\"><path d=\"M909.6 854.5L649.9 594.8C690.2 542.7 712 479 712 412c0-80.2-31.3-155.4-87.9-212.1-56.6-56.7-132-87.9-212.1-87.9s-155.5 31.3-212.1 87.9C143.2 256.5 112 331.8 112 412c0 80.1 31.3 155.5 87.9 212.1C256.5 680.8 331.8 712 412 712c67 0 130.6-21.8 182.7-62l259.7 259.6a8.2 8.2 0 0011.6 0l43.6-43.5a8.2 8.2 0 000-11.6zM570.4 570.4C528 612.7 471.8 636 412 636s-116-23.3-158.4-65.6C211.3 528 188 471.8 188 412s23.3-116.1 65.6-158.4C296 211.3 352.2 188 412 188s116.1 23.2 158.4 65.6S636 352.2 636 412s-23.3 116.1-65.6 158.4z\"></path></svg>",
                },
                new AntdUI.SelectItem("third menu item"){
                    IconSvg = "<svg viewBox=\"64 64 896 896\"><path d=\"M716.3 313.8c19-18.9 19-49.7 0-68.6l-69.9-69.9.1.1c-18.5-18.5-50.3-50.3-95.3-95.2-21.2-20.7-55.5-20.5-76.5.5L80.9 474.2a53.84 53.84 0 000 76.4L474.6 944a54.14 54.14 0 0076.5 0l165.1-165c19-18.9 19-49.7 0-68.6a48.7 48.7 0 00-68.7 0l-125 125.2c-5.2 5.2-13.3 5.2-18.5 0L189.5 521.4c-5.2-5.2-5.2-13.3 0-18.5l314.4-314.2c.4-.4.9-.7 1.3-1.1 5.2-4.1 12.4-3.7 17.2 1.1l125.2 125.1c19 19 49.8 19 68.7 0zM408.6 514.4a106.3 106.2 0 10212.6 0 106.3 106.2 0 10-212.6 0zm536.2-38.6L821.9 353.5c-19-18.9-49.8-18.9-68.7.1a48.4 48.4 0 000 68.6l83 82.9c5.2 5.2 5.2 13.3 0 18.5l-81.8 81.7a48.4 48.4 0 000 68.6 48.7 48.7 0 0068.7 0l121.8-121.7a53.93 53.93 0 00-.1-76.4z\"></path></svg>",
                },
            });

            dropdown_online.Items.Clear();
            dropdown_online.Items.AddRange(new AntdUI.SelectItem[] {
                new AntdUI.SelectItem("first menu item"){
                    Online = 1
                },
                new AntdUI.SelectItem("Second menu item"){
                    Online = 0
                }
            });

            dropdown_enable.Items.Clear();
            dropdown_enable.Items.AddRange(new AntdUI.SelectItem[] {
                new AntdUI.SelectItem("first menu item"){
                    Online = 1,
                    Enable = true
                },
                new AntdUI.SelectItem("Second menu item"){
                    Online = 0,
                },
                new AntdUI.SelectItem("Third menu item"){
                    Online = 0,
                    Enable = false
                }
            });

            dropdown_custom.Items.Clear();
            dropdown_custom.Items.AddRange(new AntdUI.SelectItem[] {
                new AntdUI.SelectItem("first menu item"){
                    Online = 1,
                    OnlineCustom = Color.Orange,
                },
                new AntdUI.SelectItem("Second menu item"){
                    Online = 1,
                    OnlineCustom = Color.Tan,
                },
                new AntdUI.SelectItem("third menu item"){
                    Online = 1,
                    OnlineCustom = Color.FromArgb(14,176,201),
                },
            });

        }
    }
}
