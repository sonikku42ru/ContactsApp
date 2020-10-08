using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            BindControls();
            SetControlsDictionary();
            SetValues();
        }

        private void BindControls()
        {
            textBox_LastName.DataBindings
                .Add(nameof(textBox_LastName.Text), Contact, nameof(Contact.LastName), 
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_LastName.DataBindings[0].BindingComplete += OnBindingComplete;
            
            textBox_FirstName.DataBindings
                .Add(nameof(textBox_FirstName.Text), Contact, nameof(Contact.FirstName), 
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_FirstName.DataBindings[0].BindingComplete += OnBindingComplete;
            
            maskedTextBox_Phone.DataBindings
                .Add(nameof(maskedTextBox_Phone.Text), Contact, nameof(Contact.PhoneNumber),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            maskedTextBox_Phone.DataBindings[0].Format += OnPhoneFormat;
            maskedTextBox_Phone.DataBindings[0].Parse += OnPhoneParse;
            maskedTextBox_Phone.DataBindings[0].BindingComplete += OnBindingComplete;
            
            dateTimePicker_Birthday.DataBindings
                .Add(nameof(dateTimePicker_Birthday.Value), Contact, nameof(Contact.Birthday),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker_Birthday.DataBindings[0].BindingComplete += OnBindingComplete;

            textBox_Email.DataBindings
                .Add(nameof(textBox_Email.Text), Contact, nameof(Contact.Email),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_Email.DataBindings[0].BindingComplete += OnBindingComplete;

            textBox_IdVk.DataBindings
                .Add(nameof(textBox_IdVk.Text), Contact, nameof(Contact.IdVk),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_IdVk.DataBindings[0].BindingComplete += OnBindingComplete;
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
        
        private Control GetLabel(Control control)
        {
            return _controlsDictionary[control];
        }

        private void CloseDialog(DialogResult result)
        {
            DialogResult = result;
            this.Close();
        }

        #region Private methods to handle errors

        private void SetError(Control control, string message)
        {
            Console.WriteLine(message);
            errorProvider.SetError(GetLabel(control), message);
            control.ForeColor = Color.Red;
            button_Ok.Enabled = false;
        }

        private void RemoveError(Control control)
        {
            errorProvider.SetError(GetLabel(control), "");
            control.ResetForeColor();
        }
        
        #endregion
        
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
        
        #region Data changed events handlers

        private void OnBindingComplete(object sender, BindingCompleteEventArgs e)
        {
            Console.WriteLine(e.ErrorText);
            if (e.Exception != null)
            {
                SetError(((Binding)sender).Control, e.Exception.Message);
            }
            else
                RemoveError(((Binding)sender).Control);
        }

        private void OnPhoneFormat(object sender, ConvertEventArgs e)
        {
            e.Value = PhoneConverter.Mask((long)e.Value);
        }

        private void OnPhoneParse(object sender, ConvertEventArgs e)
        {
            e.Value = PhoneConverter.Unmask((string) e.Value);
        }
        
        #endregion
    }
}