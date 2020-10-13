using System.Diagnostics;
using System.Windows.Forms;

namespace ContactsAppUI.Forms
{
    /// <summary>
    /// Класс формы "О программе"
    /// </summary>
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            // Инициализация формы
            InitializeComponent();
            // Установка информации
            SetInfo();
        }

        /// <summary>
        /// Установка информации о программе
        /// </summary>
        private void SetInfo()
        {
            label_VersionValue.Text = Abouts.Version;
            label_AuthorValue.Text = Abouts.Author;
            linkLabel_EmailValue.Text = Abouts.Email;
            linkLabel_GitHubValue.Text = Abouts.GitHub;
        }

        /// <summary>
        /// Обработчик события нажатия на E-Mail. Запускает почтовый клиент.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_EmailValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Abouts.MailTo + Abouts.Email);
        }

        /// <summary>
        /// Обработчик события нажатия на ID ВКонтакте. Открывает страницу автора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_GitHubValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Abouts.GitHub);
        }
    }
}