namespace PracticalADO_ReadDB
{
    partial class User
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //This does not clean up shit btw MS.

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.session = new System.Windows.Forms.TextBox();
            this.typemsg = new System.Windows.Forms.TextBox();
            this.submsg = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Role = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MFAtb = new System.Windows.Forms.TextBox();
            this.SubmitMFA = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.MFAvalue = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.RFID = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.NRIC = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.Book = new System.Windows.Forms.Button();
            this.Picker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Reason = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Messages = new System.Windows.Forms.TextBox();
            this.Systems = new System.Windows.Forms.Label();
            this.Queue = new System.Windows.Forms.TextBox();
            this.Profile.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // session
            // 
            this.session.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.session.Enabled = false;
            this.session.Location = new System.Drawing.Point(0, 442);
            this.session.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(186, 20);
            this.session.TabIndex = 1;
            // 
            // typemsg
            // 
            this.typemsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.typemsg.Location = new System.Drawing.Point(0, 515);
            this.typemsg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.typemsg.Multiline = true;
            this.typemsg.Name = "typemsg";
            this.typemsg.Size = new System.Drawing.Size(186, 62);
            this.typemsg.TabIndex = 0;
            this.typemsg.Text = "New Message";
            // 
            // submsg
            // 
            this.submsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submsg.Location = new System.Drawing.Point(0, 462);
            this.submsg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.submsg.Name = "submsg";
            this.submsg.Size = new System.Drawing.Size(186, 53);
            this.submsg.TabIndex = 0;
            this.submsg.Text = "send";
            this.submsg.UseVisualStyleBackColor = true;
            this.submsg.Click += new System.EventHandler(this.submsg_Click);
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.tabPage1);
            this.Profile.Controls.Add(this.tabPage2);
            this.Profile.Controls.Add(this.tabPage3);
            this.Profile.Location = new System.Drawing.Point(191, 50);
            this.Profile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Profile.Name = "Profile";
            this.Profile.SelectedIndex = 0;
            this.Profile.Size = new System.Drawing.Size(749, 517);
            this.Profile.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage1.Controls.Add(this.Role);
            this.tabPage1.Controls.Add(this.Email);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.MFAtb);
            this.tabPage1.Controls.Add(this.SubmitMFA);
            this.tabPage1.Controls.Add(this.Address);
            this.tabPage1.Controls.Add(this.Country);
            this.tabPage1.Controls.Add(this.ID);
            this.tabPage1.Controls.Add(this.MFAvalue);
            this.tabPage1.Controls.Add(this.DOB);
            this.tabPage1.Controls.Add(this.RFID);
            this.tabPage1.Controls.Add(this.Contact);
            this.tabPage1.Controls.Add(this.Name);
            this.tabPage1.Controls.Add(this.NRIC);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(741, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.ForeColor = System.Drawing.Color.White;
            this.Role.Location = new System.Drawing.Point(42, 159);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(29, 13);
            this.Role.TabIndex = 13;
            this.Role.Text = "Role";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(42, 172);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "MFA Value";
            // 
            // MFAtb
            // 
            this.MFAtb.Location = new System.Drawing.Point(191, 61);
            this.MFAtb.Name = "MFAtb";
            this.MFAtb.Size = new System.Drawing.Size(100, 20);
            this.MFAtb.TabIndex = 10;
            // 
            // SubmitMFA
            // 
            this.SubmitMFA.Location = new System.Drawing.Point(191, 84);
            this.SubmitMFA.Name = "SubmitMFA";
            this.SubmitMFA.Size = new System.Drawing.Size(75, 23);
            this.SubmitMFA.TabIndex = 9;
            this.SubmitMFA.Text = "Submit";
            this.SubmitMFA.UseVisualStyleBackColor = true;
            this.SubmitMFA.Click += new System.EventHandler(this.SubmitMFA_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.Location = new System.Drawing.Point(42, 94);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 8;
            this.Address.Text = "Address";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.ForeColor = System.Drawing.Color.White;
            this.Country.Location = new System.Drawing.Point(42, 120);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(43, 13);
            this.Country.TabIndex = 7;
            this.Country.Text = "Country";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(42, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // MFAvalue
            // 
            this.MFAvalue.AutoSize = true;
            this.MFAvalue.ForeColor = System.Drawing.Color.White;
            this.MFAvalue.Location = new System.Drawing.Point(42, 107);
            this.MFAvalue.Name = "MFAvalue";
            this.MFAvalue.Size = new System.Drawing.Size(55, 13);
            this.MFAvalue.TabIndex = 5;
            this.MFAvalue.Text = "MFAvalue";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.ForeColor = System.Drawing.Color.White;
            this.DOB.Location = new System.Drawing.Point(42, 133);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(30, 13);
            this.DOB.TabIndex = 4;
            this.DOB.Text = "DOB";
            // 
            // RFID
            // 
            this.RFID.AutoSize = true;
            this.RFID.ForeColor = System.Drawing.Color.White;
            this.RFID.Location = new System.Drawing.Point(42, 81);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(32, 13);
            this.RFID.TabIndex = 3;
            this.RFID.Text = "RFID";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.ForeColor = System.Drawing.Color.White;
            this.Contact.Location = new System.Drawing.Point(42, 68);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(44, 13);
            this.Contact.TabIndex = 2;
            this.Contact.Text = "Contact";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(42, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // NRIC
            // 
            this.NRIC.AutoSize = true;
            this.NRIC.ForeColor = System.Drawing.Color.White;
            this.NRIC.Location = new System.Drawing.Point(42, 146);
            this.NRIC.Name = "NRIC";
            this.NRIC.Size = new System.Drawing.Size(33, 13);
            this.NRIC.TabIndex = 0;
            this.NRIC.Text = "NRIC";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage2.Controls.Add(this.EndTime);
            this.tabPage2.Controls.Add(this.Book);
            this.tabPage2.Controls.Add(this.Picker);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Reason);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(741, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Booking";
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(123, 89);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(202, 20);
            this.EndTime.TabIndex = 5;
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(123, 215);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(75, 23);
            this.Book.TabIndex = 4;
            this.Book.Text = "Book Now";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Picker
            // 
            this.Picker.Location = new System.Drawing.Point(123, 60);
            this.Picker.Name = "Picker";
            this.Picker.Size = new System.Drawing.Size(202, 20);
            this.Picker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Booking\r\n\r\nEnd Time Booking\r\n\r\nReason\r\n";
            // 
            // Reason
            // 
            this.Reason.Location = new System.Drawing.Point(123, 115);
            this.Reason.Multiline = true;
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(202, 83);
            this.Reason.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage3.Controls.Add(this.Queue);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage3.Size = new System.Drawing.Size(741, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calendar (current)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Messages);
            this.panel1.Controls.Add(this.session);
            this.panel1.Controls.Add(this.submsg);
            this.panel1.Controls.Add(this.typemsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 1;
            // 
            // Messages
            // 
            this.Messages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Messages.Enabled = false;
            this.Messages.Location = new System.Drawing.Point(0, 0);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(186, 442);
            this.Messages.TabIndex = 2;
            // 
            // Systems
            // 
            this.Systems.AutoSize = true;
            this.Systems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(210)))), ((int)(((byte)(134)))));
            this.Systems.Location = new System.Drawing.Point(192, 9);
            this.Systems.Name = "Systems";
            this.Systems.Size = new System.Drawing.Size(55, 13);
            this.Systems.TabIndex = 2;
            this.Systems.Text = "Welcome ";
            // 
            // Queue
            // 
            this.Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Queue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Queue.Location = new System.Drawing.Point(2, 1);
            this.Queue.Multiline = true;
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(737, 489);
            this.Queue.TabIndex = 0;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Systems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Profile);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_FormClosed);
            this.Profile.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl Profile;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox typemsg;
        private System.Windows.Forms.Button submsg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox session;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label MFAvalue;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label RFID;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label NRIC;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button SubmitMFA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MFAtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Messages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Reason;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.DateTimePicker Picker;
        private System.Windows.Forms.Label Systems;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.TextBox Queue;
    }
}