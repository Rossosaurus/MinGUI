namespace MinGUI
{
    partial class frmAddLib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLib));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMinGW = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblSyntaxGW = new System.Windows.Forms.Label();
            this.txtbxSyntaxGW = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblNameGW = new System.Windows.Forms.Label();
            this.txtbxNameGW = new System.Windows.Forms.TextBox();
            this.lblMinGW = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.tlpManual = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxSyntax = new System.Windows.Forms.TextBox();
            this.txtbxLib = new System.Windows.Forms.TextBox();
            this.cmsSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbxBin = new System.Windows.Forms.TextBox();
            this.txtbxInc = new System.Windows.Forms.TextBox();
            this.lblInc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblLib = new System.Windows.Forms.Label();
            this.lblSyntax = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.pnlManOut = new System.Windows.Forms.Panel();
            this.lblManOut = new System.Windows.Forms.Label();
            this.pnlMingwOut = new System.Windows.Forms.Panel();
            this.lblMingwOut = new System.Windows.Forms.Label();
            this.fbdSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.tlpMain.SuspendLayout();
            this.tlpMinGW.SuspendLayout();
            this.tlpManual.SuspendLayout();
            this.cmsSelect.SuspendLayout();
            this.pnlManOut.SuspendLayout();
            this.pnlMingwOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpMinGW, 0, 1);
            this.tlpMain.Controls.Add(this.lblMinGW, 1, 0);
            this.tlpMain.Controls.Add(this.lblManual, 0, 0);
            this.tlpMain.Controls.Add(this.tlpManual, 0, 1);
            this.tlpMain.Controls.Add(this.pnlManOut, 0, 2);
            this.tlpMain.Controls.Add(this.pnlMingwOut, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(505, 400);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpMinGW
            // 
            this.tlpMinGW.ColumnCount = 1;
            this.tlpMinGW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMinGW.Controls.Add(this.btnOpen, 0, 1);
            this.tlpMinGW.Controls.Add(this.lblSyntaxGW, 0, 4);
            this.tlpMinGW.Controls.Add(this.txtbxSyntaxGW, 0, 5);
            this.tlpMinGW.Controls.Add(this.btnGo, 0, 6);
            this.tlpMinGW.Controls.Add(this.lblNameGW, 0, 2);
            this.tlpMinGW.Controls.Add(this.txtbxNameGW, 0, 3);
            this.tlpMinGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMinGW.Location = new System.Drawing.Point(255, 43);
            this.tlpMinGW.Name = "tlpMinGW";
            this.tlpMinGW.RowCount = 7;
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMinGW.Size = new System.Drawing.Size(247, 245);
            this.tlpMinGW.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::MinGUI.Properties.Resources.mingw;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.Location = new System.Drawing.Point(3, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(241, 103);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblSyntaxGW
            // 
            this.lblSyntaxGW.AutoSize = true;
            this.lblSyntaxGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSyntaxGW.Location = new System.Drawing.Point(3, 172);
            this.lblSyntaxGW.Name = "lblSyntaxGW";
            this.lblSyntaxGW.Size = new System.Drawing.Size(241, 20);
            this.lblSyntaxGW.TabIndex = 2;
            this.lblSyntaxGW.Text = "Now enter the syntax for the library installed:";
            this.lblSyntaxGW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxSyntaxGW
            // 
            this.txtbxSyntaxGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxSyntaxGW.Location = new System.Drawing.Point(3, 195);
            this.txtbxSyntaxGW.Name = "txtbxSyntaxGW";
            this.txtbxSyntaxGW.Size = new System.Drawing.Size(241, 20);
            this.txtbxSyntaxGW.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Location = new System.Drawing.Point(3, 218);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(241, 24);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Add Library";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblNameGW
            // 
            this.lblNameGW.AutoSize = true;
            this.lblNameGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameGW.Location = new System.Drawing.Point(3, 129);
            this.lblNameGW.Name = "lblNameGW";
            this.lblNameGW.Size = new System.Drawing.Size(241, 20);
            this.lblNameGW.TabIndex = 10;
            this.lblNameGW.Text = "Now enter the name of the library installed";
            this.lblNameGW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxNameGW
            // 
            this.txtbxNameGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxNameGW.Location = new System.Drawing.Point(3, 152);
            this.txtbxNameGW.Name = "txtbxNameGW";
            this.txtbxNameGW.Size = new System.Drawing.Size(241, 20);
            this.txtbxNameGW.TabIndex = 11;
            // 
            // lblMinGW
            // 
            this.lblMinGW.AutoSize = true;
            this.lblMinGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinGW.Location = new System.Drawing.Point(255, 0);
            this.lblMinGW.Name = "lblMinGW";
            this.lblMinGW.Size = new System.Drawing.Size(247, 40);
            this.lblMinGW.TabIndex = 1;
            this.lblMinGW.Text = "Or via MinGW Toolkit";
            this.lblMinGW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblManual.Location = new System.Drawing.Point(3, 0);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(246, 40);
            this.lblManual.TabIndex = 0;
            this.lblManual.Text = "Manually (If you just want to add a syntax please fill in Name and Syntax ONLY)";
            this.lblManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpManual
            // 
            this.tlpManual.ColumnCount = 1;
            this.tlpManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpManual.Controls.Add(this.txtbxSyntax, 0, 9);
            this.tlpManual.Controls.Add(this.txtbxLib, 0, 7);
            this.tlpManual.Controls.Add(this.txtbxBin, 0, 5);
            this.tlpManual.Controls.Add(this.txtbxInc, 0, 3);
            this.tlpManual.Controls.Add(this.lblInc, 0, 2);
            this.tlpManual.Controls.Add(this.lblName, 0, 0);
            this.tlpManual.Controls.Add(this.lblBin, 0, 4);
            this.tlpManual.Controls.Add(this.lblLib, 0, 6);
            this.tlpManual.Controls.Add(this.lblSyntax, 0, 8);
            this.tlpManual.Controls.Add(this.txtbxName, 0, 1);
            this.tlpManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpManual.Location = new System.Drawing.Point(3, 43);
            this.tlpManual.Name = "tlpManual";
            this.tlpManual.RowCount = 10;
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManual.Size = new System.Drawing.Size(246, 245);
            this.tlpManual.TabIndex = 2;
            // 
            // txtbxSyntax
            // 
            this.txtbxSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxSyntax.Location = new System.Drawing.Point(3, 219);
            this.txtbxSyntax.Name = "txtbxSyntax";
            this.txtbxSyntax.Size = new System.Drawing.Size(240, 20);
            this.txtbxSyntax.TabIndex = 9;
            // 
            // txtbxLib
            // 
            this.txtbxLib.ContextMenuStrip = this.cmsSelect;
            this.txtbxLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxLib.Location = new System.Drawing.Point(3, 171);
            this.txtbxLib.Name = "txtbxLib";
            this.txtbxLib.Size = new System.Drawing.Size(240, 20);
            this.txtbxLib.TabIndex = 8;
            // 
            // cmsSelect
            // 
            this.cmsSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.cmsSelect.Name = "cmsSelect";
            this.cmsSelect.Size = new System.Drawing.Size(127, 48);
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
            // txtbxBin
            // 
            this.txtbxBin.ContextMenuStrip = this.cmsSelect;
            this.txtbxBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxBin.Location = new System.Drawing.Point(3, 123);
            this.txtbxBin.Name = "txtbxBin";
            this.txtbxBin.Size = new System.Drawing.Size(240, 20);
            this.txtbxBin.TabIndex = 7;
            // 
            // txtbxInc
            // 
            this.txtbxInc.ContextMenuStrip = this.cmsSelect;
            this.txtbxInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxInc.Location = new System.Drawing.Point(3, 75);
            this.txtbxInc.Name = "txtbxInc";
            this.txtbxInc.Size = new System.Drawing.Size(240, 20);
            this.txtbxInc.TabIndex = 6;
            // 
            // lblInc
            // 
            this.lblInc.AutoSize = true;
            this.lblInc.BackColor = System.Drawing.Color.Transparent;
            this.lblInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInc.Location = new System.Drawing.Point(3, 48);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(240, 24);
            this.lblInc.TabIndex = 2;
            this.lblInc.Text = "Include Folder Location:";
            this.lblInc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(240, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Library Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBin.Location = new System.Drawing.Point(3, 96);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(240, 24);
            this.lblBin.TabIndex = 1;
            this.lblBin.Text = "Bin Folder Location:";
            this.lblBin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLib
            // 
            this.lblLib.AutoSize = true;
            this.lblLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLib.Location = new System.Drawing.Point(3, 144);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(240, 24);
            this.lblLib.TabIndex = 3;
            this.lblLib.Text = "Library Folder Location:";
            this.lblLib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSyntax
            // 
            this.lblSyntax.AutoSize = true;
            this.lblSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSyntax.Location = new System.Drawing.Point(3, 192);
            this.lblSyntax.Name = "lblSyntax";
            this.lblSyntax.Size = new System.Drawing.Size(240, 24);
            this.lblSyntax.TabIndex = 4;
            this.lblSyntax.Text = "Syntax (e.g  - lSDL2main , Must contain \"-\")";
            this.lblSyntax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxName
            // 
            this.txtbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxName.Location = new System.Drawing.Point(3, 27);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(240, 20);
            this.txtbxName.TabIndex = 5;
            // 
            // pnlManOut
            // 
            this.pnlManOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlManOut.Controls.Add(this.lblManOut);
            this.pnlManOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManOut.Location = new System.Drawing.Point(3, 294);
            this.pnlManOut.Name = "pnlManOut";
            this.pnlManOut.Size = new System.Drawing.Size(246, 103);
            this.pnlManOut.TabIndex = 4;
            // 
            // lblManOut
            // 
            this.lblManOut.AutoSize = true;
            this.lblManOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblManOut.Location = new System.Drawing.Point(0, 0);
            this.lblManOut.Name = "lblManOut";
            this.lblManOut.Size = new System.Drawing.Size(160, 13);
            this.lblManOut.TabIndex = 1;
            this.lblManOut.Text = "To use MinGW toolkit first select";
            this.lblManOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMingwOut
            // 
            this.pnlMingwOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMingwOut.Controls.Add(this.lblMingwOut);
            this.pnlMingwOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMingwOut.Location = new System.Drawing.Point(255, 294);
            this.pnlMingwOut.Name = "pnlMingwOut";
            this.pnlMingwOut.Size = new System.Drawing.Size(247, 103);
            this.pnlMingwOut.TabIndex = 5;
            // 
            // lblMingwOut
            // 
            this.lblMingwOut.AutoSize = true;
            this.lblMingwOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMingwOut.Location = new System.Drawing.Point(0, 0);
            this.lblMingwOut.Name = "lblMingwOut";
            this.lblMingwOut.Size = new System.Drawing.Size(112, 13);
            this.lblMingwOut.TabIndex = 0;
            this.lblMingwOut.Text = "MinGW Library Output";
            // 
            // fbdSelect
            // 
            this.fbdSelect.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // frmAddLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 400);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(521, 350);
            this.Name = "frmAddLib";
            this.Text = "New Libaray";
            this.Load += new System.EventHandler(this.frmAddLib_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpMinGW.ResumeLayout(false);
            this.tlpMinGW.PerformLayout();
            this.tlpManual.ResumeLayout(false);
            this.tlpManual.PerformLayout();
            this.cmsSelect.ResumeLayout(false);
            this.pnlManOut.ResumeLayout(false);
            this.pnlManOut.PerformLayout();
            this.pnlMingwOut.ResumeLayout(false);
            this.pnlMingwOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Label lblMinGW;
        private System.Windows.Forms.TableLayoutPanel tlpManual;
        private System.Windows.Forms.TableLayoutPanel tlpMinGW;
        private System.Windows.Forms.Label lblManOut;
        private System.Windows.Forms.Label lblSyntaxGW;
        private System.Windows.Forms.TextBox txtbxSyntaxGW;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtbxSyntax;
        private System.Windows.Forms.TextBox txtbxLib;
        private System.Windows.Forms.TextBox txtbxBin;
        private System.Windows.Forms.TextBox txtbxInc;
        private System.Windows.Forms.Label lblInc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.Label lblSyntax;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ContextMenuStrip cmsSelect;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbdSelect;
        private System.Windows.Forms.Label lblNameGW;
        private System.Windows.Forms.TextBox txtbxNameGW;
        private System.Windows.Forms.Panel pnlManOut;
        private System.Windows.Forms.Panel pnlMingwOut;
        private System.Windows.Forms.Label lblMingwOut;
    }
}