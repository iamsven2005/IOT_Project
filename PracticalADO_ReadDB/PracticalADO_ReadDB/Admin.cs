﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using System.Data.SqlClient;
using BCrypt.Net;
using System.Net;
using System.Net.Mail;

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
            loadDataTemp();
            loadDataMoisture();
            loadMessages();
            session.Text = "Admin";
        }
        private void adminsend_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText =
                "INSERT Messages (ID, Messager, Message, Time) " +
               " VALUES (@ID, @User, @Message, @Time)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@Message", adminmsg.Text);
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

        private void loadDataTemp()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select Top 20 * from Temperature Order By DateTime Desc";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("DataSet [0] Rows = " + ds.Tables[0].Rows.Count);
                Temperature.DataSource = ds;
                Temperature.Series[0].XValueMember = "DateTime";
                Temperature.Series[0].YValueMembers = "Temp";
                Temperature.DataBind();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
            finally
            {
                myConnect.Close();
            }
        }
        private void loadDataMoisture()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select Top 20 * from MoistureTable Order By DateTime Desc";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("DataSet [0] Rows = " + ds.Tables[0].Rows.Count);
                Moisture.DataSource = ds;
                Moisture.Series[0].XValueMember = "Datetime";
                Moisture.Series[0].YValueMembers = "Moisture";
                Moisture.DataBind();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
            finally
            {
                myConnect.Close();
            }
        }

        private Color getColor(int r, int g, int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }
        private DateTime getDateTime(int year, int month, int day, int hour, int min, int sec)
        {
            DateTime dt = new DateTime(year, month, day, hour, min, sec);
            return dt;
        }
        private void setXAxisDisplayRange(Chart cht, DateTime dtStart, DateTime dtEnd)
        {
            DateTime minDate = dtStart.AddSeconds(-1);
            DateTime maxDate = dtEnd;
            cht.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            cht.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            cht.Series[0].IsXValueIndexed = false;
        }
        private void initChartPropertiesTemperature()
        {
            Temperature.BackColor = getColor(243, 223, 193);
            Temperature.BackGradientStyle = GradientStyle.TopBottom;
            Temperature.BorderlineColor = getColor(181, 64, 1);
            Temperature.BorderlineDashStyle = ChartDashStyle.Solid;
            Temperature.BorderlineWidth = 2;
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Text = "Time Base Chart";
            Temperature.Titles.Add(title1);
            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            Legend legend1 = Temperature.Legends[0];
            legend1.BackColor = Color.Transparent;
            legend1.Enabled = true;
            legend1.Font = labelFont;
            Color colorGridLines = getColor(64, 64, 64, 64);
            ChartArea chartArea1 = Temperature.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.Interval = 1;
            DateTime minDate = getDateTime(2016, 10, 12, 15, 0, 0);
            DateTime maxDate = getDateTime(2016, 10, 12, 15, 10, 0);
            setXAxisDisplayRange(Temperature, minDate, maxDate);
            chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm";
            chartArea1.AxisY.LabelStyle.Font = labelFont;
            chartArea1.AxisY.LineColor = colorGridLines;
            chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisY.Interval = 10;
            chartArea1.AxisY.IsStartedFromZero = true;
            Series series1 = Temperature.Series[0];
            series1.Name = "Temp";
            Color lineColor = getColor(26, 59, 105, 180);
            series1.BorderColor = lineColor;
            series1.ChartType = SeriesChartType.Spline;
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Double;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 6;
            series1.MarkerBorderColor = lineColor;
            series1.MarkerColor = lineColor;
            series1.ToolTip = "Timestamp : #VALX{d MM yyyy H:mm:ss} , Value : #VAL";
        }
        private void initChartPropertiesMoisture()
        {
            Moisture.BackColor = getColor(243, 223, 193);
            Moisture.BackGradientStyle = GradientStyle.TopBottom;
            Moisture.BorderlineColor = getColor(181, 64, 1);
            Moisture.BorderlineDashStyle = ChartDashStyle.Solid;
            Moisture.BorderlineWidth = 2;
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Text = "Time Base Chart";
            Moisture.Titles.Add(title1);
            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            Legend legend1 = Moisture.Legends[0];
            legend1.BackColor = Color.Transparent;
            legend1.Enabled = true;
            legend1.Font = labelFont;
            Color colorGridLines = getColor(64, 64, 64, 64);
            ChartArea chartArea1 = Moisture.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.Interval = 1;
            DateTime minDate = getDateTime(2016, 10, 12, 15, 0, 0);
            DateTime maxDate = getDateTime(2016, 10, 12, 15, 10, 0);
            setXAxisDisplayRange(Moisture, minDate, maxDate);
            chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm";
            chartArea1.AxisY.LabelStyle.Font = labelFont;
            chartArea1.AxisY.LineColor = colorGridLines;
            chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisY.Interval = 10;
            chartArea1.AxisY.IsStartedFromZero = true;
            Series series1 = Moisture.Series[0];
            series1.Name = "Temp";
            Color lineColor = getColor(26, 59, 105, 180);
            series1.BorderColor = lineColor;
            series1.ChartType = SeriesChartType.Spline;
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Double;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 6;
            series1.MarkerBorderColor = lineColor;
            series1.MarkerColor = lineColor;
            series1.ToolTip = "Timestamp : #VALX{d MM yyyy H:mm:ss} , Value : #VAL";
        }
        private void Charts_Load(object sender, EventArgs e)
        {
            initChartPropertiesTemperature();
            initChartPropertiesMoisture();
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
            string strCommandText = "SELECT Contact, MFAValue FROM MyUser ";
            strCommandText += "WHERE Name=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", ContactUsername.Text);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ContactResult.Text = reader["Contact"].ToString();
                MFA2.Text = reader["MFAValue"].ToString();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT MyUser (Name, UniqueRFID, NRIC, Address, Contact, Password, MFAValue)" + " VALUES (@NewName, @NewRFID, @NewNRIC, @NewAdd, @NewContact, @NewPwd, @MFA)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@NewName", tbName.Text);
            updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID.Text);
            updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC.Text);
            updateCmd.Parameters.AddWithValue("@NewAdd", tbAdd.Text);
            updateCmd.Parameters.AddWithValue("@NewContact", tbContact.Text);
            updateCmd.Parameters.AddWithValue("@NewPwd", BCrypt.Net.BCrypt.HashPassword(tbPwd.Text));
            updateCmd.Parameters.AddWithValue("@MFA", "Hello");
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
            string strCommandText = "UPDATE MyUser SET Name=@NewName, UniqueRFID=@NewRFID, NRIC=@NewNRIC, Address=@NewAdd, Contact=@NewContact, DOB=@NewDOB, CountryOfBirth=@NewCountry, MFAValue=@MFA, Password=@NewPassword WHERE UniqueUserID=@UserID";
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
            updateCmd.Parameters.AddWithValue("@MFA", MFA.Text);
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            return result;
        }
        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }
        private float extractFloatValue(string strData, string ID)
        {
            return (float.Parse(extractStringValue(strData, ID)));
        }
        private int extractIntValue(string strData, string ID)
        {
            return (int.Parse(extractStringValue(strData, ID)));
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
        private void handleTempValue(string strData, string strTime, string ID)
        {
            string strlightValue = extractStringValue(strData, ID);
            Console.WriteLine(strlightValue);
            lightValueTB.Text = strlightValue;
            Console.WriteLine(strData);
            float fLightValue = extractFloatValue(strData, ID);
            string status = "";
            lblTemp.Text = status;
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

            if (strData.IndexOf("Temp=") != -1)
            {
                handleTempSensorData(strData, strTime, "Temp=");
            }

            if (strData.IndexOf("Moisture=") != -1)
            {
                handleMoistureSensorData(strData, strTime, "Moisture=");
            }
            if (strData.IndexOf("Voltage=") != -1)
            {
                handleVoltageData(strData, strTime, "Voltage=");
            }
            if (strData.IndexOf("Motion=") != -1)
            {
                handleMotionData(strData, strTime, "Motion=");
            }
            if (strData.IndexOf("Distance=") != -1)
            {
                handleUltrasonicData(strData, strTime, "Distance=");
            }
        }

        private void handleTempSensorData(string strData, string strTime, string ID)
        {
            float floatValue = extractFloatValue(strData, ID);
            string strValue = extractStringValue(strData, ID);
            lblTemp.Text = strValue;
            saveTempSensorDataToDB(strTime, floatValue);
            if (floatValue > 25)
            {
                lblTemp.ForeColor = Color.Red;
            }
            else if (floatValue > 22 && floatValue < 25)
            {
                lblTemp.ForeColor = Color.Yellow;
            }
            else
            {
                lblTemp.ForeColor = Color.Green;
            }
        }

        private void handleMoistureSensorData(string strData, string strTime, string ID)
        {
            string strValue = extractStringValue(strData, ID);
            int intMoistureVal = extractIntValue(strData, ID);
            saveMoistureSensorDataToDB(strTime, intMoistureVal);
            if (intMoistureVal > 500)
            {
                lblMoisture.ForeColor = Color.Red;

            }
            else if (intMoistureVal > 100 && intMoistureVal < 500)
            {
                lblMoisture.ForeColor = Color.Yellow;
            }
            else
            {
                lblMoisture.ForeColor = Color.Green;
            }
            Console.WriteLine(strValue);
            lblMoisture.Text = strValue;
        }

        private void handleMotionData(string strData, string strTime, string ID)
        {
            string strValue = extractStringValue(strData, ID);
            saveMotionSensorDataToDB(strTime, strValue);
            if (strValue == "Motion detected")
            {
                motionLbl.Text = "Yes";
                motionLbl.ForeColor = Color.Red;
            }
            else
            {
                motionLbl.Text = "No";
                motionLbl.ForeColor = Color.Green;
            }
        }

        private void handleVoltageData(string strData, string strTime, string ID)
        {
            string strValue = extractStringValue(strData, ID);
            float intVoltageVal = extractFloatValue(strData, ID);

            if (intVoltageVal >= 0.3)
            {
                doorLbl.Text = "Open";
                doorLbl.ForeColor = Color.Red;
            }
            else
            {
                doorLbl.Text = "Closed";
                doorLbl.ForeColor = Color.Green;
            }

        }

        private void handleUltrasonicData(string strData, string strTime, string ID)
        {
            string strValue = extractStringValue(strData, ID);
            float UltraSonicVal = extractFloatValue(strData, ID);
            lblUltrasonic.Text = strValue;
        }

        private void saveTempSensorDataToDB(string strTime, float strTempValue)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText =
                "INSERT Temperature (DateTime, Temp) " +
               " VALUES (@time, @temp)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@temp", strTempValue);
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
        }

        private void saveMoistureSensorDataToDB(string strTime, int strMoistureValue)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String strCommandText =
                "INSERT MoistureTable (DateTime, Moisture) " +
               " VALUES (@time, @moisture)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@moisture", strMoistureValue);
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();

            myConnect.Close();
        }

        private void saveMotionSensorDataToDB(string strTime, string strMotionValue)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText =
                "INSERT MotionTable (strTime, motionDetected) " +
               " VALUES (@time, @motion)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@motion", strMotionValue);
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
        }

        private void handleRfidSensorData(string strData, string strTime, string ID)
        {
            string strValue = extractStringValue(strData, ID);
            Console.WriteLine(strValue);
            tbRFID.Text = strValue;
        }
        public void handleSensorData(String strData)
        {
            Console.WriteLine(strData);
            string dt = DateTime.Now.ToString("s");
            extractSensorData(strData, dt);
            string strMessage = dt + ":" + strData;
            syslogLB.Items.Insert(0, strMessage);

        }
        public void processDataReceive(String strData)
        {
            myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
            Messages.Invoke(d, new object[] { strData });
        }
        private void scanCardBtn_Click(object sender, EventArgs e)
        {
            dataComms.sendData("SCANRFID");
        }
        private void stopScanBtn_Click(object sender, EventArgs e)
        {
            dataComms.sendData("STOPRFID");
        }
        private void sendLight_Click(object sender, EventArgs e)
        {
            dataComms.sendData("SENDLIGHT");
        }


        private void lblMoisture_TextChanged(object sender, EventArgs e)
        {
            loadDataTemp();
            loadDataMoisture();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
