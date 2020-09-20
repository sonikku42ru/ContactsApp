using System;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests.ModelsTests
{
    [TestFixture]
    public class PhoneNumberTest
    {
        private PhoneNumber _phoneNumber;

        [SetUp]
        public void Init()
        {
            _phoneNumber = new PhoneNumber();
        }

        [Test(Description = "Positive Number getter test")]
        public void TestNumberGet_CorrectValue()
        {
            long expected = 79998881234;
            _phoneNumber.Number = expected;
            Assert.AreEqual(expected,_phoneNumber.Number, "Number getter returned unexpected value");
        }

        [TestCase("9091240912049240",
            "An attempt to assign too long value should result in an exception.",
            TestName = "Negative Number setter test: trying to set too long number")]
        [TestCase("12345",
            "An attempt to assign too short value should result in an exception.",
            TestName = "Negative Number setter test: trying to set too short number")]
        [TestCase("-9000",
            "An attempt to assign negative value should result in an exception.",
            TestName = "Negative Number setter test: trying to set negative number")]
        public void TestNumberSet_IncorrectNumber(string incorrect, string message)
        {
            long wrong = long.Parse(incorrect);
            Assert.Throws<ArgumentException>(() => { _phoneNumber.Number = wrong; });
        }
    }
}