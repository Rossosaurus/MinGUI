using System.Drawing;

namespace MinGUI
{
    partial class frmMainNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainNew));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.pbDiv = new System.Windows.Forms.PictureBox();
            this.tlpCompile = new System.Windows.Forms.TableLayoutPanel();
            this.lblOut = new System.Windows.Forms.Label();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.cmsOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblCompiler = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblCompile = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.cmsLocation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCompiler = new System.Windows.Forms.ComboBox();
            this.pnlMethod = new System.Windows.Forms.Panel();
            this.rbOutput = new System.Windows.Forms.RadioButton();
            this.rbBuild = new System.Windows.Forms.RadioButton();
            this.rbCompile = new System.Windows.Forms.RadioButton();
            this.tlpLibs = new System.Windows.Forms.TableLayoutPanel();
            this.lblLibs = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreatePreset = new System.Windows.Forms.Button();
            this.btnAddLib = new System.Windows.Forms.Button();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnLibs = new System.Windows.Forms.Button();
            this.btnPresets = new System.Windows.Forms.Button();
            this.pnlLibContainer = new System.Windows.Forms.Panel();
            this.flpPresets = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLibs = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cmsDeleteLib = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.tRefresh = new System.Windows.Forms.Timer(this.components);
            this.sfdName = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsDeletePreset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.tlpMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiv)).BeginInit();
            this.tlpCompile.SuspendLayout();
            this.cmsOutput.SuspendLayout();
            this.cmsLocation.SuspendLayout();
            this.pnlMethod.SuspendLayout();
            this.tlpLibs.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.pnlLibContainer.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.cmsDeleteLib.SuspendLayout();
            this.cmsDeletePreset.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlTitle, 0, 1);
            this.tlpMain.Controls.Add(this.tlpBody, 0, 2);
            this.tlpMain.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(480, 607);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlTitle.Controls.Add(this.pbLogo);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(0, 25);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(480, 87);
            this.pnlTitle.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(385, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(92, 81);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.lblTitle.Location = new System.Drawing.Point(-10, -10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 114);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MinGUI";
            // 
            // tlpBody
            // 
            this.tlpBody.ColumnCount = 3;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.Controls.Add(this.pbDiv, 1, 0);
            this.tlpBody.Controls.Add(this.tlpCompile, 0, 0);
            this.tlpBody.Controls.Add(this.tlpLibs, 2, 0);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.ForeColor = System.Drawing.Color.Black;
            this.tlpBody.Location = new System.Drawing.Point(0, 112);
            this.tlpBody.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 1;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBody.Size = new System.Drawing.Size(480, 495);
            this.tlpBody.TabIndex = 3;
            // 
            // pbDiv
            // 
            this.pbDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pbDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDiv.Location = new System.Drawing.Point(235, 10);
            this.pbDiv.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pbDiv.Name = "pbDiv";
            this.pbDiv.Size = new System.Drawing.Size(10, 475);
            this.pbDiv.TabIndex = 0;
            this.pbDiv.TabStop = false;
            // 
            // tlpCompile
            // 
            this.tlpCompile.ColumnCount = 1;
            this.tlpCompile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCompile.Controls.Add(this.lblOut, 0, 9);
            this.tlpCompile.Controls.Add(this.tbOut, 0, 8);
            this.tlpCompile.Controls.Add(this.lblSave, 0, 7);
            this.tlpCompile.Controls.Add(this.lblMethod, 0, 5);
            this.tlpCompile.Controls.Add(this.lblCompiler, 0, 3);
            this.tlpCompile.Controls.Add(this.lblDir, 0, 1);
            this.tlpCompile.Controls.Add(this.lblCompile, 0, 0);
            this.tlpCompile.Controls.Add(this.tbSource, 0, 2);
            this.tlpCompile.Controls.Add(this.cbCompiler, 0, 4);
            this.tlpCompile.Controls.Add(this.pnlMethod, 0, 6);
            this.tlpCompile.Controls.Add(this.pnlOut, 0, 10);
            this.tlpCompile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCompile.Location = new System.Drawing.Point(3, 3);
            this.tlpCompile.Name = "tlpCompile";
            this.tlpCompile.RowCount = 11;
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpCompile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tlpCompile.Size = new System.Drawing.Size(229, 489);
            this.tlpCompile.TabIndex = 1;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOut.Font = new System.Drawing.Font("Courier New", 14.8F);
            this.lblOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblOut.Location = new System.Drawing.Point(3, 329);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(223, 29);
            this.lblOut.TabIndex = 10;
            this.lblOut.Text = "Output";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOut
            // 
            this.tbOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbOut.ContextMenuStrip = this.cmsOutput;
            this.tbOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tbOut.Location = new System.Drawing.Point(3, 303);
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(223, 20);
            this.tbOut.TabIndex = 9;
            // 
            // cmsOutput
            // 
            this.cmsOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFileToolStripMenuItem});
            this.cmsOutput.Name = "cmsLocation";
            this.cmsOutput.Size = new System.Drawing.Size(112, 26);
            // 
            // setFileToolStripMenuItem
            // 
            this.setFileToolStripMenuItem.Name = "setFileToolStripMenuItem";
            this.setFileToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.setFileToolStripMenuItem.Text = "Set File";
            this.setFileToolStripMenuItem.Click += new System.EventHandler(this.setFileToolStripMenuItem_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSave.Font = new System.Drawing.Font("Courier New", 14.8F);
            this.lblSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblSave.Location = new System.Drawing.Point(3, 271);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(223, 29);
            this.lblSave.TabIndex = 8;
            this.lblSave.Text = "Output File";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMethod.Font = new System.Drawing.Font("Courier New", 14.8F);
            this.lblMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblMethod.Location = new System.Drawing.Point(3, 150);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(223, 29);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Method";
            this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompiler
            // 
            this.lblCompiler.AutoSize = true;
            this.lblCompiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompiler.Font = new System.Drawing.Font("Courier New", 14.8F);
            this.lblCompiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCompiler.Location = new System.Drawing.Point(3, 92);
            this.lblCompiler.Name = "lblCompiler";
            this.lblCompiler.Size = new System.Drawing.Size(223, 29);
            this.lblCompiler.TabIndex = 3;
            this.lblCompiler.Text = "Compiler";
            this.lblCompiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDir.Font = new System.Drawing.Font("Courier New", 14.8F);
            this.lblDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDir.Location = new System.Drawing.Point(3, 34);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(223, 29);
            this.lblDir.TabIndex = 1;
            this.lblDir.Text = "Source Location";
            this.lblDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompile
            // 
            this.lblCompile.AutoSize = true;
            this.lblCompile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompile.Font = new System.Drawing.Font("Courier New", 19.5F);
            this.lblCompile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCompile.Location = new System.Drawing.Point(3, 0);
            this.lblCompile.Name = "lblCompile";
            this.lblCompile.Size = new System.Drawing.Size(223, 34);
            this.lblCompile.TabIndex = 0;
            this.lblCompile.Text = "Compile";
            this.lblCompile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSource
            // 
            this.tbSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSource.ContextMenuStrip = this.cmsLocation;
            this.tbSource.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tbSource.Location = new System.Drawing.Point(3, 66);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(223, 20);
            this.tbSource.TabIndex = 2;
            // 
            // cmsLocation
            // 
            this.cmsLocation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem});
            this.cmsLocation.Name = "cmsLocation";
            this.cmsLocation.Size = new System.Drawing.Size(127, 26);
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.selectFileToolStripMenuItem.Text = "Select File";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // cbCompiler
            // 
            this.cbCompiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbCompiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCompiler.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.cbCompiler.FormattingEnabled = true;
            this.cbCompiler.Items.AddRange(new object[] {
            "gcc (C/C++)"});
            this.cbCompiler.Location = new System.Drawing.Point(3, 124);
            this.cbCompiler.Name = "cbCompiler";
            this.cbCompiler.Size = new System.Drawing.Size(223, 22);
            this.cbCompiler.TabIndex = 6;
            // 
            // pnlMethod
            // 
            this.pnlMethod.Controls.Add(this.rbOutput);
            this.pnlMethod.Controls.Add(this.rbBuild);
            this.pnlMethod.Controls.Add(this.rbCompile);
            this.pnlMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMethod.Location = new System.Drawing.Point(3, 182);
            this.pnlMethod.Name = "pnlMethod";
            this.pnlMethod.Size = new System.Drawing.Size(223, 86);
            this.pnlMethod.TabIndex = 7;
            // 
            // rbOutput
            // 
            this.rbOutput.AutoSize = true;
            this.rbOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rbOutput.Location = new System.Drawing.Point(6, 59);
            this.rbOutput.Name = "rbOutput";
            this.rbOutput.Size = new System.Drawing.Size(156, 22);
            this.rbOutput.TabIndex = 2;
            this.rbOutput.TabStop = true;
            this.rbOutput.Tag = "-o";
            this.rbOutput.Text = "Output to exe";
            this.rbOutput.UseVisualStyleBackColor = true;
            // 
            // rbBuild
            // 
            this.rbBuild.AutoSize = true;
            this.rbBuild.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rbBuild.Location = new System.Drawing.Point(6, 31);
            this.rbBuild.Name = "rbBuild";
            this.rbBuild.Size = new System.Drawing.Size(206, 22);
            this.rbBuild.TabIndex = 1;
            this.rbBuild.TabStop = true;
            this.rbBuild.Tag = "-c";
            this.rbBuild.Text = "Compile + Assemble";
            this.rbBuild.UseVisualStyleBackColor = true;
            // 
            // rbCompile
            // 
            this.rbCompile.AutoSize = true;
            this.rbCompile.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rbCompile.Location = new System.Drawing.Point(6, 3);
            this.rbCompile.Name = "rbCompile";
            this.rbCompile.Size = new System.Drawing.Size(146, 22);
            this.rbCompile.TabIndex = 0;
            this.rbCompile.TabStop = true;
            this.rbCompile.Tag = "-S";
            this.rbCompile.Text = "Compile Only";
            this.rbCompile.UseVisualStyleBackColor = true;
            // 
            // tlpLibs
            // 
            this.tlpLibs.ColumnCount = 1;
            this.tlpLibs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLibs.Controls.Add(this.lblLibs, 0, 0);
            this.tlpLibs.Controls.Add(this.btnBuild, 0, 3);
            this.tlpLibs.Controls.Add(this.tlpButtons, 0, 2);
            this.tlpLibs.Controls.Add(this.tlpContainer, 0, 1);
            this.tlpLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLibs.Location = new System.Drawing.Point(248, 3);
            this.tlpLibs.Name = "tlpLibs";
            this.tlpLibs.RowCount = 4;
            this.tlpLibs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpLibs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.5F));
            this.tlpLibs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.tlpLibs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpLibs.Size = new System.Drawing.Size(229, 489);
            this.tlpLibs.TabIndex = 2;
            // 
            // lblLibs
            // 
            this.lblLibs.AutoSize = true;
            this.lblLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLibs.Font = new System.Drawing.Font("Courier New", 19.5F);
            this.lblLibs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblLibs.Location = new System.Drawing.Point(3, 0);
            this.lblLibs.Name = "lblLibs";
            this.lblLibs.Size = new System.Drawing.Size(223, 34);
            this.lblLibs.TabIndex = 1;
            this.lblLibs.Text = "Libraries";
            this.lblLibs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuild.FlatAppearance.BorderSize = 0;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btnBuild.Location = new System.Drawing.Point(3, 457);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(223, 29);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnCreatePreset, 1, 0);
            this.tlpButtons.Controls.Add(this.btnAddLib, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 408);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(229, 46);
            this.tlpButtons.TabIndex = 3;
            // 
            // btnCreatePreset
            // 
            this.btnCreatePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreatePreset.FlatAppearance.BorderSize = 0;
            this.btnCreatePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePreset.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btnCreatePreset.Location = new System.Drawing.Point(117, 3);
            this.btnCreatePreset.Name = "btnCreatePreset";
            this.btnCreatePreset.Size = new System.Drawing.Size(109, 40);
            this.btnCreatePreset.TabIndex = 1;
            this.btnCreatePreset.Text = "Create Preset";
            this.btnCreatePreset.UseVisualStyleBackColor = false;
            this.btnCreatePreset.Click += new System.EventHandler(this.btnCreatePreset_Click);
            // 
            // btnAddLib
            // 
            this.btnAddLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddLib.FlatAppearance.BorderSize = 0;
            this.btnAddLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLib.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btnAddLib.Location = new System.Drawing.Point(3, 3);
            this.btnAddLib.Name = "btnAddLib";
            this.btnAddLib.Size = new System.Drawing.Size(108, 40);
            this.btnAddLib.TabIndex = 0;
            this.btnAddLib.Text = "Add Library";
            this.btnAddLib.UseVisualStyleBackColor = false;
            this.btnAddLib.Click += new System.EventHandler(this.btnAddLib_Click);
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainer.Controls.Add(this.pnlTabs, 0, 0);
            this.tlpContainer.Controls.Add(this.pnlLibContainer, 0, 1);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(3, 37);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpContainer.Size = new System.Drawing.Size(223, 368);
            this.tlpContainer.TabIndex = 4;
            // 
            // pnlTabs
            // 
            this.pnlTabs.Controls.Add(this.btnLibs);
            this.pnlTabs.Controls.Add(this.btnPresets);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(223, 36);
            this.pnlTabs.TabIndex = 0;
            // 
            // btnLibs
            // 
            this.btnLibs.BackgroundImage = global::MinGUI.Properties.Resources.tabLib;
            this.btnLibs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLibs.FlatAppearance.BorderSize = 0;
            this.btnLibs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLibs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLibs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibs.Location = new System.Drawing.Point(-1, 1);
            this.btnLibs.Margin = new System.Windows.Forms.Padding(0);
            this.btnLibs.Name = "btnLibs";
            this.btnLibs.Size = new System.Drawing.Size(71, 36);
            this.btnLibs.TabIndex = 1;
            this.btnLibs.UseVisualStyleBackColor = true;
            // 
            // btnPresets
            // 
            this.btnPresets.BackgroundImage = global::MinGUI.Properties.Resources.presetsUnselected;
            this.btnPresets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPresets.FlatAppearance.BorderSize = 0;
            this.btnPresets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPresets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresets.Location = new System.Drawing.Point(71, 1);
            this.btnPresets.Margin = new System.Windows.Forms.Padding(0);
            this.btnPresets.Name = "btnPresets";
            this.btnPresets.Size = new System.Drawing.Size(71, 36);
            this.btnPresets.TabIndex = 0;
            this.btnPresets.UseVisualStyleBackColor = true;
            // 
            // pnlLibContainer
            // 
            this.pnlLibContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.pnlLibContainer.Controls.Add(this.flpPresets);
            this.pnlLibContainer.Controls.Add(this.flpLibs);
            this.pnlLibContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLibContainer.Location = new System.Drawing.Point(0, 36);
            this.pnlLibContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLibContainer.Name = "pnlLibContainer";
            this.pnlLibContainer.Size = new System.Drawing.Size(223, 332);
            this.pnlLibContainer.TabIndex = 1;
            // 
            // flpPresets
            // 
            this.flpPresets.Location = new System.Drawing.Point(5, 112);
            this.flpPresets.Name = "flpPresets";
            this.flpPresets.Size = new System.Drawing.Size(212, 100);
            this.flpPresets.TabIndex = 1;
            // 
            // flpLibs
            // 
            this.flpLibs.Location = new System.Drawing.Point(5, 6);
            this.flpLibs.Name = "flpLibs";
            this.flpLibs.Size = new System.Drawing.Size(212, 100);
            this.flpLibs.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 5;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.Controls.Add(this.btnSettings, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 3);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.Size = new System.Drawing.Size(480, 22);
            this.tlpHeader.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btnSettings.Location = new System.Drawing.Point(20, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 30);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cmsDeleteLib
            // 
            this.cmsDeleteLib.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLibraryToolStripMenuItem});
            this.cmsDeleteLib.Name = "cmsLocation";
            this.cmsDeleteLib.Size = new System.Drawing.Size(147, 26);
            // 
            // deleteLibraryToolStripMenuItem
            // 
            this.deleteLibraryToolStripMenuItem.Name = "deleteLibraryToolStripMenuItem";
            this.deleteLibraryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteLibraryToolStripMenuItem.Text = "Delete Library";
            this.deleteLibraryToolStripMenuItem.Click += new System.EventHandler(this.deleteLibraryToolStripMenuItem_Click);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.InitialDirectory = "Documents";
            this.ofdSelectFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSelectFile_FileOk);
            // 
            // tRefresh
            // 
            this.tRefresh.Enabled = true;
            this.tRefresh.Interval = 3000;
            this.tRefresh.Tick += new System.EventHandler(this.tRefresh_Tick);
            // 
            // sfdName
            // 
            this.sfdName.DefaultExt = "exe";
            this.sfdName.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdName_FileOk);
            // 
            // cmsDeletePreset
            // 
            this.cmsDeletePreset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePresetToolStripMenuItem});
            this.cmsDeletePreset.Name = "cmsLocation";
            this.cmsDeletePreset.Size = new System.Drawing.Size(143, 26);
            // 
            // deletePresetToolStripMenuItem
            // 
            this.deletePresetToolStripMenuItem.Name = "deletePresetToolStripMenuItem";
            this.deletePresetToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deletePresetToolStripMenuItem.Text = "Delete Preset";
            this.deletePresetToolStripMenuItem.Click += new System.EventHandler(this.deletePresetToolStripMenuItem_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblOutput.Location = new System.Drawing.Point(0, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(229, 131);
            this.lblOutput.TabIndex = 11;
            // 
            // pnlOut
            // 
            this.pnlOut.AutoScroll = true;
            this.pnlOut.Controls.Add(this.lblOutput);
            this.pnlOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOut.Location = new System.Drawing.Point(0, 358);
            this.pnlOut.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(229, 131);
            this.pnlOut.TabIndex = 11;
            // 
            // frmMainNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(480, 607);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.MinimumSize = new System.Drawing.Size(500, 650);
            this.Name = "frmMainNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MinGUI";
            this.Load += new System.EventHandler(this.frmMainNew_Load);
            this.tlpMain.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiv)).EndInit();
            this.tlpCompile.ResumeLayout(false);
            this.tlpCompile.PerformLayout();
            this.cmsOutput.ResumeLayout(false);
            this.cmsLocation.ResumeLayout(false);
            this.pnlMethod.ResumeLayout(false);
            this.pnlMethod.PerformLayout();
            this.tlpLibs.ResumeLayout(false);
            this.tlpLibs.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.pnlTabs.ResumeLayout(false);
            this.pnlLibContainer.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.cmsDeleteLib.ResumeLayout(false);
            this.cmsDeletePreset.ResumeLayout(false);
            this.pnlOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.PictureBox pbDiv;
        private System.Windows.Forms.TableLayoutPanel tlpCompile;
        private System.Windows.Forms.Label lblCompile;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblCompiler;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.ComboBox cbCompiler;
        private System.Windows.Forms.Panel pnlMethod;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TableLayoutPanel tlpLibs;
        private System.Windows.Forms.Label lblLibs;
        private System.Windows.Forms.RadioButton rbCompile;
        private System.Windows.Forms.RadioButton rbOutput;
        private System.Windows.Forms.RadioButton rbBuild;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnCreatePreset;
        private System.Windows.Forms.Button btnAddLib;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Panel pnlLibContainer;
        private System.Windows.Forms.Button btnPresets;
        private System.Windows.Forms.Button btnLibs;
        private System.Windows.Forms.ContextMenuStrip cmsLocation;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsOutput;
        private System.Windows.Forms.ContextMenuStrip cmsDeleteLib;
        private System.Windows.Forms.ToolStripMenuItem deleteLibraryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.Timer tRefresh;
        private System.Windows.Forms.SaveFileDialog sfdName;
        private System.Windows.Forms.ToolStripMenuItem setFileToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpPresets;
        private System.Windows.Forms.FlowLayoutPanel flpLibs;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip cmsDeletePreset;
        private System.Windows.Forms.ToolStripMenuItem deletePresetToolStripMenuItem;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel pnlOut;
    }
}