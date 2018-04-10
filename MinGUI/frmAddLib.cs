using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MinGUI
{
    public partial class frmAddLib : Form
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source = mingui.db; Version=3;");
        public frmAddLib()
        {
            InitializeComponent();
        }

        private void frmAddLib_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (((txtbxName.Text != "" && txtbxSyntax.Text != "") || (txtbxBin.Text != "" || txtbxInc.Text != "" || txtbxLib.Text != "")) && txtbxSyntaxGW.Text == "")
            {

            }
            else if (txtbxSyntaxGW.Text != "" && !(txtbxName.Text != "" && txtbxSyntax.Text != "" && txtbxLib.Text != "" && txtbxBin.Text != "" && txtbxInc.Text != ""))
            {

            }
            else
            {
                MessageBox.Show("Somthing went wrong, either you didn't fill in any inputs or somethings screwed. If it's the latter and this error persists please post a bug on github.com/Rossosaurus/MinGUi");
            }
        }
    }
}
