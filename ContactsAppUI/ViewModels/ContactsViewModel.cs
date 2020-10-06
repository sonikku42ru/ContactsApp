using System.Threading.Tasks;
using ContactsApp;

namespace ContactsAppUI.ViewModels
{
    public class ContactsViewModel
    {
        public Project Project { get; private set; }

        public async Task LoadProject()
        {
            Project = await ProjectManager.Current.Load();
        }

        public async Task SaveProject(Project project)
        {
            Project = project;
            await ProjectManager.Current.Save(Project);
        }
    }
}