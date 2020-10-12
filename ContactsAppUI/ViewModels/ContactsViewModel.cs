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
            _project = await ProjectManager.Current.LoadAsync();
        }
        
        public async Task SaveProject(Project project)
        {
            _project = project;
            await ProjectManager.Current.SaveAsync(_project);
        }

        public List<Contact> GetSortedContacts() => _project.GetSorted();

        public List<Contact> GetBirthdays(DateTime date) => _project.GetBirthdays(date);

        public List<Contact> Find(string lastName) => _project.FindSorted(lastName);

        public void AddContact(Contact contact)
        {
            _project.Contacts.Add(contact);
            int index = _project.Contacts.IndexOf(contact);
            OnContactsListChanged?.Invoke(this, 
                new ContactsListChangedEventArgs(index));
            Task.Run(async() => await SaveProject(_project));
        }

        public void RemoveContact(Contact contact)
        {
            int index = _project.Contacts.IndexOf(contact);
            _project.Contacts.Remove(contact);
            OnContactsListChanged?.Invoke(this, new ContactsListChangedEventArgs(index));
            Task.Run(async() => await SaveProject(_project));
        } 
        
        public void UpdateContact(Contact oldContact, Contact newContact)
        {
            int index = _project.Contacts.IndexOf(oldContact);
            _project.Contacts[index] = newContact;
            OnContactsListChanged?.Invoke(this, new ContactsListChangedEventArgs(index));
            Task.Run(async() => await SaveProject(_project));
        }

        #region Nested events
        
        public delegate void ContactsListChangedHandler(object sender, ContactsListChangedEventArgs e);

        public event ContactsListChangedHandler OnContactsListChanged;

        public class ContactsListChangedEventArgs : EventArgs
        {
            public int Index { get; }
            
            public ContactsListChangedEventArgs(int index)
            {
                Index = index;
            }
        }
        
        #endregion
    }
}