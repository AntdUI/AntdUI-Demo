namespace AntdUIDemo
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.titlebar = new AntdUI.PageHeader();
            this.input_search = new AntdUI.Input();
            this.dropdown_translate = new AntdUI.Dropdown();
            this.button_color = new AntdUI.Button();
            this.buttonSZ = new AntdUI.Button();
            this.button_collapse = new AntdUI.Button();
            this.tabs = new AntdUI.Tabs();
            this.tabPage = new AntdUI.TabPage();
            this.panel_content = new AntdUI.Panel();
            this.menu = new AntdUI.Menu();
            this.panel_left = new AntdUI.Panel();
            this.titlebar.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.Controls.Add(this.input_search);
            this.titlebar.Controls.Add(this.dropdown_translate);
            this.titlebar.Controls.Add(this.button_color);
            this.titlebar.Controls.Add(this.buttonSZ);
            this.titlebar.DividerShow = true;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowButton = true;
            this.titlebar.ShowIcon = true;
            this.titlebar.Size = new System.Drawing.Size(1024, 40);
            this.titlebar.SubText = "Demo";
            this.titlebar.TabIndex = 0;
            this.titlebar.Text = "AntdUI";
            // 
            // input_search
            // 
            this.input_search.AllowClear = true;
            this.input_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.input_search.LocalizationPlaceholderText = "search";
            this.input_search.Location = new System.Drawing.Point(530, 0);
            this.input_search.Name = "input_search";
            this.input_search.PlaceholderText = "搜索";
            this.input_search.PrefixSvg = "SearchOutlined";
            this.input_search.Size = new System.Drawing.Size(200, 40);
            this.input_search.TabIndex = 4;
            // 
            // dropdown_translate
            // 
            this.dropdown_translate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropdown_translate.Ghost = true;
            this.dropdown_translate.IconSvg = "TranslationOutlined";
            this.dropdown_translate.Items.AddRange(new object[] {
            "简体中文",
            "English"});
            this.dropdown_translate.Location = new System.Drawing.Point(730, 0);
            this.dropdown_translate.Name = "dropdown_translate";
            this.dropdown_translate.Placement = AntdUI.TAlignFrom.BR;
            this.dropdown_translate.Size = new System.Drawing.Size(50, 40);
            this.dropdown_translate.TabIndex = 3;
            this.dropdown_translate.Trigger = AntdUI.Trigger.Hover;
            this.dropdown_translate.WaveSize = 0;
            // 
            // button_color
            // 
            this.button_color.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_color.Ghost = true;
            this.button_color.IconSvg = "SunOutlined";
            this.button_color.Location = new System.Drawing.Point(780, 0);
            this.button_color.Name = "button_color";
            this.button_color.Radius = 0;
            this.button_color.Size = new System.Drawing.Size(50, 40);
            this.button_color.TabIndex = 1;
            this.button_color.ToggleIconSvg = "MoonOutlined";
            this.button_color.WaveSize = 0;
            // 
            // buttonSZ
            // 
            this.buttonSZ.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSZ.Ghost = true;
            this.buttonSZ.IconSvg = "SettingOutlined";
            this.buttonSZ.Location = new System.Drawing.Point(830, 0);
            this.buttonSZ.Name = "buttonSZ";
            this.buttonSZ.Radius = 0;
            this.buttonSZ.Size = new System.Drawing.Size(50, 40);
            this.buttonSZ.TabIndex = 0;
            this.buttonSZ.WaveSize = 0;
            // 
            // button_collapse
            // 
            this.button_collapse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_collapse.Ghost = true;
            this.button_collapse.IconRatio = 1F;
            this.button_collapse.IconSvg = "MenuUnfoldOutlined";
            this.button_collapse.Location = new System.Drawing.Point(0, 560);
            this.button_collapse.Name = "button_collapse";
            this.button_collapse.Radius = 0;
            this.button_collapse.Size = new System.Drawing.Size(58, 40);
            this.button_collapse.TabIndex = 3;
            this.button_collapse.ToggleIconSvg = "MenuFoldOutlined";
            this.button_collapse.WaveSize = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Gap = 20;
            this.tabs.Location = new System.Drawing.Point(58, 40);
            this.tabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.tabs.Name = "tabs";
            this.tabs.Pages.Add(this.tabPage);
            this.tabs.Size = new System.Drawing.Size(966, 600);
            styleCard1.Closable = true;
            this.tabs.Style = styleCard1;
            this.tabs.TabIndex = 9;
            this.tabs.Type = AntdUI.TabType.Card;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.panel_content);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.IconSvg = "HomeOutlined";
            this.tabPage.Location = new System.Drawing.Point(3, 42);
            this.tabPage.Name = "tabPage";
            this.tabPage.ReadOnly = true;
            this.tabPage.Size = new System.Drawing.Size(960, 555);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "主页";
            // 
            // panel_content
            // 
            this.panel_content.Back = System.Drawing.Color.Transparent;
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Radius = 0;
            this.panel_content.Size = new System.Drawing.Size(960, 555);
            this.panel_content.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.Collapsed = true;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.IconRatio = 1F;
            this.menu.Indent = true;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4);
            this.menu.Size = new System.Drawing.Size(58, 560);
            this.menu.TabIndex = 8;
            this.menu.Unique = true;
            // 
            // panel_left
            // 
            this.panel_left.Back = System.Drawing.Color.Transparent;
            this.panel_left.Controls.Add(this.menu);
            this.panel_left.Controls.Add(this.button_collapse);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 40);
            this.panel_left.Name = "panel_left";
            this.panel_left.Radius = 0;
            this.panel_left.Size = new System.Drawing.Size(58, 600);
            this.panel_left.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.ControlBox = false;
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.titlebar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AntdUI Demo";
            this.titlebar.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader titlebar;
        private AntdUI.Button buttonSZ;
        private AntdUI.Button button_color;
        private AntdUI.Panel panel_left;
        private AntdUI.Button button_collapse;
        private AntdUI.Menu menu;
        private AntdUI.Tabs tabs;
        private AntdUI.TabPage tabPage;
        private AntdUI.Panel panel_content;
        private AntdUI.Dropdown dropdown_translate;
        private AntdUI.Input input_search;
    }
}