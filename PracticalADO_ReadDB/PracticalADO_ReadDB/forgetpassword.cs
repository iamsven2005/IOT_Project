using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BCrypt.Net;
namespace PracticalADO_ReadDB
{
    public partial class forgetpassword : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        public forgetpassword()
        {
            InitializeComponent();
        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {

        }

        private void forgetpassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, Contact, Address FROM MyUser WHERE Name=@uname";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uname", Username.Text);
            try
            {
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string Contacts = reader["Contact"].ToString();
                    string Addresss = reader["Address"].ToString();
                    string tbContact = Contact.Text;
                    string tbAddress = Address.Text;
                    if (tbContact == Contacts && tbAddress == Addresss)
                    {
                        myConnect.Close();
                        reader.Close();
                        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_+={}[]|;:";
                        Random random = new Random();
                        char[] passwordChars = new char[8];
                        for (int i = 0; i < 8; i++)
                        {
                            passwordChars[i] = characters[random.Next(characters.Length)];
                        }
                        string Password = new string(passwordChars);
                        string Hash = BCrypt.Net.BCrypt.HashPassword(Password);
                        string strCommandText2 = "UPDATE MyUser SET Password=@NewPassword";
                        SqlCommand updateCmd = new SqlCommand(strCommandText2, myConnect);
                        updateCmd.Parameters.AddWithValue("@NewPassword", Hash);
                        myConnect.Open();
                        int result = updateCmd.ExecuteNonQuery();
                        myConnect.Close();
                        MessageBox.Show($"Succcess: Your New Password is {Password}");
                        string dataToPass = Username.Text;
                        User f2 = new User(dataToPass);
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Details");
                    }
                }
                else
                {
                    MessageBox.Show("Fail: Please Try Again");
                }
                
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

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
