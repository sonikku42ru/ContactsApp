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
        private string _query = "";
        
        public ContactsForm(ContactsViewModel viewModel)
        {
            InitializeComponent();
            _contactsViewModel = viewModel;
            BindViewModelEvents();
            SetData();
            SetVisuals();
        }

        #region Private methods to process data

        /// <summary>
        /// Реакция формы на изменение списка контактов во вьюмодели
        /// </summary>
        private void BindViewModelEvents()
        {
            _contactsViewModel.OnContactsListChanged += (sender, args) => UpdateData();
        }
        
        /// <summary>
        /// Первичная привязка списка контактов к контролу ListBox
        /// </summary>
        private void SetData()
        {
            UpdateData();
            // Отображение фамилии контакта в списке контактов
            listBox_Contacts.DisplayMember = nameof(Contact.LastName);
        }

        /// <summary>
        /// Обновление списка контактов в контроле ListBox
        /// </summary>
        private void UpdateData()
        {
            // Поиск контактов по введённой строке
            _contacts = new BindingList<Contact>(_contactsViewModel.Find(_query));
            // Повторная привязка DataSource
            listBox_Contacts.DataSource = _contacts;
            if (listBox_Contacts.Items.Count == 0)
                SelectContact(-1);
        }
        
        /// <summary>
        /// Установка выбранного контакта
        /// </summary>
        /// <param name="index">Индекс выбранного контакта в ListBox</param>
        private void SelectContact(int index)
        {
            // Если выбрано пустое место или индекс превышает фактическое количество контактов
            if (index == -1 || index > _contacts.Count - 1)
            {
                index = -1;
                // Стирание детальных данных
                SwitchDetails(false);
                SwitchEditButtons(false);
            }
            else
            {
                _selectedContact = _contacts[index];
                // Запись и отображение детальных данных
                SwitchDetails(true);
                SwitchEditButtons(true);
            }
        }
        
        /// <summary>
        /// Добавление контакта
        /// </summary>
        private void AddContact()
        {
            (Contact, DialogResult) dialogResult = ShowEditDialog();
            if (DialogResult == DialogResult.OK)
                _contactsViewModel.AddContact(dialogResult.Item1);
        }

        /// <summary>
        /// Редактирование выбранного контакта
        /// </summary>
        private void EditContact()
        {
            (Contact, DialogResult) dialogResult = ShowEditDialog(_selectedContact.Clone());
            if (dialogResult.Item2 == DialogResult.OK)
                _contactsViewModel.UpdateContact(_selectedContact,dialogResult.Item1);
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

        private void SwitchEditButtons(bool enabled)
        {
            button_EditContact.Enabled = enabled;
            button_RemoveContact.Enabled = enabled;
            toolStripMenuItem_EditContact.Enabled = enabled;
            toolStripMenuItem_RemoveContact.Enabled = enabled;
        }
        
        #endregion
        
        #region Private methods for other actions

        /// <summary>
        /// Отображение окна "О программе"
        /// </summary>
        private void ShowAbout()
        {
            // Блокировка формы
            Enabled = false;
            var aboutForm = new AboutForm();
            // Форма будет отключена до тех пор, пока отображается форма "О программе"
            using (aboutForm)
                aboutForm.ShowDialog();
            // Включение формы
            Enabled = true;
        }

        /// <summary>
        /// Отображение формы редактирования контакта
        /// </summary>
        /// <param name="contact">Редактируемый контакт. Передать null, если нужно создать новый.</param>
        /// <returns>Кортеж из Contact и DialogResult</returns>
        private (Contact, DialogResult) ShowEditDialog(Contact contact = null)
        {
            Enabled = false;
            var editForm = new EditForm(contact ?? new Contact());
            (Contact, DialogResult) result = (contact, DialogResult.Cancel);
            using (editForm)
            {
                editForm.ShowDialog();
                result = (editForm.Contact, editForm.DialogResult);
            }
            Enabled = true;
            return result;
        }
        
        #endregion
        
        #region UI Events
        
        /// <summary>
        /// Обработчик события изменения индекса выбранного контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectContact(listBox_Contacts.SelectedIndex);
        }
        
        // Основные кнопки
        
        /// <summary>
        /// Обработчик события нажатия на кнопку "Добавить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddContact_Click(object sender, EventArgs e)
        {
            AddContact();
        }
        
        /// <summary>
        /// Обработчик события
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_EditContact_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Удалить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_RemoveContact_Click(object sender, EventArgs e)
        {
            int index = listBox_Contacts.SelectedIndex;
            _contactsViewModel.RemoveContact(_selectedContact);
            if (index < listBox_Contacts.Items.Count)
                listBox_Contacts.SelectedIndex = index;
        }

        /// <summary>
        /// Обработчик события изменения поисковой строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            _query = textBox_Search.Text;
            UpdateData();
        }
        
        /// <summary>
        /// Обработчик события нажатия на кнопку "О программе" в главном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }
        
        #endregion
    }
}