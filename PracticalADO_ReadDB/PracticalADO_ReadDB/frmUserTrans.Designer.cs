namespace PracticalADO_ReadDB
{
    partial class frmUserTrans
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.btnGetUser = new System.Windows.Forms.Button();
            this.grdTrans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(16, 11);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 17);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "UserID";
            this.lblUserID.Click += new System.EventHandler(this.lblUserID_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 46);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(16, 78);
            this.lblRFID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(39, 17);
            this.lblRFID.TabIndex = 2;
            this.lblRFID.Text = "RFID";
            this.lblRFID.Click += new System.EventHandler(this.lblRFID_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(16, 110);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(56, 17);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact";
            this.lblContact.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(77, 7);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(132, 22);
            this.tbUserID.TabIndex = 5;
            this.tbUserID.TextChanged += new System.EventHandler(this.tbUserID_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(77, 42);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(132, 22);
            this.tbName.TabIndex = 6;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(77, 74);
            this.tbRFID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.ReadOnly = true;
            this.tbRFID.Size = new System.Drawing.Size(132, 22);
            this.tbRFID.TabIndex = 7;
            this.tbRFID.TextChanged += new System.EventHandler(this.tbRFID_TextChanged);
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(77, 106);
            this.tbContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContact.Name = "tbContact";
            this.tbContact.ReadOnly = true;
            this.tbContact.Size = new System.Drawing.Size(132, 22);
            this.tbContact.TabIndex = 8;
            this.tbContact.TextChanged += new System.EventHandler(this.tbContact_TextChanged);
            // 
            // btnGetUser
            // 
            this.btnGetUser.Location = new System.Drawing.Point(380, 46);
            this.btnGetUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetUser.Name = "btnGetUser";
            this.btnGetUser.Size = new System.Drawing.Size(100, 28);
            this.btnGetUser.TabIndex = 9;
            this.btnGetUser.Text = "Get User";
            this.btnGetUser.UseVisualStyleBackColor = true;
            this.btnGetUser.Click += new System.EventHandler(this.btnGetUser_Click);
            // 
            // grdTrans
            // 
            this.grdTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrans.Location = new System.Drawing.Point(25, 138);
            this.grdTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTrans.Name = "grdTrans";
            this.grdTrans.Size = new System.Drawing.Size(564, 185);
            this.grdTrans.TabIndex = 10;
            this.grdTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTrans_CellContentClick);
            // 
            // frmUserTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 321);
            this.Controls.Add(this.grdTrans);
            this.Controls.Add(this.btnGetUser);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUserTrans";
            this.Text = "frmUserTrans";
            this.Load += new System.EventHandler(this.frmUserTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Button btnGetUser;
        private System.Windows.Forms.DataGridView grdTrans;
    }
}