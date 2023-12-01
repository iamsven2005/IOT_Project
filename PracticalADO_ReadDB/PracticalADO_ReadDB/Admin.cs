using System;
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
        private void loadDataTemp()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select * from Temperature'";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("DataSet Rows = " + ds.Tables[0].Rows.Count);
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
            String strCommandText = "Select * from MoistureTable'";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("DataSet Rows = " + ds.Tables[0].Rows.Count);
                Temperature.DataSource = ds;
                Temperature.Series[0].XValueMember = "DateTime";
                Temperature.Series[0].YValueMembers = "Moisture";
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
        private void btnLoadData2_Click(object sender, EventArgs e)
        {
            loadDataTemp();
            loadDataMoisture();
        }

        private Color getColor(int r, int g, int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }
        private DateTime getDateTime(int year, int month, int day, int hour, int min, int sec, int miliesecs = 0)
        {
            DateTime dt = new DateTime(year, month, day, hour, min, sec, miliesecs);
            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            return dt;
        }
        private void setXAxisDisplayRange(Chart cht, DateTime dtStart, DateTime dtEnd)
        {
            DateTime minDate = dtStart.AddSeconds(-1);
            DateTime maxDate = dtEnd;
            Console.WriteLine("Setting AxisX.Minimum =" + minDate.ToOADate());
            Console.WriteLine("Setting AxisX.Minimum =" + maxDate.ToOADate());
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
            updateCmd.Parameters.AddWithValue("@NewContact", tbContact.Text);
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

            if (strData.IndexOf("Temp=") != -1)
            {
                handleTempSensorData(strData, strTime, "Temp=");
            }

            if (strData.IndexOf("Moisture=") != -1)
            {
                handleMoistureSensorData(strData, strTime, "Moisture=");
            }
        }

        private void handleTempSensorData(string strData, string strTime, string ID)
        {
            float floatValue = extractFloatValue(strData, ID);
            string strValue = extractStringValue(strData, ID);
            lblTemp.Text = strValue;
            if (floatValue > 30)
            {
                lblTemp.ForeColor = Color.Red;
            }
            else if (floatValue > 28 && floatValue < 30)
            {
                lblTemp.ForeColor = Color.Yellow;
            }
            else
            {
                lblTemp.ForeColor = Color.Green;
            }
            saveTempSensorDataToDB(strTime, floatValue);
        }

        private void handleMoistureSensorData(string strData, string strTime, string ID)
        {
            string strValue = extractStringValue(strData, ID);
            int intMoistureVal = extractIntValue(strData, ID);

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
            saveMoistureSensorDataToDB(strTime, intMoistureVal);
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
        }

        public void processDataReceive(String strData)
        {
            myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
            textBox1.Invoke(d, new object[] { strData });
        }
        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void grdUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void stopLightBtn_Click(object sender, EventArgs e)
        {
            dataComms.sendData("STOPLIGHT");
        }
        private void CountryLbl_Click(object sender, EventArgs e)
        {

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

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void roomStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void Temperature_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_3(object sender, EventArgs e)
        {

        }

        private void label10_Click_4(object sender, EventArgs e)
        {

        }
        private void Admin_Resize(object sender, EventArgs e)
        {

        }

        private void splitContainer14_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
