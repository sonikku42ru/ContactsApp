using System.Windows.Forms;

namespace ContactsAppUI.Forms
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void SetUp()
        {
            panel_BirthdaysInfo.Visible = false;
        }
    }
}