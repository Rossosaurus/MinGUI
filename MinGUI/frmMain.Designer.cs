namespace MinGUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.txtbxFileName = new System.Windows.Forms.TextBox();
            this.cmsName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tlpItems = new System.Windows.Forms.TableLayoutPanel();
            this.tlpName = new System.Windows.Forms.TableLayoutPanel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlCompile = new System.Windows.Forms.Panel();
            this.rbCompile = new System.Windows.Forms.RadioButton();
            this.rbAssembly = new System.Windows.Forms.RadioButton();
            this.rbBuild = new System.Windows.Forms.RadioButton();
            this.txtbxFilePath = new System.Windows.Forms.TextBox();
            this.cbCompiler = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlpLibraries = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAddLib = new System.Windows.Forms.Button();
            this.lblLibs = new System.Windows.Forms.Label();
            this.flpChkBxLib = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsLib = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRefresh = new System.Windows.Forms.Timer(this.components);
            this.sfdName = new System.Windows.Forms.SaveFileDialog();
            this.cmsName.SuspendLayout();
            this.cmsFile.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.tlpItems.SuspendLayout();
            this.tlpName.SuspendLayout();
            this.pnlCompile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpLibraries.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsLib.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.InitialDirectory = "Documents";
            this.ofdSelectFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSelectFile_FileOk);
            // 
            // txtbxFileName
            // 
            this.txtbxFileName.ContextMenuStrip = this.cmsName;
            this.txtbxFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxFileName.Location = new System.Drawing.Point(3, 3);
            this.txtbxFileName.Name = "txtbxFileName";
            this.txtbxFileName.Size = new System.Drawing.Size(451, 20);
            this.txtbxFileName.TabIndex = 4;
            this.txtbxFileName.Text = "Program Name";
            // 
            // cmsName
            // 
            this.cmsName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToolStripMenuItem});
            this.cmsName.Name = "cmsFile";
            this.cmsName.Size = new System.Drawing.Size(142, 26);
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.selectFolderToolStripMenuItem.Text = "Select Folder";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // cmsFile
            // 
            this.cmsFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.cmsFile.Name = "cmsFile";
            this.cmsFile.Size = new System.Drawing.Size(127, 48);
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.selectFileToolStripMenuItem.Text = "Select File";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.80627F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.19373F));
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpMain.Controls.Add(this.tlpLibraries, 1, 0);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.41122F));
            this.tlpMain.Size = new System.Drawing.Size(702, 535);
            this.tlpMain.TabIndex = 3;
            // 
            // tlpLeft
            // 
            this.tlpLeft.AutoScroll = true;
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31579F));
            this.tlpLeft.Controls.Add(this.tlpItems, 0, 1);
            this.tlpLeft.Controls.Add(this.pbLogo, 0, 0);
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Size = new System.Drawing.Size(469, 529);
            this.tlpLeft.TabIndex = 4;
            // 
            // tlpItems
            // 
            this.tlpItems.ColumnCount = 1;
            this.tlpItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItems.Controls.Add(this.tlpName, 0, 1);
            this.tlpItems.Controls.Add(this.lblOutput, 0, 4);
            this.tlpItems.Controls.Add(this.pnlCompile, 0, 3);
            this.tlpItems.Controls.Add(this.txtbxFilePath, 0, 0);
            this.tlpItems.Controls.Add(this.cbCompiler, 0, 2);
            this.tlpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItems.Location = new System.Drawing.Point(3, 267);
            this.tlpItems.Name = "tlpItems";
            this.tlpItems.RowCount = 5;
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpItems.Size = new System.Drawing.Size(463, 259);
            this.tlpItems.TabIndex = 3;
            // 
            // tlpName
            // 
            this.tlpName.ColumnCount = 1;
            this.tlpName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpName.Controls.Add(this.txtbxFileName, 0, 0);
            this.tlpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpName.Location = new System.Drawing.Point(3, 37);
            this.tlpName.Name = "tlpName";
            this.tlpName.RowCount = 1;
            this.tlpName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpName.Size = new System.Drawing.Size(457, 24);
            this.tlpName.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.Location = new System.Drawing.Point(3, 172);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(457, 87);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output...";
            // 
            // pnlCompile
            // 
            this.pnlCompile.Controls.Add(this.rbCompile);
            this.pnlCompile.Controls.Add(this.rbAssembly);
            this.pnlCompile.Controls.Add(this.rbBuild);
            this.pnlCompile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompile.Location = new System.Drawing.Point(3, 94);
            this.pnlCompile.Name = "pnlCompile";
            this.pnlCompile.Size = new System.Drawing.Size(457, 75);
            this.pnlCompile.TabIndex = 8;
            // 
            // rbCompile
            // 
            this.rbCompile.AutoSize = true;
            this.rbCompile.Checked = true;
            this.rbCompile.Location = new System.Drawing.Point(3, 5);
            this.rbCompile.Name = "rbCompile";
            this.rbCompile.Size = new System.Drawing.Size(86, 17);
            this.rbCompile.TabIndex = 13;
            this.rbCompile.TabStop = true;
            this.rbCompile.Tag = "-S ";
            this.rbCompile.Text = "Compile Only";
            this.rbCompile.UseVisualStyleBackColor = true;
            // 
            // rbAssembly
            // 
            this.rbAssembly.AutoSize = true;
            this.rbAssembly.Location = new System.Drawing.Point(3, 23);
            this.rbAssembly.Name = "rbAssembly";
            this.rbAssembly.Size = new System.Drawing.Size(131, 17);
            this.rbAssembly.TabIndex = 12;
            this.rbAssembly.Tag = "-c";
            this.rbAssembly.Text = "Compile and Assemble";
            this.rbAssembly.UseVisualStyleBackColor = true;
            // 
            // rbBuild
            // 
            this.rbBuild.AutoSize = true;
            this.rbBuild.Location = new System.Drawing.Point(3, 41);
            this.rbBuild.Name = "rbBuild";
            this.rbBuild.Size = new System.Drawing.Size(136, 17);
            this.rbBuild.TabIndex = 11;
            this.rbBuild.Tag = "-o";
            this.rbBuild.Text = "Build and Output to exe";
            this.rbBuild.UseVisualStyleBackColor = true;
            // 
            // txtbxFilePath
            // 
            this.txtbxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFilePath.ContextMenuStrip = this.cmsFile;
            this.txtbxFilePath.Location = new System.Drawing.Point(6, 9);
            this.txtbxFilePath.Margin = new System.Windows.Forms.Padding(6, 9, 3, 3);
            this.txtbxFilePath.Name = "txtbxFilePath";
            this.txtbxFilePath.Size = new System.Drawing.Size(454, 20);
            this.txtbxFilePath.TabIndex = 9;
            this.txtbxFilePath.Text = "File Location";
            // 
            // cbCompiler
            // 
            this.cbCompiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCompiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompiler.FormattingEnabled = true;
            this.cbCompiler.Items.AddRange(new object[] {
            "gcc"});
            this.cbCompiler.Location = new System.Drawing.Point(6, 67);
            this.cbCompiler.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cbCompiler.Name = "cbCompiler";
            this.cbCompiler.Size = new System.Drawing.Size(451, 21);
            this.cbCompiler.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::MinGUI.Properties.Resources.icon;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(463, 258);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // tlpLibraries
            // 
            this.tlpLibraries.ColumnCount = 1;
            this.tlpLibraries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLibraries.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpLibraries.Controls.Add(this.lblLibs, 0, 0);
            this.tlpLibraries.Controls.Add(this.flpChkBxLib, 0, 1);
            this.tlpLibraries.Location = new System.Drawing.Point(478, 3);
            this.tlpLibraries.Name = "tlpLibraries";
            this.tlpLibraries.RowCount = 3;
            this.tlpLibraries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpLibraries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLibraries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpLibraries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLibraries.Size = new System.Drawing.Size(221, 529);
            this.tlpLibraries.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddLib, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 492);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(110, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Build";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAddLib
            // 
            this.btnAddLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddLib.Location = new System.Drawing.Point(3, 3);
            this.btnAddLib.Name = "btnAddLib";
            this.btnAddLib.Size = new System.Drawing.Size(101, 28);
            this.btnAddLib.TabIndex = 0;
            this.btnAddLib.Text = "Add Library";
            this.btnAddLib.UseVisualStyleBackColor = true;
            this.btnAddLib.Click += new System.EventHandler(this.btnAddLib_Click);
            // 
            // lblLibs
            // 
            this.lblLibs.AutoSize = true;
            this.lblLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLibs.Location = new System.Drawing.Point(3, 0);
            this.lblLibs.Name = "lblLibs";
            this.lblLibs.Size = new System.Drawing.Size(215, 25);
            this.lblLibs.TabIndex = 2;
            this.lblLibs.Text = "Select External Libraries";
            this.lblLibs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpChkBxLib
            // 
            this.flpChkBxLib.AutoScroll = true;
            this.flpChkBxLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChkBxLib.Location = new System.Drawing.Point(3, 28);
            this.flpChkBxLib.Name = "flpChkBxLib";
            this.flpChkBxLib.Size = new System.Drawing.Size(215, 458);
            this.flpChkBxLib.TabIndex = 3;
            // 
            // cmsLib
            // 
            this.cmsLib.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsLib.Name = "cmsLib";
            this.cmsLib.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tRefresh
            // 
            this.tRefresh.Enabled = true;
            this.tRefresh.Interval = 10000;
            this.tRefresh.Tick += new System.EventHandler(this.tRefresh_Tick);
            // 
            // sfdName
            // 
            this.sfdName.DefaultExt = "exe";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 535);
            this.ContextMenuStrip = this.cmsFile;
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(718, 574);
            this.MinimumSize = new System.Drawing.Size(718, 574);
            this.Name = "frmMain";
            this.Text = "MinGUI";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsName.ResumeLayout(false);
            this.cmsFile.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.tlpItems.ResumeLayout(false);
            this.tlpItems.PerformLayout();
            this.tlpName.ResumeLayout(false);
            this.tlpName.PerformLayout();
            this.pnlCompile.ResumeLayout(false);
            this.pnlCompile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpLibraries.ResumeLayout(false);
            this.tlpLibraries.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cmsLib.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.TextBox txtbxFileName;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpItems;
        private System.Windows.Forms.TableLayoutPanel tlpName;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TableLayoutPanel tlpLibraries;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddLib;
        private System.Windows.Forms.Panel pnlCompile;
        private System.Windows.Forms.RadioButton rbCompile;
        private System.Windows.Forms.RadioButton rbAssembly;
        private System.Windows.Forms.RadioButton rbBuild;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLibs;
        private System.Windows.Forms.ContextMenuStrip cmsFile;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbxFilePath;
        private System.Windows.Forms.FlowLayoutPanel flpChkBxLib;
        private System.Windows.Forms.ComboBox cbCompiler;
        private System.Windows.Forms.ContextMenuStrip cmsLib;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer tRefresh;
        private System.Windows.Forms.ContextMenuStrip cmsName;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdName;
    }
}