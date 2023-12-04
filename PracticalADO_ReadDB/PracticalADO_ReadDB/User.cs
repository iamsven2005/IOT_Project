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
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {
            MessageBox.Show(receivedData);
        }

        private void submsg_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText =
                "INSERT Messages (ID, Messager, Message, Time) " +
               " VALUES (@ID, @User, @Message, @Time)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@Message", typemsg.Text);
            updateCmd.Parameters.AddWithValue("@ID", newGuid.ToString());
            updateCmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("s"));
            updateCmd.Parameters.AddWithValue("@User", session.Text);
            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            loadMessages();
        }
        private void loadMessages()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select Top 20 * from Messages Order By Time Desc";
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
    }
}
