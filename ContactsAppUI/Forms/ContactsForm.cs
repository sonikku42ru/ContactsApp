using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        public ContactsForm(ContactsViewModel viewModel)
        {
            InitializeComponent();
            _contactsViewModel = viewModel;
            SetData();
            SetVisuals();
        }

        private void SetData()
        {
            _contacts = new BindingList<Contact>(_contactsViewModel.GetSortedContacts());
            listBox_Contacts.DataSource = _contacts;
            listBox_Contacts.DisplayMember = nameof(Contact.LastName);
        }

        private void SetVisuals()
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
    }
}