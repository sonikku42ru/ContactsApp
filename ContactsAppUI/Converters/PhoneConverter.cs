using System.Text.RegularExpressions;

namespace ContactsAppUI.Converters
{
    public static class PhoneConverter
    {
        public static string Mask(long phone)
        {
            return phone == 0 ? "+7 (___) ___-____" : phone.ToString("+0 (000) 000-0000");
        }

        public static long Unmask(string phone)
        {
            Regex reg = new Regex(@"\D");
            string unmasked = reg.Replace(phone, "");
            return long.Parse(unmasked);
        }
    }
}