namespace PracticalADO_ReadDB
{
    partial class GetNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Username = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.GetContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(12, 22);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(44, 13);
            this.Contact.TabIndex = 1;
            this.Contact.Text = "Contact";
            this.Contact.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.AllowDrop = true;
            this.tbUsername.Location = new System.Drawing.Point(73, 6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsernmae_TextChanged);
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(73, 32);
            this.tbContact.Name = "tbContact";
            this.tbContact.ReadOnly = true;
            this.tbContact.Size = new System.Drawing.Size(100, 20);
            this.tbContact.TabIndex = 3;
            // 
            // GetContact
            // 
            this.GetContact.Location = new System.Drawing.Point(197, 22);
            this.GetContact.Name = "GetContact";
            this.GetContact.Size = new System.Drawing.Size(75, 23);
            this.GetContact.TabIndex = 4;
            this.GetContact.Text = "Get Contact";
            this.GetContact.UseVisualStyleBackColor = true;
            this.GetContact.Click += new System.EventHandler(this.GetContact_Click);
            // 
            // GetNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GetContact);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Username);
            this.Name = "GetNumber";
            this.Text = "GetNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Button GetContact;
    }
}