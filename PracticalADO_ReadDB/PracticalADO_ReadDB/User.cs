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

        }
    }
}
