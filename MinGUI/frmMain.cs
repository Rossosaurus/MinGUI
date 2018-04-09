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

//gcc -o test.exe "C++\SDLTest.cpp" -lmingw32 -lSDL2main -lSDL2

namespace MinGUI
{
    public partial class frmMain : Form
    {
        frmAddLib addLib = new frmAddLib();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("mingui.db");
            SQLiteConnection conn = new SQLiteConnection("Data Source=mingui.db; Version=3;");
            conn.Open();
            SQLiteCommand createLibraries = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Libraries(libID INT AUTO_INCREMENT NOT NULL, libSyntax VARCHAR(255) NOT NULL)", conn);
            createLibraries.ExecuteNonQuery();
        }

        private void btnAddLib_Click(object sender, EventArgs e)
        {
            addLib.Show();
        }
    }
}
