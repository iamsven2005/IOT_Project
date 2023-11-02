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

    public partial class GetNumber : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;

        public GetNumber()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbUsernmae_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetContact_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Contact FROM MyUser ";
            strCommandText += "WHERE Name=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", tbUsername.Text);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbContact.Text = reader["Contact"].ToString();
            }
            else
            {
                MessageBox.Show("error");
            }

        }
    }
}
