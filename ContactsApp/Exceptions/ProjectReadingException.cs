namespace ContactsApp.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое в случае ошибки при работе с файлом проекта
    /// </summary>
    public class ProjectReadingException : System.Exception
    {
        /// <summary>
        /// Путь до файла
        /// </summary>
        public string Path { get; }

        public ProjectReadingException(System.Exception ex, string path) : base(ex.Message)
        {
            Path = path;
        }
    }
}