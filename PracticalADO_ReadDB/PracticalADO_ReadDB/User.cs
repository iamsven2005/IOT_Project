using System;
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

namespace PracticalADO_ReadDB
{
    public partial class User : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        private string receivedData;
        public User(string data)
        {
            InitializeComponent();
            receivedData = data;
            session.Text = data;
            loadMessages();
            loadUser();
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
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
            }
            Messages.Text = messagesBuilder.ToString();
            reader.Close();
            myConnect.Close();
        }

        private void submsg_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText =
                "INSERT Messages (ID, User, Message, Time) " +
               " VALUES (@ID, @User, @Message, @Time)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@Message", typemsg.Text);
            updateCmd.Parameters.AddWithValue("@ID", newGuid.ToString());
            updateCmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("s"));
            updateCmd.Parameters.AddWithValue("@User", receivedData);
            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            loadMessages();
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
                string user = reader["Messager"].ToString();
                string time = reader["Time"].ToString();
                messagesBuilder.AppendLine($"{user} {message} {time}");
            }
            Messages.Text = messagesBuilder.ToString();
            reader.Close();
            myConnect.Close();
        }

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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void session_TextChanged(object sender, EventArgs e)
        {

        }

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
    }
}