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
    public partial class frmForget : Form
    {
        public frmForget()
        {
            InitializeComponent();
        }

        private void frmForget_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
