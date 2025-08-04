<div align="center">

<img height="100" src="assets/logo.png">

<h1>AntdUI Demo</h1>

本项目基于 `Winform .NET Framework 4.8` 开发，是 [AntdUI](https://gitee.com/antdui/AntdUI) 的 Demo 项目，当前版本 `1.9.12`

</div>

中文 | <a href="README-en.md">English</a>

## ✅ 快速开始

>1. git clone 或者直接下载本项目
>2. 使用 Visual Studio 打开本项目
>3. 若电脑没有安装 .NET Framework 4.8，编辑项目文件设置 TargetFramework 属性为自己安装的目标框架，参照 [AntdUI兼容框架](https://www.nuget.org/packages/AntdUI#supportedframeworks-body-tab)
>4. 编译运行

## ⚠️ 注意事项
- 电脑屏幕分辨率低于 1920×1080(1080P) 请使用大于等于 1080P 分辨率的屏幕开发
- 如果 `TargetFramework` 设置为 `net6.0-windows7.0` 及以上，可以直接打开窗体界面，显示如下提示
![coredesign](assets/screenshots/coredesign.png)
- 如果 `TargetFramework` 设置为 `net48` 及以下且电脑屏幕分辨率大于 1080P 或者缩放不是 100% 的，务必选择以下任一方式打开项目，详细原因见 [解决 Visual Studio 中 Windows 窗体设计器的 HDPI/缩放问题](https://learn.microsoft.com/zh-cn/visualstudio/designers/disable-dpi-awareness?view=vs-2022)：
	1. 使用 `devenv /noScale` 命令启动 Visual Studio 并点击`文件-打开-项目/解决方案`，如下所示	
![vsopen](assets/screenshots/vsopen.png)
	2. 直接打开项目，在窗口页面提示点击 **使用 100% 缩放比例重新启动 Visual Studio**，如下所示
![design](assets/screenshots/design.png)

## 系统设置
- ✅ 支持浅色/深色模式，并且随系统自动切换
- ✅ 支持启用/关闭动画效果
- ✅ 支持启用/关闭阴影效果
- ✅ 支持显示/隐藏滚动条
- ✅ 支持设置 Message/Notification 消息显示位置

![SystemSet](assets/screenshots/Demo.png)
![SystemSet](assets/screenshots/Dark.png)
![SystemSet](assets/screenshots/SystemSet.png)

## 控件演示

### 通用
#### Button 按钮
![Button](assets/screenshots/Button.png)
#### FloatButton 悬浮按钮
![FloatButton](assets/screenshots/FloatButton.png)
#### Icon 图标
![Icon](assets/screenshots/Icon.png)

### 布局
#### Divider 分割线
![Divider](assets/screenshots/Divider.png)
#### FlowPanel 流动布局
![FlowPanel](assets/screenshots/FlowPanel.png)
#### GridPanel 网格布局
![GridPanel](assets/screenshots/GridPanel.png)
#### Panel 面板
![Panel](assets/screenshots/Panel.png)
#### Splitter 分隔面板
![Splitter](assets/screenshots/Splitter.png)
#### StackPanel 堆叠布局
![StackPanel](assets/screenshots/StackPanel.png)

### 导航
#### Breadcrumb 面包屑
![Breadcrumb](assets/screenshots/Breadcrumb.png)
#### Dropdown 下拉菜单
![Dropdown](assets/screenshots/Dropdown.png)
#### Menu 导航菜单
![Menu](assets/screenshots/Menu.png)
#### Pagination 分页
![Pagination](assets/screenshots/Pagination.png)
#### Steps 步骤条
![Steps](assets/screenshots/Steps.png)

### 数据录入
#### Checkbox 多选框
![Checkbox](assets/screenshots/Checkbox.png)
#### ColorPicker 颜色选择器
![ColorPicker](assets/screenshots/ColorPicker.png)
#### DatePicker 日期选择器
![DatePicker](assets/screenshots/DatePicker.png)
#### DatePickerRange 日期范围选择器
![DatePickerRange](assets/screenshots/DatePickerRange.png)
#### Input 输入框
![Input](assets/screenshots/Input.png)
#### InputNumber 数字输入框
![InputNumber](assets/screenshots/InputNumber.png)
#### Radio 单选框
![Radio](assets/screenshots/Radio.png)
#### Rate 评分
![Rate](assets/screenshots/Rate.png)
#### Select 选择器
![Select](assets/screenshots/Select.png)
#### SelectMultiple 多选选择器
![SelectMultiple](assets/screenshots/SelectMultiple.png)
#### Slider 滑动输入条
![Slider](assets/screenshots/Slider.png)
#### SliderRange 滑动范围输入条
![SliderRange](assets/screenshots/SliderRange.png)
#### Switch 开关
![Switch](assets/screenshots/Switch.png)
#### TimePicker 时间选择框
![TimePicker](assets/screenshots/TimePicker.png)
#### UploadDragger 上传
![UploadDragger](assets/screenshots/UploadDragger.png)

### 数据展示
#### Avatar 头像
![Avatar](assets/screenshots/Avatar.png)
#### Badge 徽标数
![Badge](assets/screenshots/Badge.png)
#### Calendar 日历
![Calendar](assets/screenshots/Calendar.png)
#### Carousel 走马灯
![Carousel](assets/screenshots/Carousel.png)
#### Collapse 折叠面板
![Collapse](assets/screenshots/Collapse.png)
#### Label 标签
![Label](assets/screenshots/Label.png)
#### LabelTime 时间标签
![Label](assets/screenshots/LabelTime.png)
#### Popover 气泡卡片
![Popover](assets/screenshots/Popover.png)
#### Preview 图片预览
![Preview](assets/screenshots/Preview.png)
#### Segmented 分段控制器
![Segmented](assets/screenshots/Segmented.png)
#### Table 表格
![Table](assets/screenshots/Table.png)
#### Tabs 标签页
![Tabs](assets/screenshots/Tabs.png)
#### Tag 标签
![Tag](assets/screenshots/Tag.png)
#### Timeline 时间轴
![Timeline](assets/screenshots/Timeline.png)
#### Tooltip 文字提示
![Tooltip](assets/screenshots/Tooltip.png)
#### Tour 漫游式引导
![Tour](assets/screenshots/Tour.png)
#### Tree 树形控件
![Tree](assets/screenshots/Tree.png)

### 反馈
#### Alert 警告提示
![Alert](assets/screenshots/Alert.png)
#### Drawer 抽屉
![Drawer](assets/screenshots/Drawer.png)
#### Message 全局提示
![Message](assets/screenshots/Message.png)
#### Modal 对话框
![Modal](assets/screenshots/Modal.png)
#### Notification 通知提醒框
![Notification](assets/screenshots/Notification.png)
#### Progress 进度条
![Progress](assets/screenshots/Progress.png)
#### Spin 加载中
![Spin](assets/screenshots/Spin.png)

### 聊天
#### ChatList 气泡聊天列表
![ChatList](assets/screenshots/ChatList.png)
#### MsgList 好友消息列表
![MsgList](assets/screenshots/MsgList.png)

### 其它
#### Battery 电池
![Battery](assets/screenshots/Battery.png)
#### ContextMenuStrip 快捷菜单
![ContextMenuStrip](assets/screenshots/ContextMenuStrip.png)
#### Image3D 图片3D
![Image3D](assets/screenshots/Image3D.png)
#### PageHeader 页头
![PageHeader](assets/screenshots/PageHeader.png)
#### Signal 信号
![Signal](assets/screenshots/Signal.png)