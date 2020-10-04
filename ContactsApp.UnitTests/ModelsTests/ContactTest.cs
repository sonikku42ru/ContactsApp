using System;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests.ModelsTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void Init()
        {
            _contact = new Contact();
        }

        // Testing LastName
        
        [Test(Description = "Positive LastName getter test")]
        public void TestLastNameGet_CorrectValue()
        {
            var expected = "Mustaine";
            _contact.LastName = expected;
            string actual = _contact.LastName;
            Assert.AreEqual(expected, actual, "LastName getter returned unexpected value");
        }

        [Test(Description = "Negative LastName setter test: setting too long value")]
        public void TestLastNameSet_TooLongValue()
        {
            var incorrect = "Just like a churchyard shadow creeping after me" +
                            "Its only there to terrify my mind, a black swan keeps haunting me";
            Assert.Throws<ArgumentException>(() => { _contact.LastName = incorrect; });
        }
        
        // Testing FirstName
        
        [Test(Description = "Positive FirstName getter test")]
        public void TestFirstNameGet_CorrectValue()
        {
            var expected = "Dave";
            _contact.LastName = expected;
            string actual = _contact.LastName;
            Assert.AreEqual(expected, actual, "FirstName getter returned unexpected value");
        }

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
        
        [Test(Description = "Positive Email getter test")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "duke_nukem@edf.gov";
            _contact.LastName = expected;
            string actual = _contact.LastName;
            Assert.AreEqual(expected, actual, "Email getter returned unexpected value");
        }
        
        [Test(Description = "Negative Email setter test: setting too long value")]
        public void TestEmailSet_TooLongValue()
        {
            var incorrect = "A pathetic creature of meat and bone. How can you challenge a perfect, immortal machine?";
            Assert.Throws<ArgumentException>(() => { _contact.Email = incorrect; });
        }
        
        // Testing VK ID
        
        [Test(Description = "Positive IdVk getter test")]
        public void TestIdVkGet_CorrectValue()
        {
            var expected = "iddqd";
            _contact.LastName = expected;
            string actual = _contact.LastName;
            Assert.AreEqual(expected, actual, "IdVk getter returned unexpected value");
        }
        
        [Test(Description = "Negative IdVk setter test: setting too long value")]
        public void TestIdVkSet_TooLongValue()
        {
            var incorrect = "whatta heck is you goddamn id man can i just pass this mess asap plz i rly need it";
            Assert.Throws<ArgumentException>(() => { _contact.Email = incorrect; });
        }
        
        // Testing phone number
        
        [Test(Description = "Positive PhoneNumber getter test")]
        public void TestPhoneNumberGet_CorrectValue()
        {
            var expected = 71234567890;
            _contact.PhoneNumber = expected;
            long actual = _contact.PhoneNumber;
            Assert.AreEqual(expected, actual, "PhoneNumber getter returned unexpected value");
        }
    }
}