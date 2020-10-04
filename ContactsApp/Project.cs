using System.Collections.Generic;
using System.Linq;
using ContactsApp.Models;

namespace ContactsApp
{
    public class Project
    {
        public List<Contact> Contacts = new List<Contact>();

        public bool Equals(Project other)
        {
            return Contacts.Equals(other.Contacts);
        }
    }
}