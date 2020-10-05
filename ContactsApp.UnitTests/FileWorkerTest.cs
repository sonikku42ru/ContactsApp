using System;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class FileWorkerTest
    {
        private string _testString;

        private static readonly string Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                                               + @"\UnitTest";

        private static readonly string File = Folder + @"\TestFile";

        [SetUp]
        public void Init()
        {
            _testString = "Sticks and stones...";
            FileWorker.CreateFolder(Folder);
        }

        [TearDown]
        public void DeleteTrash()
        {
            if (Directory.Exists(Folder))
                Directory.Delete(Folder, true);
        }

        [Test(Description = "Writing file test")]
        public async Task FileWorkerTest_WriteProject()
        {
            string expected = _testString;
            await FileWorker.SaveFileAsync(expected, File);
            string actual = await FileWorker.ReadFileAsync(File);
            Assert.AreEqual(expected, actual, "Written data differs with expected.");
        }
    }
}