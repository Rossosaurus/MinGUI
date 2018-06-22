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
    public partial class frmPreset : Form
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=mingui.db; Version=3;");

        public frmPreset()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            conn.Open();
            SQLiteCommand addPreset = new SQLiteCommand("INSERT INTO Presets(pName, pSyntax) VALUES (\"" + tbName.Text + "\", \"" + tbSyntax.Text + "\");", conn);
            addPreset.ExecuteNonQuery();
            MessageBox.Show("Preset successfully added.");
            this.Close();
        }
    }
}
