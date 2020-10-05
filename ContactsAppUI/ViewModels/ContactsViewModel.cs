using System.Threading.Tasks;
using ContactsApp;

namespace ContactsAppUI.ViewModels
{
    public class ContactsViewModel
    {
        private Project _project;

        public Project Project
        {
            get => _project;
            set => _project = value;
        }

        public async Task LoadProject()
        {
            await ProjectManager.Current.Load();
            _project = ProjectManager.Current.Project;
        }
    }
}