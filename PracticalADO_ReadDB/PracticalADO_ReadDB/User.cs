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
        public User()
        {
            try
            {
                InitializeComponent();
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("New");
            }
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDBDataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.sampleDBDataSet.Messages);

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
    }
}
