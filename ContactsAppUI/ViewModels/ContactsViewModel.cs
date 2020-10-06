using System.Threading.Tasks;
using ContactsApp;

namespace ContactsAppUI.ViewModels
{
    public class ContactsViewModel
    {
        public Project Project { get; private set; }

        public async Task LoadProject()
        {
            await ProjectManager.Current.Load();
            Project = ProjectManager.Current.Project;
        }
    }
}