using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ContactsApp.Models;

namespace ContactsApp
{
    /// <summary>
    /// Класс с основными данными проекта
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список контактов
        /// </summary>
        public List<Contact> Contacts { get; } = new List<Contact>();

        /// <summary>
        /// Сортировка контактов в алфавитном порядке
        /// </summary>
        /// <returns>Возвращает отсортированный по фамилиям в алфавитном порядке список контактов</returns>
        public List<Contact> GetSorted() => Contacts.OrderBy(i => i.LastName).ToList();

        /// <summary>
        /// Поиск контактов по фамилии
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Возвращает отсортированный по фамилиям в алфавитном порядке список контактов, чья фамилия
        /// начинается с заданной строки</returns>
        public List<Contact> FindSorted(string query) => Contacts
            .Where(i => i.LastName.StartsWith(query))
            .OrderBy(j => j.LastName)
            .ToList();

        /// <summary>
        /// Поиск именинников
        /// </summary>
        /// <param name="date">Дата рождения</param>
        /// <returns>Возвращает список контактов, у которых в указанную дату день рождения</returns>
        public List<Contact> GetBirthdays(DateTime date) => Contacts
            .Where(i => i.Birthday.Day == date.Day && i.Birthday.Month == date.Month)
            .OrderBy(j => j.LastName)
            .ToList();

        public bool Equals(Project other)
        {
            return Contacts.SequenceEqual(other.Contacts);
        }
    }
}