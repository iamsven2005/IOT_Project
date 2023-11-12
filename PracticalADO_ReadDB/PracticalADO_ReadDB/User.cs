using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalADO_ReadDB
{
    public partial class User : Form
    {
        private string receivedData;
        //used for inter-form parsing
        public User(string data) //declared from function in login
        {
            InitializeComponent();
            receivedData = data;
            //used for inter-form parsing
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDBDataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.sampleDBDataSet.Messages);
            MessageBox.Show(receivedData);
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void User_Resize(object sender, EventArgs e)
        {
            int width = (this.Width / 50);
            int height = ((this.Height / 25) / 2);
            if (width == 0 || height == 0)
            {

            }
            else
            {
                //AddTitle.Font = new System.Drawing.Font("Arial Rounded MT", width, System.Drawing.FontStyle.Bold);
                this.Font = new System.Drawing.Font("Arial Rounded MT", height, System.Drawing.FontStyle.Regular);
                //this.TextBox.Height = this.Height * 2;
                //tbUserName.Height = this.Height * 2;
            }
        }
    }
}
