﻿namespace PracticalADO_ReadDB
{
    partial class frmForget
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
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.pwdbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(54, 23);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(100, 20);
            this.passwordtb.TabIndex = 0;
            this.passwordtb.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // pwdbtn
            // 
            this.pwdbtn.Location = new System.Drawing.Point(32, 77);
            this.pwdbtn.Name = "pwdbtn";
            this.pwdbtn.Size = new System.Drawing.Size(75, 23);
            this.pwdbtn.TabIndex = 1;
            this.pwdbtn.Text = "Submit";
            this.pwdbtn.UseVisualStyleBackColor = true;
            this.pwdbtn.Click += new System.EventHandler(this.pwdbtn_Click);
            // 
            // frmForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.pwdbtn);
            this.Controls.Add(this.passwordtb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmForget";
            this.Text = "frmForget";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmForget_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Button pwdbtn;
    }
}