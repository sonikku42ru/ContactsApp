using System.Collections.Generic;
using System.Linq;
using ContactsApp.Models;

namespace ContactsApp
{
    public class Project
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public List<Contact> GetSorted() => Contacts.OrderBy(i => i.LastName).ToList();

        public List<Contact> FindSorted(string query) => Contacts
            .Where(i => i.LastName.Contains(query))
            .OrderBy(j => j.LastName)
            .ToList();

        public bool Equals(Project other)
        {
            return Contacts.Equals(other.Contacts);
        }
    }
}