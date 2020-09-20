using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Exception;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class FileWorker
    {
        private static string AppData => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string AppDirectory => AppData + @"\ContactsApp";
        private static string ContactsDataFile => AppDirectory + @"\ContactsApp.notes";
        
        public static async Task<Project> ReadProjectAsync()
        {
            try
            {
                Directory.CreateDirectory(AppDirectory);

                FileStream fstream = File.Open(ContactsDataFile, FileMode.OpenOrCreate);
                byte[] bytes = new byte[fstream.Length];
                await fstream.ReadAsync(bytes, 0, bytes.Length);
                string data = System.Text.Encoding.UTF8.GetString(bytes);
                fstream.Close();

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

        public static async Task SaveProjectAsync(Project project)
        {
            try
            {
                string data = JsonConvert.SerializeObject(project);
                FileStream fstream = File.Open(ContactsDataFile + ".tmp",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite);
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
                await fstream.WriteAsync(bytes, 0, bytes.Length);
                fstream.Close();
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