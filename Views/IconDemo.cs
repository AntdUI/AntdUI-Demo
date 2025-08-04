using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class IconDemo : UserControl
    {
        private AntdUI.Window window;
        public IconDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
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

        private void segmented1_SelectIndexChanged(object sender, AntdUI.IntEventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            var data = GetData();
            var svgs = new List<AntdUI.VirtualItem>(data.Count);
            foreach (var it in data)
            {
                svgs.Add(new TItem(it.Key, it.Value));
                svgs.AddRange(it.Value);
            }
            vpanel.Items.Clear();
            txt_search.Text = "";
            vpanel.Items.AddRange(svgs);

            //global
            segmented1.Items[0].Text = AntdUI.Localization.Get("outlined", "线框风格");
            segmented1.Items[1].Text = AntdUI.Localization.Get("filled", "实底风格");
        }

        Dictionary<string, List<VItem>> GetData()
        {
            var dir = new Dictionary<string, List<VItem>>(AntdUI.SvgDb.Custom.Count);
            var tmp = new List<VItem>(AntdUI.SvgDb.Custom.Count);
            string directionalicon = AntdUI.Localization.Get("directionalicon", "方向性图标");
            string suggestionicon = AntdUI.Localization.Get("suggestionicon", "提示建议性图标");
            string editingicon = AntdUI.Localization.Get("editingicon", "编辑类图标");
            string dataicon = AntdUI.Localization.Get("dataicon", "数据类图标");
            string brand = AntdUI.Localization.Get("brand", "品牌和标识");
            string universal = AntdUI.Localization.Get("universal", "网站通用图标");
            if (segmented1.SelectIndex == 0)
            {
                foreach (var it in AntdUI.SvgDb.Custom)
                {
                    if (it.Key == "QuestionOutlined")
                    {
                        dir.Add(directionalicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "EditOutlined")
                    {
                        dir.Add(suggestionicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AreaChartOutlined")
                    {
                        dir.Add(editingicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AndroidOutlined")
                    {
                        dir.Add(dataicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AccountBookOutlined")
                    {
                        dir.Add(brand, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "StepBackwardFilled")
                    {
                        dir.Add(universal, new List<VItem>(tmp));
                        tmp.Clear();
                        return dir;
                    }
                    tmp.Add(new VItem(it.Key, it.Value));
                }
                dir.Add(universal, new List<VItem>(tmp));
                tmp.Clear();
            }
            else
            {
                bool isadd = false;
                foreach (var it in AntdUI.SvgDb.Custom)
                {
                    if (it.Key == "StepBackwardFilled") isadd = true;
                    else if (it.Key == "QuestionCircleFilled")
                    {
                        dir.Add(directionalicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "EditFilled")
                    {
                        dir.Add(suggestionicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "PieChartFilled")
                    {
                        dir.Add(editingicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AndroidFilled")
                    {
                        dir.Add(dataicon, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    else if (it.Key == "AccountBookFilled")
                    {
                        dir.Add(brand, new List<VItem>(tmp));
                        tmp.Clear();
                    }
                    if (isadd) tmp.Add(new VItem(it.Key, it.Value));
                }
                dir.Add(universal, new List<VItem>(tmp));
                tmp.Clear();
            }
            return dir;
        }

        #endregion

        #region 渲染

        class TItem : AntdUI.VirtualItem
        {
            string title, count;
            public List<VItem> data;
            public TItem(string t, List<VItem> d)
            {
                CanClick = false;
                data = d;
                title = t;
                count = d.Count.ToString();
            }

            StringFormat s_f = AntdUI.Helper.SF_NoWrap(lr: StringAlignment.Near);
            StringFormat s_c = AntdUI.Helper.SF_NoWrap();
            public override void Paint(AntdUI.Canvas g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;

                using (var fore = new SolidBrush(AntdUI.Style.Db.Text))
                {
                    using (var font_title = new Font(e.Panel.Font, FontStyle.Bold))
                    using (var font_count = new Font(e.Panel.Font.FontFamily, e.Panel.Font.Size * .74F, e.Panel.Font.Style))
                    {
                        var size = AntdUI.Helper.Size(g.MeasureString(title, font_title));
                        g.String(title, font_title, fore, e.Rect, s_f);

                        var rect_count = new Rectangle(e.Rect.X + size.Width, e.Rect.Y + (e.Rect.Height - size.Height) / 2, size.Height, size.Height);
                        using (var path = AntdUI.Helper.RoundPath(rect_count, e.Radius))
                        {
                            g.Fill(AntdUI.Style.Db.TagDefaultBg, path);
                            g.Draw(AntdUI.Style.Db.DefaultBorder, 1 * dpi, path);
                        }
                        g.String(count, font_count, fore, rect_count, s_c);
                    }
                }
            }

            public override Size Size(AntdUI.Canvas g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;
                return new Size(e.Rect.Width, (int)(44 * dpi));
            }
        }
        class VItem : AntdUI.VirtualItem
        {
            public string Key, Value;
            public VItem(string key, string value) { Tag = Key = key; Value = value; }

            StringFormat s_f = AntdUI.Helper.SF_NoWrap();
            Bitmap bmp = null, bmp_ac = null;
            public override void Paint(AntdUI.Canvas g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;
                int icon_size = (int)(24 * dpi), text_size = (int)(24 * dpi), y = e.Rect.Y + (e.Rect.Height - (icon_size + text_size)) / 2;
                var rect_icon = new Rectangle(e.Rect.X + (e.Rect.Width - icon_size) / 2, y, icon_size, icon_size);
                var rect_text = new Rectangle(e.Rect.X, y + icon_size / 2 + text_size, e.Rect.Width, text_size);
                if (Hover)
                {
                    using (var path = AntdUI.Helper.RoundPath(e.Rect, e.Radius))
                    {
                        g.Fill(AntdUI.Style.Db.Primary, path);
                    }
                    if (bmp_ac == null) bmp_ac = AntdUI.SvgExtend.SvgToBmp(Value, icon_size, icon_size, AntdUI.Style.Db.PrimaryColor);
                    g.Image(bmp_ac, rect_icon);
                    g.String(Key, e.Panel.Font, AntdUI.Style.Db.PrimaryColor, rect_text, s_f);
                }
                else
                {
                    if (bmp == null) bmp = AntdUI.SvgExtend.SvgToBmp(Value, icon_size, icon_size, AntdUI.Style.Db.Text);
                    g.Image(bmp, rect_icon);
                    g.String(Key, e.Panel.Font, AntdUI.Style.Db.Text, rect_text, s_f);
                }

            }
            public override Size Size(AntdUI.Canvas g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;
                return new Size((int)(140 * dpi), (int)(100 * dpi));
            }
        }

        #endregion

        private void vpanel_ItemClick(object sender, AntdUI.VirtualItemEventArgs e)
        {
            string copysuccess = AntdUI.Localization.Get("copysuccess", "复制成功");
            string copyfail = AntdUI.Localization.Get("copyfail", "复制失败");
            if (e.Item is VItem item)
            {
                if (AntdUI.Helper.ClipboardSetText(this, item.Key)) AntdUI.Message.success(window, item.Key + " " + copysuccess);
                else AntdUI.Message.error(window, item.Key + " " + copyfail);
            }
        }

        #region 搜索

        private void txt_search_TextChanged(object sender, System.EventArgs e) => LoadSearchList();
        private void txt_search_SuffixClick(object sender, MouseEventArgs e) => LoadSearchList();

        void LoadSearchList()
        {
            string search = txt_search.Text;
            BeginInvoke(new Action(() =>
            {
                vpanel.PauseLayout = true;
                if (string.IsNullOrEmpty(search))
                {
                    foreach (var it in vpanel.Items) it.Visible = true;
                    vpanel.Empty = false;
                }
                else
                {
                    vpanel.Empty = true;
                    string searchLower = search.ToLower();
                    var titles = new List<TItem>(vpanel.Items.Count);
                    foreach (var it in vpanel.Items)
                    {
                        if (it is VItem item) it.Visible = item.Key.ToLower().Contains(searchLower);
                        else if (it is TItem itemTitle) titles.Add(itemTitle);
                    }
                    foreach (var it in titles)
                    {
                        int count = 0;
                        foreach (var item in it.data)
                        {
                            if (item.Visible) count++;
                        }
                        it.Visible = count > 0;
                    }
                }
                vpanel.PauseLayout = false;
            }));
        }

        #endregion
    }
}
