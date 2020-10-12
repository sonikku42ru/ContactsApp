using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Асинхронно загружает проект из файла
        /// </summary>
        /// <returns>Проект</returns>
        public async Task<Project> LoadAsync()
        {
            // Создание папки приложения в случае её отсутствия
            FileWorker.CreateFolder(Settings.AppDirectory);
            if (!File.Exists(Settings.ContactsDataFile))
                await CreateAsync();
            // Асинхронное чтение файла
            string data = await FileWorker.ReadFileAsync(Settings.ContactsDataFile);
            // Десериализация полученных данных
            Project project = JsonConvert.DeserializeObject<Project>(data);
            return project;
        }

        /// <summary>
        /// Асинхронно записывает проект в файл
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        public async Task SaveAsync(Project project)
        {
            // Создание папки приложения в случае её отсутствия
            FileWorker.CreateFolder(Settings.AppDirectory);
            // Сериализация данных
            string data = JsonConvert.SerializeObject(project);
            // Асинхронная запись
            await FileWorker.SaveFileAsync(data, Settings.ContactsDataFile);
        }

        /// <summary>
        /// Создание нового файла проекта
        /// </summary>
        /// <returns></returns>
        public async Task CreateAsync()
        {
            await SaveAsync(new Project());
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