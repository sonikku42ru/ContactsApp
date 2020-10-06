using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class ProjectManager
    {
        public async Task<Project> Load()
        {
            // Создание папки приложения в случае её отсутствия
            FileWorker.CreateFolder(Settings.AppDirectory);
            if (!File.Exists(Settings.ContactsDataFile))
                await Create();
            // Асинхронное чтение файла
            string data = await FileWorker.ReadFileAsync(Settings.ContactsDataFile);
            // Десериализация полученных данных
            Project project = JsonConvert.DeserializeObject<Project>(data);
            return project;
        }

        public async Task Save(Project project)
        {
            // Создание папки приложения в случае её отсутствия
            FileWorker.CreateFolder(Settings.AppDirectory);
            // Сериализация данных
            string data = JsonConvert.SerializeObject(project);
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