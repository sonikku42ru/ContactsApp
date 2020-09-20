using System;
using System.Xml.Schema;

namespace ContactsApp.Models
{
    /// <summary>
    /// Класс "Contact" водержит информацию о контакте
    /// </summary>
    public class Contact
    {
        private static readonly DateTime MinDate = new DateTime(1900, 1, 1);
        private static readonly short MaxTextLength = 60;

        private string _lastName = "";
        private string _firstName = "";
        private DateTime _birthday = DateTime.Today;
        private string _email = "";
        private string _idVk = "";

        /// <summary>
        /// Свойство "PhoneNumber" хранит в себе номер телефона контакта
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; } = new PhoneNumber();

        /// <summary>
        /// Свойство "Birthday" хранит в себе дату рождения контакта. Дата рождения не может быть ранее 1.1.1900
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается при попытке присвоить дату рождения ранее
        /// 1.1.1900</exception>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value <= MinDate && value >= DateTime.Today)
                    throw new ArgumentException("Birthday date shouldn't be less " +
                                                "than 1.1.1900 or more than today");
                _birthday = value;
            }
        }

        /// <summary>
        /// Свойство "LastName" хранит в себе фамилию контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинной фамилии.</exception>
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("Last name shouldn't be null or longer than " 
                                                + MaxTextLength 
                                                + " characters.");
                _lastName = value;
            }
        }
        
        /// <summary>
        /// Свойство "FirstName" хранит в себе имя контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного имени.</exception>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("First name shouldn't be null or longer than " 
                                                + MaxTextLength 
                                                + " characters.");
                _firstName = value;
            }
        }

        /// <summary>
        /// Свойство "Email" хранит в себе E-Mail контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного E-Mail.</exception>
        public string Email
        {
            get => _email;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("E-mail shouldn't be null or longer than " 
                                                + MaxTextLength
                                                + " characters.");
                _email = value;
            }
        }

        /// <summary>
        /// Свойство "IdVk" хранит в себе VK ID контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного VK ID.</exception>
        public string IdVk
        {
            get => _idVk;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("VK ID shouldn't be null or longer than " 
                                                + MaxTextLength
                                                + " characters.");
                _idVk = value;
            }
        }

        /// <summary>
        /// Проверяет корректность текстового значения: оно не должно быть null или длиннее максимально допустимой длины
        /// </summary>
        /// <param name="text">Текстовое значение</param>
        /// <returns>TRUE, если значение корректно, иначе FALSE.</returns>
        private static bool TextIsCorrect(string text)
        {
            return text != null && text.Length <= MaxTextLength;
        }
    }
}