using System;

namespace ContactsApp.Models
{
    /// <summary>
    /// Класс "PhoneNumber" содержит в себе информацию о номере телефона
    /// </summary>
    public class PhoneNumber
    {
        private long _phoneNumber = 70000000000;
        private const int Length = 11;

        /// <summary>
        /// Свойство "Number" хранит в себе номер телефона в виде числа типа long
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения некорректного значения: 
        /// слишком короткого или слишком длинного.</exception>
        public long Number
        {
            get => _phoneNumber;
            set
            {
                // Если количество цифр в номере не равно 11, то выбрасывается исключение
                if (Digits(value) != Length)
                    throw new ArgumentException("Номер должен состоять из " + Length.ToString() + " цифр");
                // Если номер отрицательный, то выбрасывается исключение
                if (value < 0)
                    throw new ArgumentException("Номер должен быть положительным числом");
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Метод "Digits" возвращает количество цифр в целом положительном числе.
        /// </summary>
        /// <param name="phone">Число, для которого требуется вычислить количество цифр.</param>
        /// <returns>Количество цифр в числе.</returns>
        private static int Digits(long phone)
        {
            if (phone == 0)
                return 1;
            // Логарифмический способ
            return (int)Math.Ceiling(Math.Log10(Math.Abs(phone) + 0.5));
        }

        public static bool IsValid(long phone)
        {
            return Digits(phone) == Length;
        }

        public bool Equals(PhoneNumber other)
        {
            return Number == other.Number;
        }
    }
}