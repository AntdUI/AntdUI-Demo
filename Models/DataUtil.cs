using System.Collections.Generic;

namespace AntdUIDemo.Models
{
    public class DataUtil
    {
        public static readonly Dictionary<string, List<MenuItems>> MenuItems_zhcn = new Dictionary<string, List<MenuItems>>()
    {
        { "通用", new List<MenuItems>
            {
                new MenuItems { Text = "Button 按钮" , Tag = "Button"},
                new MenuItems { Text = "FloatButton 悬浮按钮", Tag = "FloatButton"},
                new MenuItems { Text = "Icon 图标", Tag = "Icon"},
            }
        },
        { "布局", new List<MenuItems>
            {
                new MenuItems { Text = "Divider 分割线", Tag = "Divider" },
                new MenuItems { Text = "FlowPanel 流动布局", Tag = "FlowPanel"},
                new MenuItems { Text = "GridPanel 网格布局", Tag = "GridPanel"},
                new MenuItems { Text = "Panel 面板", Tag = "Panel"},
                new MenuItems { Text = "Splitter 分隔面板", Tag = "Splitter"},
                new MenuItems { Text = "StackPanel 堆叠布局", Tag = "StackPanel"}
            }
        },
        { "导航", new List<MenuItems>
            {
                new MenuItems { Text = "Breadcrumb 面包屑", Tag = "Breadcrumb"},
                new MenuItems { Text = "Dropdown 下拉菜单", Tag = "Dropdown"},
                new MenuItems { Text = "Menu 导航菜单", Tag = "Menu"},
                new MenuItems { Text = "Pagination 分页", Tag = "Pagination"},
                new MenuItems { Text = "Steps 步骤条", Tag = "Steps"}
            }
        },
        { "数据录入", new List<MenuItems>
            {
                new MenuItems { Text = "Checkbox 多选框", Tag = "Checkbox"},
                new MenuItems { Text = "ColorPicker 颜色选择器", Tag = "ColorPicker"},
                new MenuItems { Text = "DatePicker 日期选择器", Tag = "DatePicker"},
                new MenuItems { Text = "DatePickerRange 日期范围选择器", Tag = "DatePickerRange"},
                new MenuItems { Text = "Input 输入框", Tag = "Input"},
                new MenuItems { Text = "InputNumber 数字输入框", Tag = "InputNumber"},
                new MenuItems { Text = "Radio 单选框", Tag = "Radio"},
                new MenuItems { Text = "Rate 评分", Tag = "Rate"},
                new MenuItems { Text = "Select 选择器", Tag = "Select"},
                new MenuItems { Text = "SelectMultiple 多选选择器", Tag = "SelectMultiple"},
                new MenuItems { Text = "Slider 滑动输入条", Tag = "Slider"},
                new MenuItems { Text = "SliderRange 滑动范围输入条", Tag = "SliderRange"},
                new MenuItems { Text = "Switch 开关", Tag = "Switch"},
                new MenuItems { Text = "TimePicker 时间选择框", Tag = "TimePicker"},
                new MenuItems { Text = "UploadDragger 上传", Tag = "UploadDragger"}
            }
        },
        { "数据展示", new List<MenuItems>
            {
                new MenuItems { Text = "Avatar 头像", Tag = "Avatar"},
                new MenuItems { Text = "Badge 徽标数", Tag = "Badge"},
                new MenuItems { Text = "Calendar 日历", Tag = "Calendar"},
                new MenuItems { Text = "Carousel 走马灯", Tag = "Carousel"},
                new MenuItems { Text = "Collapse 折叠面板", Tag = "Collapse"},
                new MenuItems { Text = "Label 标签", Tag = "Label"},
                new MenuItems { Text = "LabelTime 时间标签", Tag = "LabelTime"},
                new MenuItems { Text = "Popover 气泡卡片", Tag = "Popover"},
                new MenuItems { Text = "Preview 图片预览", Tag = "Preview"},
                new MenuItems { Text = "Segmented 分段控制器", Tag = "Segmented"},
                new MenuItems { Text = "Table 表格", Tag = "Table"},
                new MenuItems { Text = "Tabs 标签页", Tag = "Tabs"},
                new MenuItems { Text = "Tag 标签", Tag = "Tag"},
                new MenuItems { Text = "Timeline 时间轴", Tag = "Timeline"},
                new MenuItems { Text = "Tooltip 文字提示", Tag = "Tooltip"},
                new MenuItems { Text = "Tour 漫游式引导" , Tag = "Tour"},
                new MenuItems { Text = "Tree 树形控件", Tag = "Tree"}
            }
        },
        { "反馈", new List<MenuItems>
            {
                new MenuItems { Text = "Alert 警告提示", Tag = "Alert"},
                new MenuItems { Text = "Drawer 抽屉", Tag = "Drawer"},
                new MenuItems { Text = "Message 全局提示", Tag = "Message"},
                new MenuItems { Text = "Modal 对话框", Tag = "Modal"},
                new MenuItems { Text = "Notification 通知提醒框", Tag = "Notification"},
                new MenuItems { Text = "Progress 进度条", Tag = "Progress"},
                new MenuItems { Text = "Spin 加载中", Tag = "Spin"}
            }
        },
        { "聊天", new List<MenuItems>
            {
                new MenuItems { Text = "ChatList 气泡聊天列表", Tag = "ChatList"},
                new MenuItems { Text = "MsgList 好友消息列表", Tag = "MsgList"}
            }
        },
        { "其它", new List<MenuItems>
            {
                new MenuItems { Text = "Battery 电池", Tag = "Battery" },
                new MenuItems { Text = "ContextMenuStrip 快捷菜单", Tag = "ContextMenuStrip" },
                new MenuItems { Text = "Image3D 图片3D", Tag = "Image3D" },
                new MenuItems { Text = "PageHeader 页头", Tag= "PageHeader"},
                new MenuItems { Text = "Signal 信号", Tag = "Signal" }
            }
        }
    };

        public static readonly Dictionary<string, string> MenuIcons_zhcn = new Dictionary<string, string>
{
    { "通用", "AppstoreOutlined" },
    { "布局", "LayoutOutlined" },
    { "导航", "CompressOutlined" },
    { "数据录入", "EditOutlined" },
    { "数据展示", "BarChartOutlined" },
    { "反馈", "NotificationOutlined" },
    { "聊天", "MessageOutlined" },
    { "其它", "SettingOutlined" }
};

        public static readonly Dictionary<string, List<MenuItems>> MenuItems_enus = new Dictionary<string, List<MenuItems>>()
    {
        { "General", new List<MenuItems>
            {
                new MenuItems { Text = "Button" , Tag = "Button"},
                new MenuItems { Text = "FloatButton", Tag = "FloatButton"},
                new MenuItems { Text = "Icon", Tag = "Icon"},
            }
        },
        { "Layout", new List<MenuItems>
            {
                new MenuItems { Text = "Divider", Tag = "Divider" },
                new MenuItems { Text = "FlowPanel", Tag = "FlowPanel"},
                new MenuItems { Text = "GridPanel", Tag = "GridPanel"},
                new MenuItems { Text = "Panel", Tag = "Panel"},
                new MenuItems { Text = "Splitter ", Tag = "Splitter"},
                new MenuItems { Text = "StackPanel", Tag = "StackPanel"}
            }
        },
        { "Navigation", new List<MenuItems>
            {
                new MenuItems { Text = "Breadcrumb", Tag = "Breadcrumb"},
                new MenuItems { Text = "Dropdown", Tag = "Dropdown"},
                new MenuItems { Text = "Menu", Tag = "Menu"},
                new MenuItems { Text = "Pagination", Tag = "Pagination"},
                new MenuItems { Text = "Steps", Tag = "Steps"}
            }
        },
        { "Data Entry", new List<MenuItems>
            {
                new MenuItems { Text = "Checkbox", Tag = "Checkbox"},
                new MenuItems { Text = "ColorPicker", Tag = "ColorPicker"},
                new MenuItems { Text = "DatePicker", Tag = "DatePicker"},
                new MenuItems { Text = "DatePickerRange", Tag = "DatePickerRange"},
                new MenuItems { Text = "Input", Tag = "Input"},
                new MenuItems { Text = "InputNumber", Tag = "InputNumber"},
                new MenuItems { Text = "Radio", Tag = "Radio"},
                new MenuItems { Text = "Rate", Tag = "Rate"},
                new MenuItems { Text = "Select", Tag = "Select"},
                new MenuItems { Text = "SelectMultiple", Tag = "SelectMultiple"},
                new MenuItems { Text = "Slider", Tag = "Slider"},
                new MenuItems { Text = "SliderRange", Tag = "SliderRange"},
                new MenuItems { Text = "Switch", Tag = "Switch"},
                new MenuItems { Text = "TimePicker", Tag = "TimePicker"},
                new MenuItems { Text = "UploadDragger", Tag = "UploadDragger"}
            }
        },
        { "Data Display", new List<MenuItems>
            {
                new MenuItems { Text = "Avatar", Tag = "Avatar"},
                new MenuItems { Text = "Badge", Tag = "Badge"},
                new MenuItems { Text = "Calendar", Tag = "Calendar"},
                new MenuItems { Text = "Carousel", Tag = "Carousel"},
                new MenuItems { Text = "Collapse", Tag = "Collapse"},
                new MenuItems { Text = "Label", Tag = "Label"},
                new MenuItems { Text = "LabelTime", Tag = "LabelTime"},
                new MenuItems { Text = "Popover", Tag = "Popover"},
                new MenuItems { Text = "Preview", Tag = "Preview"},
                new MenuItems { Text = "Segmented", Tag = "Segmented"},
                new MenuItems { Text = "Table", Tag = "Table"},
                new MenuItems { Text = "Tabs", Tag = "Tabs"},
                new MenuItems { Text = "Tag", Tag = "Tag"},
                new MenuItems { Text = "Timeline", Tag = "Timeline"},
                new MenuItems { Text = "Tooltip", Tag = "Tooltip"},
                new MenuItems { Text = "Tour" , Tag = "Tour"},
                new MenuItems { Text = "Tree", Tag = "Tree"}
            }
        },
        { "Feedback", new List<MenuItems>
            {
                new MenuItems { Text = "Alert", Tag = "Alert"},
                new MenuItems { Text = "Drawer", Tag = "Drawer"},
                new MenuItems { Text = "Message", Tag = "Message"},
                new MenuItems { Text = "Modal", Tag = "Modal"},
                new MenuItems { Text = "Notification", Tag = "Notification"},
                new MenuItems { Text = "Progress", Tag = "Progress"},
                new MenuItems { Text = "Spin", Tag = "Spin"}
            }
        },
        { "Chat", new List<MenuItems>
            {
                new MenuItems { Text = "ChatList", Tag = "ChatList"},
                new MenuItems { Text = "MsgList", Tag = "MsgList"}
            }
        },
        { "Other", new List<MenuItems>
            {
                new MenuItems { Text = "Battery", Tag = "Battery" },
                new MenuItems { Text = "ContextMenuStrip", Tag = "ContextMenuStrip" },
                new MenuItems { Text = "Image3D", Tag = "Image3D" },
                new MenuItems { Text = "PageHeader", Tag= "PageHeader"},
                new MenuItems { Text = "Signal", Tag = "Signal" }
            }
        }
    };

        public static readonly Dictionary<string, string> MenuIcons_enus = new Dictionary<string, string>
{
    { "General", "AppstoreOutlined" },
    { "Layout", "LayoutOutlined" },
    { "Navigation", "CompressOutlined" },
    { "Data Entry", "EditOutlined" },
    { "Data Display", "BarChartOutlined" },
    { "Feedback", "NotificationOutlined" },
    { "Chat", "MessageOutlined" },
    { "Other", "SettingOutlined" }
};


    }


}
