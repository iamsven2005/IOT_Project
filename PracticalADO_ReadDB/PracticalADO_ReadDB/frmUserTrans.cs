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
    public partial class frmUserTrans : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        public frmUserTrans()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetUser_Click(object sender, EventArgs e)
        {
            bool blnfound = false;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, UniqueRFID, Contact FROM MyUser ";
            strCommandText += "WHERE UniqueUserID=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbName.Text = reader["Name"].ToString();
                tbRFID.Text = reader["UniqueRFID"].ToString();
                tbContact.Text = reader["Contact"].ToString();
                blnfound = true;
            }
            else

                MessageBox.Show("No Record Found...");
            reader.Close();
            myConnect.Close();
            if (blnfound)
                RetrieveTrans();
        }
        private void RetrieveTrans()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT UniqueActivityID, UniqueRFID, Activity, DateAndTime FROM MyTxn ";
            strCommandText += "WHERE UniqueRFID = @RFID";
            SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            adapter.SelectCommand.Parameters.AddWithValue("@RFID", tbRFID.Text);
            DataTable transTable = new DataTable();
            adapter.Fill(transTable);
            if (transTable.Rows.Count > 0)
                grdTrans.DataSource = transTable;
            else
                MessageBox.Show("Not Found");

        }
        private void grdTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRFID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblRFID_Click(object sender, EventArgs e)
        {

        }

        private void frmUserTrans_Load(object sender, EventArgs e)
        {

        }
        private void frmUserTrans_Closing(object sender, EventArgs e)
        {
            MessageBox.Show("Close");
        }
    }
}
