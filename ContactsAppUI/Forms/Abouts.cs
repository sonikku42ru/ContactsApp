using System.Windows.Forms;

namespace ContactsAppUI.Forms
{
    internal static class Abouts
    {
        /// <summary>
        /// HTTPS-префикс
        /// </summary>
        internal static string Https => "https://";
        /// <summary>
        /// Mailto-префикс
        /// </summary>
        internal static string MailTo => "mailto:";
        
        /// <summary>
        /// Текущая версия приложения
        /// </summary>
        internal static string Version => Application.ProductVersion;
        /// <summary>
        /// Автор приложения
        /// </summary>
        internal static string Author => "Кушнарёв Артём";
        /// <summary>
        /// Репозиторий приложения
        /// </summary>
        internal static string GitHub => Https + "github.com/sonikku42ru/ContactsApp"; 
        /// <summary>
        /// E-Mail автора
        /// </summary>
        internal static string Email => "sonikku@e.tusur.ru";
    }
}