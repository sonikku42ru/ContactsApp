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
        /// <summary>
        /// Словарь соответствий контролов для отображения ErrorProvider на Label'ах, соответствующих
        /// элементам, на которых произошла ошибка
        /// </summary>
        private Dictionary<Control, Control> _controlsDictionary;

        public Contact Contact { get; private set; }

        public EditForm(Contact contact)
        {
            // Инициализация формы
            InitializeComponent();
            // Привязка контакта
            Contact = contact;
            // Привязка элементов управления к свойствам объекта Contact
            BindControls();
            // Установление соответствий между Label'ами и элементами управления
            SetControlsDictionary();
            // Установка значений
            SetValues();
            // Проверка полей на валидность
            CheckFields();
        }

        /// <summary>
        /// Привязка полей формы к свойствам объекта Contact, а также подписывание событий
        /// </summary>
        private void BindControls()
        {
            // Фамилия
            textBox_LastName.DataBindings
                .Add(nameof(textBox_LastName.Text), Contact, nameof(Contact.LastName), 
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_LastName.DataBindings[0].BindingComplete += OnBindingComplete;
            
            // Имя
            textBox_FirstName.DataBindings
                .Add(nameof(textBox_FirstName.Text), Contact, nameof(Contact.FirstName), 
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_FirstName.DataBindings[0].BindingComplete += OnBindingComplete;
            
            // Телефон
            maskedTextBox_Phone.DataBindings
                .Add(nameof(maskedTextBox_Phone.Text), Contact, nameof(Contact.PhoneNumber),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            maskedTextBox_Phone.DataBindings[0].Format += OnPhoneFormat;
            maskedTextBox_Phone.DataBindings[0].Parse += OnPhoneParse;
            maskedTextBox_Phone.DataBindings[0].BindingComplete += OnBindingComplete;
            
            // Дата рождения
            dateTimePicker_Birthday.DataBindings
                .Add(nameof(dateTimePicker_Birthday.Value), Contact, nameof(Contact.Birthday),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker_Birthday.DataBindings[0].BindingComplete += OnBindingComplete;

            // E-Mail
            textBox_Email.DataBindings
                .Add(nameof(textBox_Email.Text), Contact, nameof(Contact.Email),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_Email.DataBindings[0].BindingComplete += OnBindingComplete;

            // ID ВКонтакте
            textBox_IdVk.DataBindings
                .Add(nameof(textBox_IdVk.Text), Contact, nameof(Contact.IdVk),
                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_IdVk.DataBindings[0].BindingComplete += OnBindingComplete;
        }
        
        /// <summary>
        /// Первичная установка значений
        /// </summary>
        private void SetValues()
        {
            textBox_LastName.Text = Contact.LastName;
            textBox_FirstName.Text = Contact.FirstName;
            dateTimePicker_Birthday.Value = Contact.Birthday;
            maskedTextBox_Phone.Text = PhoneConverter.Mask(Contact.PhoneNumber);
            textBox_Email.Text = Contact.Email;
            textBox_IdVk.Text = Contact.IdVk;
        }

        /// <summary>
        /// Установка соответствий между Label'ами и полями формы
        /// </summary>
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
        
        /// <summary>
        /// Получение Label'а, соответствующего полю формы
        /// </summary>
        /// <param name="control">Поле формы</param>
        /// <returns>Label</returns>
        private Control GetLabel(Control control)
        {
            return _controlsDictionary[control];
        }

        /// <summary>
        /// Закрытие диалогового окна с известным результатом
        /// </summary>
        /// <param name="result">Результат</param>
        private void CloseDialog(DialogResult result)
        {
            DialogResult = result;
            this.Close();
        }

        #region Private methods to handle errors

        /// <summary>
        /// Установка ошибки в контрол через ErrorProvider
        /// </summary>
        /// <param name="control">Поле формы</param>
        /// <param name="message">Сообщение об ошибке</param>
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
            CheckFields();
        }

        /// <summary>
        /// Проверка полей на содержание в них ошибок
        /// </summary>
        private void CheckFields()
        {
            button_Ok.Enabled = !(FieldsAreEmpty() || EnteredInvalidValues());
        }
        
        /// <summary>
        /// Проверка полей на пустоту
        /// </summary>
        /// <returns></returns>
        private bool FieldsAreEmpty()
        {
            bool i = (string.IsNullOrEmpty(textBox_LastName.Text) ||
                    string.IsNullOrEmpty(textBox_FirstName.Text) ||
                    !PhoneNumber.IsValid(PhoneConverter.Unmask(maskedTextBox_Phone.Text)));
            return i;
        }

        /// <summary>
        /// Проверка полей на наличие неправильных значений
        /// </summary>
        /// <returns></returns>
        private bool EnteredInvalidValues()
        {
            bool j = _controlsDictionary
                .Select(i => i.Value)
                .Any(k => !string.IsNullOrEmpty(errorProvider.GetError(k)));
            return j;
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

        /// <summary>
        /// Обработчик события завершения привязки. Используется для валидации данных, введённых в поле формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.Exception != null)
            {
                SetError(((Binding)sender).Control, e.Exception.Message);
            }
            else
                RemoveError(((Binding)sender).Control);
        }

        /// <summary>
        /// Обработчик события форматирования телефона. Используется для преобразования телефона в long на этапе
        /// присвоения значения свойству объекта Contact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPhoneFormat(object sender, ConvertEventArgs e)
        {
            e.Value = PhoneConverter.Mask((long)e.Value);
        }

        /// <summary>
        /// Обработчик события парсинга телефона. Используется для преобразования телефона в string на этапе
        /// присвоения свойства объекта Contact полю формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPhoneParse(object sender, ConvertEventArgs e)
        {
            e.Value = PhoneConverter.Unmask((string) e.Value);
        }
        
        #endregion
    }
}