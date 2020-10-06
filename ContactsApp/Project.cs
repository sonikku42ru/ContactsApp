using System;
using System.Collections.Generic;
using System.Linq;
using ContactsApp.Models;

namespace ContactsApp
{
    public class Project
    {
        public List<Contact> Contacts { get; } = new List<Contact>();

        public List<Contact> GetSorted() => Contacts.OrderBy(i => i.LastName).ToList();

        public List<Contact> FindSorted(string query) => Contacts
            .Where(i => i.LastName.Contains(query))
            .OrderBy(j => j.LastName)
            .ToList();

        public List<Contact> GetBirthdays(DateTime date) => Contacts
            .Where(i => i.Birthday.Day == date.Day && i.Birthday.Month == date.Month)
            .OrderBy(j => j.LastName)
            .ToList();

        public bool Equals(Project other)
        {
            return Contacts.Equals(other.Contacts);
        }
    }
}