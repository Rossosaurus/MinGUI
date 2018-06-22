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
                           guessing the language based on the file's extension.*/

    public partial class frmMainNew : Form
    {
        Process cmd = new Process();
        ProcessStartInfo cmdInfo = new ProcessStartInfo();
        SQLiteConnection conn = new SQLiteConnection("Data Source=mingui.db; Version=3;");

        string path;
        string name;
        string compiler;
        string compile;
        string temp;
        int i;
        bool error = false;
        bool libChecked = true;

        public class lib
        {
            public int libID { get; set; }
            public string libName { get; set; }
            public string libSyntax { get; set; }
            public int? libOrder { get; set; }
        }
        public class preset
        {
            public int pID { get; set; }
            public string pName { get; set; }
            public string pSyntax { get; set; }
        }
        List<lib> libs = new List<lib>();
        List<preset> presets = new List<preset>();
        string libList = "";

        public TableLayoutPanel OrderedListItem(string tag, string text)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.RowCount = 1;
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.Height = 30;
            tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tlp.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            tlp.ContextMenuStrip = cmsDeleteLib;
            tlp.Tag = tag;

            MaskedTextBox tb = new MaskedTextBox();
            tb.Mask = "09";
            tb.Dock = DockStyle.Fill;
            tb.Tag = tag;

            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Fill;
            lbl.Text = text;
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            void textChanged()
            {
                int i = libs.FindIndex(x => x.libID == Int32.Parse(tb.Tag.ToString()));
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    libs[i].libOrder = null;
                }
                else
                {
                    libs[i].libOrder = Int32.Parse(tb.Text);
                }
                try
                {
                    if (libs.FindIndex(x => x.libOrder == Int32.Parse(tb.Text)) > 0)
                    {
                        error = true;
                        lblOutput.Text = "One of the libraries selected has the same order number as another";
                    }
                }
                catch { }
            }

            tb.TextChanged += (s, e) => textChanged();

            tlp.Controls.Add(tb, 0, 0);
            tlp.Controls.Add(lbl, 1, 0);
            return tlp;
        }

        public frmMainNew()
        {            
            InitializeComponent();
            btnSettings.MouseHover += (s, e) => { btnSettings.BackgroundImage = global::MinGUI.Properties.Resources.SettingsHover; };
            btnSettings.MouseLeave += (s, e) => { btnSettings.BackgroundImage = global::MinGUI.Properties.Resources.Settings; };
            btnSettings.MouseDown += (s, e) => { btnSettings.BackgroundImage = global::MinGUI.Properties.Resources.SettingsDown; };
            btnSettings.MouseUp += (s, e) => { btnSettings.BackgroundImage = global::MinGUI.Properties.Resources.SettingsHover; };
            btnLibs.MouseDown += (s, e) =>
            {
                if (!libChecked)
                {
                    libChecked = true;
                    btnLibs.BackgroundImage = Properties.Resources.tabLibUnselectedDown;
                    btnPresets.BackgroundImage = Properties.Resources.presetsUnselected;
                }
                else { btnLibs.BackgroundImage = Properties.Resources.tabLibDown; };
            };
            btnLibs.MouseUp += (s, e) => 
            {
                btnLibs.BackgroundImage = Properties.Resources.tabLibHover;
                flpPresets.Hide();
                flpLibs.Show();
            };
            btnLibs.MouseEnter += (s, e) =>
            {
                if (libChecked) { btnLibs.BackgroundImage = Properties.Resources.tabLibHover; }
                else { btnLibs.BackgroundImage = Properties.Resources.tabLibUnselectedHover; }
            };
            btnLibs.MouseLeave += (s, e) =>
            {
                if (libChecked) { btnLibs.BackgroundImage = Properties.Resources.tabLib; }
                else { btnLibs.BackgroundImage = Properties.Resources.tabLibUnselected; }
            };
            btnPresets.MouseDown += (s, e) =>
            {
                if (libChecked)
                {
                    libChecked = false;
                    btnPresets.BackgroundImage = Properties.Resources.presetsUnselectedDown;
                    btnLibs.BackgroundImage = Properties.Resources.tabLibUnselected;
                }
                else { btnPresets.BackgroundImage = Properties.Resources.presetsDown; };
            };
            btnPresets.MouseUp += (s, e) => 
            {
                btnPresets.BackgroundImage = Properties.Resources.presetsHover;
                flpLibs.Hide();
                flpPresets.Show();
            };
            btnPresets.MouseEnter += (s, e) =>
            {
                if (!libChecked) { btnPresets.BackgroundImage = Properties.Resources.presetsHover; }
                else { btnPresets.BackgroundImage = Properties.Resources.presetsUnselectedHover; }
            };
            btnPresets.MouseLeave += (s, e) =>
            {
                if (!libChecked) { btnPresets.BackgroundImage = Properties.Resources.presets; }
                else { btnPresets.BackgroundImage = Properties.Resources.presetsUnselected; }
            };
        }

        private void frmMainNew_Load(object sender, EventArgs e)
        {
            if (!File.Exists("mingui.db"))
            {
                SQLiteConnection.CreateFile("mingui.db");
            }
            conn.Open();
            SQLiteCommand createLibraries = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `Libraries` (`libID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `libName` TEXT NOT NULL, `libSyntax`	TEXT NOT NULL); CREATE TABLE IF NOT EXISTS `Presets` ( `pID` INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE, `pName` TEXT, `pSyntax` TEXT);", conn);
            createLibraries.ExecuteNonQuery();
            flpLibs.Dock = DockStyle.Fill;
            flpPresets.Dock = DockStyle.Fill;
            flpPresets.Hide();
            SQLiteCommand getLibs = new SQLiteCommand("SELECT * FROM Libraries", conn);
            SQLiteDataReader readLibs = getLibs.ExecuteReader();
            while (readLibs.Read())
            {
                libs.Add(new lib
                {
                    libID = Int32.Parse(readLibs[0].ToString()),
                    libName = readLibs[1].ToString(),
                    libSyntax = readLibs[2].ToString()
                });
                flpLibs.Controls.Add(OrderedListItem(readLibs[0].ToString(), readLibs[1].ToString()));
            }
            SQLiteCommand getPresets = new SQLiteCommand("SELECT * FROM Presets", conn);
            SQLiteDataReader readPresets = getPresets.ExecuteReader();
            while (readPresets.Read())
            {
                presets.Add(new preset
                {
                    pID = Int32.Parse(readPresets[0].ToString()),
                    pName = readPresets[1].ToString(),
                    pSyntax = readPresets[2].ToString()
                });
                flpPresets.Controls.Add(new RadioButton()
                {
                    Text = readPresets[1].ToString(),
                    Tag = readPresets[0].ToString(),
                    ContextMenuStrip = cmsDeletePreset
                });
            }
        }

        private void btnAddLib_Click(object sender, EventArgs e)
        {
            frmAddLib AddLib = new frmAddLib();
            AddLib.Show();
        }

        private void btnCreatePreset_Click(object sender, EventArgs e)
        {
            frmPreset Preset = new frmPreset();
            Preset.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings();
            Settings.Show();
        }

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdSelectFile.ShowDialog();
        }

        private void ofdSelectFile_FileOk(object sender, CancelEventArgs e)
        {
            tbSource.Text = ofdSelectFile.FileName;
        }

        private void setFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdName.ShowDialog();
        }

        private void sfdName_FileOk(object sender, CancelEventArgs e)
        {
            tbOut.Text = sfdName.FileName;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbSource.Text.Replace("\\", "\\\\")) || string.IsNullOrWhiteSpace(tbOut.Text) || tbOut.Text == "Program Name" || string.IsNullOrWhiteSpace(cbCompiler.Text))
            {
                lblOutput.Text = "One of the inputs is either incorrect or empty";
                return;
            }
            if (cbCompiler.Text == "gcc (C/C++)") { compiler = "gcc "; }
            compile = pnlMethod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString() + " ";
            name = "\"" + tbOut.Text + "\" ";
            path = "\"" + tbSource.Text + "\" ";
            if (libChecked)
            {
                foreach (lib lib in libs.Where(x => x.libOrder != null).OrderBy(x => x.libOrder))
                {
                    libList += lib.libSyntax + " ";
                }
            }
            else
            {
                temp = flpPresets.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
                SQLiteCommand getPreset = new SQLiteCommand("SELECT * FROM Presets WHERE `pID` = \"" + temp + "\";", conn);
                SQLiteDataReader readPreset = getPreset.ExecuteReader();
                libList = readPreset[2].ToString();
            }            
            lblOutput.Text = "All required information is present, making command...";
            cmdInfo.FileName = "cmd.exe";
            cmdInfo.Arguments = "/C " + compiler + path + compile + name + libList;
            if (pnlMethod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString() == "-S" || pnlMethod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString() == "-c")
            {
                cmdInfo.Arguments += " & PAUSE";
            }
            cmd.StartInfo = cmdInfo;
            lblOutput.Text += "\nCommand is: " + cmdInfo.Arguments.ToString() + "\nCommand made, executing...";
            if (!error)
            {
                cmd.Start();
            }
        }

        private void tRefresh_Tick(object sender, EventArgs e)
        {
            List<lib> newLibs = new List<lib>();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Libraries", conn);
            SQLiteDataReader readGetLibs = command.ExecuteReader();
            while (readGetLibs.Read())
            {
                int y = libs.FindIndex(x => x.libID == Int32.Parse(readGetLibs[0].ToString()));
                if (y >= 0) { }
                else
                {
                    libs.Add(new lib()
                    {
                        libID = Int32.Parse(readGetLibs[0].ToString()),
                        libName = readGetLibs[1].ToString(),
                        libSyntax = readGetLibs[2].ToString()
                    });
                    flpLibs.Controls.Add(OrderedListItem(readGetLibs[0].ToString(), readGetLibs[1].ToString()));
                }
            }
            command = new SQLiteCommand("SELECT * FROM Presets", conn);
            SQLiteDataReader readPresets = command.ExecuteReader();
            while (readPresets.Read())
            {
                int y = presets.FindIndex(x => x.pID == Int32.Parse(readPresets[0].ToString()));
                if (y >= 0) { }
                else
                {
                    presets.Add(new preset()
                    {
                        pID = Int32.Parse(readPresets[0].ToString()),
                        pName = readPresets[1].ToString(),
                        pSyntax = readPresets[2].ToString()
                    });
                    flpPresets.Controls.Add(new RadioButton
                    {
                        Text = readPresets[1].ToString(),
                        Tag = readPresets[0].ToString(),
                        ContextMenuStrip = cmsDeletePreset
                    });
                }
            }
        }

        private void deleteLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp = cmsDeleteLib.SourceControl.Tag.ToString();
            SQLiteCommand deleteLib = new SQLiteCommand("DELETE FROM Libraries WHERE `libID` = \"" + temp + "\";", conn);
            deleteLib.ExecuteNonQuery();
            flpLibs.Controls.Remove(cmsDeleteLib.SourceControl);
            libs.RemoveAt(libs.FindIndex(x => x.libID == Int32.Parse(temp)));
        }

        private void deletePresetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp = cmsDeletePreset.SourceControl.Tag.ToString();
            SQLiteCommand deletePreset = new SQLiteCommand("DELEtE FROM Presets WHERE `Pid` = \"" + temp + "\";", conn);
            deletePreset.ExecuteNonQuery();
            flpPresets.Controls.Remove(cmsDeletePreset.SourceControl);
            presets.RemoveAt(presets.FindIndex(x => x.pID == Int32.Parse(temp)));
        }
    }
}
