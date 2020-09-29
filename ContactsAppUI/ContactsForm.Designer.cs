using System.ComponentModel;

namespace ContactsAppUI
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
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel_Left.SuspendLayout();
            this.panel_ContactsList.SuspendLayout();
            this.panel_EditButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem_File, this.toolStripMenuItem_Edit, this.toolStripMenuItem_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(584, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem_File.Text = "Файл";
            // 
            // toolStripMenuItem_Edit
            // 
            this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItem_Edit.Text = "Редактирование";
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem_Help.Text = "Помощь";
            // 
            // tableLayoutPanel_Left
            // 
            this.tableLayoutPanel_Left.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel_Left.ColumnCount = 2;
            this.tableLayoutPanel_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Left.Controls.Add(this.label_Search, 0, 0);
            this.tableLayoutPanel_Left.Controls.Add(this.textBox_Search, 1, 0);
            this.tableLayoutPanel_Left.Controls.Add(this.panel_ContactsList, 0, 1);
            this.tableLayoutPanel_Left.Controls.Add(this.panel_EditButtons, 0, 2);
            this.tableLayoutPanel_Left.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel_Left.MinimumSize = new System.Drawing.Size(200, 400);
            this.tableLayoutPanel_Left.Name = "tableLayoutPanel_Left";
            this.tableLayoutPanel_Left.RowCount = 3;
            this.tableLayoutPanel_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_Left.Size = new System.Drawing.Size(200, 400);
            this.tableLayoutPanel_Left.TabIndex = 1;
            // 
            // label_Search
            // 
            this.label_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Search.Location = new System.Drawing.Point(0, 2);
            this.label_Search.Margin = new System.Windows.Forms.Padding(0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(50, 20);
            this.label_Search.TabIndex = 0;
            this.label_Search.Text = "Поиск:";
            this.label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Location = new System.Drawing.Point(53, 3);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(144, 20);
            this.textBox_Search.TabIndex = 1;
            // 
            // panel_ContactsList
            // 
            this.panel_ContactsList.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Left.SetColumnSpan(this.panel_ContactsList, 2);
            this.panel_ContactsList.Controls.Add(this.listBox_Contacts);
            this.panel_ContactsList.Location = new System.Drawing.Point(0, 24);
            this.panel_ContactsList.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ContactsList.Name = "panel_ContactsList";
            this.panel_ContactsList.Size = new System.Drawing.Size(200, 340);
            this.panel_ContactsList.TabIndex = 2;
            // 
            // listBox_Contacts
            // 
            this.listBox_Contacts.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Contacts.FormattingEnabled = true;
            this.listBox_Contacts.Location = new System.Drawing.Point(3, 3);
            this.listBox_Contacts.Name = "listBox_Contacts";
            this.listBox_Contacts.Size = new System.Drawing.Size(194, 329);
            this.listBox_Contacts.TabIndex = 0;
            // 
            // panel_EditButtons
            // 
            this.panel_EditButtons.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Left.SetColumnSpan(this.panel_EditButtons, 2);
            this.panel_EditButtons.Controls.Add(this.button_RemoveContact);
            this.panel_EditButtons.Controls.Add(this.button_EditContact);
            this.panel_EditButtons.Controls.Add(this.button_AddContact);
            this.panel_EditButtons.Location = new System.Drawing.Point(0, 364);
            this.panel_EditButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panel_EditButtons.Name = "panel_EditButtons";
            this.panel_EditButtons.Size = new System.Drawing.Size(200, 36);
            this.panel_EditButtons.TabIndex = 3;
            // 
            // button_RemoveContact
            // 
            this.button_RemoveContact.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.button_RemoveContact.BackgroundImage = global::ContactsAppUI.Assets.ImageAssets.Delete;
            this.button_RemoveContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_RemoveContact.Location = new System.Drawing.Point(74, 2);
            this.button_RemoveContact.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveContact.Name = "button_RemoveContact";
            this.button_RemoveContact.Size = new System.Drawing.Size(32, 32);
            this.button_RemoveContact.TabIndex = 2;
            this.button_RemoveContact.UseVisualStyleBackColor = true;
            // 
            // button_EditContact
            // 
            this.button_EditContact.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.button_EditContact.BackgroundImage = global::ContactsAppUI.Assets.ImageAssets.Edit;
            this.button_EditContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_EditContact.Location = new System.Drawing.Point(38, 2);
            this.button_EditContact.Margin = new System.Windows.Forms.Padding(2);
            this.button_EditContact.Name = "button_EditContact";
            this.button_EditContact.Size = new System.Drawing.Size(32, 32);
            this.button_EditContact.TabIndex = 1;
            this.button_EditContact.UseVisualStyleBackColor = true;
            // 
            // button_AddContact
            // 
            this.button_AddContact.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddContact.BackgroundImage = global::ContactsAppUI.Assets.ImageAssets.Add;
            this.button_AddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddContact.Location = new System.Drawing.Point(2, 2);
            this.button_AddContact.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddContact.Name = "button_AddContact";
            this.button_AddContact.Size = new System.Drawing.Size(32, 32);
            this.button_AddContact.TabIndex = 0;
            this.button_AddContact.UseVisualStyleBackColor = true;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 439);
            this.Controls.Add(this.tableLayoutPanel_Left);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 478);
            this.Name = "ContactsForm";
            this.Text = "ContactsApp";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel_Left.ResumeLayout(false);
            this.tableLayoutPanel_Left.PerformLayout();
            this.panel_ContactsList.ResumeLayout(false);
            this.panel_EditButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_AddContact;
        private System.Windows.Forms.Button button_EditContact;
        private System.Windows.Forms.Button button_RemoveContact;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.ListBox listBox_Contacts;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel_ContactsList;
        private System.Windows.Forms.Panel panel_EditButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Left;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;

        #endregion
    }
}