using System;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class ProjectManager
    {
        public Project Project { get; private set; }

        public async Task Load()
        {
            // Создание папки приложения в случае её отсутствия
            FileWorker.CreateFolder(Settings.AppDirectory);
            // Асинхронное чтение файла
            string data = await FileWorker.ReadFileAsync(Settings.ContactsDataFile);
            // Десериализация полученных данных
            Project = JsonConvert.DeserializeObject<Project>(data);
        }

        public async Task Save(Project project)
        {
            // Обновление данных
            Project = project;
            // Создание папки приложения в случае её отсутствия
            FileWorker.CreateFolder(Settings.AppDirectory);
            // Сериализация данных
            string data = JsonConvert.SerializeObject(Project);
            // Асинхронная запись
            await FileWorker.SaveFileAsync(data, Settings.ContactsDataFile);
        }

        public async Task Create()
        {
            await Save(new Project());
        }

        #region Singleton
        
        private static readonly Lazy<ProjectManager> Singleton = 
            new Lazy<ProjectManager>(() => new ProjectManager());

        private ProjectManager()
        {
        }

        public static ProjectManager Current => Singleton.Value;

        #endregion
    }
}