using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Exceptions;
using ContactsAppUI.Forms;
using ContactsAppUI.ViewModels;

namespace ContactsAppUI
{
    public class Launcher
    {
        /// <summary>
        /// Загрузка контактов и основной формы
        /// </summary>
        /// <returns></returns>
        public async Task StartApplication()
        {
            try
            {
                var contactsViewModel = new ContactsViewModel();
                await contactsViewModel.LoadProject();
                var contactsForm = new ContactsForm(contactsViewModel);
                Application.Run(contactsForm);
            }
            catch (ProjectReadingException ex)
            {
                var messageBox = MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        #region Signleton
        private static readonly Lazy<Launcher> Singleton = new Lazy<Launcher>();

        public static Launcher Current => Singleton.Value;
        #endregion
    }
}