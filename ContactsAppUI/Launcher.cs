using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using ContactsAppUI.Forms;

namespace ContactsAppUI
{
    public class Launcher
    {
        public async Task StartApplication()
        {
            await ProjectManager.Current.Load();
            ContactsForm contactsForm = new ContactsForm(ProjectManager.Current.Project);
            Application.Run(contactsForm);
        }
        
        #region Signleton
        private static readonly Lazy<Launcher> Singleton = new Lazy<Launcher>();

        public static Launcher Current => Singleton.Value;
        #endregion
    }
}