using System.Windows.Forms;
using ContactsApp.Models;

namespace ContactsAppUI.Forms
{
    public partial class EditForm : Form
    {
        public Contact Contact { get; private set; }
        
        public EditForm(Contact contact)
        {
            InitializeComponent();
            Contact = contact;
        }
        
        
    }
}