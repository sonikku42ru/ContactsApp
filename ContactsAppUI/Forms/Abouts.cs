using System.Windows.Forms;

namespace ContactsAppUI.Forms
{
    internal static class Abouts
    {
        internal static string Https => "https://";
        internal static string MailTo => "mailto:";
        
        internal static string Version => Application.ProductVersion;
        internal static string Author => "Кушнарёв Артём";
        internal static string GitHub => Https + "github.com/sonikku42ru/ContactsApp";
        internal static string Email => "sonikku@e.tusur.ru";
    }
}