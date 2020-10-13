using System;

namespace ContactsApp.Models
{
    /// <summary>
    /// Класс "Contact" водержит информацию о контакте
    /// </summary>
    public class Contact : ICloneable, IEquatable<Contact>
    {
        /// <summary>
        /// Минимально допустимая дата рождения
        /// </summary>
        private static readonly DateTime MinDate = new DateTime(1900, 1, 1);
        
        /// <summary>
        /// Максимальная длина текстовых полей
        /// </summary>
        private static readonly short MaxTextLength = 60;

        /// <summary>
        /// Фамилия контакта
        /// </summary>
        private string _lastName = "";
        
        /// <summary>
        /// Имя контакта
        /// </summary>
        private string _firstName = "";
        
        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private DateTime _birthday = DateTime.Today;
        
        /// <summary>
        /// E-Mail контакта
        /// </summary>
        private string _email = "";
        
        /// <summary>
        /// ID ВКонтакте контакта
        /// </summary>
        private string _idVk = "";
        
        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        private PhoneNumber _phoneNumber = new PhoneNumber();

        /// <summary>
        /// Свойство "PhoneNumber" получает и возвращает номер телефона контакта
        /// </summary>
        public long PhoneNumber
        {
            get => _phoneNumber.Number;
            set => _phoneNumber.Number = value;
        }

        /// <summary>
        /// Свойство "Birthday" получает и возвращает дату рождения контакта. Дата рождения не может быть ранее 1.1.1900
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается при попытке присвоить дату рождения ранее
        /// 1.1.1900</exception>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value < MinDate || value > DateTime.Today)
                    throw new ArgumentException("Дата рождения не должна быть ранее " 
                                                + MinDate.ToString("D") 
                                                + " или позднее сегодняшнего дня");
                _birthday = value;
            }
        }

        /// <summary>
        /// Свойство "LastName" получает и возвращает фамилию контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинной фамилии.</exception>
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("Фамилия не должна быть длиннее " 
                                                + MaxTextLength 
                                                + " символов");
                _lastName = value;
            }
        }
        
        /// <summary>
        /// Свойство "FirstName" получает и возвращает имя контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного имени.</exception>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("Имя не должно быть длиннее " 
                                                + MaxTextLength 
                                                + " символов");
                _firstName = value;
            }
        }

        /// <summary>
        /// Свойство "Email" получает и возвращает E-Mail контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного E-Mail.</exception>
        public string Email
        {
            get => _email;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("E-mail не должен быть длиннее " 
                                                + MaxTextLength
                                                + " символов");
                _email = value;
            }
        }

        /// <summary>
        /// Свойство "IdVk" получает и возвращает VK ID контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного VK ID.</exception>
        public string IdVk
        {
            get => _idVk;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("ID ВКонтакте не должен быть длиннее " 
                                                + MaxTextLength
                                                + " символов");
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

        public bool Equals(Contact other)
        {
            return _lastName.Equals(other._lastName) &&
                   _firstName.Equals(other._firstName) &&
                   _birthday.Equals(other._birthday) &&
                   _email.Equals(other._email) &&
                   _idVk.Equals(other._idVk) &&
                   _phoneNumber.Equals(other._phoneNumber);
        }

        public object Clone()
        {
            return new Contact()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Birthday = this.Birthday,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
                IdVk = this.IdVk
            };
        }
    }
}