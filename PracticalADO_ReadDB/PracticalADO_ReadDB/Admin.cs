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

        public Admin(string data)
        {
            InitializeComponent();
            receivedData = data;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadUserRecords();
        }
        private void LoadUserRecords()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT UniqueUserID, Name, UniqueRFID, Address, Contact FROM MyUser";
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
            int width = (this.Width / 50);
            int height = ((this.Height / 25) / 2);
            if (width == 0 || height == 0)
            {

            }
            else
            {
                ContactTitle.Font = new System.Drawing.Font("Arial Rounded MT", width, System.Drawing.FontStyle.Bold);
                AddTitle.Font = new System.Drawing.Font("Arial Rounded MT", width, System.Drawing.FontStyle.Bold);
                this.Font = new System.Drawing.Font("Arial Rounded MT", height, System.Drawing.FontStyle.Regular);
                ContactResult.Height = this.Height * 2;
                ContactUsername.Height = this.Height * 2;
            }

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

    }
}
