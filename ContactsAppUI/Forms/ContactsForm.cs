using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using ContactsApp.Models;
using ContactsAppUI.ViewModels;

namespace ContactsAppUI.Forms
{
    public partial class ContactsForm : Form
    {
        private readonly ContactsViewModel _contactsViewModel;
        
        private BindingList<Contact> _contacts;
        private Contact _selectedContact;
        
        public ContactsForm(ContactsViewModel viewModel)
        {
            InitializeComponent();
            _contactsViewModel = viewModel;
            SetData();
            SetVisuals();
        }

        #region Private methods to process data
        
        private void SetData()
        {
            _contacts = new BindingList<Contact>(_contactsViewModel.GetSortedContacts());
            listBox_Contacts.DataSource = _contacts;
            listBox_Contacts.DisplayMember = nameof(Contact.LastName);
        }
        
        private void SelectContact(int index)
        {
            if (index == -1 || index > _contacts.Count - 1)
            {
                index = -1;
                SwitchDetails(false);
            }
            else
            {
                _selectedContact = _contacts[index];
                SwitchDetails(true);
            }
        }
        
        #endregion
        
        #region Private methods to update UI

        private void SetVisuals()
        {
            SetBirthdays();
        }

        private void SetBirthdays()
        {
            // Поиск и отображение именинников
            List<string> birthdays = _contactsViewModel
                .GetBirthdays(DateTime.Today)
                .Select(i => i.LastName)
                .ToList();
            if (birthdays.Count > 0)
            {
                for (int i = 0; i < birthdays.Count - 1; i++)
                    label_BirthdaysInfo.Text += ' ' + birthdays[i] + ',';
                label_BirthdaysInfo.Text += ' ' + birthdays[birthdays.Count - 1] + '.';
                panel_BirthdaysInfo.Visible = true;
            }
        }

        private void SwitchDetails(bool show)
        {
            textBox_LastName.Text = show ? _selectedContact.LastName : "";
            textBox_FirstName.Text = show ? _selectedContact.FirstName : "";
            textBox_Birthday.Text = show ? _selectedContact.Birthday.ToString(CultureInfo.CurrentUICulture) : "";
            textBox_Phone.Text = show ? _selectedContact.PhoneNumber.ToString() : "";
            textBox_Email.Text = show ? _selectedContact.Email : "";
            textBox_IdVk.Text = show ? _selectedContact.IdVk : "";
        }
        
        #endregion
        
        #region UI Events
        
        private void listBox_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectContact(listBox_Contacts.SelectedIndex);
        }
        
        #endregion
    }
}