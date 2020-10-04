using System.ComponentModel;

namespace ContactsAppUI.Forms
{
    partial class EditForm
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
            this.tableLayoutPanel_Edit = new System.Windows.Forms.TableLayoutPanel();
            this.label_IdVk = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_IdVk = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Edit
            // 
            this.tableLayoutPanel_Edit.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Edit.ColumnCount = 2;
            this.tableLayoutPanel_Edit.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel_Edit.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Edit.Controls.Add(this.label_IdVk, 0, 5);
            this.tableLayoutPanel_Edit.Controls.Add(this.label_Email, 0, 4);
            this.tableLayoutPanel_Edit.Controls.Add(this.label_Phone, 0, 3);
            this.tableLayoutPanel_Edit.Controls.Add(this.label_Birthday, 0, 2);
            this.tableLayoutPanel_Edit.Controls.Add(this.label_FirstName, 0, 1);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBox_LastName, 1, 0);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBox_FirstName, 1, 1);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBox_Email, 1, 4);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBox_IdVk, 1, 5);
            this.tableLayoutPanel_Edit.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel_Edit.Controls.Add(this.maskedTextBox1, 1, 3);
            this.tableLayoutPanel_Edit.Controls.Add(this.label_LastName, 0, 0);
            this.tableLayoutPanel_Edit.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_Edit.Name = "tableLayoutPanel_Edit";
            this.tableLayoutPanel_Edit.RowCount = 6;
            this.tableLayoutPanel_Edit.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Edit.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Edit.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Edit.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Edit.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Edit.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Edit.Size = new System.Drawing.Size(434, 174);
            this.tableLayoutPanel_Edit.TabIndex = 0;
            // 
            // label_IdVk
            // 
            this.label_IdVk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_IdVk.Location = new System.Drawing.Point(3, 145);
            this.label_IdVk.Name = "label_IdVk";
            this.label_IdVk.Size = new System.Drawing.Size(100, 29);
            this.label_IdVk.TabIndex = 11;
            this.label_IdVk.Text = "ID ВКонтакте:";
            this.label_IdVk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Email
            // 
            this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Email.Location = new System.Drawing.Point(3, 116);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(100, 29);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "E-Mail:";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Phone
            // 
            this.label_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Phone.Location = new System.Drawing.Point(3, 87);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(100, 29);
            this.label_Phone.TabIndex = 9;
            this.label_Phone.Text = "Телефон:";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Birthday
            // 
            this.label_Birthday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Birthday.Location = new System.Drawing.Point(3, 58);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(100, 29);
            this.label_Birthday.TabIndex = 8;
            this.label_Birthday.Text = "Дата рождения:";
            this.label_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FirstName
            // 
            this.label_FirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_FirstName.Location = new System.Drawing.Point(3, 29);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(100, 29);
            this.label_FirstName.TabIndex = 7;
            this.label_FirstName.Text = "Имя:";
            this.label_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LastName.Location = new System.Drawing.Point(133, 3);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(298, 23);
            this.textBox_LastName.TabIndex = 0;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FirstName.Location = new System.Drawing.Point(133, 32);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(298, 23);
            this.textBox_FirstName.TabIndex = 1;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Email.Location = new System.Drawing.Point(133, 119);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(298, 23);
            this.textBox_Email.TabIndex = 4;
            // 
            // textBox_IdVk
            // 
            this.textBox_IdVk.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IdVk.Location = new System.Drawing.Point(133, 148);
            this.textBox_IdVk.Name = "textBox_IdVk";
            this.textBox_IdVk.Size = new System.Drawing.Size(298, 23);
            this.textBox_IdVk.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(133, 90);
            this.maskedTextBox1.Mask = "+7 (000) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(298, 23);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // label_LastName
            // 
            this.label_LastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_LastName.Location = new System.Drawing.Point(3, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(100, 29);
            this.label_LastName.TabIndex = 6;
            this.label_LastName.Text = "Фамилия:";
            this.label_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Cancel.Location = new System.Drawing.Point(363, 189);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(80, 28);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Ok
            // 
            this.button_Ok.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Ok.Location = new System.Drawing.Point(277, 189);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(80, 28);
            this.button_Ok.TabIndex = 2;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 221);
            this.ControlBox = false;
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.tableLayoutPanel_Edit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(775, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 260);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.tableLayoutPanel_Edit.ResumeLayout(false);
            this.tableLayoutPanel_Edit.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_IdVk;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_IdVk;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Edit;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
    }
}