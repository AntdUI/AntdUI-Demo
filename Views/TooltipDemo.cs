using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class TooltipDemo : UserControl
    {
        public TooltipDemo()
        {
            InitializeComponent();
            BindingEventHandler();
        }

        private void BindingEventHandler()
        {
            AntdUI.TooltipComponent tooltip = new AntdUI.TooltipComponent()
            {
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
            };
            tooltip.SetTip(label_show, "prompt text");

            label_showclick.Click += (sender, e) =>
            {
                AntdUI.Tooltip.open(new AntdUI.Tooltip.Config(label_showclick, "prompt text")
                {
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                });
            };
            BindButtonWithToolTip(this);
        }

        private void BindButtonWithToolTip(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is AntdUI.Button button)
                {
                    AntdUI.TooltipComponent tooltip = new AntdUI.TooltipComponent()
                    {
                        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                    };
                    var text = button.Text;
                    switch (text)
                    {
                        case "BR":
                            tooltip.ArrowAlign = AntdUI.TAlign.BR;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "BL":
                            tooltip.ArrowAlign = AntdUI.TAlign.BL;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "Bottom":
                            tooltip.ArrowAlign = AntdUI.TAlign.Bottom;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "TR":
                            tooltip.ArrowAlign = AntdUI.TAlign.TR;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "TL":
                            tooltip.ArrowAlign = AntdUI.TAlign.TL;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "Top":
                            tooltip.ArrowAlign = AntdUI.TAlign.Top;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "LT":
                            tooltip.ArrowAlign = AntdUI.TAlign.LT;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "LB":
                            tooltip.ArrowAlign = AntdUI.TAlign.LB;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "RT":
                            tooltip.ArrowAlign = AntdUI.TAlign.RT;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "RB":
                            tooltip.ArrowAlign = AntdUI.TAlign.RB;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "Left":
                            tooltip.ArrowAlign = AntdUI.TAlign.Left;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        case "Right":
                            tooltip.ArrowAlign = AntdUI.TAlign.Right;
                            tooltip.SetTip(control, "prompt text");
                            break;
                        default:
                            break;
                    }
                }
                // 递归遍历子控件
                if (control.HasChildren)
                {
                    BindButtonWithToolTip(control);
                }
            }
        }
    }
}
