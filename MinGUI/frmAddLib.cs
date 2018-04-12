using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MinGUI
{
    public partial class frmAddLib : Form
    {
        bool oops = true;
        bool mingw = false;
        SQLiteConnection conn = new SQLiteConnection("Data Source = mingui.db; Version=3;");
        Process proc = new Process();
        ProcessStartInfo procInfo = new ProcessStartInfo();

        public frmAddLib()
        {
            InitializeComponent();
        }

        private void frmAddLib_Load(object sender, EventArgs e)
        {
            conn.Open();
            procInfo.WindowStyle = ProcessWindowStyle.Normal;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            mingw = true;
            procInfo.FileName = "MinGW\\bin\\mingw-get.exe";
            proc.StartInfo = procInfo;
            proc.Start();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if ((txtbxName.Text != "" && txtbxSyntax.Text != "") && (txtbxSyntaxGW.Text == "" && txtbxNameGW.Text == ""))
            {
                oops = false;
                if (txtbxBin.Text != "" && txtbxInc.Text != "" && txtbxLib.Text != "")
                {
                    if (Directory.Exists(txtbxBin.Text) && Directory.Exists(txtbxInc.Text) && Directory.Exists(txtbxLib.Text))
                    {
                        lblManOut.Text = "All folders exist\n \n";
                        procInfo.FileName = "cmd.exe";
                        string mvBinIncLib = "/C xcopy /Y /S \"" + txtbxBin.Text + "\" MinGW\\bin && " +
                            "echo Bin folder successfully moved & xcopy /Y /S \"" + txtbxInc.Text + "\" MinGW\\include && " +
                            "echo Include folder successfully moved & xcopy /Y /S \"" + txtbxLib.Text + "\" MinGW\\lib && " +
                            "echo Lib folder successfully moved && echo. && " + 
                            "echo All folders successfully moved";
                        procInfo.Arguments = mvBinIncLib;
                        procInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        proc.StartInfo = procInfo;
                        proc.Start();
                        lblManOut.Text += "All files successfully moved";
                        SQLiteCommand appendLib = new SQLiteCommand("INSERT INTO Libraries (libName, libSyntax) VALUES (\"" + txtbxName.Text + "\", \"" + txtbxSyntax.Text + "\");", conn);
                        appendLib.ExecuteNonQuery();
                        lblManOut.Text += "\n \n Entry in DB successfully Added";
                        lblManOut.Text += "\n \n Success!";
                    }
                    else
                    {
                        lblManOut.Text = "Check performed to ensure library exists returned false:\n    Bin: " + (Directory.Exists(txtbxBin.Text) + "\n    Include: " + Directory.Exists(txtbxInc.Text) + "\n    Lib: " + Directory.Exists(txtbxLib.Text));
                    }
                }
                else if (txtbxBin.Text == "" || txtbxInc.Text == "" || txtbxLib.Text == "")
                {
                    lblManOut.Text = "One of the directories required is empty";
                }
                else if (txtbxBin.Text == "" && txtbxInc.Text == "" && txtbxLib.Text == "")
                {
                    SQLiteCommand appendLib = new SQLiteCommand("INSERT INTO Libraries (libName, libSyntax) VALUES (\"" + txtbxName.Text + "\", \"" + txtbxSyntax.Text + "\");", conn);
                    appendLib.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Something's fucked");
                }

            }
            if ((txtbxSyntaxGW.Text != "" && txtbxNameGW.Text != "") && !(txtbxName.Text != "" && txtbxSyntax.Text != "" && txtbxLib.Text != "" && txtbxBin.Text != "" && txtbxInc.Text != ""))
            {
                oops = false;
                if (mingw)
                {
                    SQLiteCommand addLib = new SQLiteCommand("INSERT INTO Libraries(libName, libSyntax) VALUES (\"" + txtbxNameGW.Text + "\", \"" + txtbxSyntaxGW.Text + "\");", conn);
                    addLib.ExecuteNonQuery();
                    lblMingwOut.Text = "Library successfully added to the database";
                }
                else
                {
                    MessageBox.Show("You need to click on the MinGW button first and install a library before you add this library. If you are simply trying to add a library fill in the file name and syntax inputs on the left.");

                }
            }
            if (oops)
            {
                MessageBox.Show("Somthing went wrong, either you didn't fill in any inputs or didn't fill enough inputs or somethings screwed. If it's the latter and this error persists please post a bug on github.com/Rossosaurus/MinGUi");
            }
        }

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fbdSelect.ShowDialog();
            cmsSelect.SourceControl.Text = fbdSelect.SelectedPath;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmsSelect.SourceControl.Text = "";
        }
    }
}
