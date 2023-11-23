using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;


namespace PracticalADO_ReadDB
{
    public partial class Admin : Form
    {
        private string receivedData;
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        DataTable UserTable = new DataTable();
        DataGridViewRow CurrentRow = null;
        SqlDataAdapter UserAdapter;

        DataComms dataComms;

        public delegate void myprocessDataDelegate(String strData);


        public Admin(string data)
        {
            InitializeComponent();
            receivedData = data;
        }


        public void commsDataReceive(string dataReceived)
        {
            processDataReceive(dataReceived);
        }

        public void commsSendError(string errMsg)
        {
            MessageBox.Show(errMsg);
            processDataReceive(errMsg);
        }


        private void InitComms()
        {
            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }

        private void saveLightSensorDataToDB(string strTime, string strlightValue, string strStatus)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String strCommandText =
                "INSERT MyLightSensor (TimeOccurred, SensorValue, SensorStatus) " +
               " VALUES (@time, @value, @status)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@value", strlightValue);
            updateCmd.Parameters.AddWithValue("@status", strStatus);

            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();

            myConnect.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadUserRecords();
            InitComms();
        }


        private void LoadUserRecords()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT UniqueUserID, Name, UniqueRFID, Address, Contact, Gender, DOB, CountryOfBirth, NRIC FROM MyUser";
            UserAdapter = new SqlDataAdapter(strCommandText, myConnect);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(UserAdapter);
            UserTable.Clear();
            UserAdapter.Fill(UserTable);
            if (UserTable.Rows.Count > 0)
                grdUser.DataSource = UserTable;
            grdUser.Columns["UniqueUserID"].DefaultCellStyle.BackColor = Color.FromArgb(227, 227, 227);
            grdUser.Columns["UniqueUserID"].ReadOnly = true;
            grdUser.Columns["UniqueRFID"].DefaultCellStyle.BackColor = Color.FromArgb(227, 227, 227);
            grdUser.Columns["UniqueRFID"].ReadOnly = true;


        }


        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void GetContact_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Contact FROM MyUser ";
            strCommandText += "WHERE Name=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", ContactUsername.Text);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ContactResult.Text = reader["Contact"].ToString();
            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void Admin_Resize(object sender, EventArgs e)
        {

        }

        private void splitContainer14_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //ghost (dont delete)
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT MyUser (Name, UniqueRFID, NRIC, Address, Contact, Password)" + " VALUES (@NewName, @NewRFID, @NewNRIC, @NewAdd, @NewContact, @NewPwd)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@NewName", tbName.Text);
            updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID.Text);
            updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC.Text);
            updateCmd.Parameters.AddWithValue("@NewAdd", tbAdd.Text);
            updateCmd.Parameters.AddWithValue("@NewContact", lblContact.Text);
            updateCmd.Parameters.AddWithValue("@NewPwd", BCrypt.Net.BCrypt.HashPassword(tbPwd.Text));
            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("New User Record Added Successfully!");
            }
            else
            {
                MessageBox.Show("New User Record Failed to Add");

            }
            myConnect.Close();


        }
        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdUser_Click(object sender, EventArgs e)
        {
            CurrentRow = grdUser.CurrentRow;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int modifiedRows = 0;
            DataTable UpdatedTable = UserTable.GetChanges();
            if (UpdatedTable != null)
            {
                modifiedRows = UserAdapter.Update(UpdatedTable);
                UserTable.AcceptChanges();

            }
            else
            {
                MessageBox.Show("There are " + modifiedRows + " records updated...");

            }
            if (modifiedRows > 0)
                MessageBox.Show("There are " + modifiedRows + " records updated...");
            LoadUserRecords();
        }
        private int DeleteTxnRecord(string strRFID)
        {
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "DELETE FROM MyTxn WHERE UniqueRFID = @UniqueRFID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@UniqueRFID", strRFID);
            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            return result;
        }
        private int DeleteUserRecord(string strRFID)
        {
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "DELETE FROM MyUser WHERE UniqueRFID = @UniqueRFID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@UniqueRFID", strRFID);
            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            return result;
            //here

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (CurrentRow == null)
                {
                    MessageBox.Show("No Row selected for delete");

                }
                else
                {
                    string strRFID = CurrentRow.Cells[2].Value + "";
                    string strUserName = CurrentRow.Cells[1].Value + "";
                    int NumberOfRecords = DeleteTxnRecord(strRFID);
                    if (DeleteUserRecord(strRFID) > 0)
                        MessageBox.Show("Username = " + strUserName + " along with " + NumberOfRecords + " transactions has been deleted");
                    else
                    {
                        MessageBox.Show("Delete Failed");

                    }
                    LoadUserRecords();
                }
            }

        }

        private void btnGetUserID_Click(object sender, EventArgs e)
        {
            GetUserDetails();
        }
        private void GetUserDetails()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, UniqueRFID, NRIC, Address, Contact, DOB, CountryOfBirth FROM MyUser ";
            strCommandText += "WHERE UniqueUserID=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbNameMd.Text = reader["Name"].ToString();
                tbRFIDMd.Text = reader["UniqueRFID"].ToString();
                tbNRICMd.Text = reader["NRIC"].ToString();
                tbAddMd.Text = reader["Address"].ToString();
                tbContactMd.Text = reader["Contact"].ToString();
                tbDOBMd.Text = reader["DOB"].ToString();
                tbCountryOfBirthMd.Text = reader["CountryOfBirth"].ToString();


            }
            else
                MessageBox.Show("No Record Found");
            reader.Close();
            myConnect.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ModifyUserRecord() > 0)
                MessageBox.Show("Modify Successful");
            else
                MessageBox.Show("Modify Fail");
        }
        private int ModifyUserRecord()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "UPDATE MyUser SET Name=@NewName, UniqueRFID=@NewRFID, NRIC=@NewNRIC, Address=@NewAdd, Contact=@NewContact, DOB=@NewDOB, CountryOfBirth=@NewCountry, Password=@NewPassword WHERE UniqueUserID=@UserID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            updateCmd.Parameters.AddWithValue("@NewName", tbNameMd.Text);
            updateCmd.Parameters.AddWithValue("@NewRFID", tbRFIDMd.Text);
            updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRICMd.Text);
            updateCmd.Parameters.AddWithValue("@NewAdd", tbAddMd.Text);
            updateCmd.Parameters.AddWithValue("@NewContact", tbContactMd.Text);
            updateCmd.Parameters.AddWithValue("@NewDOB", tbDOBMd.Text);
            updateCmd.Parameters.AddWithValue("@NewCountry", tbCountryOfBirthMd.Text);
            updateCmd.Parameters.AddWithValue("@NewPassword", BCrypt.Net.BCrypt.HashPassword(tbPasswordMd.Text));
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            return result;
        }

        private void CountryLbl_Click(object sender, EventArgs e)
        {

        }

        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }

       
    
        private float extractFloatValue(string strData, string ID)
        {
            // Console.WriteLine(float.Parse(extractStringValue(strData, ID)));
            return (float.Parse(extractStringValue(strData, ID)));
        }

        private void handleLightSensorData(string strData, string strTime, string ID)
        {
            string strlightValue = extractStringValue(strData, ID);
            Console.WriteLine(strlightValue);

            lightValueTB.Text = strlightValue;
            Console.WriteLine(strData);

            float fLightValue = extractFloatValue(strData, ID);

            string status = "";

            if (fLightValue <= 200)
            {
                status = "Dark";
            }
            else
            {
                status = "Bright";
            }
            roomStatus.Text = status;
            saveLightSensorDataToDB(strTime, strlightValue, status);




        }


        


        private void extractSensorData(string strData, string strTime)
        {
            if (strData.IndexOf("LIGHT=") != -1)
            {
                handleLightSensorData(strData, strTime, "LIGHT=");
            }

            if (strData.IndexOf("RFID=") != -1)
            {
                handleRfidSensorData(strData, strTime, "RFID=");
            }


        }


        //public void extractRfidData(String strData)
        //{
        //    string dt = DateTime.Now.ToString("s");
        //    if (strData.IndexOf("RFID=") != -1)
        //    {

        //        handleRfidSensorData(strData, dt, "RFID=");
        //    }
        //}

        private void handleRfidSensorData(string strData, string strTime, string ID)
        {
            string strValue = extractStringValue(strData, ID);
            Console.WriteLine(strValue);
            tbRFID.Text = strValue;

            // Console.WriteLine(strData);

            // float fLightValue = extractFloatValue(strData, ID);

            // string status = "";

            //tbRFID.Text = strData;

        }


        public void handleSensorData(String strData)
        {
            Console.WriteLine(strData);
            string dt = DateTime.Now.ToString("s");
            extractSensorData(strData, dt);

            string strMessage = dt + ":" + strData;

        }

        public void processDataReceive(String strData)
        {
            myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
            textBox1.Invoke(d, new object[] { strData });
        }

        

        private void scanCardBtn_Click(object sender, EventArgs e)
        {
            dataComms.sendData("SCANRFID");
        }

        private void stopScanBtn_Click(object sender, EventArgs e)
        {
            dataComms.sendData("STOPRFID");
        }

        private void tbRFID_TextChanged(object sender, EventArgs e)
        {

        }

        

   
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lightValueTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendLight_Click(object sender, EventArgs e)
        {
            dataComms.sendData("SENDLIGHT");
        }

        private void stopLightBtn_Click(object sender, EventArgs e)
        {
            dataComms.sendData("STOPLIGHT");
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void roomStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
