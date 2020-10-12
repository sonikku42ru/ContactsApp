using System;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Юнит-тесты FileWorker
    /// </summary>
    [TestFixture]
    public class FileWorkerTest
    {
        // Тестовая строка
        private string _testString;

        // Папка для тестовых файлов
        private static readonly string Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                                               + @"\UnitTest";

        // Путь до тестового файла
        private static readonly string File = Folder + @"\TestFile";

        [SetUp]
        public void Init()
        {
            // Инициализация тестовой строки
            _testString = "Sticks and stones...";
            // Создание тестовой папки
            FileWorker.CreateFolder(Folder);
        }

        [TearDown]
        public void DeleteTrash()
        {
            // Если тестовая папка существует, удалить её
            if (Directory.Exists(Folder))
                Directory.Delete(Folder, true);
        }

        /// <summary>
        /// Тест корректности записи файла
        /// </summary>
        /// <returns></returns>
        [Test(Description = "Writing file test")]
        public async Task FileWorkerTest_WriteProject()
        {
            string expected = _testString;
            await FileWorker.SaveFileAsync(expected, File);
            string actual = await FileWorker.ReadFileAsync(File);
            Assert.AreEqual(expected, actual, "Written data differs with expected.");
        }

        /// <summary>
        /// Тест создания папки
        /// </summary>
        [Test(Description = "Creating folder test")]
        public void FileWorkerTest_CreateFolder()
        {
            FileWorker.CreateFolder(Folder);
            Assert.IsTrue(Directory.Exists(Folder));
        }
    }
}