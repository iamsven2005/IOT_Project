namespace PracticalADO_ReadDB
{
    partial class frmAddUser
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblNRIC = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(65, 103);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(43, 17);
            this.lblRFID.TabIndex = 1;
            this.lblRFID.Text = "RFID:";
            // 
            // lblNRIC
            // 
            this.lblNRIC.AutoSize = true;
            this.lblNRIC.Location = new System.Drawing.Point(64, 131);
            this.lblNRIC.Name = "lblNRIC";
            this.lblNRIC.Size = new System.Drawing.Size(44, 17);
            this.lblNRIC.TabIndex = 2;
            this.lblNRIC.Text = "NRIC:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(64, 159);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // tbContact
            // 
            this.tbContact.AutoSize = true;
            this.tbContact.Location = new System.Drawing.Point(65, 187);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(60, 17);
            this.tbContact.TabIndex = 4;
            this.tbContact.Text = "Contact:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(134, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(134, 103);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(100, 22);
            this.tbRFID.TabIndex = 6;
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(134, 131);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(100, 22);
            this.tbNRIC.TabIndex = 7;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(134, 159);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(100, 22);
            this.tbAdd.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(68, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(159, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(64, 51);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(69, 17);
            this.lblPwd.TabIndex = 12;
            this.lblPwd.Text = "Password";
            this.lblPwd.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(134, 46);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(100, 22);
            this.tbPwd.TabIndex = 13;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 253);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.tbNRIC);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNRIC);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblNRIC;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label tbContact;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tbPwd;
    }
}