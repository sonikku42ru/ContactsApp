using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Exceptions;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class FileWorker
    {
        public static async Task<string> ReadFileAsync(string path)
        {
            try
            {
                // Открытие потока
                FileStream fstream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, 
                    FileShare.ReadWrite, 4096, FileOptions.Asynchronous);
                // Создание массива байт размером в читаемый файл
                byte[] bytes = new byte[fstream.Length];
                // Асинхронное чтение файла и запись считанных байтов в bytes
                await fstream.ReadAsync(bytes, 0, bytes.Length);
                // Закрытие потока
                fstream.Close();
                // Преобразование считанных байт в строку UTF-8
                string data = System.Text.Encoding.UTF8.GetString(bytes);
                
                return data;
            }
            catch (JsonReaderException ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + path
                                                      + "\": file corrupted.");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + path
                                                      + "\": insufficient permissions.");
            }
            catch (IOException ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + path
                                                      + "\": I/O error.");
            }
            catch (System.Exception ex)
            {
                throw new ProjectReadingException(ex, "Unable to read file \""
                                                      + path
                                                      + "\": undefined error has occured.");
            }
        }
        
        /// <summary>
        /// Асинхронно записывает объект Project в файл с контактами
        /// </summary>
        /// <param name="project">Объект Project</param>
        /// <returns></returns>
        /// <exception cref="ProjectReadingException">Выбрасывается в случае ошибки записи</exception>
        public static async Task SaveFileAsync(string data, string path)
        {
            try
            {
                // Открытие потока в резервный файл
                FileStream fstream = File.Open(path + ".tmp",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite);
                // Преобразование строки UTF-8 в массив байт
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
                // Асинхронная запись в файл
                await fstream.WriteAsync(bytes, 0, bytes.Length);
                // Закрытие потока
                fstream.Close();
                // Замена старого файла контактов новым
                File.Delete(path);
                File.Move(path + ".tmp", path);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new ProjectReadingException(ex, "Unable to write file \""
                                                      + path
                                                      + "\": insufficient permissions.");
            }
            catch (IOException ex)
            {
                throw new ProjectReadingException(ex, "Unable to write file \""
                                                      + path
                                                      + "\": I/O error.");
            }
            catch (System.Exception ex)
            {
                throw new ProjectReadingException(ex, "Unable to write file \""
                                                      + path
                                                      + "\": undefined error has occured.");
            }
        }

        /// <summary>
        /// Создаёт директорию по указанному пути
        /// </summary>
        /// <param name="path">Путь до создаваемой директории</param>
        /// <returns></returns>
        public static void CreateFolder(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (IOException ex)
            {
                throw new ProjectReadingException(ex, "Unable to create folder \"" + path +
                                                      "\": I/O error.");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new ProjectReadingException(ex, "Unable to create folder \"" + path +
                                                      "\": insufficient permissions.");
            }
            catch (System.Exception ex)
            {
                throw new ProjectReadingException(ex, "Unable to create folder \"" + path +
                                                      "\": undefined error has occured");
            }
        }
    }
}