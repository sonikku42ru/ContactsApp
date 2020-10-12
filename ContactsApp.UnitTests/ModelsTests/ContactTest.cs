using System;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests.ModelsTests
{
    /// <summary>
    /// Юнит-тесты Contact
    /// </summary>
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void Init()
        {
            // Инициализация
            _contact = new Contact();
        }

        // Testing LastName
        
        /// <summary>
        /// Позитивный тест геттера LastName
        /// </summary>
        [Test(Description = "Positive LastName getter test")]
        public void TestLastNameGet_CorrectValue()
        {
            var expected = "Mustaine";
            _contact.LastName = expected;
            string actual = _contact.LastName;
            Assert.AreEqual(expected, actual, "LastName getter returned unexpected value");
        }

        /// <summary>
        /// Негативный тест сеттера LastName: присвоение слишком длинной фамилии
        /// </summary>
        [Test(Description = "Negative LastName setter test: setting too long value")]
        public void TestLastNameSet_TooLongValue()
        {
            var incorrect = "Just like a churchyard shadow creeping after me" +
                            "Its only there to terrify my mind, a black swan keeps haunting me";
            Assert.Throws<ArgumentException>(() => { _contact.LastName = incorrect; });
        }
        
        // Testing FirstName
        
        /// <summary>
        /// Позитивный тест геттера FirstName
        /// </summary>
        [Test(Description = "Positive FirstName getter test")]
        public void TestFirstNameGet_CorrectValue()
        {
            var expected = "Dave";
            _contact.FirstName = expected;
            string actual = _contact.FirstName;
            Assert.AreEqual(expected, actual, "FirstName getter returned unexpected value");
        }

        /// <summary>
        /// Негативный тест сеттера FirstName: присвоение слишком длинного имени
        /// </summary>
        [Test(Description = "Negative FirstName setter test: setting too long value")]
        public void TestFirstNameSet_TooLongValue()
        {
            var incorrect = "Computer banks to rule the world,"
                            + "Instruments to sight the stars."
                            + "Possibly I've seen too much,"
                            + "Hangar 18, I know too much.";
            Assert.Throws<ArgumentException>(() => { _contact.FirstName = incorrect; });
        }
        
        // Testing E-Mail
        
        /// <summary>
        /// Позитивный тест геттера Email
        /// </summary>
        [Test(Description = "Positive Email getter test")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "duke_nukem@edf.gov";
            _contact.Email = expected;
            string actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Email getter returned unexpected value");
        }
        
        /// <summary>
        /// Негативный тест сеттера Email: присвоение слишком длинного E-Mail
        /// </summary>
        [Test(Description = "Negative Email setter test: setting too long value")]
        public void TestEmailSet_TooLongValue()
        {
            var incorrect = "A pathetic creature of meat and bone. How can you challenge a perfect, immortal machine?";
            Assert.Throws<ArgumentException>(() => { _contact.Email = incorrect; });
        }
        
        // Testing VK ID
        
        /// <summary>
        /// Позитивный тест геттера IdVk
        /// </summary>
        [Test(Description = "Positive IdVk getter test")]
        public void TestIdVkGet_CorrectValue()
        {
            var expected = "iddqd";
            _contact.IdVk = expected;
            string actual = _contact.IdVk;
            Assert.AreEqual(expected, actual, "IdVk getter returned unexpected value");
        }
        
        /// <summary>
        /// Негативный тест сеттера IdVk: присвоение слишком длинного ID
        /// </summary>
        [Test(Description = "Negative IdVk setter test: setting too long value")]
        public void TestIdVkSet_TooLongValue()
        {
            var incorrect = "whatta heck is you goddamn id man can i just pass this mess asap plz i rly need it";
            Assert.Throws<ArgumentException>(() => { _contact.IdVk = incorrect; });
        }
        
        // Testing phone number

        /// <summary>
        /// Позитивный тест геттера PhoneNumber
        /// </summary>
        [Test(Description = "Positive PhoneNumber getter test")]
        public void TestPhoneNumberGet_CorrectValue()
        {
            var expected = 71234567890;
            _contact.PhoneNumber = expected;
            long actual = _contact.PhoneNumber;
            Assert.AreEqual(expected, actual, "PhoneNumber getter returned unexpected value");
        }
        
        // Testing Birthday
        
        /// <summary>
        /// Позитивный тест геттера Birthday
        /// </summary>
        [Test(Description = "Positive Birthday getter test")]
        public void TestBirthdayGet_CorrectValue()
        {
            var expected = new DateTime(1999,6,16);
            _contact.Birthday = expected;
            DateTime actual = _contact.Birthday;
            Assert.AreEqual(expected, actual, "Birthday getter returned unexpected value");
        }

        /// <summary>
        /// Негативный тест сеттера Birthday: присвоение некорректных дат
        /// </summary>
        /// <param name="incorrect">Некорректная дата</param>
        /// <param name="message">Сообщение об ошибке</param>
        [TestCase("1.1.3000",
            "An attempt to set the birthday date too late.",
            TestName = "Negative Birthday setter test: setting the date too late")]
        [TestCase("1.1.1899",
            "An attempt to assign too short value should result in an exception.",
            TestName = "Negative Birthday setter test: setting the date too late")]
        [Test(Description = "Negative Birthday setter test: setting incorrect dates")]
        public void TestBirthdaySet_TooLate(string incorrect, string message)
        {
            var date = DateTime.Parse(incorrect);
            Assert.Throws<ArgumentException>(() => _contact.Birthday = date);
        }
    }
}