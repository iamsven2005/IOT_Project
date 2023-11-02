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
    public partial class frmUserMaintenance : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        DataTable UserTable = new DataTable();
        DataGridViewRow CurrentRow = null;
        SqlDataAdapter UserAdapter;

        public frmUserMaintenance()
        {
            InitializeComponent();
        }

        private void frmUserMaintenance_Load(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdUser_Click(object sender, EventArgs e)
        {
            CurrentRow = grdUser.CurrentRow;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
