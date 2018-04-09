using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinGUI
{
    public partial class frmAddLib : Form
    {
        public frmAddLib()
        {
            InitializeComponent();
        }

        private void frmAddLib_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
