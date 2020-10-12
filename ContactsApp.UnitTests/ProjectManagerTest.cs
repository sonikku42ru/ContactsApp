using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Exceptions;
using ContactsApp.Models;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Project _project;
        
        private static readonly string File = Settings.ContactsDataFile;
        
        [SetUp]
        public void Init()
        {
            Backup();
            
            _project = new Project();
            
            Contact con1 = new Contact()
            {
                LastName = "Prower",
                FirstName = "Miles",
                Birthday = new DateTime(1992,6,6),
                Email = "tails@e.tusur.ru",
                IdVk = "tails",
                PhoneNumber = 79001112233
            };
            
            Contact con2 = new Contact()
            {
                LastName = "Rebel",
                FirstName = "Jack",
                Birthday = new DateTime(1991, 1, 17),
                Email = "rebel.jack.tv@gmail.com",
                IdVk = "rebel_jack",
                PhoneNumber = 70987654321
            };

            _project.Contacts.Add(con1);
            _project.Contacts.Add(con2);
        }

        [TearDown]
        public void TearDown()
        {
            DeleteTrash();
            Restore();
        }
        
        private void DeleteTrash()
        {
            if (System.IO.File.Exists(File))
                System.IO.File.Delete(File);
        }

        private void Backup()
        {
            if (System.IO.File.Exists(File))
                System.IO.File.Move(File, File + ".bak");
        }

        private void Restore()
        {
            if (System.IO.File.Exists(File + ".bak"))
                System.IO.File.Move(File + ".bak", File);
        }
        
        [Test(Description = "Trying to load corrupted file")]
        public void ProjectManagerTest_ReadCorruptedFile()
        {
            Assert.ThrowsAsync<JsonReaderException>(async () =>
            {
                FileStream stream = System.IO.File.Open(File, FileMode.OpenOrCreate);
                var array = System.Text.Encoding.UTF8.GetBytes("TERRAIN AHEAD PULL UP");
                stream.Seek(0, SeekOrigin.End);
                await stream.WriteAsync(array, 0, array.Length);
                stream.Close();
                await ProjectManager.Current.LoadAsync();
            });
        }

        [Test(Description = "Saving and loading project")]
        public async Task ProjectManagerTest_SaveAndLoad()
        {
            await ProjectManager.Current.SaveAsync(_project);
            var actual = await ProjectManager.Current.LoadAsync();
            bool equals = actual.Equals(_project);
            Assert.IsTrue(equals, "Loaded project differs from expected");
        }

        [Test(Description = "Creating and loading empty project")]
        public async Task ProjectManagerTest_CreateBlankProject()
        {
            await ProjectManager.Current.CreateAsync();
            var actual = await ProjectManager.Current.LoadAsync();
            bool equals = actual.Equals(new Project());
            Assert.IsTrue(equals, "Created project is not blank");
        }
    }
}