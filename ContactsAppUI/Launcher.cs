using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsAppUI.Forms;
using ContactsAppUI.ViewModels;

namespace ContactsAppUI
{
    public class Launcher
    {
        public async Task StartApplication()
        {
            var contactsViewModel = new ContactsViewModel();
            await contactsViewModel.LoadProject();
            var contactsForm = new ContactsForm(contactsViewModel);
            Application.Run(contactsForm);
        }

        #region Signleton
        private static readonly Lazy<Launcher> Singleton = new Lazy<Launcher>();

        public static Launcher Current => Singleton.Value;
        #endregion
    }
}