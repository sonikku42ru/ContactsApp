using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ContactsApp.Models;
using ContactsAppUI.Converters;

namespace ContactsAppUI.Forms
{
    public partial class EditForm : Form
    {
        private Dictionary<Control, Control> _controlsDictionary;

        public Contact Contact { get; private set; }

        public EditForm(Contact contact)
        {
            InitializeComponent();
            Contact = contact;
            SetControlsDictionary();
            SetValues();
        }

        private void SetValues()
        {
            textBox_LastName.Text = Contact.LastName;
            textBox_FirstName.Text = Contact.FirstName;
            dateTimePicker_Birthday.Value = Contact.Birthday;
            maskedTextBox_Phone.Text = PhoneConverter.Mask(Contact.PhoneNumber);
            textBox_Email.Text = Contact.Email;
            textBox_IdVk.Text = Contact.IdVk;
        }

        private void SetControlsDictionary()
        {
            _controlsDictionary = new Dictionary<Control, Control>()
            {
                {textBox_LastName, label_LastName},
                {textBox_FirstName, label_FirstName},
                {dateTimePicker_Birthday, label_Birthday},
                {maskedTextBox_Phone, label_Phone},
                {textBox_Email, label_Email},
                {textBox_IdVk, label_IdVk}
            };
        }

        private void CloseDialog(DialogResult result)
        {
            DialogResult = result;
            this.Close();
        }
        
        #region UI Events
        
        private void button_Ok_Click(object sender, EventArgs e)
        {
            CloseDialog(DialogResult.OK);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            CloseDialog(DialogResult.Cancel);
        }
        
        #endregion
    }
}