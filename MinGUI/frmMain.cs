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

//compile sdltest:
/* Usage: gcc [options] file...
Options:
  -pass-exit-codes         Exit with highest error code from a phase.
  --help                   Display this information.
  --target-help            Display target specific command line options.
  --help={common|optimizers|params|target|warnings|[^]{joined|separate|undocumented}}[,...].
                           Display specific types of command line options.
  (Use '-v --help' to display command line options of sub-processes).
  --version                Display compiler version information.
  -dumpspecs               Display all of the built in spec strings.
  -dumpversion             Display the version of the compiler.
  -dumpmachine             Display the compiler's target processor.
  -print-search-dirs       Display the directories in the compiler's search path.
  -print-libgcc-file-name  Display the name of the compiler's companion library.
  -print-file-name=<lib>   Display the full path to library <lib>.
  -print-prog-name=<prog>  Display the full path to compiler component <prog>.
  -print-multiarch         Display the target's normalized GNU triplet, used as
                           a component in the library path.
  -print-multi-directory   Display the root directory for versions of libgcc.
  -print-multi-lib         Display the mapping between command line options and
                           multiple library search directories.
  -print-multi-os-directory Display the relative path to OS libraries.
  -print-sysroot           Display the target libraries directory.
  -print-sysroot-headers-suffix Display the sysroot suffix used to find headers.
  -Wa,<options>            Pass comma-separated <options> on to the assembler.
  -Wp,<options>            Pass comma-separated <options> on to the preprocessor.
  -Wl,<options>            Pass comma-separated <options> on to the linker.
  -Xassembler <arg>        Pass <arg> on to the assembler.
  -Xpreprocessor <arg>     Pass <arg> on to the preprocessor.
  -Xlinker <arg>           Pass <arg> on to the linker.
  -save-temps              Do not delete intermediate files.
  -save-temps=<arg>        Do not delete intermediate files.
  -no-canonical-prefixes   Do not canonicalize paths when building relative
                           prefixes to other gcc components.
  -pipe                    Use pipes rather than intermediate files.
  -time                    Time the execution of each subprocess.
  -specs=<file>            Override built-in specs with the contents of <file>.
  -std=<standard>          Assume that the input sources are for <standard>.
  --sysroot=<directory>    Use <directory> as the root directory for headers
                           and libraries.
  -B <directory>           Add <directory> to the compiler's search paths.
  -v                       Display the programs invoked by the compiler.
  -###                     Like -v but options quoted and commands not executed.
  -E                       Preprocess only; do not compile, assemble or link.
  -S                       Compile only; do not assemble or link.
  -c                       Compile and assemble, but do not link.
  -o <file>                Place the output into <file>.
  -pie                     Create a position independent executable.
  -shared                  Create a shared library.
  -x <language>            Specify the language of the following input files.
                           Permissible languages include: c c++ assembler none
                           'none' means revert to the default behavior of
                           guessing the language based on the file's extension.

Options starting with -g, -f, -m, -O, -W, or --param are automatically
 passed on to the various sub-processes invoked by gcc.  In order to pass
 other options on to these processes the -W<letter> options must be used.
*/

namespace MinGUI
{
    public partial class frmMain : Form
    {
        public class lib
        {
            public int libID { get; set; }
            public string libName { get; set; }
            public string libSyntax { get; set; }
            public bool libState { get; set; }
        }

        frmAddLib addLib = new frmAddLib();
        Process cmd = new Process();        
        ProcessStartInfo cmdInfo = new ProcessStartInfo();
        SQLiteConnection conn = new SQLiteConnection("Data Source=mingui.db; Version=3;");
        
        string path;
        string name;
        string compiler;
        string compile;
        string cmdStr;
        string temp;
        int i;

        List<lib> libs = new List<lib>();
        string libList = "";

        public frmMain()
        {
            InitializeComponent();
        }

        public void refreshLibs()
        {
            SQLiteCommand Records = new SQLiteCommand("SELECT * FROM Libraries", conn);
            SQLiteDataReader readRecords = Records.ExecuteReader();
            while (readRecords.Read())
            {
                flpChkBxLib.Controls.Add(EventToCB(new CheckBox
                {
                    Text = readRecords[1].ToString(),
                    Tag = readRecords[0].ToString(),
                    Anchor = AnchorStyles.Left & AnchorStyles.Right,
                }));
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            conn.Open();
            SQLiteCommand createLibraries = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `Libraries` (`libID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `libName` TEXT NOT NULL, `libSyntax`	TEXT NOT NULL); ", conn);
            createLibraries.ExecuteNonQuery();
            refreshLibs();
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtbxFilePath.Text.Replace("\\", "\\\\")) || string.IsNullOrWhiteSpace(txtbxFileName.Text) || txtbxFileName.Text == "Program Name" || string.IsNullOrWhiteSpace(cbCompiler.Text))
            {
                lblOutput.Text = "One of the inputs is either incorrect or empty";
                return;
            }
            //gcc -o test.exe "C++\SDLTest.cpp" -lmingw32 -lSDL2main -lSDL2
            compiler = cbCompiler.Text + " ";
            compile = pnlCompile.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString() + " ";
            name = "\"" + txtbxFileName.Text + "\" ";
            path = "\"" + txtbxFilePath.Text + "\" ";
            foreach (lib lib in libs.Where(x => x.libState == true))
            {
                libList += lib.libSyntax + " ".ToString();
            }
            lblOutput.Text = "All required information is present, making command...";
            cmdInfo.FileName = "cmd.exe";
            cmdInfo.Arguments = "/C " + compiler + compile + name + path + libList;
            cmd.StartInfo = cmdInfo;
            lblOutput.Text += "\nCommand is: " + cmdInfo.Arguments.ToString() + "\nCommand made, executing...";
            cmd.Start();
        }

        public CheckBox EventToCB(CheckBox cb)
        {
            SQLiteCommand getLib = new SQLiteCommand("SELECT * FROM Libraries WHERE libID = \"" + cb.Tag.ToString() + "\";", conn);
            SQLiteDataReader readGetLib = getLib.ExecuteReader();
            while (readGetLib.Read())
            {
                libs.Add(new lib { libID = Int32.Parse(readGetLib[0].ToString()), libName = readGetLib[1].ToString(), libSyntax = readGetLib[2].ToString(), libState = false });
            }
            void method()
            {
                if (cb.Checked)
                {
                    i = libs.FindIndex(x => x.libSyntax.Equals(cb.Tag.ToString()));
                    libs[i].libState = true;

                }
                else if (!cb.Checked)
                {
                    i = libs.FindIndex(x => x.libSyntax.Equals(cb.Tag.ToString()));
                    libs[i].libState = false;
                }
                else
                {
                    MessageBox.Show("Somethings screwed, please submit a bug report at www.github.co.uk/Rossosaurus/MinGUI.");
                }

            }
            cb.CheckedChanged += (s, e) => method();
            cb.ContextMenuStrip = cmsLib;
            return cb;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp = cmsLib.SourceControl.Tag.ToString();
            SQLiteCommand nonQuery = new SQLiteCommand("DELETE FROM Libraries WHERE libID = " + temp + ";", conn);
            nonQuery.ExecuteNonQuery();
            flpChkBxLib.Controls.Clear();
            refreshLibs();
        }

        private void tRefresh_Tick(object sender, EventArgs e)
        {
            List<lib> newLibs = new List<lib>();
            SQLiteCommand getLibs = new SQLiteCommand("SELECT * FROM Libraries", conn);
            SQLiteDataReader readGetLibs = getLibs.ExecuteReader();
            while (readGetLibs.Read())
            {
                int y = libs.FindIndex(x => x.libID == Int32.Parse(readGetLibs[0].ToString()));
                if (y >= 0) { }
                else
                {
                    flpChkBxLib.Controls.Add(EventToCB(new CheckBox
                    {
                        Text = readGetLibs[1].ToString(),
                        Tag = readGetLibs[0].ToString(),
                        Anchor = AnchorStyles.Left & AnchorStyles.Right,
                    }));
                }
            }
        
        }

        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdName.ShowDialog();
            txtbxFileName.Text = sfdName.FileName;
        }
    }
}
