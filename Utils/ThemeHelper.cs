using Microsoft.Win32;

namespace AntdUIDemo.Utils
{
    public class ThemeHelper
    {
        /// <summary>
        /// 判断是否浅色
        /// </summary>
        /// <returns></returns>
        public static bool IsLightMode()
        {
            var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            if (key != null)
            {
                int appsUseLightTheme = (int)key.GetValue("AppsUseLightTheme", -1);
                return appsUseLightTheme == 1;
            }
            return true;
        }
    }
}
