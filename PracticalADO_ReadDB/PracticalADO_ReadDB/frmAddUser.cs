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
    public partial class frmAddUser : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
            updateCmd.Parameters.AddWithValue("@NewPwd", tbPwd.Text);
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
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
