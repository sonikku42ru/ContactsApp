using System;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests.ModelsTests
{
    /// <summary>
    /// Юнит-тесты PhoneNumber
    /// </summary>
    [TestFixture]
    public class PhoneNumberTest
    {
        private PhoneNumber _phoneNumber;

        [SetUp]
        public void Init()
        {
            // Инициализация
            _phoneNumber = new PhoneNumber();
        }

        /// <summary>
        /// Позитивный тест геттера Number
        /// </summary>
        [Test(Description = "Positive Number getter test")]
        public void TestNumberGet_CorrectValue()
        {
            long expected = 79998881234;
            _phoneNumber.Number = expected;
            Assert.AreEqual(expected,_phoneNumber.Number, "Number getter returned unexpected value");
        }

        /// <summary>
        /// Негативный тест сеттера Number: присвоение некорректных значений
        /// </summary>
        /// <param name="incorrect">Некорректный номер телефона</param>
        /// <param name="message">Сообщение об ошибке</param>
        [TestCase("9091240912049240",
            "An attempt to assign too long value should result in an exception.",
            TestName = "Negative Number setter test: trying to set too long number")]
        [TestCase("12345",
            "An attempt to assign too short value should result in an exception.",
            TestName = "Negative Number setter test: trying to set too short number")]
        [TestCase("-9000",
            "An attempt to assign negative value should result in an exception.",
            TestName = "Negative Number setter test: trying to set negative number")]
        [TestCase("0",
            "An attempt to assign zero should result in an exception.",
            TestName = "Negative Number setter test: trying to set zero")]
        public void TestNumberSet_IncorrectNumber(string incorrect, string message)
        {
            long wrong = long.Parse(incorrect);
            Assert.Throws<ArgumentException>(() => { _phoneNumber.Number = wrong; });
        }

        /// <summary>
        /// Тест на корректность работы валидации номера: некорректные случаи
        /// </summary>
        /// <param name="value">Некорректный номер телефона</param>
        /// <param name="message">Сообщение об ошибке</param>
        [TestCase("111",
            "An attempt to check too short number should return false",
            TestName = "Number validation test: too short value")]
        [TestCase("12345678901234",
            "An attempt to check too long number should return false",
            TestName = "Number validation test: too long value")]
        public void TestValidation_IncorrectNumbers(string value, string message)
        {
            long val = long.Parse(value);
            Assert.IsFalse(PhoneNumber.IsValid(val));
        }
        
        /// <summary>
        /// Тест на корректность работы валидации номера: корректный случай
        /// </summary>
        [Test(Description = "Number validation test: correct value")]
        public void TestValidation_CorrectNumber()
        {
            long val = 79008007000;
            Assert.IsTrue(PhoneNumber.IsValid(val));
        } 
    }
}