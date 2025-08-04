using AntdUI;
using AntdUIDemo.Models;
using AntdUIDemo.Views.Table;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class TableDemo : UserControl
    {
        private AntdUI.Window window;
        AntList<User> antList;
        User curUser;
        public TableDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            //初始化表格列头
            InitTableColumns();
            InitData();
            BindEventHandler();
        }

        private void InitTableColumns()
        {
            table_base.Columns = new ColumnCollection() {
                new Column("","序号"){
                    Width = "50",
                    Render = (value,record,rowindex)=>{return (rowindex+1); },
                    Fixed = true,//冻结列
                },
                new ColumnCheck("Selected"){Fixed = true},
                new Column("Name", "姓名", ColumnAlign.Center)
                {
                    Width="120",
                    //设置树节点，名称需和User里的User[]名称保持一致
                    KeyTree = "Users"
                },
                new Column("Age", "年龄",ColumnAlign.Center),
                new Column("Address", "地址"){
                    Width = "120",
                    LineBreak = true,
                },
                new ColumnSwitch("Enabled", "是否启用", ColumnAlign.Center){
                    //支持点击回调
                    Call= (value,record, i_row, i_col) =>{
                        //执行耗时操作
                        Thread.Sleep(1000);
                        AntdUI.Message.info(window, value.ToString(),autoClose:1);
                        return value;
                    }
                },
                new Column("CellImages", "图片",ColumnAlign.Center),
                new Column("CellTags", "标签",ColumnAlign.Center),
                new Column("CellBadge", "徽标",ColumnAlign.Center),
                new Column("CellText", "富文本")
                {
                    ColAlign = ColumnAlign.Center,//支持表头位置单独设置
                },
                new Column("CellProgress", "进度条",ColumnAlign.Center),
                new Column("CellDivider", "分割线",ColumnAlign.Center),
                new Column("CellLinks", "链接", ColumnAlign.Center),
            };

            //设置多表头
            table_base.StackedHeaderRows = new StackedHeaderRow[]
            {
                new StackedHeaderRow(
                    new AntdUI.StackedColumn("Name,Address","个人信息").SetForeColor(Color.Red),
                    new AntdUI.StackedColumn("CellImages,CellTags","图标"))
            };
        }

        private void BindEventHandler()
        {
            buttonADD.Click += ButtonADD_Click;
            buttonDEL.Click += ButtonDEL_Click;

            checkbox_border.CheckedChanged += Checkbox_CheckedChanged;
            checkbox_columndragsort.CheckedChanged += Checkbox_CheckedChanged;
            checkbox_fixheader.CheckedChanged += Checkbox_CheckedChanged;
            checkbox_rowstyle.CheckedChanged += Checkbox_rowstyle_CheckedChanged;
            checkbox_sort.CheckedChanged += Checkbox_CheckedChanged;
            checkbox_visibleheader.CheckedChanged += Checkbox_CheckedChanged;

            table_base.CellClick += Table_base_CellClick;
            table_base.CellButtonClick += Table_base_CellButtonClick;
            table_base.CellPaint += Table_base_CellPaint;
        }

        private void Table_base_CellPaint(object sender, TablePaintEventArgs e)
        {
            if (e.Index == 4 && e.RowIndex == 2)
            {
                e.g.Fill(Color.FromArgb(80, 0, 255, 0), e.Rect);
            }
            else if (e.Index == 4 && e.RowIndex == 6)
            {
                int size = (int)(14 * AntdUI.Config.Dpi);
                e.g.FillPolygon(Brushes.Red, new Point[] { new Point(e.Rect.X, e.Rect.Y), new Point(e.Rect.X + size, e.Rect.Y), new Point(e.Rect.X, e.Rect.Y + size) });
            }
        }

        private void Checkbox_rowstyle_CheckedChanged(object sender, BoolEventArgs e)
        {
            if (e.Value)
            {
                table_base.SetRowStyle += Table_base_SetRowStyle;
                table_base.Invalidate();
            }
            else
            {
                table_base.SetRowStyle -= Table_base_SetRowStyle;
                table_base.Invalidate();
            }
        }

        private void Checkbox_CheckedChanged(object sender, BoolEventArgs e)
        {
            table_base.Bordered = checkbox_border.Checked;
            table_base.ColumnDragSort = checkbox_columndragsort.Checked;
            table_base.FixedHeader = checkbox_fixheader.Checked;
            table_base.VisibleHeader = checkbox_visibleheader.Checked;

            foreach (var item in table_base.Columns)
            {
                item.SortOrder = checkbox_sort.Checked;
            }
        }

        private AntdUI.Table.CellStyleInfo Table_base_SetRowStyle(object sender, TableSetRowStyleEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                return new AntdUI.Table.CellStyleInfo
                {
                    BackColor = AntdUI.Style.Db.ErrorBg,
                };
            }
            return null;
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            User useradd = new User()
            {
                CellBadge = new CellBadge(TState.Processing, "测试中"),
                CellImages = new CellImage[] { new CellImage(Properties.Resources.head) },
                CellDivider = new CellDivider(),
                CellTags = new CellTag[] { new CellTag("测试", TTypeMini.Primary), new CellTag("测试", TTypeMini.Success), new CellTag("测试", TTypeMini.Warn) },
                CellText = new CellText("这是一个无图标的文本"),
                CellProgress = new CellProgress(0.5f),
                CellLinks = new CellLink[]{ new CellLink("https://gitee.com/antdui/AntdUI", "AntdUI"),
                    new CellButton(Guid.NewGuid().ToString(),"编辑",TTypeMini.Primary),
                    new CellButton(Guid.NewGuid().ToString(),"删除",TTypeMini.Error) },
            };
            var form = new UserEdit(window, useradd) { Size = new Size(700, 400) };
            AntdUI.Modal.open(new AntdUI.Modal.Config(window, "", form, TType.None)
            {
                BtnHeight = 0,
            });
            if (form.submit)
            {
                antList.Add(useradd);
            }

        }

        private void Table_base_CellClick(object sender, TableClickEventArgs e)
        {
            var record = e.Record;
            if (record is User user)
            {
                curUser = user;
                //判断是否右键
                if (e.Button == MouseButtons.Right)
                {
                    if (antList.Count == 0) return;
                    AntdUI.ContextMenuStrip.open(new AntdUI.ContextMenuStrip.Config(table_base,
                    (item) =>
                        {
                            if (item.Text == "开启")
                            {
                                user.Enabled = true;
                            }
                            else if (item.Text == "关闭")
                            {
                                user.Enabled = false;
                            }
                            else if (item.Text == "编辑")
                            {
                                var form = new UserEdit(window, user) { Size = new Size(500, 300) };
                                AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, form)
                                {
                                    OnLoad = () =>
                                    {
                                        AntdUI.Message.info(window, "进入编辑", autoClose: 1);
                                    },
                                    OnClose = () =>
                                    {
                                        AntdUI.Message.info(window, "结束编辑", autoClose: 1);
                                    }
                                });
                            }
                            else if (item.Text == "删除")
                            {
                                var result = Modal.open(window, "删除警告！", "确认要删除选择的数据吗？", TType.Warn);
                                if (result == DialogResult.OK)
                                {
                                    //父元素没有勾选或者子元素也没有勾选，则删除当前行
                                    bool delCurrent = !antList.Any(x => x.Selected || (x.Users?.Any(u => u.Selected) ?? false));

                                    if (delCurrent)
                                    {
                                        //删除当前行，先判断是否父元素，再判断是否子元素,只支持一层子元素，需实现嵌套查询
                                        for (int i = 0; i < antList.Count; i++)
                                        {
                                            if (antList[i] == user)
                                            {
                                                antList.RemoveAt(i);
                                            }
                                            else
                                            {
                                                antList[i].Users = antList[i].Users?.Where(x => x != user).ToArray();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        // 使用反转for循环删除主列表中选中的项
                                        for (int i = antList.Count - 1; i >= 0; i--)
                                        {
                                            // 1.删除选中的主列表项
                                            if (antList[i].Selected)
                                            {
                                                antList.RemoveAt(i);
                                            }
                                            else
                                            {
                                                // 删除子列表中选中的项
                                                antList[i].Users = antList[i].Users?.Where(childUser => !childUser.Selected).ToArray();
                                            }
                                        }
                                    }

                                }
                            }
                            else if (item.Text == "查看图片")
                            {
                                //查看其他来源的高清图片
                                Preview.open(new Preview.Config(window, Properties.Resources.head2));
                            }
                            else
                                AntdUI.Message.info(window, item.Text, autoClose: 1);
                        },
                        new IContextMenuStripItem[] {
                            //根据行数据动态修改右键菜单
                            user.Enabled?  new ContextMenuStripItem("关闭")
                            {
                                IconSvg = "CloseOutlined"
                            }:new ContextMenuStripItem("开启")
                            {
                                IconSvg = "CheckOutlined"
                            },
                            new AntdUI.ContextMenuStripItem("编辑"){
                                IconSvg = "EditOutlined",
                            },
                            new AntdUI.ContextMenuStripItem("删除"){
                                IconSvg = "DeleteOutlined"
                            },
                            new ContextMenuStripItem("查看图片")
                            {
                                IconSvg = "FundViewOutlined"
                            },
                            new ContextMenuStripItemDivider(),
                            new AntdUI.ContextMenuStripItem("详情"){
                                Sub = new IContextMenuStripItem[]{ new AntdUI.ContextMenuStripItem("打印", "Ctrl + P") { },
                                        new AntdUI.ContextMenuStripItem("另存为", "Ctrl + S") { } },
                                IconSvg = "<svg t=\"1725101601993\" class=\"icon\" viewBox=\"0 0 1024 1024\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" p-id=\"1414\" width=\"200\" height=\"200\"><path d=\"M450.23 831.7c-164.87 0-316.85-108.51-366.94-269.68-30.4-97.82-20.9-201.62 26.76-292.29s127.79-157.35 225.6-187.75c97.83-30.42 201.61-20.9 292.29 26.76 90.67 47.67 157.35 127.79 187.75 225.61 35.78 115.12 16.24 237.58-53.6 335.99a383.494 383.494 0 0 1-43 50.66c-15.04 14.89-39.34 14.78-54.23-0.29-14.9-15.05-14.77-39.34 0.29-54.23a307.844 307.844 0 0 0 34.39-40.52c55.9-78.76 71.54-176.75 42.92-268.84-50.21-161.54-222.49-252.1-384.03-201.9-78.26 24.32-142.35 77.67-180.48 150.2-38.14 72.53-45.74 155.57-21.42 233.83 44.58 143.44 190.03 234.7 338.26 212.42 20.98-3.14 40.48 11.26 43.64 32.2 3.16 20.95-11.26 40.48-32.2 43.64a377.753 377.753 0 0 1-56 4.19z\" p-id=\"1415\"></path><path d=\"M919.84 959.5c-9.81 0-19.63-3.74-27.11-11.24L666.75 722.29c-14.98-14.97-14.98-39.25 0-54.23 14.97-14.98 39.26-14.98 54.23 0l225.97 225.97c14.98 14.97 14.98 39.25 0 54.23-7.48 7.5-17.3 11.24-27.11 11.24z\" p-id=\"1416\"></path></svg>",
                            }
                        }));
                }
                else
                {

                }
            }
        }

        //表格内部按钮事件
        private void Table_base_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            var buttontext = e.Btn.Text;

            if (e.Record is User user)
            {
                curUser = user;
                switch (buttontext)
                {
                    //暂不支持进入整行编辑，只支持指定单元格编辑，推荐使用弹窗或抽屉编辑整行数据
                    case "编辑":
                        var form = new UserEdit(window, user) { Size = new Size(500, 300) };
                        AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, form)
                        {
                            OnLoad = () =>
                            {
                                AntdUI.Message.info(window, "进入编辑", autoClose: 1);
                            },
                            OnClose = () =>
                            {
                                AntdUI.Message.info(window, "结束编辑", autoClose: 1);
                            }
                        });
                        break;
                    case "删除":
                        var result = Modal.open(window, "删除警告！", "确认要删除选择的数据吗？", TType.Warn);
                        if (result == DialogResult.OK)
                            antList.Remove(user);
                        break;
                    case "AntdUI":
                        //超链接内容
                        AntdUI.Message.info(window, user.CellLinks.FirstOrDefault().Id, autoClose: 1);
                        break;
                    case "查看图片":
                        //使用clone可以防止table中的image被修改
                        Preview.open(new Preview.Config(window, (Image)curUser.CellImages[0].Image.Clone()));
                        break;
                }
            }
        }

        private void ButtonDEL_Click(object sender, EventArgs e)
        {
            if (antList.Count == 0 || !antList.Any(x => x.Selected))
            {
                bool isSubSelected = false;
                // 判断子元素是否勾选
                for (int i = 0; i < antList.Count; i++)
                {
                    if (antList[i].Users != null && antList[i].Users.Any(x => x.Selected))
                    {
                        isSubSelected = true;
                        break;
                    }
                }
                if (!isSubSelected)
                {
                    AntdUI.Message.warn(window, "请选择要删除的行！", autoClose: 3);
                    return;
                }
            }

            var result = Modal.open(window, "删除警告！", "确认要删除选择的数据吗？", TType.Warn);
            if (result == DialogResult.OK)
            {
                // 使用反转for循环删除主列表中选中的项
                for (int i = antList.Count - 1; i >= 0; i--)
                {
                    // 删除选中的主列表项
                    if (antList[i].Selected)
                    {
                        antList.RemoveAt(i);
                    }
                    else
                    {
                        // 删除子列表中选中的项
                        antList[i].Users = antList[i].Users?.Where(user => !user.Selected).ToArray();
                    }
                }
                // 提示删除完成
                AntdUI.Message.success(window, "删除成功！", autoClose: 3);
            }
        }



        private void InitData()
        {
            antList = new AntList<User>();

            for (int i = 0; i < 10; i++)
            {
                antList.Add(new User
                {
                    Name = "张三",
                    Age = 30 + i,
                    Address = $"浙江省杭州市西湖区湖底公园{i + 1}号",
                    Enabled = i % 2 == 0,
                    CellImages = new CellImage[] { new CellImage(Properties.Resources.head) },
                    CellTags = new CellTag[] { new CellTag("测试", TTypeMini.Primary), new CellTag("测试", TTypeMini.Success), new CellTag("测试", TTypeMini.Warn) },
                    CellBadge = new CellBadge(TState.Processing, "测试中"),
                    CellText = new CellText("这是一个带图标的文本")
                    {
                        IconRatio = 0.5f,
                        PrefixSvg = "<svg viewBox=\"64 64 896 896\" focusable=\"false\" data-icon=\"search\" width=\"1em\" height=\"1em\" fill=\"currentColor\" aria-hidden=\"true\"><path d=\"M909.6 854.5L649.9 594.8C690.2 542.7 712 479 712 412c0-80.2-31.3-155.4-87.9-212.1-56.6-56.7-132-87.9-212.1-87.9s-155.5 31.3-212.1 87.9C143.2 256.5 112 331.8 112 412c0 80.1 31.3 155.5 87.9 212.1C256.5 680.8 331.8 712 412 712c67 0 130.6-21.8 182.7-62l259.7 259.6a8.2 8.2 0 0011.6 0l43.6-43.5a8.2 8.2 0 000-11.6zM570.4 570.4C528 612.7 471.8 636 412 636s-116-23.3-158.4-65.6C211.3 528 188 471.8 188 412s23.3-116.1 65.6-158.4C296 211.3 352.2 188 412 188s116.1 23.2 158.4 65.6S636 352.2 636 412s-23.3 116.1-65.6 158.4z\"></path></svg>"
                    },
                    CellLinks = new CellLink[] {new CellLink("https://gitee.com/antdui/AntdUI", "AntdUI"),
                    new CellButton(Guid.NewGuid().ToString(),"编辑",TTypeMini.Primary),
                    new CellButton(Guid.NewGuid().ToString(), "徽标", TTypeMini.Success)
                    {
                        //支持所有单元格控件
                        DropDownItems = new ISelectItem[]
                        {
                             new AntdUI.SelectItem(TState.Default),
                             new AntdUI.SelectItem(TState.Primary),
                             new AntdUI.SelectItem(TState.Success),
                             new AntdUI.SelectItem(TState.Error),
                             new AntdUI.SelectItem(TState.Warn),
                             new AntdUI.SelectItem(TState.Processing),

                        },
                        DropDownValueChanged = (value) =>
                        {
                            string badge = value.ToString();
                            switch(badge) {
                            case "Default":
                                    curUser.CellBadge = new CellBadge(TState.Default, badge); break;
                            case "Primary":
                                    curUser.CellBadge = new CellBadge(TState.Primary, badge); break;
                            case "Success":
                                    curUser.CellBadge = new CellBadge(TState.Success, badge); break;
                            case "Error":
                                    curUser.CellBadge = new CellBadge(TState.Error, badge); break;
                            case "Warn":
                                    curUser.CellBadge = new CellBadge(TState.Warn, badge); break;
                            case "Processing":
                                    curUser.CellBadge = new CellBadge(TState.Processing, badge); break;
                            }
                        }
                    },
                    new CellButton(Guid.NewGuid().ToString(),"删除",TTypeMini.Error),
                    new CellButton(Guid.NewGuid().ToString(),"查看图片",TTypeMini.Primary)},
                    //value:0-1
                    CellProgress = new CellProgress(0.5f),
                    CellDivider = new CellDivider(),
                });
            }

            List<User> subUsers = new List<User>();
            for (int i = 0; i < 3; i++)
            {
                subUsers.Add(new User()
                {
                    Name = "李四",
                    Age = 30 + i,
                    Address = $"上海市东方明珠{i + 1}号",
                    Enabled = i % 2 == 0,
                    CellImages = new CellImage[] { new CellImage(Properties.Resources.head) },
                    CellTags = new CellTag[] { new CellTag("测试", TTypeMini.Primary) },
                    CellBadge = new CellBadge(TState.Success, "已完成"),
                    CellText = new CellText("这是一个带图标的文本")
                    {
                        IconRatio = 0.5f,
                        PrefixSvg = "<svg viewBox=\"64 64 896 896\" focusable=\"false\" data-icon=\"search\" width=\"1em\" height=\"1em\" fill=\"currentColor\" aria-hidden=\"true\"><path d=\"M909.6 854.5L649.9 594.8C690.2 542.7 712 479 712 412c0-80.2-31.3-155.4-87.9-212.1-56.6-56.7-132-87.9-212.1-87.9s-155.5 31.3-212.1 87.9C143.2 256.5 112 331.8 112 412c0 80.1 31.3 155.5 87.9 212.1C256.5 680.8 331.8 712 412 712c67 0 130.6-21.8 182.7-62l259.7 259.6a8.2 8.2 0 0011.6 0l43.6-43.5a8.2 8.2 0 000-11.6zM570.4 570.4C528 612.7 471.8 636 412 636s-116-23.3-158.4-65.6C211.3 528 188 471.8 188 412s23.3-116.1 65.6-158.4C296 211.3 352.2 188 412 188s116.1 23.2 158.4 65.6S636 352.2 636 412s-23.3 116.1-65.6 158.4z\"></path></svg>"
                    },
                    CellLinks = new CellLink[] { new CellLink("https://gitee.com/antdui/AntdUI", "AntdUI") },
                    //value:0-1
                    CellProgress = new CellProgress(1f),
                    CellDivider = new CellDivider(),
                });
            }

            //设置树数据，可为任意行设置

            antList[1].Users = subUsers.ToArray();
            table_base.Binding(antList);

            //设置行禁用
            table_base.SetRowEnable(0, false, true);

            //竖向合并单元格
            table_base.AddMergedRegion(new CellRange(2, 4, 3, 3));
            //横向合并单元格
            table_base.AddMergedRegion(new CellRange(5, 5, 1, 3));
        }
    }
}
