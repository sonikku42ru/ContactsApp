using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс со статическими константами
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Путь к папке %APPDATA%
        /// </summary>
        public static string AppData => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        
        /// <summary>
        /// Путь к папке приложения
        /// </summary>
        public static string AppDirectory => AppData + @"\ContactsApp";
        
        
        /// <summary>
        /// Путь к файлу проекта
        /// </summary>
        public static string ContactsDataFile => AppDirectory + @"\ContactsApp.notes";
    }
}