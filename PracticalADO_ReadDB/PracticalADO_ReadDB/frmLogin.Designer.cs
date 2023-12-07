using System;
using System.IO;
namespace PracticalADO_ReadDB
{
    partial class frmLogin
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
        #region Windows Form Designer generated code
        //DEXTER, This is mine, I will clean it
        //This is autorighting based on init(), just change the init at same time the method should be able shift around.

        private void InitializeComponent()
        {
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.MFATB = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.ForgetPwd = new System.Windows.Forms.Button();
            this.AdminLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbUserName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbUserName.Location = new System.Drawing.Point(11, 24);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(261, 22);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "Username";
            this.tbUserName.UseWaitCursor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(11, 58);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(8);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(261, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(11, 120);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 38);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.UseWaitCursor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // MFATB
            // 
            this.MFATB.Location = new System.Drawing.Point(11, 91);
            this.MFATB.Name = "MFATB";
            this.MFATB.Size = new System.Drawing.Size(264, 22);
            this.MFATB.TabIndex = 3;
            this.MFATB.Text = "MFA Value (Default \"Hello\")";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(10);
            this.Title.MaximumSize = new System.Drawing.Size(2000, 200);
            this.Title.MinimumSize = new System.Drawing.Size(200, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(326, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Server Environment Monitoring System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.UseWaitCursor = true;
            this.Title.ParentChanged += new System.EventHandler(this.Title_ParentChanged);
            // 
            // ForgetPwd
            // 
            this.ForgetPwd.AutoSize = true;
            this.ForgetPwd.Location = new System.Drawing.Point(107, 120);
            this.ForgetPwd.Name = "ForgetPwd";
            this.ForgetPwd.Size = new System.Drawing.Size(168, 38);
            this.ForgetPwd.TabIndex = 4;
            this.ForgetPwd.Text = "Forget Password";
            this.ForgetPwd.UseVisualStyleBackColor = true;
            this.ForgetPwd.UseWaitCursor = true;
            this.ForgetPwd.Click += new System.EventHandler(this.ForgetPwd_Click);
            // 
            // AdminLogin
            // 
            this.AdminLogin.Location = new System.Drawing.Point(419, 414);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(75, 23);
            this.AdminLogin.TabIndex = 6;
            this.AdminLogin.Text = "Admin";
            this.AdminLogin.UseVisualStyleBackColor = true;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.ForgetPwd);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.MFATB);
            this.panel1.Location = new System.Drawing.Point(321, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 169);
            this.panel1.TabIndex = 7;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Resize += new System.EventHandler(this.frmLogin_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button ForgetPwd;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox MFATB;
        private System.Windows.Forms.Button AdminLogin;
        private System.Windows.Forms.Panel panel1;
    }
}

