using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;


namespace PracticalADO_ReadDB
{
    public partial class frmLogin : Form
    {
        public delegate void myprocessDataDelegate(String strData);
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string textBoxValue = MFATB.Text;
            if (string.IsNullOrEmpty(textBoxValue))
            {
                textBoxValue = null;
            }
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT * FROM MyUser WHERE Name=@uname";
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
                    string MFADB = reader["MFAValue"].ToString();
                    string enteredPassword = tbPassword.Text;
                    if (BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPasswordFromDB) && textBoxValue == MFADB)
                    {
                        MessageBox.Show($"Succcess: Welcome {tbUserName.Text}");
                        if (tbUserName.Text == "Admin")
                        {
                            string dataToPass = tbUserName.Text;
                            Admin f2 = new Admin(dataToPass);
                            f2.Show();
                            this.Hide();
                            string fromEmail = "iamsven2005@gmail.com";
                            string password = "gens kebu bstg kcqb";
                            string toEmail = "dexdreamin0416@gmail.com";
                            string smtpServer = "smtp.gmail.com";
                            MailMessage mail = new MailMessage(fromEmail, toEmail);
                            mail.Subject = "Login";
                            mail.Body = "Someone have logged in as admin";
                            mail.IsBodyHtml = false;
                            SmtpClient smtp = new SmtpClient(smtpServer);
                            smtp.Port = 587;
                            smtp.Credentials = new NetworkCredential(fromEmail, password);
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                        else
                        {
                            string dataToPass = tbUserName.Text;
                            User f2 = new User(dataToPass);
                            f2.Show();
                            this.Hide();
                            string Email = reader["Email"].ToString();
                            if (Email != "NULL")
                            {
                                string fromEmail = "iamsven2005@gmail.com";
                                string password = "gens kebu bstg kcqb";
                                string toEmail = Email;
                                string smtpServer = "smtp.gmail.com";
                                MailMessage mail = new MailMessage(fromEmail, toEmail);
                                mail.Subject = "Login";
                                mail.Body = "Hi, you have logged into your account.";
                                mail.IsBodyHtml = false;
                                SmtpClient smtp = new SmtpClient(smtpServer);
                                smtp.Port = 587;
                                smtp.Credentials = new NetworkCredential(fromEmail, password);
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                            else
                            {

                            }

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

        private void Title_ParentChanged(object sender, EventArgs e)
        {
            Title.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
        }

        private void ForgetPwd_Click(object sender, EventArgs e)
        {
            forgetpassword f5 = new forgetpassword();
            f5.Show();
            this.Hide();
        }
        private void AdminLogin_Click_1(object sender, EventArgs e)
        {
            string dataToPass = "Admin";
            Admin f2 = new Admin(dataToPass);
            f2.Show();
            this.Hide();


        }
    }
}
