﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BCrypt.Net;

namespace PracticalADO_ReadDB
{
    public partial class frmLogin : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, Password FROM MyUser WHERE Name=@uname";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uname", tbUserName.Text);

            try
            {
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string hashedPasswordFromDB = reader["Password"].ToString();

                    // Verify the entered password during login
                    string enteredPassword = tbPassword.Text; // Replace with the actual user-entered password

                    if (BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPasswordFromDB))
                    {
                        MessageBox.Show($"Succcess: Welcome {tbUserName.Text}");

                        if (tbUserName.Text == "Admin")
                        {
                            string dataToPass = tbUserName.Text;
                            Admin f2 = new Admin(dataToPass);
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            string dataToPass = tbUserName.Text;
                            User f2 = new User(dataToPass);
                            f2.Show();
                            this.Hide();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");

                    }
                }
                else
                {
                    MessageBox.Show("Fail: Please Try Again");
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                myConnect.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            frmUsers f3 = new frmUsers();
            //frmForget f3 = new frmForget();
            f3.Show();
            this.Hide();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Test files for references (please delete before submitting)

        private void test3_Click(object sender, EventArgs e)
        {
            Charts f5 = new Charts();
            f5.Show();
            this.Hide();
        }
        private void AdminLogin_Click(object sender, EventArgs e)
        {
            string dataToPass = "Admin";
            Admin f2 = new Admin(dataToPass);
            f2.Show();
            this.Hide();
        }
        private void Title_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {


        }

        private void Title_ParentChanged(object sender, EventArgs e)
        {
            Title.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
        }

        private void ForgetPwd_Click(object sender, EventArgs e)
        {
            forgetpassword f5 = new forgetpassword();
            //this leads to the email page frmForget leads to the MFA page
            f5.Show();
            this.Hide();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
                int width = (this.Width / 50);
                int height = ((this.Height / 25)/2);
                if (width == 0 || height == 0)
            {

            }
            else
            {
                Title.Font = new System.Drawing.Font("Arial Rounded MT", width, System.Drawing.FontStyle.Bold);
                this.Font = new System.Drawing.Font("Arial Rounded MT", height, System.Drawing.FontStyle.Regular);
                tbPassword.Height = this.Height * 2;
                tbUserName.Height = this.Height * 2;
            }


        }


    }
}
