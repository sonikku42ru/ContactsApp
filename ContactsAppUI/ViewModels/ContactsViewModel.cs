using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContactsApp;
using ContactsApp.Models;
using ContactsAppUI.Events;

namespace ContactsAppUI.ViewModels
{
    /// <summary>
    /// ViewModel для основной формы
    /// </summary>
    public class ContactsViewModel
    {
        /// <summary>
        /// Сущность проекта
        /// </summary>
        private Project _project;

        /// <summary>
        /// Асинхронно загружает проект
        /// </summary>
        /// <returns></returns>
        public async Task LoadProjectAsync()
        {
            _project = await ProjectManager.Current.LoadAsync();
        }
        
        /// <summary>
        /// Асинхронно сохраняет проект
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        public async Task SaveProjectAsync(Project project)
        {
            _project = project;
            await ProjectManager.Current.SaveAsync(_project);
        }

        /// <summary>
        /// Возвращает отсортированный по фамилиям в алфавитном порядке список контактов
        /// </summary>
        /// <returns>Список контактов</returns>
        public List<Contact> GetSortedContacts() => _project.GetSorted();

        /// <summary>
        /// Возвращает отсортированный по фамилиям список именинников
        /// </summary>
        /// <param name="date">Дата рождения</param>
        /// <returns>Список именинников</returns>
        public List<Contact> GetBirthdays(DateTime date) => _project.GetBirthdays(date);

        /// <summary>
        /// Возвращает список контактов, начинающихся с заданной подстроки
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <returns>Список контактов</returns>
        public List<Contact> Find(string lastName) => _project.FindSorted(lastName);

        /// <summary>
        /// Добавляет контакт в список контактов
        /// </summary>
        /// <param name="contact">Контакт</param>
        public void AddContact(Contact contact)
        {
            _project.Contacts.Add(contact);
            int index = _project.Contacts.IndexOf(contact);
            OnContactsListChanged?.Invoke(this, 
                new ContactsListChangedEvent.ContactsListChangedEventArgs(index));
            Task.Run(async() => await SaveProjectAsync(_project));
        }

        /// <summary>
        /// Удаляет контакт из списка контактов
        /// </summary>
        /// <param name="contact">Контакт</param>
        public void RemoveContact(Contact contact)
        {
            int index = _project.Contacts.IndexOf(contact);
            _project.Contacts.Remove(contact);
            OnContactsListChanged?.Invoke(this, new ContactsListChangedEvent.ContactsListChangedEventArgs(index));
            Task.Run(async() => await SaveProjectAsync(_project));
        } 
        
        /// <summary>
        /// Обновляет контакт в списке контактов
        /// </summary>
        /// <param name="oldContact">Обновляемый контакт</param>
        /// <param name="newContact">Новый контакт</param>
        public void UpdateContact(Contact oldContact, Contact newContact)
        {
            int index = _project.Contacts.IndexOf(oldContact);
            _project.Contacts[index] = newContact;
            OnContactsListChanged?.Invoke(this, new ContactsListChangedEvent.ContactsListChangedEventArgs(index));
            Task.Run(async() => await SaveProjectAsync(_project));
        }

        #region Nested events
        
        /// <summary>
        /// Событие, вызываемое при каждом изменении списка
        /// </summary>
        public event ContactsListChangedEvent.ContactsListChangedHandler OnContactsListChanged;
        
        #endregion
    }
}