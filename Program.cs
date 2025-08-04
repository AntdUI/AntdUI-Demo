using System;
using System.Windows.Forms;

namespace AntdUIDemo
{
    internal static class Program
    {
        private static MainWindow mainWindow;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            AntdUI.Localization.DefaultLanguage = "zh-CN";
            //若文字不清晰，切换其他渲染方式
            AntdUI.Config.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            AntdUI.Config.TextRenderingHighQuality = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }

        // 捕获UI线程中的未处理异常
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            AntdUI.Notification.error(mainWindow, "未处理的UI线程异常", e.Exception.Message, autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }

        // 捕获非UI线程中的未处理异常
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            AntdUI.Notification.error(mainWindow, "未处理的非UI线程异常", e.ToString(), autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }
    }
}
