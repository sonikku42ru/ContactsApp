using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Models;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class FileWorkerTest
    {
        private string _testString;

        private static readonly string _folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                                               + @"\UnitTest";

        private static readonly string _file = _folder + @"\TestFile";

        [SetUp]
        public void Init()
        {
            _testString = "Sticks and stones...";
            FileWorker.CreateFolder(_folder);
        }

        [TearDown]
        public void DeleteTrash()
        {
            if (Directory.Exists(_folder))
                Directory.Delete(_folder, true);
        }

        [Test(Description = "Writing file test")]
        public async Task FileWorkerTest_WriteProject()
        {
            string expected = _testString;
            await FileWorker.SaveFileAsync(expected, _file);
            string actual = await FileWorker.ReadFileAsync(_file);
            Assert.AreEqual(expected, actual, "Written data differs with expected.");
        }
    }
}