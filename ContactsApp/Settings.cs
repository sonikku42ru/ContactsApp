using System;

namespace ContactsApp
{
    public static class Settings
    {
        // Путь к папке %APPDATA% текущего пользователя
        public static string AppData => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        // Путь к папке приложения ContactsApp
        public static string AppDirectory => AppData + @"\ContactsApp";
        // Путь к файлу с контактами
        public static string ContactsDataFile => AppDirectory + @"\ContactsApp.notes";
    }
}