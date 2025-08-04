using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntdUIDemo.Languages
{
    public class Localizer_enus : AntdUI.ILocalization
    {
        public string GetLocalizedString(string key)
        {
            switch (key)
            {
                case "search":
                    return "Search";
                case "welcome":
                    return "Welcome to the AntdUI Demo";
                case "home":
                    return "Home";
                case "closeall":
                    return "Close all tabs";
                #region systemset
                case "systemset":
                    return "System Settings";
                case "baseset":
                    return "Basic Settings";
                case "messageconfig":
                    return "Message configuration";
                case "animationon":
                    return "Turn on animation";
                case "shadowon":
                    return "Enable shadow";
                case "scrollbarhide":
                    return "Hide scrollbar";
                case "showinwindow":
                    return "Show in window";
                case "windowOffsetXY":
                    return "WindowOffsetXY";
                case "tip":
                    return "Tip";
                case "switchsuccess":
                    return "Switch successful.";
                #endregion

                #region Button
                case "Button.Text":
                    return "Button";
                case "Button.Description":
                    return "To trigger an operation.";
                case "type":
                    return "Type";
                case "wave":
                    return "Wave";
                case "loading":
                    return "Loading";
                case "ghost":
                    return "Ghost";
                case "border":
                    return "Border";
                case "icon":
                    return "Icon";
                case "arrow":
                    return "Arrow";
                case "join":
                    return "Join";
                case "gradient":
                    return "Gradient";
                case "toggle":
                    return "Toggle";
                case "animate":
                    return "Animate";
                #endregion

                #region FloatButton
                case "FloatButton.Text":
                    return "FloatButton";
                case "FloatButton.Description":
                    return "A button that floats at the top of the page.";
                case "FloatButton.Tip":
                    return "FloatButton does not have a toolbox control and is called code.";
                case "control_option":
                    return "Control Options";
                case "button_option":
                    return "Button Options";
                case "open":
                    return "Open";
                case "close":
                    return "Close";
                case "reset":
                    return "Reset";
                #endregion

                #region Icon
                case "Icon.Text":
                    return "Icon";
                case "Icon.Description":
                    return "Semantic vector graphics.";
                case "Icon.Tip":
                    return "Icon does not have a toolbox control and is used for Svg property assignments.";
                case "outlined":
                    return "Outlined";
                case "filled":
                    return "Filled";
                case "directionalicon":
                    return "Directional icons";
                case "suggestionicon":
                    return "Suggestion Icon";
                case "editingicon":
                    return "Editing Icons";
                case "dataicon":
                    return "Data icons";
                case "brand":
                    return "Brand and logo";
                case "universal":
                    return "Universal Icons for Websites";
                case "copysuccess":
                    return "Copy successful!";
                case "copyfail":
                    return "Copy failed!";
                #endregion

                #region Divider
                case "Divider.Text":
                    return "Divider";
                case "Divider.Description":
                    return "A divider line separates different content.";
                case "basicusage":
                    return "Basic Usage";
                case "vertical":
                    return "Vertical";
                case "horizontal":
                    return "Horizontal";
                #endregion
                default:
                    return null;

            }
        }
    }
}
