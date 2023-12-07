namespace PracticalADO_ReadDB
{
    partial class forgetpassword
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
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(171, 87);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(178, 22);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(168, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write Your Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(168, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Write Your Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(171, 140);
            this.Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(178, 22);
            this.Address.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(168, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Write Your Contact Number";
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(171, 194);
            this.Contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(178, 22);
            this.Contact.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(171, 229);
            this.Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Location = new System.Drawing.Point(396, 263);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 276);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(178, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Write Your Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "forgetpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.forgetpassword_FormClosed);
            this.Load += new System.EventHandler(this.forgetpassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}