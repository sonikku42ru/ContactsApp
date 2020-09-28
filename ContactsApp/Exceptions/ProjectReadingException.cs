namespace ContactsApp.Exceptions
{
    public class ProjectReadingException : System.Exception
    {
        public string Path { get; }

        public ProjectReadingException(System.Exception ex, string path) : base(ex.Message)
        {
            Path = path;
        }
    }
}