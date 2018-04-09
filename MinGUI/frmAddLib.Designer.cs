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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLib));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblMinGW = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.tlpManual = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMinGW = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblInc = new System.Windows.Forms.Label();
            this.lblLib = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblSyntaxGW = new System.Windows.Forms.Label();
            this.lblSyntax = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxInc = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtbxSyntax = new System.Windows.Forms.TextBox();
            this.txtbxSyntaxGW = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpManual.SuspendLayout();
            this.tlpMinGW.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpMinGW, 0, 1);
            this.tlpMain.Controls.Add(this.lblMinGW, 1, 0);
            this.tlpMain.Controls.Add(this.lblManual, 0, 0);
            this.tlpMain.Controls.Add(this.tlpManual, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(505, 306);
            this.tlpMain.TabIndex = 0;
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
            this.tlpManual.Controls.Add(this.textBox4, 0, 7);
            this.tlpManual.Controls.Add(this.textBox3, 0, 5);
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
            this.tlpManual.Size = new System.Drawing.Size(246, 260);
            this.tlpManual.TabIndex = 2;
            // 
            // tlpMinGW
            // 
            this.tlpMinGW.ColumnCount = 1;
            this.tlpMinGW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMinGW.Controls.Add(this.btnOpen, 0, 1);
            this.tlpMinGW.Controls.Add(this.lblOpen, 0, 0);
            this.tlpMinGW.Controls.Add(this.lblSyntaxGW, 0, 2);
            this.tlpMinGW.Controls.Add(this.txtbxSyntaxGW, 0, 3);
            this.tlpMinGW.Controls.Add(this.btnGo, 0, 4);
            this.tlpMinGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMinGW.Location = new System.Drawing.Point(255, 43);
            this.tlpMinGW.Name = "tlpMinGW";
            this.tlpMinGW.RowCount = 5;
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpMinGW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMinGW.Size = new System.Drawing.Size(247, 260);
            this.tlpMinGW.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(240, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Library Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBin.Location = new System.Drawing.Point(3, 104);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(240, 26);
            this.lblBin.TabIndex = 1;
            this.lblBin.Text = "Bin Folder Location:";
            this.lblBin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInc
            // 
            this.lblInc.AutoSize = true;
            this.lblInc.BackColor = System.Drawing.Color.Transparent;
            this.lblInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInc.Location = new System.Drawing.Point(3, 52);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(240, 26);
            this.lblInc.TabIndex = 2;
            this.lblInc.Text = "Include Folder Location:";
            this.lblInc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLib
            // 
            this.lblLib.AutoSize = true;
            this.lblLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLib.Location = new System.Drawing.Point(3, 156);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(240, 26);
            this.lblLib.TabIndex = 3;
            this.lblLib.Text = "Library Folder Location:";
            this.lblLib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOpen.Location = new System.Drawing.Point(3, 0);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(241, 20);
            this.lblOpen.TabIndex = 1;
            this.lblOpen.Text = "To use MinGW toolkit first select";
            this.lblOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSyntaxGW
            // 
            this.lblSyntaxGW.AutoSize = true;
            this.lblSyntaxGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSyntaxGW.Location = new System.Drawing.Point(3, 187);
            this.lblSyntaxGW.Name = "lblSyntaxGW";
            this.lblSyntaxGW.Size = new System.Drawing.Size(241, 20);
            this.lblSyntaxGW.TabIndex = 2;
            this.lblSyntaxGW.Text = "Now enter the syntax for the library installed:";
            this.lblSyntaxGW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSyntax
            // 
            this.lblSyntax.AutoSize = true;
            this.lblSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSyntax.Location = new System.Drawing.Point(3, 208);
            this.lblSyntax.Name = "lblSyntax";
            this.lblSyntax.Size = new System.Drawing.Size(240, 26);
            this.lblSyntax.TabIndex = 4;
            this.lblSyntax.Text = "Syntax (e.g  - lSDL2main , Must contain \"-\")";
            this.lblSyntax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxName
            // 
            this.txtbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxName.Location = new System.Drawing.Point(3, 29);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(240, 20);
            this.txtbxName.TabIndex = 5;
            // 
            // txtbxInc
            // 
            this.txtbxInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxInc.Location = new System.Drawing.Point(3, 81);
            this.txtbxInc.Name = "txtbxInc";
            this.txtbxInc.Size = new System.Drawing.Size(240, 20);
            this.txtbxInc.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(3, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 20);
            this.textBox4.TabIndex = 8;
            // 
            // txtbxSyntax
            // 
            this.txtbxSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxSyntax.Location = new System.Drawing.Point(3, 237);
            this.txtbxSyntax.Name = "txtbxSyntax";
            this.txtbxSyntax.Size = new System.Drawing.Size(240, 20);
            this.txtbxSyntax.TabIndex = 9;
            // 
            // txtbxSyntaxGW
            // 
            this.txtbxSyntaxGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxSyntaxGW.Location = new System.Drawing.Point(3, 210);
            this.txtbxSyntaxGW.Name = "txtbxSyntaxGW";
            this.txtbxSyntaxGW.Size = new System.Drawing.Size(241, 20);
            this.txtbxSyntaxGW.TabIndex = 7;
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Location = new System.Drawing.Point(3, 233);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(241, 24);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Add Library";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::MinGUI.Properties.Resources.mingw;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.Location = new System.Drawing.Point(3, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(241, 161);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // frmAddLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 306);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddLib";
            this.Text = "New Libaray";
            this.Load += new System.EventHandler(this.frmAddLib_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpManual.ResumeLayout(false);
            this.tlpManual.PerformLayout();
            this.tlpMinGW.ResumeLayout(false);
            this.tlpMinGW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Label lblMinGW;
        private System.Windows.Forms.TableLayoutPanel tlpManual;
        private System.Windows.Forms.TableLayoutPanel tlpMinGW;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblSyntaxGW;
        private System.Windows.Forms.TextBox txtbxSyntaxGW;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtbxSyntax;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtbxInc;
        private System.Windows.Forms.Label lblInc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.Label lblSyntax;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Button btnOpen;
    }
}