using System.ComponentModel;

namespace ContactsAppUI.Forms
{
    partial class AboutForm
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
            this.label_AppName = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_GitHub = new System.Windows.Forms.Label();
            this.label_VersionValue = new System.Windows.Forms.Label();
            this.label_AuthorValue = new System.Windows.Forms.Label();
            this.linkLabel_EmailValue = new System.Windows.Forms.LinkLabel();
            this.linkLabel_GitHubValue = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AppName
            // 
            this.label_AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label_AppName.Location = new System.Drawing.Point(14, 10);
            this.label_AppName.Name = "label_AppName";
            this.label_AppName.Size = new System.Drawing.Size(362, 47);
            this.label_AppName.TabIndex = 0;
            this.label_AppName.Text = "ContactsApp";
            this.label_AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Version
            // 
            this.label_Version.Location = new System.Drawing.Point(3, 0);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(50, 26);
            this.label_Version.TabIndex = 1;
            this.label_Version.Text = "Версия:";
            this.label_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Author
            // 
            this.label_Author.Location = new System.Drawing.Point(3, 26);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(50, 26);
            this.label_Author.TabIndex = 2;
            this.label_Author.Text = "Автор:";
            this.label_Author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.Controls.Add(this.label_AuthorValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Version, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Author, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Email, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_GitHub, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_VersionValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel_EmailValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel_GitHubValue, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 104);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label_Email
            // 
            this.label_Email.Location = new System.Drawing.Point(3, 52);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(50, 23);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "E-Mail:";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_GitHub
            // 
            this.label_GitHub.Location = new System.Drawing.Point(3, 78);
            this.label_GitHub.Name = "label_GitHub";
            this.label_GitHub.Size = new System.Drawing.Size(50, 23);
            this.label_GitHub.TabIndex = 4;
            this.label_GitHub.Text = "GitHub:";
            this.label_GitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_VersionValue
            // 
            this.label_VersionValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_VersionValue.Location = new System.Drawing.Point(59, 0);
            this.label_VersionValue.Name = "label_VersionValue";
            this.label_VersionValue.Size = new System.Drawing.Size(296, 26);
            this.label_VersionValue.TabIndex = 5;
            this.label_VersionValue.Text = "1.0.0";
            this.label_VersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_AuthorValue
            // 
            this.label_AuthorValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_AuthorValue.Location = new System.Drawing.Point(59, 26);
            this.label_AuthorValue.Name = "label_AuthorValue";
            this.label_AuthorValue.Size = new System.Drawing.Size(296, 26);
            this.label_AuthorValue.TabIndex = 6;
            this.label_AuthorValue.Text = "Кушнарёв Артём";
            this.label_AuthorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_EmailValue
            // 
            this.linkLabel_EmailValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel_EmailValue.Location = new System.Drawing.Point(59, 52);
            this.linkLabel_EmailValue.Name = "linkLabel_EmailValue";
            this.linkLabel_EmailValue.Size = new System.Drawing.Size(296, 26);
            this.linkLabel_EmailValue.TabIndex = 7;
            this.linkLabel_EmailValue.TabStop = true;
            this.linkLabel_EmailValue.Text = "sonikku@e.tusur.ru";
            this.linkLabel_EmailValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_GitHubValue
            // 
            this.linkLabel_GitHubValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel_GitHubValue.Location = new System.Drawing.Point(59, 78);
            this.linkLabel_GitHubValue.Name = "linkLabel_GitHubValue";
            this.linkLabel_GitHubValue.Size = new System.Drawing.Size(296, 26);
            this.linkLabel_GitHubValue.TabIndex = 8;
            this.linkLabel_GitHubValue.TabStop = true;
            this.linkLabel_GitHubValue.Text = "https://github.com/sonikku42ru/ContactsApp";
            this.linkLabel_GitHubValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_AppName);
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label_Version;

        private System.Windows.Forms.Label label_AppName;

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_GitHub;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_AuthorValue;
        private System.Windows.Forms.Label label_VersionValue;
        private System.Windows.Forms.LinkLabel linkLabel_EmailValue;
        private System.Windows.Forms.LinkLabel linkLabel_GitHubValue;
    }
}