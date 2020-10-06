using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContactsApp;
using ContactsApp.Models;

namespace ContactsAppUI.ViewModels
{
    public class ContactsViewModel
    {
        private Project _project;

        public async Task LoadProject()
        {
            _project = await ProjectManager.Current.Load();
        }

        public List<Contact> GetSortedContacts() => _project.GetSorted();

        public List<Contact> GetBirthdays(DateTime date) => _project.GetBirthdays(date);

        public List<Contact> Find(string lastName) => _project.FindSorted(lastName);

        public void AddContact(Contact contact) => _project.Contacts.Add(contact);

        public void RemoveContact(Contact contact) => _project.Contacts.Remove(contact);
        
        public void UpdateContact(Contact oldContact, Contact newContact)
        {
            int index = _project.Contacts.IndexOf(oldContact);
            _project.Contacts[index] = newContact;
        }

        public async Task SaveProject(Project project)
        {
            _project = project;
            await ProjectManager.Current.Save(_project);
        }
    }
}