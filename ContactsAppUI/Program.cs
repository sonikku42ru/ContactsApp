using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using ContactsAppUI.Forms;

namespace ContactsAppUI
{
    static class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        [MTAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await Launcher.Current.StartApplication();
        }
    }
}