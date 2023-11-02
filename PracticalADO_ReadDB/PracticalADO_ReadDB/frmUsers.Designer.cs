namespace PracticalADO_ReadDB
{
    partial class frmUsers
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
            this.lblUniqueUserID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblNRIC = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.btnGetUserID = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUniqueUserID
            // 
            this.lblUniqueUserID.AutoSize = true;
            this.lblUniqueUserID.Location = new System.Drawing.Point(12, 9);
            this.lblUniqueUserID.Name = "lblUniqueUserID";
            this.lblUniqueUserID.Size = new System.Drawing.Size(100, 17);
            this.lblUniqueUserID.TabIndex = 0;
            this.lblUniqueUserID.Text = "UniqueUserID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(12, 65);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(43, 17);
            this.lblRFID.TabIndex = 2;
            this.lblRFID.Text = "RFID:";
            // 
            // lblNRIC
            // 
            this.lblNRIC.AutoSize = true;
            this.lblNRIC.Location = new System.Drawing.Point(12, 93);
            this.lblNRIC.Name = "lblNRIC";
            this.lblNRIC.Size = new System.Drawing.Size(44, 17);
            this.lblNRIC.TabIndex = 3;
            this.lblNRIC.Text = "NRIC:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 120);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            this.lblAddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(12, 143);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 17);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact:";
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.SystemColors.Window;
            this.tbUserID.Location = new System.Drawing.Point(118, 4);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(100, 22);
            this.tbUserID.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbName.Location = new System.Drawing.Point(118, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 7;
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(118, 60);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(100, 22);
            this.tbRFID.TabIndex = 8;
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(118, 88);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(100, 22);
            this.tbNRIC.TabIndex = 9;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(118, 115);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(100, 22);
            this.tbAdd.TabIndex = 10;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(118, 143);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(100, 22);
            this.tbContact.TabIndex = 11;
            // 
            // btnGetUserID
            // 
            this.btnGetUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUserID.Location = new System.Drawing.Point(262, 12);
            this.btnGetUserID.Name = "btnGetUserID";
            this.btnGetUserID.Size = new System.Drawing.Size(75, 23);
            this.btnGetUserID.TabIndex = 12;
            this.btnGetUserID.Text = "Get User";
            this.btnGetUserID.UseVisualStyleBackColor = true;
            this.btnGetUserID.Click += new System.EventHandler(this.btnGetUserID_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(118, 238);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(199, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(280, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetUserID);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.tbNRIC);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNRIC);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUniqueUserID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUniqueUserID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblNRIC;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Button btnGetUserID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}