using AntdUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class IconDemo : UserControl
    {
        private Window window;
        public IconDemo(Window _window)
        {
            window = _window;
            InitializeComponent();
            segmented1.Items.Add(new SegmentedItem
            {
                IconSvg = Utils.Emoji.emoji_svg_all,
                Text = "Emoji"
            });
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        // 处理父窗体发来的事件
        public void OnLanguageChanged(object sender, EventArgs e)
        {
            //global
            InitData();
        }

        private void BindEventHandler()
        {
            segmented1.SelectIndexChanged += segmented1_SelectIndexChanged;
            txt_search.TextChanged += txt_search_TextChanged;
            txt_search.SuffixClick += txt_search_SuffixClick;
            vpanel.ItemClick += vpanel_ItemClick;
        }

        #region 数据

        private void segmented1_SelectIndexChanged(object sender, IntEventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            int index = segmented1.SelectIndex;
            if (index == 2)
            {
                var data = GetDataEmoji();
                var svgs = new List<VirtualItem>(data.Count);
                foreach (var it in data)
                {
                    if (it.Key == "people body") svgs.Add(new TItem_Skin(GetChinaEmojiGroup(it.Key), it.Key, it.Value.ToArray()));
                    else svgs.Add(new TItem(GetChinaEmojiGroup(it.Key), it.Key, it.Value.ToArray()));
                    svgs.AddRange(it.Value);
                }
                vpanel.Items.Clear();
                txt_search.Text = "";
                vpanel.Items.AddRange(svgs);
            }
            else
            {
                var data = GetData(index);
                var svgs = new List<VirtualItem>(data.Count);
                foreach (var it in data)
                {
                    svgs.Add(new TItem(GetChinaGroup(it.Key), it.Key, it.Value.ToArray()));
                    svgs.AddRange(it.Value);
                }
                vpanel.Items.Clear();
                txt_search.Text = "";
                vpanel.Items.AddRange(svgs);
            }
        }

        Dictionary<string, List<VIItem>> GetData(int index)
        {
            var dir = new Dictionary<string, List<VIItem>>(SvgDb.Custom.Count);
            var tmp = new List<VIItem>(SvgDb.Custom.Count);
            if (index == 0)
            {
                foreach (var it in SvgDb.Custom)
                {
                    if (it.Key == "QuestionOutlined")
                    {
                        var id = "Icon.Directional";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "EditOutlined")
                    {
                        var id = "Icon.Suggested";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AreaChartOutlined")
                    {
                        var id = "Icon.Editor";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AndroidOutlined")
                    {
                        var id = "Icon.Data";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AccountBookOutlined")
                    {
                        var id = "Icon.Logos";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "StepBackwardFilled")
                    {
                        var id = "Icon.Application";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                        return dir;
                    }
                    tmp.Add(new VIItem(it.Key, it.Value));
                }
                foreach (var item in tmp) item.Group = "Icon.Application";
                dir.Add("Icon.Application", new List<VIItem>(tmp));
                tmp.Clear();
            }
            else
            {
                bool isadd = false;
                foreach (var it in SvgDb.Custom)
                {
                    if (it.Key == "StepBackwardFilled") isadd = true;
                    else if (it.Key == "QuestionCircleFilled")
                    {
                        var id = "Icon.Directional";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "EditFilled")
                    {
                        var id = "Icon.Suggested";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "PieChartFilled")
                    {
                        var id = "Icon.Editor";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AndroidFilled")
                    {
                        var id = "Icon.Data";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AccountBookFilled")
                    {
                        var id = "Icon.Logos";
                        foreach (var item in tmp) item.Group = id;
                        dir.Add(id, new List<VIItem>(tmp));
                        tmp.Clear();
                    }
                    if (isadd) tmp.Add(new VIItem(it.Key, it.Value));
                }
                foreach (var item in tmp) item.Group = "Icon.Application";
                dir.Add("Icon.Application", new List<VIItem>(tmp));
                tmp.Clear();
            }
            return dir;
        }
        Dictionary<string, List<EItem>> GetDataEmoji()
        {
            var dir = new Dictionary<string, List<EItem>>(9);
            int count = SvgDb.Emoji.Count;
            var hs = new List<string>();
            foreach (var it in SvgDb.Emoji)
            {
                var group = Utils.Emoji.emoji_group[it.Key];
                if (Utils.Emoji.emoji_skins.TryGetValue(it.Key, out var skins))
                {
                    var fid = Utils.Emoji.emoji_skins[it.Key];
                    hs.AddRange(skins);
                    var item = new EItem(it.Key, it.Value, Utils.Emoji.emoji_keywords[it.Key], group);
                    item.Skins = skins.ToArray();
                    if (dir.TryGetValue(group, out var tmp)) tmp.Add(item);
                    else dir.Add(group, new List<EItem>(count) { item });
                }
                else if (hs.Contains(it.Key)) continue;
                else
                {
                    var item = new EItem(it.Key, it.Value, Utils.Emoji.emoji_keywords[it.Key], group);
                    if (dir.TryGetValue(group, out var tmp)) tmp.Add(item);
                    else dir.Add(group, new List<EItem>(count) { item });
                }
            }
            return dir;
        }

        string GetChinaGroup(string key)
        {
            switch (key)
            {
                case "QuestionOutlined":
                case "QuestionCircleFilled":
                case "Icon.Directional":
                    return "方向性图标";
                case "EditOutlined":
                case "EditFilled":
                case "Icon.Suggested":
                    return "提示建议性图标";
                case "AreaChartOutlined":
                case "PieChartFilled":
                case "Icon.Editor":
                    return "编辑类图标";
                case "AndroidOutlined":
                case "AndroidFilled":
                case "Icon.Data":
                    return "数据类图标";
                case "AccountBookOutlined":
                case "AccountBookFilled":
                case "Icon.Logos":
                    return "品牌和标识";
                case "StepBackwardFilled":
                case "Icon.Application":
                    return "网站通用图标";

                default:
                    return "未知";
            }
        }
        string GetChinaEmojiGroup(string key)
        {
            switch (key)
            {
                case "smileys emotion":
                    return "笑脸和情感";
                case "people body":
                    return "人物和身体";
                case "animals nature":
                    return "动物和自然";
                case "food drink":
                    return "食物和饮料";
                case "travel places":
                    return "旅行和地点";
                case "activities":
                    return "活动";
                case "objects":
                    return "物品";
                case "symbols":
                    return "符号";
                case "flags":
                    return "旗帜";
                default:
                    return "未知";
            }
        }

        #endregion

        #region 渲染

        internal class TItem : VirtualItem
        {
            string Title, Count, originalCount;
            string LocalizationTitle;
            public VirtualItem[] data;
            public TItem(string t, string localization, VirtualItem[] d)
            {
                CanClick = false;
                data = d;
                Title = t;
                LocalizationTitle = localization;
                originalCount = Count = d.Length.ToString();
            }

            public void SetCount(int value)
            {
                Count = value.ToString();
                Visible = value > 0;
            }
            public void Restore() => Count = originalCount;

            public override void Paint(Canvas g, VirtualPanelArgs e)
            {
                g.String(Localization.Get(LocalizationTitle, Title), font_title, Style.Db.Text, rect, FormatFlags.Left | FormatFlags.VerticalCenter | FormatFlags.NoWrap);
                using (var path = rect_count.RoundPath(e.Radius))
                {
                    g.Fill(Style.Db.TagDefaultBg, path);
                    g.Draw(Style.Db.DefaultBorder, sp, path);
                }
                g.String(Count, font_count, Style.Db.Text, rect_count);
            }

            internal int sp = 1, rl = 0;
            Rectangle rect, rect_count;
            Font font_title, font_count;
            public override Size Size(Canvas g, VirtualPanelArgs e)
            {
                var dpi = g.Dpi;
                sp = (int)(1 * dpi);
                int gap = (int)(8 * dpi), x = (int)(30 * dpi), h = (int)(44 * dpi);
                rect = new Rectangle(x, 0, e.Rect.Width, h);
                font_title?.Dispose();
                font_count?.Dispose();
                font_title = new Font(e.Panel.Font, FontStyle.Bold);
                font_count = new Font(e.Panel.Font.FontFamily, e.Panel.Font.Size * .74F, e.Panel.Font.Style);
                Size size_title = g.MeasureString(Localization.Get(LocalizationTitle, Title), font_title), size_count = g.MeasureString(Count, font_count);
                int rx = x + size_title.Width + gap, ry = (h - size_title.Height) / 2;
                if (size_count.Width > size_count.Height)
                {
                    float r = size_title.Height * 1F / size_count.Height;
                    rect_count = new Rectangle(rx, ry, (int)(size_count.Width * r), size_title.Height);
                }
                else rect_count = new Rectangle(rx, ry, size_title.Height, size_title.Height);
                rl = rect_count.Right;
                return rect.Size;
            }

            public override void Dispose(VirtualPanel sender, bool disposed)
            {
                font_title?.Dispose();
                font_count?.Dispose();
                base.Dispose(sender, disposed);
            }
        }
        internal class TItem_Skin : TItem
        {
            public TItem_Skin(string t, string localization, VirtualItem[] d) : base(t, localization, d)
            {
                CanClick = true;
            }

            public override void Paint(Canvas g, VirtualPanelArgs e)
            {
                base.Paint(g, e);
                Paint(g, "#ffc83d".ToColor(), hove_default, sel_default, rect_default);
                Paint(g, "#f7d7c4".ToColor(), hove_light, sel_light, rect_light);
                Paint(g, "#d8b094".ToColor(), hove_medium, sel_medium, rect_medium);
                Paint(g, "#bb9167".ToColor(), hove_medium_light, sel_medium_light, rect_medium_light);
                Paint(g, "#8e562e".ToColor(), hove_medium_dark, sel_medium_dark, rect_medium_dark);
                Paint(g, "#613d30".ToColor(), hove_dark, sel_dark, rect_dark);
            }

            void Paint(Canvas g, Color color, bool hove, bool sel, Rectangle rect)
            {
                if (hove) g.FillEllipse(color, GetBig(rect, (int)(20 * g.Dpi)));
                else g.FillEllipse(color, rect);
                if (sel) g.DrawEllipse(color, 4 * g.Dpi, GetBig(rect, (int)(26 * g.Dpi)));
            }

            Rectangle rect_default, rect_light, rect_medium, rect_medium_light, rect_medium_dark, rect_dark;
            public override Size Size(Canvas g, VirtualPanelArgs e)
            {
                var size = base.Size(g, e);
                int gap = (int)(12 * g.Dpi), wh = (int)(18 * g.Dpi);
                int rx = rl + gap, ry = (size.Height - wh) / 2;
                rect_default = new Rectangle(rx, ry, wh, wh);
                rx += gap + wh;
                rect_light = new Rectangle(rx, ry, wh, wh);
                rx += gap + wh;
                rect_medium = new Rectangle(rx, ry, wh, wh);
                rx += gap + wh;
                rect_medium_light = new Rectangle(rx, ry, wh, wh);
                rx += gap + wh;
                rect_medium_dark = new Rectangle(rx, ry, wh, wh);
                rx += gap + wh;
                rect_dark = new Rectangle(rx, ry, wh, wh);
                return size;
            }

            static RectangleF GetBig(Rectangle rect, int wh)
            {
                float xy = (rect.Width - wh) / 2F;
                return new RectangleF(rect.X + xy, rect.Y + xy, wh, wh);
            }

            #region 鼠标

            bool hove_default, hove_light, hove_medium, hove_medium_light, hove_medium_dark, hove_dark;
            bool sel_default = true, sel_light, sel_medium, sel_medium_light, sel_medium_dark, sel_dark;
            public override bool MouseMove(VirtualPanel sender, VirtualPanelMouseArgs e)
            {
                bool old_default = hove_default, old_light = hove_light, old_medium = hove_medium, old_medium_light = hove_medium_light, old_medium_dark = hove_medium_dark, old_dark = hove_dark;
                hove_default = rect_default.Contains(e.X, e.Y);
                hove_light = rect_light.Contains(e.X, e.Y);
                hove_medium = rect_medium.Contains(e.X, e.Y);
                hove_medium_light = rect_medium_light.Contains(e.X, e.Y);
                hove_medium_dark = rect_medium_dark.Contains(e.X, e.Y);
                hove_dark = rect_dark.Contains(e.X, e.Y);

                bool r = hove_default || hove_light || hove_medium || hove_medium_light || hove_medium_dark || hove_dark;
                if (old_default == hove_default && old_light == hove_light && old_medium == hove_medium && old_medium_light == hove_medium_light && old_medium_dark == hove_medium_dark && old_dark == hove_dark) return r;
                Invalidate();
                return r;
            }
            public override void MouseClick(VirtualPanel sender, VirtualPanelMouseArgs e)
            {
                hove_default = rect_default.Contains(e.X, e.Y);
                hove_light = rect_light.Contains(e.X, e.Y);
                hove_medium = rect_medium.Contains(e.X, e.Y);
                hove_medium_light = rect_medium_light.Contains(e.X, e.Y);
                hove_medium_dark = rect_medium_dark.Contains(e.X, e.Y);
                hove_dark = rect_dark.Contains(e.X, e.Y);
                if (hove_default || hove_light || hove_medium || hove_medium_light || hove_medium_dark || hove_dark)
                {
                    int code = 0;
                    if (hove_default)
                    {
                        code = 0;
                        if (sel_default) return;
                        sel_default = sel_light = sel_medium = sel_medium_light = sel_medium_dark = sel_dark = false;
                        sel_default = true;
                    }
                    else if (hove_light)
                    {
                        code = 1;
                        if (sel_light) return;
                        sel_default = sel_light = sel_medium = sel_medium_light = sel_medium_dark = sel_dark = false;
                        sel_light = true;
                    }
                    else if (hove_medium)
                    {
                        code = 2;
                        if (sel_medium) return;
                        sel_default = sel_light = sel_medium = sel_medium_light = sel_medium_dark = sel_dark = false;
                        sel_medium = true;
                    }
                    else if (hove_medium_light)
                    {
                        code = 3;
                        if (sel_medium_light) return;
                        sel_default = sel_light = sel_medium = sel_medium_light = sel_medium_dark = sel_dark = false;
                        sel_medium_light = true;
                    }
                    else if (hove_medium_dark)
                    {
                        code = 4;
                        if (sel_medium_dark) return;
                        sel_default = sel_light = sel_medium = sel_medium_light = sel_medium_dark = sel_dark = false;
                        sel_medium_dark = true;
                    }
                    else if (hove_dark)
                    {
                        code = 5;
                        if (sel_dark) return;
                        sel_default = sel_light = sel_medium = sel_medium_light = sel_medium_dark = sel_dark = false;
                        sel_dark = true;
                    }
                    sender.PauseLayout = true;
                    foreach (var it in data)
                    {
                        if (it is EItem eItem) eItem.SetSkin(code);
                    }
                    sender.PauseLayout = false;
                }
            }

            #endregion
        }
        internal class VIItem : VirtualItem
        {
            public string Key, Value, Group;
            public VIItem(string key, string value)
            {
                Tag = Key = key;
                Value = value;
            }

            internal Bitmap bmp = null, bmp_ac = null;
            public override void Paint(Canvas g, VirtualPanelArgs e)
            {
                if (Hover)
                {
                    using (var path = e.Rect.RoundPath(e.Radius))
                    {
                        g.Fill(Style.Db.Primary, path);
                    }
                    if (bmp_ac == null) bmp_ac = Value.SvgToBmp(icon_size, icon_size, Style.Db.PrimaryColor);
                    g.Image(bmp_ac, rect_icon);
                    g.String(Key, e.Panel.Font, Style.Db.PrimaryColor, rect_text);
                }
                else
                {
                    if (bmp == null) bmp = Value.SvgToBmp(icon_size, icon_size, Style.Db.Text);
                    g.Image(bmp, rect_icon);
                    g.String(Key, e.Panel.Font, Style.Db.Text, rect_text);

                }
            }

            int icon_size = 36;
            Rectangle rect_icon, rect_text;
            public override Size Size(Canvas g, VirtualPanelArgs e)
            {
                var dpi = g.Dpi;
                int w = (int)(200 * dpi), h = (int)(100 * dpi);
                icon_size = (int)(36 * dpi);
                int text_size = (int)(24 * dpi), y = (h - (icon_size + text_size)) / 2;
                rect_icon = new Rectangle((w - icon_size) / 2, y, icon_size, icon_size);
                rect_text = new Rectangle(0, y + icon_size / 2 + text_size, w, text_size);
                return new Size(w, h);
            }

            public override void Dispose(VirtualPanel sender, bool disposed)
            {
                if (disposed)
                {
                    bmp?.Dispose();
                    bmp_ac?.Dispose();
                    bmp = bmp_ac = null;
                }
                else
                {
                    bmp?.Dispose();
                    bmp = null;
                }
                base.Dispose(sender, disposed);
            }
        }
        internal class EItem : VirtualItem
        {
            public string Key, Value, Group;
            public string[] Keywords;
            public string[] Skins = null;
            public EItem(string key, string value, string[] keywords, string group)
            {
                Tag = Key = key;
                Keywords = keywords;
                Value = value;
                Group = group;
            }

            public void SetSkin(int i)
            {
                if (Skins == null) return;
                bmp?.Dispose();
                bmp = null;
                Key = Skins[i];
                Value = SvgDb.Emoji[Key];
            }

            Bitmap bmp = null;
            public override void Paint(Canvas g, VirtualPanelArgs e)
            {
                if (bmp == null) bmp = Value.SvgToBmp(rect_icon_hover.Width, rect_icon_hover.Height, Style.Db.Text);
                if (Hover)
                {
                    using (var path = e.Rect.RoundPath(e.Radius))
                    {
                        g.Draw(Style.Db.Primary, sp, path);
                    }
                    g.Image(bmp, rect_icon_hover);
                }
                else g.Image(bmp, rect_icon);
            }

            int sp = 4;
            Rectangle rect_icon, rect_icon_hover;
            public override Size Size(Canvas g, VirtualPanelArgs e)
            {
                var dpi = g.Dpi;
                sp = (int)(4 * dpi);
                int size = (int)(100 * dpi);
                int icon_size = (int)(48 * dpi), xy = (size - icon_size) / 2;
                int icon_size_hover = (int)(78 * dpi), xy_hover = (size - icon_size_hover) / 2;
                rect_icon = new Rectangle(xy, xy, icon_size, icon_size);
                rect_icon_hover = new Rectangle(xy_hover, xy_hover, icon_size_hover, icon_size_hover);
                return new Size(size, size);
            }


            public override void Dispose(VirtualPanel sender, bool disposed)
            {
                bmp?.Dispose();
                bmp = null;
                base.Dispose(sender, disposed);
            }
        }

        #endregion

        private void vpanel_ItemClick(object sender, VirtualItemEventArgs e)
        {
            string copysuccess = Localization.Get("copysuccess", "复制成功");
            string copyfail = Localization.Get("copyfail", "复制失败");
            if (e.Item is VIItem item)
            {
                if (Helper.ClipboardSetText(this, item.Key)) AntdUI.Message.success(window, item.Key + " " + copysuccess);
                else AntdUI.Message.error(window, item.Key + " " + copyfail);
            }
            else if (e.Item is EItem emoji)
            {
                if (Helper.ClipboardSetText(this, emoji.Key)) AntdUI.Message.success(window, emoji.Key + " " + copysuccess);
                else AntdUI.Message.error(window, emoji.Key + " " + copyfail);
            }
        }

        #region 搜索

        private void txt_search_TextChanged(object sender, System.EventArgs e) => LoadSearchList();
        private void txt_search_SuffixClick(object sender, MouseEventArgs e) => LoadSearchList();

        void LoadSearchList()
        {
            string search = txt_search.Text.Trim();
            BeginInvoke(new Action(() =>
            {
                vpanel.PauseLayout = true;
                if (string.IsNullOrEmpty(search))
                {
                    foreach (var it in vpanel.Items)
                    {
                        it.Visible = true;
                        if (it is TItem itemTitle) itemTitle.Restore();
                    }
                    vpanel.Empty = false;
                }
                else
                {
                    vpanel.Empty = true;
                    var titles = new List<TItem>(vpanel.Items.Count);
                    var listSearch = new List<ItemSearchWeigth<VirtualItem>>(vpanel.Items.Count);
                    foreach (var it in vpanel.Items)
                    {
                        if (it is EItem emoji_item)
                        {
                            int score = Helper.SearchContains(search, emoji_item.Key, emoji_item.Keywords, out _);
                            it.Visible = score > 0;
                            if (it.Visible) listSearch.Add(new ItemSearchWeigth<VirtualItem>(score, it).SetGroup(emoji_item.Group));
                        }
                        else if (it is VIItem item)
                        {
                            int score = Helper.SearchContains(search, item.Key, out _);
                            it.Visible = score > 0;
                            if (it.Visible) listSearch.Add(new ItemSearchWeigth<VirtualItem>(score, it).SetGroup(item.Group));
                        }
                        else if (it is TItem itemTitle) titles.Add(itemTitle);
                    }
                    listSearch.SearchWeightSortByVirtualItem();
                    foreach (var it in titles)
                    {
                        it.SortIndex = -1;
                        int count = 0;
                        foreach (var item in it.data)
                        {
                            if (item.Visible)
                            {
                                count++;
                                if (it.SortIndex == -1 || it.SortIndex > item.SortIndex) it.SortIndex = item.SortIndex;
                            }
                        }
                        it.SetCount(count);
                    }
                }
                vpanel.PauseLayout = false;
            }));
        }

        #endregion
    }
}
