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
    public partial class frmUsers : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetUserID_Click(object sender, EventArgs e)
        {
            GetUserDetails();
        }
        private void GetUserDetails()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, UniqueRFID, NRIC, Address, Contact FROM MyUser ";
            strCommandText += "WHERE UniqueUserID=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbName.Text = reader["Name"].ToString();
                tbRFID.Text = reader["UniqueRFID"].ToString();
                tbNRIC.Text = reader["NRIC"].ToString();
                tbAdd.Text = reader["Address"].ToString();
                tbContact.Text = reader["Contact"].ToString();

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
            string strCommandText = "UPDATE MyUser SET Name=@NewName, UniqueRFID=@NewRFID, NRIC=@NewNRIC, Address=@NewAdd, Contact=@NewContact WHERE UniqueUserID=@UserID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            updateCmd.Parameters.AddWithValue("@NewName", tbName.Text);
            updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID.Text);
            updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC.Text);
            updateCmd.Parameters.AddWithValue("@NewAdd", tbAdd.Text);
            updateCmd.Parameters.AddWithValue("@NewContact", tbContact.Text);
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
