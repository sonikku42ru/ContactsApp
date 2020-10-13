using System;

namespace ContactsAppUI.Events
{
    /// <summary>
    /// Событие изменения списка контактов.
    /// </summary>
    public class ContactsListChangedEvent
    {
        public delegate void ContactsListChangedHandler(object sender, ContactsListChangedEventArgs e);

        /// <summary>
        /// Класс аргументов события изменения списка
        /// </summary>
        public class ContactsListChangedEventArgs : EventArgs
        {
            /// <summary>
            /// Индекс изменившегося элемента
            /// </summary>
            public int Index { get; }
            
            public ContactsListChangedEventArgs(int index)
            {
                Index = index;
            }
        }
    }
}