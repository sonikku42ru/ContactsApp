using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using ContactsApp.Models;
using ContactsAppUI.ViewModels;

namespace ContactsAppUI.Forms
{
    public partial class ContactsForm : Form
    {
        private readonly ContactsViewModel _contactsViewModel = new ContactsViewModel();
        
        private BindingList<Contact> _contacts = new BindingList<Contact>();
        
        public ContactsForm(Project project)
        {
            InitializeComponent();
            SetUp();
            SetProject(project);
        }

        private void SetProject(Project project)
        {
            _contactsViewModel.Project = project;
            _contacts = new BindingList<Contact>(_contactsViewModel.Project.Contacts);
            listBox_Contacts.DataSource = _contacts;
            listBox_Contacts.DisplayMember = nameof(Contact.LastName);
        }

        private void SetUp()
        {
            panel_BirthdaysInfo.Visible = false;
        }
    }
}