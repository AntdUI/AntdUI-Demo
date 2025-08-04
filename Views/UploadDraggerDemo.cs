using System;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class UploadDraggerDemo : UserControl
    {
        private AntdUI.Window window;
        public UploadDraggerDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            //1.7.14开始,uploadDragger自带点击打开文件选择框
            uploadDragger.DragChanged += UploadDragger_DragChanged;
            uploadDragger.Multiselect = true;//允许多选文件
            uploadDragger.Filter = "All Files (*.*)|*.*";//文件筛选
            uploadDragger.HandDragFolder = true;//是否支持拖拽，默认为true
        }

        private void UploadDragger_DragChanged(object sender, AntdUI.StringsEventArgs e)
        {
            string[] filePaths = e.Value;
            foreach (string path in filePaths)
            {
                AntdUI.Message.info(window, path, autoClose: 3);
            }
        }
    }
}
