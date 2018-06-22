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
        SQLiteConnection conn = new SQLiteConnection("Data Source = mingui.db; Version=3;");
        Process proc = new Process();
        ProcessStartInfo procInfo = new ProcessStartInfo() { FileName = "cmd.exe", WindowStyle = ProcessWindowStyle.Minimized };

        public frmAddLib()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(frmAddLib_Close);
        }

        private void frmAddLib_Load(object sender, EventArgs e)
        {
            conn.Open();
            procInfo.WindowStyle = ProcessWindowStyle.Normal;
            this.Focus();
        }

        private void frmAddLib_Close(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBin.Text) && !string.IsNullOrWhiteSpace(tbInclude.Text) && !string.IsNullOrWhiteSpace(tbLib.Text) && !string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbSyntax.Text))
            {
                if (Directory.Exists(tbBin.Text.Replace("\\", "\\\\")) && Directory.Exists(tbInclude.Text.Replace("\\", "\\\\")) && Directory.Exists(tbLib.Text.Replace("\\", "\\\\")))
                {
                    rtbOut.Text += "Directories specified exists \n";
                    procInfo.Arguments = "/C xcopy /e /y \"" + tbBin.Text.Replace("\\", "\\\\") + "MinGW\\";
                    proc.StartInfo = procInfo;
                    rtbOut.Text += "Bin folder copied\n";
                    procInfo.Arguments = "/C xcopy /e /y \"" + tbInclude.Text.Replace("\\", "\\\\") + "MinGW\\";
                    proc.StartInfo = procInfo;
                    rtbOut.Text += "Include folder copied\n";
                    procInfo.Arguments = "/C xcopy /e /y \"" + tbLib.Text.Replace("\\", "\\\\") + "MinGW\\";
                    proc.StartInfo = procInfo;
                    rtbOut.Text += "Lib folder copied\n";
                    SQLiteCommand appendLib = new SQLiteCommand("INSERT INTO Libraries(libName, libSyntax) VALUES (\"" + tbName.Text + "\", \"" + tbSyntax + "\");");
                    appendLib.ExecuteNonQuery();
                    rtbOut.Text += "Entry added to DB";

                }
            }
            else if (string.IsNullOrWhiteSpace(tbBin.Text) && string.IsNullOrWhiteSpace(tbInclude.Text) && string.IsNullOrWhiteSpace(tbLib.Text) && (!string.IsNullOrWhiteSpace(tbName.Text)) && (!string.IsNullOrWhiteSpace(tbSyntax.Text)))
            {
                SQLiteCommand appendLib = new SQLiteCommand("INSERT INTO Libraries(libName, libSyntax) VALUES (\"" + tbName.Text + "\", \"" + tbSyntax.Text + "\");", conn);
                appendLib.ExecuteNonQuery();
                rtbOut.Text = "Entry added to DB";
            }
            else { MessageBox.Show("Either All the inputs must be filled or ONLY the LAST 2 Inputs must be filled in order to add a library."); }
        }
    }
}
