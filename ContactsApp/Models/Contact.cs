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

        public PhoneNumber PhoneNumber { get; set; } = new PhoneNumber();

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

        private static bool TextIsCorrect(string text)
        {
            return text != null && text.Length <= MaxTextLength;
        }
    }
}