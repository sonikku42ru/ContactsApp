using System;

namespace ContactsApp.Models
{
    /// <summary>
    /// Класс "PhoneNumber" содержит в себе информацию о номере телефона
    /// </summary>
    public class PhoneNumber
    {
        private long _phoneNumber = 0;
        private const int MaxDigits = 11;

        public long Number
        {
            get => _phoneNumber;
            set
            {
                if (Digits(value) < MaxDigits)
                    throw new ArgumentException("Insufficient digits in phone number");
                _phoneNumber = value;
            }
        }

        private static int Digits(long phone)
        {
            if (phone == 0)
                return 1;
            return (int) Math.Ceiling(Math.Log10(Math.Abs(phone) + 0.5));
        }
    }
}