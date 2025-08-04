using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AntdUIDemo
{
    /// <summary>
    /// InputTable泛型控件
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class InputTable<T> : UserControl where T : class
    {
        #region 控件字段
        private Table _table;
        private Form _popover;
        private T _selectedItem;
        #endregion

        #region 公共属性
        /// <summary>
        /// 数据源集合
        /// </summary>
        [Category("Data")]
        [Description("数据源集合")]
        public List<T> DataSource { get; set; } = new List<T>();

        /// <summary>
        /// 列配置集合
        /// </summary>
        [Category("Data")]
        [Description("列配置集合")]
        public ColumnCollection Columns { get; set; } = new ColumnCollection();

        /// <summary>
        /// 搜索框占位符文本
        /// </summary>
        [Category("Behavior")]
        [Description("搜索框占位符文本")]
        public string PlaceholderText
        {
            get => txtSearch.PlaceholderText;
            set => txtSearch.PlaceholderText = value;
        }

        /// <summary>
        /// 当前选中的对象
        /// </summary>
        [Browsable(false)]
        public T SelectedItem
        {
            get => _selectedItem;
            private set
            {
                if (EqualityComparer<T>.Default.Equals(_selectedItem, value)) return;
                _selectedItem = value;
                SelectedItemChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 显示文本格式化委托
        /// </summary>
        [Category("Behavior")]
        [Description("显示文本格式化委托")]
        public Func<T, string> DisplayTextFormatter { get; set; }
        #endregion

        #region 事件
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler SelectedItemChanged;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler SearchButtonClick;
        #endregion

        #region 构造函数
        public InputTable()
        {
            InitializeComponent();
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnSearch.Click += BtnSearch_Click;
            InitializeTable();
        }
        #endregion

        #region 初始化方法


        private void InitializeTable()
        {
            if (DesignMode) return;

            _table = new Table
            {
                Columns = Columns,
                Size = new Size(txtSearch.Width, 300),
                Font = new Font("Microsoft YaHei UI", 9f)

            };
            _table.CellDoubleClick += Table_CellDoubleClick;
        }
        #endregion

        #region 核心方法

        /// <summary>
        /// 更新Table数据源
        /// </summary>
        private void UpdateTableDataSource()
        {
            if (_table == null || _table.IsDisposed) return;

            var filtered = (List<T>)ApplySearchFilter(DataSource).ToList();
            _table.DataSource = filtered;
        }


        private IEnumerable<T> ApplySearchFilter(IEnumerable<T> source)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                return source;

            return source.Where(item => Columns.Any(col =>
            {
                var propValue = GetPropertyValue(item, col.Key);
                return propValue.ToString().Contains(txtSearch.Text) ;
            })
            );
        }

        private object GetPropertyValue(T item, string propertyName)
        {
            return item.GetType()
                .GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)?
                .GetValue(item);
        }
        #endregion

        #region 事件处理
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_popover == null)
            {
                if (_table == null || _table.IsDisposed) InitializeTable();

                UpdateTableDataSource();
                ShowPopover();
            }
            else
            {
                UpdateTableDataSource();
            }
        }

        /// <summary>
        /// 获取当前对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClick?.Invoke(this, e);
        }

        /// <summary>
        /// Table双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Table_CellDoubleClick(object sender, TableClickEventArgs e)
        {
            if (e.Record is T selected)
            {
                SelectedItem = selected;
                UpdateSearchText(selected);
                ClosePopover();
            }
        }

        /// <summary>
        /// 释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Popover_Disposed(object sender, EventArgs e)
        {
            _popover = null;
        }
        #endregion

        #region UI控制方法
        private void ShowPopover()
        {
            if (_table == null) return;

            // 动态获取实际宽度
            var controlWidth = txtSearch.Width > 10 ? txtSearch.Width : 200; // 设置默认最小值
            _table.Size = new Size(controlWidth, 300);
            _popover = Popover.open(new Popover.Config(txtSearch, _table)
            {
                OnControlLoad = () => BeginInvoke(new Action(() =>
                {
                    txtSearch.Focus();
                    txtSearch.SelectAll();
                }))
            });
            _popover.Disposed += Popover_Disposed;
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            // 布局变化时同步表格尺寸
            if (_table != null && !_table.IsDisposed)
            {
                _table.Width = txtSearch.Width;
            }
        }


        private void ClosePopover()
        {
            _popover?.Close();
            _popover = null;
        }

        private void UpdateSearchText(T item)
        {
            txtSearch.Text = DisplayTextFormatter?.Invoke(item) ?? item.ToString();
        }
        #endregion

        #region 资源清理


        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                _table?.Dispose();
                ClosePopover();
            }

            base.Dispose(disposing);
        }

        #endregion
    }
}
