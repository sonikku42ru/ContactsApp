using System;
using System.Collections.Generic;
using System.Linq;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;
        
        [SetUp]
        public void Init()
        {
            _project = new Project();
            
            Contact con1 = new Contact()
            {
                LastName = "Prower",
                FirstName = "Miles",
                Birthday = new DateTime(1992,6,6),
                Email = "tails@e.tusur.ru",
                IdVk = "tails",
                PhoneNumber = 79001112233
            };
            
            Contact con2 = new Contact()
            {
                LastName = "Rebel",
                FirstName = "Jack",
                Birthday = new DateTime(1991, 1, 17),
                Email = "rebel.jack.tv@gmail.com",
                IdVk = "rebel_jack",
                PhoneNumber = 70987654321
            };

            _project.Contacts.Add(con1);
            _project.Contacts.Add(con2);
        }

        [Test(Description = "Positive contacts sorting test")]
        public void ProjectTest_GetCorrectSortedList()
        {
            var expected = _project.Contacts.OrderBy(i => i.LastName).ToList();
            var actual = _project.GetSorted();
            Assert.AreEqual(expected, actual, "Contacts list sorted wrong");
        }

        [Test(Description = "Negative contacts sorting test")]
        public void ProjectTest_GetIncorrectSortedList()
        {
            var expected = _project.Contacts.OrderBy(i => i.LastName).Reverse().ToList();
            var actual = _project.GetSorted();
            Assert.AreNotEqual(expected, actual, "Contacts list sorted wrong");
        }

        [Test(Description = "Positive contacts searching test")]
        public void ProjectTest_GetFoundContactsList()
        {
            var query = "Re";
            List<Contact> expected = _project.Contacts
                .Where(i => i.LastName.StartsWith(query))
                .OrderBy(i => i.LastName)
                .ToList();
            Assert.AreEqual(expected, _project.FindSorted(query), "Found different sequences");
        }

        [Test(Description = "Searching for non-exist values test")]
        public void ProjectTest_FindNothingTest()
        {
            var expected = new List<Contact>();
            List<Contact> actual = _project.FindSorted("ыыыыыыыыыыыыыыыыыыыы");
            Assert.AreEqual(expected, actual, "Found values that shouldn't be found");
        }

        [Test(Description = "Positive birthdays selection test")]
        public void ProjectTest_GetBirthdaysList()
        {
            var date = new DateTime(1992, 6, 6);
            List<Contact> expected = _project.Contacts
                .Where(i => i.Birthday.Day == date.Day && i.Birthday.Month == date.Month)
                .OrderBy(i => i.LastName)
                .ToList();
            Assert.AreEqual(expected, _project.GetBirthdays(date), "Birthdays sequences are different");
        }

        [Test(Description = "Searching for non-exist birthdays test")]
        public void ProjectTest_LookForNoBirthdays()
        {
            var date = new DateTime(1999, 4,4);
            var expected = new List<Contact>();
            Assert.AreEqual(expected, _project.GetBirthdays(date));
        }
    }
}