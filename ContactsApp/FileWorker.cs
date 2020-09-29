using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Exceptions;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class FileWorker
    {
        // Путь к папке %APPDATA% текущего пользователя
        private static string AppData => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        // Путь к папке приложения ContactsApp
        private static string AppDirectory => AppData + @"\ContactsApp";
        // Путь к файлу с контактами
        private static string ContactsDataFile => AppDirectory + @"\ContactsApp.notes";
        
        /// <summary>
        /// Асинхронно читает файл с контактами и десериализует данные из него в объект Project
        /// </summary>
        /// <returns>Объект Project</returns>
        /// <exception cref="ProjectReadingException">Выбрасывается в случае ошибки чтения</exception>
        public static async Task<Project> ReadProjectAsync()
        {
            try
            {
                // Создание папки приложения в случае её отсутствия
                Directory.CreateDirectory(AppDirectory);
                // Открытие потока
                FileStream fstream = File.Open(ContactsDataFile, FileMode.OpenOrCreate);
                // Создание массива байт размером в читаемый файл
                byte[] bytes = new byte[fstream.Length];
                // Асинхронное чтение файла и запись считанных байтов в bytes
                await fstream.ReadAsync(bytes, 0, bytes.Length);
                // Закрытие потока
                fstream.Close();
                // Преобразование считанных байт в строку UTF-8
                string data = System.Text.Encoding.UTF8.GetString(bytes);
                
                // Десериализация считанных данных в объект Project
                Project project = JsonConvert.DeserializeObject<Project>(data);
                return project;
            }
            catch (JsonReaderException ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + ContactsDataFile
                                                      + "\": file corrupted.");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + ContactsDataFile
                                                      + "\": insufficient permissions.");
            }
            catch (IOException ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + ContactsDataFile
                                                      + "\": I/O error.");
            }
            catch (System.Exception ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + ContactsDataFile
                                                      + "\": undefined error has occured.");
            }
        }

        /// <summary>
        /// Асинхронно записывает объект Project в файл с контактами
        /// </summary>
        /// <param name="project">Объект Project</param>
        /// <returns></returns>
        /// <exception cref="ProjectReadingException">Выбрасывается в случае ошибки записи</exception>
        public static async Task SaveProjectAsync(Project project)
        {
            try
            {
                // Сериализация объекта Project в строку
                string data = JsonConvert.SerializeObject(project);
                // Открытие потока в резервный файл
                FileStream fstream = File.Open(ContactsDataFile + ".tmp",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite);
                // Преобразование строки UTF-8 в массив байт
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
                // Асинхронная запись в файл
                await fstream.WriteAsync(bytes, 0, bytes.Length);
                // Закрытие потока
                fstream.Close();
                // Замена старого файла контактов новым
                File.Delete(ContactsDataFile);
                File.Move(ContactsDataFile + ".tmp", ContactsDataFile);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new ProjectReadingException(ex, "Unable to write file \""
                                                      + ContactsDataFile
                                                      + "\": insufficient permissions.");
            }
            catch (IOException ex)
            {
                throw new ProjectReadingException(ex, "Unable to write file \""
                                                      + ContactsDataFile
                                                      + "\": I/O error.");
            }
            catch (System.Exception ex)
            {
                throw new ProjectReadingException(ex, "Unable to write file \""
                                                      + ContactsDataFile
                                                      + "\": undefined error has occured.");
            }
        }
    }
}