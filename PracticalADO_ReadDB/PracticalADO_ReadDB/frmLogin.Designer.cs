namespace PracticalADO_ReadDB
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.test2 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.ForgetPwd = new System.Windows.Forms.Button();
            this.test3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(4, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbUserName.Location = new System.Drawing.Point(89, 89);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(261, 22);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.UseWaitCursor = true;
            this.tbUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPassword.Location = new System.Drawing.Point(89, 119);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(261, 22);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseWaitCursor = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogin.Location = new System.Drawing.Point(4, 187);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.UseWaitCursor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.Location = new System.Drawing.Point(4, 223);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.UseWaitCursor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test
            // 
            this.Test.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Test.Location = new System.Drawing.Point(119, 223);
            this.Test.Margin = new System.Windows.Forms.Padding(4);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(146, 28);
            this.Test.TabIndex = 6;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.UseWaitCursor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Panel1.BackgroundImage = global::PracticalADO_ReadDB.Properties.Resources.SYSTEM_OVERVIEW__1_;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Navy;
            this.splitContainer1.Panel2.Controls.Add(this.test3);
            this.splitContainer1.Panel2.Controls.Add(this.test2);
            this.splitContainer1.Panel2.Controls.Add(this.Title);
            this.splitContainer1.Panel2.Controls.Add(this.Test);
            this.splitContainer1.Panel2.Controls.Add(this.ForgetPwd);
            this.splitContainer1.Panel2.Controls.Add(this.btnLogin);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbUserName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tbPassword);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(592, 318);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 7;
            // 
            // test2
            // 
            this.test2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.test2.Location = new System.Drawing.Point(120, 255);
            this.test2.Margin = new System.Windows.Forms.Padding(4);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(146, 28);
            this.test2.TabIndex = 7;
            this.test2.Text = "test2";
            this.test2.UseVisualStyleBackColor = true;
            this.test2.UseWaitCursor = true;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(4, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(271, 16);
            this.Title.TabIndex = 0;
            this.Title.Text = "Server Environment Monitoring System";
            this.Title.UseWaitCursor = true;
            // 
            // ForgetPwd
            // 
            this.ForgetPwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ForgetPwd.Location = new System.Drawing.Point(119, 186);
            this.ForgetPwd.Name = "ForgetPwd";
            this.ForgetPwd.Size = new System.Drawing.Size(147, 29);
            this.ForgetPwd.TabIndex = 6;
            this.ForgetPwd.Text = "Forget Password";
            this.ForgetPwd.UseVisualStyleBackColor = true;
            this.ForgetPwd.UseWaitCursor = true;
            // 
            // test3
            // 
            this.test3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.test3.Location = new System.Drawing.Point(120, 286);
            this.test3.Margin = new System.Windows.Forms.Padding(4);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(146, 28);
            this.test3.TabIndex = 8;
            this.test3.Text = "test3";
            this.test3.UseVisualStyleBackColor = true;
            this.test3.UseWaitCursor = true;
            this.test3.Click += new System.EventHandler(this.test3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(592, 318);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ForgetPwd;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button test2;
        private System.Windows.Forms.Button test3;
    }
}

