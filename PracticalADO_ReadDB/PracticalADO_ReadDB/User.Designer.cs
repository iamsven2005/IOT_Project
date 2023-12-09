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
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Messages = new System.Windows.Forms.TextBox();
            this.Profile.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // session
            // 
            this.session.Location = new System.Drawing.Point(165, 680);
            this.session.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(112, 26);
            this.session.TabIndex = 1;
            this.session.Visible = false;
            this.session.TextChanged += new System.EventHandler(this.session_TextChanged);
            // 
            // typemsg
            // 
            this.typemsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.typemsg.Location = new System.Drawing.Point(0, 795);
            this.typemsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typemsg.Multiline = true;
            this.typemsg.Name = "typemsg";
            this.typemsg.Size = new System.Drawing.Size(279, 93);
            this.typemsg.TabIndex = 0;
            this.typemsg.Text = "New Message";
            // 
            // submsg
            // 
            this.submsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submsg.Location = new System.Drawing.Point(0, 714);
            this.submsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submsg.Name = "submsg";
            this.submsg.Size = new System.Drawing.Size(279, 81);
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
            this.Profile.Location = new System.Drawing.Point(461, 125);
            this.Profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Profile.Name = "Profile";
            this.Profile.SelectedIndex = 0;
            this.Profile.Size = new System.Drawing.Size(599, 430);
            this.Profile.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(591, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "MFA Value";
            // 
            // MFAtb
            // 
            this.MFAtb.Location = new System.Drawing.Point(287, 94);
            this.MFAtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MFAtb.Name = "MFAtb";
            this.MFAtb.Size = new System.Drawing.Size(148, 26);
            this.MFAtb.TabIndex = 10;
            // 
            // SubmitMFA
            // 
            this.SubmitMFA.Location = new System.Drawing.Point(287, 129);
            this.SubmitMFA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitMFA.Name = "SubmitMFA";
            this.SubmitMFA.Size = new System.Drawing.Size(112, 35);
            this.SubmitMFA.TabIndex = 9;
            this.SubmitMFA.Text = "Submit";
            this.SubmitMFA.UseVisualStyleBackColor = true;
            this.SubmitMFA.Click += new System.EventHandler(this.SubmitMFA_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(63, 145);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 20);
            this.Address.TabIndex = 8;
            this.Address.Text = "Address";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(63, 185);
            this.Country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(64, 20);
            this.Country.TabIndex = 7;
            this.Country.Text = "Country";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(63, 85);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // MFAvalue
            // 
            this.MFAvalue.AutoSize = true;
            this.MFAvalue.Location = new System.Drawing.Point(63, 165);
            this.MFAvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MFAvalue.Name = "MFAvalue";
            this.MFAvalue.Size = new System.Drawing.Size(80, 20);
            this.MFAvalue.TabIndex = 5;
            this.MFAvalue.Text = "MFAvalue";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(63, 205);
            this.DOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(44, 20);
            this.DOB.TabIndex = 4;
            this.DOB.Text = "DOB";
            // 
            // RFID
            // 
            this.RFID.AutoSize = true;
            this.RFID.Location = new System.Drawing.Point(63, 125);
            this.RFID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(48, 20);
            this.RFID.TabIndex = 3;
            this.RFID.Text = "RFID";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(63, 105);
            this.Contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(65, 20);
            this.Contact.TabIndex = 2;
            this.Contact.Text = "Contact";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(63, 34);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // NRIC
            // 
            this.NRIC.AutoSize = true;
            this.NRIC.Location = new System.Drawing.Point(63, 225);
            this.NRIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NRIC.Name = "NRIC";
            this.NRIC.Size = new System.Drawing.Size(48, 20);
            this.NRIC.TabIndex = 0;
            this.NRIC.Text = "NRIC";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(591, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Booking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 2);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(585, 393);
            this.splitContainer4.SplitterDistance = 352;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer5.Size = new System.Drawing.Size(352, 393);
            this.splitContainer5.SplitterDistance = 123;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(591, 397);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 888);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(0, 0);
            this.Messages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(277, 709);
            this.Messages.TabIndex = 2;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1426, 888);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Profile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_FormClosed);
            this.Load += new System.EventHandler(this.User_Load);
            this.Profile.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Profile;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox typemsg;
        private System.Windows.Forms.Button submsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
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
    }
}