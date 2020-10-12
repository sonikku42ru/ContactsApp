using System.Text.RegularExpressions;

namespace ContactsAppUI.Converters
{
    /// <summary>
    /// Конвертер номера телефона для UI и обратно
    /// </summary>
    public static class PhoneConverter
    {
        /// <summary>
        /// Преобразует номер телефона из числа в строку с маской
        /// </summary>
        /// <param name="phone">Номер етефона в числовом виде</param>
        /// <returns>Строка с маской</returns>
        public static string Mask(long phone)
        {
            return phone == 0 ? "+7 (___) ___-____" : phone.ToString("+0 (000) 000-0000");
        }

        /// <summary>
        /// Преобразует номер телефона из строки с маской в число
        /// </summary>
        /// <param name="phone">Строка с маской</param>
        /// <returns>Число</returns>
        public static long Unmask(string phone)
        {
            Regex reg = new Regex(@"\D");
            string unmasked = reg.Replace(phone, "");
            return long.Parse(unmasked);
        }
    }
}