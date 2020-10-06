using System.Diagnostics;
using System.Windows.Forms;

namespace ContactsAppUI.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            SetInfo();
        }

        private void SetInfo()
        {
            label_VersionValue.Text = Abouts.Version;
            label_AuthorValue.Text = Abouts.Author;
            linkLabel_EmailValue.Text = Abouts.Email;
            linkLabel_GitHubValue.Text = Abouts.GitHub;
        }

        private void linkLabel_EmailValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Abouts.MailTo + Abouts.Email);
        }

        private void linkLabel_GitHubValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Abouts.GitHub);
        }
    }
}