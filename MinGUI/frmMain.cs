using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

//compile sdltest:
//gcc -o test.exe "C++\SDLTest.cpp" -lmingw32 -lSDL2main -lSDL2

namespace MinGUI
{
    public partial class frmMain : Form
    {
        frmAddLib addLib = new frmAddLib();
        Process cmd = new Process();        
        ProcessStartInfo cmdInfo = new ProcessStartInfo();
        SQLiteConnection conn = new SQLiteConnection("Data Source=mingui.db; Version=3;");

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("mingui.db");
            conn.Open();
            SQLiteCommand createLibraries = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Libraries(libID INT AUTOINCREMENT, libName VARCHAR(255) NOT NULL, libSyntax VARCHAR(255) NOT NULL)", conn);
            createLibraries.ExecuteNonQuery();
        }

        private void btnAddLib_Click(object sender, EventArgs e)
        {
            addLib.Show();
        }

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdSelectFile.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmsFile.SourceControl.Text = "";
        }

        private void ofdSelectFile_FileOk(object sender, CancelEventArgs e)
        {
            txtbxFilePath.Text = ofdSelectFile.FileName;
        }
    }
}
