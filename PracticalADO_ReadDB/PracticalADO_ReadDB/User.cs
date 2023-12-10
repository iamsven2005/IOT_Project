using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace PracticalADO_ReadDB
{
    public partial class User : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        private string receivedData;
        //Loader
        public User(string data)
        {
            InitializeComponent();
            receivedData = data;
            session.Text = data;
            loadMessages();
            loadUser();
            loadapproved();
        }
        //Close Application
        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Profile
        private void loadUser()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select * from MyUser Where Name = @Name";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@Name", receivedData);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            StringBuilder messagesBuilder = new StringBuilder();
            while (reader.Read())
            {

                Name.Text = "Name:" + reader["Name"].ToString();
                NRIC.Text = "NRIC:" + reader["NRIC"].ToString();
                Address.Text = "Address:" + reader["Address"].ToString();
                DOB.Text = "DOB:" + reader["DOB"].ToString();
                MFAvalue.Text = "MFA value:" + reader["MFAValue"].ToString();
                Contact.Text = "Contact:" + reader["Contact"].ToString();
                ID.Text = "UID:" + reader["UniqueUserID"].ToString();
                RFID.Text = "RFID:" + reader["UniqueRFID"].ToString();
                Country.Text = "Country:" + reader["CountryOfBirth"].ToString();
                Email.Text = "Email:" + reader["Email"].ToString();

            }
            Messages.Text = messagesBuilder.ToString();
            reader.Close();
            myConnect.Close();
        }
        //Messaging
        private void submsg_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText =
                "INSERT Messages (ID, Sender, Message, Time) " +
               " VALUES (@ID, @Sender, @Message, @Time)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@Message", typemsg.Text);
            updateCmd.Parameters.AddWithValue("@ID", newGuid.ToString());
            updateCmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("s"));
            updateCmd.Parameters.AddWithValue("@Sender", receivedData);
            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            loadMessages();
            typemsg.Text = "";
        }
        private void loadMessages()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select * from Messages Order By Time Desc";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            StringBuilder messagesBuilder = new StringBuilder();

            while (reader.Read())
            {
                string message = reader["Message"].ToString();
                string user = reader["Sender"].ToString();
                string time = reader["Time"].ToString();
                messagesBuilder.AppendLine($"{user} {message} {time}");
            }
            Messages.Text = messagesBuilder.ToString();
            reader.Close();
            myConnect.Close();
        }
        //Profile Change MFA value
        private void SubmitMFA_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "UPDATE MyUser SET MFAValue=@MFA WHERE Name=@Name";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@MFA", MFAtb.Text);
            updateCmd.Parameters.AddWithValue("@Name", receivedData);
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            loadUser();
            string fromEmail = "iamsven2005@gmail.com";
            string password = "gens kebu bstg kcqb";
            string emailAddress = Email.Text;
            string smtpServer = "smtp.gmail.com";
            MailMessage mail = new MailMessage(fromEmail, emailAddress);
            mail.Subject = "Security";
            mail.Body = $"MFA Value has been changed to {MFAtb.Text}";
            mail.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient(smtpServer);
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(fromEmail, password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
        //Booking Form
        private void Book_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText =
                "INSERT Booking (ID, Sender, Message, Time, Booking, Approval) " +
               " VALUES (@ID, @User, @Message, @Time, @Booking, @Approval)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@Message", Reason.Text);
            updateCmd.Parameters.AddWithValue("@ID", newGuid.ToString());
            updateCmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("s"));
            updateCmd.Parameters.AddWithValue("@Booking", Picker.Value);
            updateCmd.Parameters.AddWithValue("@User", receivedData);
            updateCmd.Parameters.AddWithValue("@Approval", "1");
            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            Reason.Text = "";
            Systems.Text = "Booking Done";
            Systems.ForeColor = Color.Green;
        }
        private void loadapproved()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select * from Booking WHERE Approval = '2' Order By Time Desc ";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            StringBuilder messagesBuilder = new StringBuilder();
            while (reader.Read())
            {
                string message = reader["Message"].ToString();
                string user = reader["Sender"].ToString();
                string time = reader["Booking"].ToString();
                string end = reader["End"].ToString();
                messagesBuilder.AppendLine($"User:\n{user} \n Reason Of Booking:\n{message}\n Time Of Booking \n {time} End Time:  {end}");
            }
            Queue.Text = messagesBuilder.ToString();
            Queue.ForeColor = Color.White;
            reader.Close();
            myConnect.Close();
        }
    }
}