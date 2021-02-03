using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210203
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        const string exeRelLocation = @"bin\Debug\net5.0-windows";
        public static string appData;

        [STAThread]
        static void Main()
        {
            appData = Application.StartupPath
                .Replace(exeRelLocation, "AppData");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
