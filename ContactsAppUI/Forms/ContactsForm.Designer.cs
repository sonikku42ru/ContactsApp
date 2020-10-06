using System.ComponentModel;

namespace ContactsAppUI.Forms
{
    partial class ContactsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Left = new System.Windows.Forms.TableLayoutPanel();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel_ContactsList = new System.Windows.Forms.Panel();
            this.listBox_Contacts = new System.Windows.Forms.ListBox();
            this.panel_EditButtons = new System.Windows.Forms.Panel();
            this.button_RemoveContact = new System.Windows.Forms.Button();
            this.button_EditContact = new System.Windows.Forms.Button();
            this.button_AddContact = new System.Windows.Forms.Button();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_BirthdaysInfo = new System.Windows.Forms.Panel();
            this.label_BirthdaysInfo = new System.Windows.Forms.Label();
            this.pictureBox_BirthdaysInfo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_ContactInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label_IdVk = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Birthday = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_IdVk = new System.Windows.Forms.TextBox();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_EditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_RemoveContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel_Left.SuspendLayout();
            this.panel_ContactsList.SuspendLayout();
            this.panel_EditButtons.SuspendLayout();
            this.panel_Right.SuspendLayout();
            this.panel_BirthdaysInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_BirthdaysInfo)).BeginInit();
            this.tableLayoutPanel_ContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItem_File, this.toolStripMenuItem_Edit, this.toolStripMenuItem_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(681, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItem_Exit});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem_File.Text = "Файл";
            // 
            // toolStripMenuItem_Edit
            // 
            this.toolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripMenuItem_AddContact, this.toolStripMenuItem_EditContact,
                this.toolStripMenuItem_RemoveContact
            });
            this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItem_Edit.Text = "Редактирование";
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItem_About});
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem_Help.Text = "Помощь";
            // 
            // tableLayoutPanel_Left
            // 
            this.tableLayoutPanel_Left.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel_Left.ColumnCount = 2;
            this.tableLayoutPanel_Left.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel_Left.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Left.Controls.Add(this.label_Search, 0, 0);
            this.tableLayoutPanel_Left.Controls.Add(this.textBox_Search, 1, 0);
            this.tableLayoutPanel_Left.Controls.Add(this.panel_ContactsList, 0, 1);
            this.tableLayoutPanel_Left.Controls.Add(this.panel_EditButtons, 0, 2);
            this.tableLayoutPanel_Left.Location = new System.Drawing.Point(14, 31);
            this.tableLayoutPanel_Left.MinimumSize = new System.Drawing.Size(233, 462);
            this.tableLayoutPanel_Left.Name = "tableLayoutPanel_Left";
            this.tableLayoutPanel_Left.RowCount = 3;
            this.tableLayoutPanel_Left.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel_Left.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Left.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel_Left.Size = new System.Drawing.Size(233, 462);
            this.tableLayoutPanel_Left.TabIndex = 1;
            // 
            // label_Search
            // 
            this.label_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Search.Location = new System.Drawing.Point(0, 2);
            this.label_Search.Margin = new System.Windows.Forms.Padding(0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(58, 23);
            this.label_Search.TabIndex = 0;
            this.label_Search.Text = "Поиск:";
            this.label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Location = new System.Drawing.Point(61, 3);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(169, 23);
            this.textBox_Search.TabIndex = 1;
            // 
            // panel_ContactsList
            // 
            this.panel_ContactsList.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Left.SetColumnSpan(this.panel_ContactsList, 2);
            this.panel_ContactsList.Controls.Add(this.listBox_Contacts);
            this.panel_ContactsList.Location = new System.Drawing.Point(0, 28);
            this.panel_ContactsList.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ContactsList.Name = "panel_ContactsList";
            this.panel_ContactsList.Size = new System.Drawing.Size(233, 392);
            this.panel_ContactsList.TabIndex = 2;
            // 
            // listBox_Contacts
            // 
            this.listBox_Contacts.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Contacts.FormattingEnabled = true;
            this.listBox_Contacts.ItemHeight = 15;
            this.listBox_Contacts.Location = new System.Drawing.Point(3, 3);
            this.listBox_Contacts.Name = "listBox_Contacts";
            this.listBox_Contacts.Size = new System.Drawing.Size(226, 379);
            this.listBox_Contacts.TabIndex = 0;
            // 
            // panel_EditButtons
            // 
            this.panel_EditButtons.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Left.SetColumnSpan(this.panel_EditButtons, 2);
            this.panel_EditButtons.Controls.Add(this.button_RemoveContact);
            this.panel_EditButtons.Controls.Add(this.button_EditContact);
            this.panel_EditButtons.Controls.Add(this.button_AddContact);
            this.panel_EditButtons.Location = new System.Drawing.Point(0, 420);
            this.panel_EditButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panel_EditButtons.Name = "panel_EditButtons";
            this.panel_EditButtons.Size = new System.Drawing.Size(233, 42);
            this.panel_EditButtons.TabIndex = 3;
            // 
            // button_RemoveContact
            // 
            this.button_RemoveContact.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.button_RemoveContact.BackgroundImage = global::ContactsAppUI.Assets.ImageAssets.Delete;
            this.button_RemoveContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_RemoveContact.Location = new System.Drawing.Point(86, 2);
            this.button_RemoveContact.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveContact.Name = "button_RemoveContact";
            this.button_RemoveContact.Size = new System.Drawing.Size(37, 37);
            this.button_RemoveContact.TabIndex = 2;
            this.button_RemoveContact.UseVisualStyleBackColor = true;
            // 
            // button_EditContact
            // 
            this.button_EditContact.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.button_EditContact.BackgroundImage = global::ContactsAppUI.Assets.ImageAssets.Edit;
            this.button_EditContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_EditContact.Location = new System.Drawing.Point(44, 2);
            this.button_EditContact.Margin = new System.Windows.Forms.Padding(2);
            this.button_EditContact.Name = "button_EditContact";
            this.button_EditContact.Size = new System.Drawing.Size(37, 37);
            this.button_EditContact.TabIndex = 1;
            this.button_EditContact.UseVisualStyleBackColor = true;
            // 
            // button_AddContact
            // 
            this.button_AddContact.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddContact.BackgroundImage = global::ContactsAppUI.Assets.ImageAssets.Add;
            this.button_AddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddContact.Location = new System.Drawing.Point(2, 2);
            this.button_AddContact.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddContact.Name = "button_AddContact";
            this.button_AddContact.Size = new System.Drawing.Size(37, 37);
            this.button_AddContact.TabIndex = 0;
            this.button_AddContact.UseVisualStyleBackColor = true;
            // 
            // panel_Right
            // 
            this.panel_Right.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Right.Controls.Add(this.panel_BirthdaysInfo);
            this.panel_Right.Controls.Add(this.tableLayoutPanel_ContactInfo);
            this.panel_Right.Location = new System.Drawing.Point(251, 31);
            this.panel_Right.MinimumSize = new System.Drawing.Size(416, 462);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(416, 462);
            this.panel_Right.TabIndex = 2;
            // 
            // panel_BirthdaysInfo
            // 
            this.panel_BirthdaysInfo.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.panel_BirthdaysInfo.Controls.Add(this.label_BirthdaysInfo);
            this.panel_BirthdaysInfo.Controls.Add(this.pictureBox_BirthdaysInfo);
            this.panel_BirthdaysInfo.Location = new System.Drawing.Point(3, 376);
            this.panel_BirthdaysInfo.Name = "panel_BirthdaysInfo";
            this.panel_BirthdaysInfo.Size = new System.Drawing.Size(409, 81);
            this.panel_BirthdaysInfo.TabIndex = 1;
            this.panel_BirthdaysInfo.Visible = false;
            // 
            // label_BirthdaysInfo
            // 
            this.label_BirthdaysInfo.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label_BirthdaysInfo.Location = new System.Drawing.Point(85, 3);
            this.label_BirthdaysInfo.Name = "label_BirthdaysInfo";
            this.label_BirthdaysInfo.Size = new System.Drawing.Size(321, 74);
            this.label_BirthdaysInfo.TabIndex = 1;
            this.label_BirthdaysInfo.Text = "День рождения сегодня празднуют";
            // 
            // pictureBox_BirthdaysInfo
            // 
            this.pictureBox_BirthdaysInfo.BackgroundImage = global::ContactsAppUI.Assets.ImageAssets.Info;
            this.pictureBox_BirthdaysInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_BirthdaysInfo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_BirthdaysInfo.Name = "pictureBox_BirthdaysInfo";
            this.pictureBox_BirthdaysInfo.Size = new System.Drawing.Size(75, 74);
            this.pictureBox_BirthdaysInfo.TabIndex = 0;
            this.pictureBox_BirthdaysInfo.TabStop = false;
            // 
            // tableLayoutPanel_ContactInfo
            // 
            this.tableLayoutPanel_ContactInfo.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_ContactInfo.ColumnCount = 2;
            this.tableLayoutPanel_ContactInfo.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel_ContactInfo.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.label_IdVk, 0, 5);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.label_FirstName, 0, 1);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.label_LastName, 0, 0);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.textBox_LastName, 1, 0);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.label_Birthday, 0, 2);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.label_Phone, 0, 3);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.label_Email, 0, 4);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.textBox_FirstName, 1, 1);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.textBox_Birthday, 1, 2);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.textBox_Phone, 1, 3);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.textBox_Email, 1, 4);
            this.tableLayoutPanel_ContactInfo.Controls.Add(this.textBox_IdVk, 1, 5);
            this.tableLayoutPanel_ContactInfo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_ContactInfo.Name = "tableLayoutPanel_ContactInfo";
            this.tableLayoutPanel_ContactInfo.RowCount = 6;
            this.tableLayoutPanel_ContactInfo.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_ContactInfo.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_ContactInfo.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_ContactInfo.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_ContactInfo.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_ContactInfo.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_ContactInfo.Size = new System.Drawing.Size(409, 180);
            this.tableLayoutPanel_ContactInfo.TabIndex = 0;
            // 
            // label_IdVk
            // 
            this.label_IdVk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_IdVk.Location = new System.Drawing.Point(3, 153);
            this.label_IdVk.Name = "label_IdVk";
            this.label_IdVk.Size = new System.Drawing.Size(121, 23);
            this.label_IdVk.TabIndex = 10;
            this.label_IdVk.Text = "ID ВКонтакте:";
            this.label_IdVk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_FirstName
            // 
            this.label_FirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_FirstName.Location = new System.Drawing.Point(3, 33);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(121, 23);
            this.label_FirstName.TabIndex = 2;
            this.label_FirstName.Text = "Имя:";
            this.label_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_LastName
            // 
            this.label_LastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_LastName.Location = new System.Drawing.Point(3, 3);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(121, 23);
            this.label_LastName.TabIndex = 0;
            this.label_LastName.Text = "Фамилия:";
            this.label_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LastName.Location = new System.Drawing.Point(131, 3);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.ReadOnly = true;
            this.textBox_LastName.Size = new System.Drawing.Size(275, 23);
            this.textBox_LastName.TabIndex = 1;
            // 
            // label_Birthday
            // 
            this.label_Birthday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Birthday.Location = new System.Drawing.Point(3, 63);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(121, 23);
            this.label_Birthday.TabIndex = 4;
            this.label_Birthday.Text = "Дата рождения:";
            this.label_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Phone
            // 
            this.label_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Phone.Location = new System.Drawing.Point(3, 93);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(121, 23);
            this.label_Phone.TabIndex = 6;
            this.label_Phone.Text = "Телефон:";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Email
            // 
            this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Email.Location = new System.Drawing.Point(3, 123);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(121, 23);
            this.label_Email.TabIndex = 8;
            this.label_Email.Text = "E-Mail:";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FirstName.Location = new System.Drawing.Point(131, 33);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.ReadOnly = true;
            this.textBox_FirstName.Size = new System.Drawing.Size(275, 23);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // textBox_Birthday
            // 
            this.textBox_Birthday.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Birthday.Location = new System.Drawing.Point(131, 63);
            this.textBox_Birthday.Name = "textBox_Birthday";
            this.textBox_Birthday.ReadOnly = true;
            this.textBox_Birthday.Size = new System.Drawing.Size(275, 23);
            this.textBox_Birthday.TabIndex = 5;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Phone.Location = new System.Drawing.Point(131, 93);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.ReadOnly = true;
            this.textBox_Phone.Size = new System.Drawing.Size(275, 23);
            this.textBox_Phone.TabIndex = 7;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Email.Location = new System.Drawing.Point(131, 123);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(275, 23);
            this.textBox_Email.TabIndex = 9;
            // 
            // textBox_IdVk
            // 
            this.textBox_IdVk.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IdVk.Location = new System.Drawing.Point(131, 153);
            this.textBox_IdVk.Name = "textBox_IdVk";
            this.textBox_IdVk.ReadOnly = true;
            this.textBox_IdVk.Size = new System.Drawing.Size(275, 23);
            this.textBox_IdVk.TabIndex = 11;
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Exit.Text = "Выход";
            // 
            // toolStripMenuItem_AddContact
            // 
            this.toolStripMenuItem_AddContact.Image = global::ContactsAppUI.Assets.ImageAssets.Add;
            this.toolStripMenuItem_AddContact.Name = "toolStripMenuItem_AddContact";
            this.toolStripMenuItem_AddContact.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem_AddContact.Text = "Добавить контакт";
            // 
            // toolStripMenuItem_EditContact
            // 
            this.toolStripMenuItem_EditContact.Image = global::ContactsAppUI.Assets.ImageAssets.Edit;
            this.toolStripMenuItem_EditContact.Name = "toolStripMenuItem_EditContact";
            this.toolStripMenuItem_EditContact.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem_EditContact.Text = "Редактировать контакт";
            // 
            // toolStripMenuItem_RemoveContact
            // 
            this.toolStripMenuItem_RemoveContact.Image = global::ContactsAppUI.Assets.ImageAssets.Delete;
            this.toolStripMenuItem_RemoveContact.Name = "toolStripMenuItem_RemoveContact";
            this.toolStripMenuItem_RemoveContact.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem_RemoveContact.Text = "Удалить контакт";
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_About.Text = "О программе";
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 507);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.tableLayoutPanel_Left);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(697, 546);
            this.Name = "ContactsForm";
            this.Text = "Контакты";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel_Left.ResumeLayout(false);
            this.tableLayoutPanel_Left.PerformLayout();
            this.panel_ContactsList.ResumeLayout(false);
            this.panel_EditButtons.ResumeLayout(false);
            this.panel_Right.ResumeLayout(false);
            this.panel_BirthdaysInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox_BirthdaysInfo)).EndInit();
            this.tableLayoutPanel_ContactInfo.ResumeLayout(false);
            this.tableLayoutPanel_ContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_AddContact;
        private System.Windows.Forms.Button button_EditContact;
        private System.Windows.Forms.Button button_RemoveContact;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_BirthdaysInfo;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_IdVk;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.ListBox listBox_Contacts;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel_BirthdaysInfo;
        private System.Windows.Forms.Panel panel_ContactsList;
        private System.Windows.Forms.Panel panel_EditButtons;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.PictureBox pictureBox_BirthdaysInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContactInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Left;
        private System.Windows.Forms.TextBox textBox_Birthday;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_IdVk;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AddContact;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_RemoveContact;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_EditContact;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
    }
}