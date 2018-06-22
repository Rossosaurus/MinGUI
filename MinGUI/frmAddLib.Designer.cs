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
            this.pbRibbon = new System.Windows.Forms.PictureBox();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.tbSyntax = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLib = new System.Windows.Forms.TextBox();
            this.tbInclude = new System.Windows.Forms.TextBox();
            this.lblLib = new System.Windows.Forms.Label();
            this.lblInc = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSyntax = new System.Windows.Forms.Label();
            this.tbBin = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRibbon)).BeginInit();
            this.tlpBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.pbRibbon, 0, 1);
            this.tlpMain.Controls.Add(this.tlpBody, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tlpMain.Size = new System.Drawing.Size(284, 470);
            this.tlpMain.TabIndex = 0;
            // 
            // pbRibbon
            // 
            this.pbRibbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pbRibbon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRibbon.BackgroundImage")));
            this.pbRibbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRibbon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRibbon.Location = new System.Drawing.Point(0, 5);
            this.pbRibbon.Margin = new System.Windows.Forms.Padding(0);
            this.pbRibbon.Name = "pbRibbon";
            this.pbRibbon.Size = new System.Drawing.Size(284, 55);
            this.pbRibbon.TabIndex = 0;
            this.pbRibbon.TabStop = false;
            // 
            // tlpBody
            // 
            this.tlpBody.ColumnCount = 1;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBody.Controls.Add(this.tbSyntax, 0, 9);
            this.tlpBody.Controls.Add(this.tbName, 0, 7);
            this.tlpBody.Controls.Add(this.tbLib, 0, 5);
            this.tlpBody.Controls.Add(this.tbInclude, 0, 3);
            this.tlpBody.Controls.Add(this.lblLib, 0, 4);
            this.tlpBody.Controls.Add(this.lblInc, 0, 2);
            this.tlpBody.Controls.Add(this.lblBin, 0, 0);
            this.tlpBody.Controls.Add(this.lblName, 0, 6);
            this.tlpBody.Controls.Add(this.lblSyntax, 0, 8);
            this.tlpBody.Controls.Add(this.tbBin, 0, 1);
            this.tlpBody.Controls.Add(this.btnAdd, 0, 10);
            this.tlpBody.Controls.Add(this.rtbOut, 0, 11);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBody.Location = new System.Drawing.Point(3, 63);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 12;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpBody.Size = new System.Drawing.Size(278, 404);
            this.tlpBody.TabIndex = 1;
            // 
            // tbSyntax
            // 
            this.tbSyntax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSyntax.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSyntax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tbSyntax.Location = new System.Drawing.Point(3, 255);
            this.tbSyntax.Name = "tbSyntax";
            this.tbSyntax.Size = new System.Drawing.Size(272, 20);
            this.tbSyntax.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tbName.Location = new System.Drawing.Point(3, 199);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(272, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbLib
            // 
            this.tbLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLib.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tbLib.Location = new System.Drawing.Point(3, 143);
            this.tbLib.Name = "tbLib";
            this.tbLib.Size = new System.Drawing.Size(272, 20);
            this.tbLib.TabIndex = 7;
            // 
            // tbInclude
            // 
            this.tbInclude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInclude.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInclude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tbInclude.Location = new System.Drawing.Point(3, 87);
            this.tbInclude.Name = "tbInclude";
            this.tbInclude.Size = new System.Drawing.Size(272, 20);
            this.tbInclude.TabIndex = 6;
            // 
            // lblLib
            // 
            this.lblLib.AutoSize = true;
            this.lblLib.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblLib.Location = new System.Drawing.Point(3, 115);
            this.lblLib.Margin = new System.Windows.Forms.Padding(3);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(88, 16);
            this.lblLib.TabIndex = 4;
            this.lblLib.Text = "Lib Folder";
            // 
            // lblInc
            // 
            this.lblInc.AutoSize = true;
            this.lblInc.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblInc.Location = new System.Drawing.Point(3, 59);
            this.lblInc.Margin = new System.Windows.Forms.Padding(3);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(120, 16);
            this.lblInc.TabIndex = 2;
            this.lblInc.Text = "Include Folder";
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBin.Location = new System.Drawing.Point(3, 3);
            this.lblBin.Margin = new System.Windows.Forms.Padding(3);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(88, 16);
            this.lblBin.TabIndex = 0;
            this.lblBin.Text = "Bin Folder";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(3, 171);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Library Name";
            // 
            // lblSyntax
            // 
            this.lblSyntax.AutoSize = true;
            this.lblSyntax.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyntax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblSyntax.Location = new System.Drawing.Point(3, 227);
            this.lblSyntax.Margin = new System.Windows.Forms.Padding(3);
            this.lblSyntax.Name = "lblSyntax";
            this.lblSyntax.Size = new System.Drawing.Size(120, 16);
            this.lblSyntax.TabIndex = 1;
            this.lblSyntax.Text = "Library Syntax";
            // 
            // tbBin
            // 
            this.tbBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tbBin.Location = new System.Drawing.Point(3, 31);
            this.tbBin.Name = "tbBin";
            this.tbBin.Size = new System.Drawing.Size(272, 20);
            this.tbBin.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btnAdd.Location = new System.Drawing.Point(79, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 22);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Library";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtbOut
            // 
            this.rtbOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.rtbOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rtbOut.Location = new System.Drawing.Point(3, 311);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(272, 90);
            this.rtbOut.TabIndex = 11;
            this.rtbOut.Text = "Output...\n";
            // 
            // frmAddLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(284, 470);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "frmAddLib";
            this.Text = "New Libaray";
            this.Load += new System.EventHandler(this.frmAddLib_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRibbon)).EndInit();
            this.tlpBody.ResumeLayout(false);
            this.tlpBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbRibbon;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.TextBox tbSyntax;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLib;
        private System.Windows.Forms.TextBox tbInclude;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.Label lblInc;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSyntax;
        private System.Windows.Forms.TextBox tbBin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtbOut;
    }
}