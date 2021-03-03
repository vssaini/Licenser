namespace Licenser
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicensePath = new System.Windows.Forms.TextBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbKeysPair = new System.Windows.Forms.GroupBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPassPhrase = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbLicenseGenerator = new System.Windows.Forms.GroupBox();
            this.btnGenerateLicenseFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnValidateLicense = new System.Windows.Forms.Button();
            this.linkCredits = new System.Windows.Forms.LinkLabel();
            this.linkDeveloper = new System.Windows.Forms.LinkLabel();
            this.statusStrip1.SuspendLayout();
            this.gbKeysPair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbLicenseGenerator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(307, 51);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(45, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = ". . . ";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set directory for license file:";
            // 
            // txtLicensePath
            // 
            this.txtLicensePath.Location = new System.Drawing.Point(20, 51);
            this.txtLicensePath.Name = "txtLicensePath";
            this.txtLicensePath.Size = new System.Drawing.Size(281, 23);
            this.txtLicensePath.TabIndex = 2;
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Image = global::Licenser.Properties.Resources.ImgKey;
            this.btnGenerateKeys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateKeys.Location = new System.Drawing.Point(243, 113);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(109, 28);
            this.btnGenerateKeys.TabIndex = 4;
            this.btnGenerateKeys.Text = "Generate Keys";
            this.btnGenerateKeys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(396, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(355, 17);
            this.lblStatus.Text = "Generate keys and license file. Finally validate to check if all is fine.";
            // 
            // gbKeysPair
            // 
            this.gbKeysPair.Controls.Add(this.txtPublicKey);
            this.gbKeysPair.Controls.Add(this.label4);
            this.gbKeysPair.Controls.Add(this.label3);
            this.gbKeysPair.Controls.Add(this.btnGenerateKeys);
            this.gbKeysPair.Controls.Add(this.label2);
            this.gbKeysPair.Controls.Add(this.txtPrivateKey);
            this.gbKeysPair.Controls.Add(this.txtPassPhrase);
            this.gbKeysPair.Location = new System.Drawing.Point(12, 15);
            this.gbKeysPair.Name = "gbKeysPair";
            this.gbKeysPair.Size = new System.Drawing.Size(373, 151);
            this.gbKeysPair.TabIndex = 7;
            this.gbKeysPair.TabStop = false;
            this.gbKeysPair.Text = "Create private and public key";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(91, 84);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(261, 23);
            this.txtPublicKey.TabIndex = 12;
            this.toolTip.SetToolTip(this.txtPublicKey, "Will be provided to end users");
            this.txtPublicKey.TextChanged += new System.EventHandler(this.txtPublicKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Public Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Private Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pass Phrase:";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(91, 55);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(261, 23);
            this.txtPrivateKey.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtPrivateKey, "The key that need to be keep confidential");
            // 
            // txtPassPhrase
            // 
            this.txtPassPhrase.Location = new System.Drawing.Point(91, 25);
            this.txtPassPhrase.Name = "txtPassPhrase";
            this.txtPassPhrase.Size = new System.Drawing.Size(261, 23);
            this.txtPassPhrase.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtPassPhrase, "Will be used for generating private key");
            this.txtPassPhrase.TextChanged += new System.EventHandler(this.txtPassPhrase_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gbLicenseGenerator
            // 
            this.gbLicenseGenerator.Controls.Add(this.btnGenerateLicenseFile);
            this.gbLicenseGenerator.Controls.Add(this.label1);
            this.gbLicenseGenerator.Controls.Add(this.txtLicensePath);
            this.gbLicenseGenerator.Controls.Add(this.btnBrowse);
            this.gbLicenseGenerator.Location = new System.Drawing.Point(12, 187);
            this.gbLicenseGenerator.Name = "gbLicenseGenerator";
            this.gbLicenseGenerator.Size = new System.Drawing.Size(373, 135);
            this.gbLicenseGenerator.TabIndex = 8;
            this.gbLicenseGenerator.TabStop = false;
            this.gbLicenseGenerator.Text = "License Generator";
            // 
            // btnGenerateLicenseFile
            // 
            this.btnGenerateLicenseFile.Image = global::Licenser.Properties.Resources.ImgLicense;
            this.btnGenerateLicenseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateLicenseFile.Location = new System.Drawing.Point(216, 91);
            this.btnGenerateLicenseFile.Name = "btnGenerateLicenseFile";
            this.btnGenerateLicenseFile.Size = new System.Drawing.Size(136, 28);
            this.btnGenerateLicenseFile.TabIndex = 13;
            this.btnGenerateLicenseFile.Text = "Generate license file";
            this.btnGenerateLicenseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateLicenseFile.UseVisualStyleBackColor = true;
            this.btnGenerateLicenseFile.Click += new System.EventHandler(this.btnGenerateLicenseFile_Click);
            // 
            // btnValidateLicense
            // 
            this.btnValidateLicense.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValidateLicense.Image = global::Licenser.Properties.Resources.ImgValidLicense;
            this.btnValidateLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidateLicense.Location = new System.Drawing.Point(249, 338);
            this.btnValidateLicense.Name = "btnValidateLicense";
            this.btnValidateLicense.Size = new System.Drawing.Size(136, 28);
            this.btnValidateLicense.TabIndex = 14;
            this.btnValidateLicense.Text = "Validate license file";
            this.btnValidateLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidateLicense.UseVisualStyleBackColor = false;
            this.btnValidateLicense.Click += new System.EventHandler(this.btnValidateLicense_Click);
            // 
            // linkCredits
            // 
            this.linkCredits.AutoSize = true;
            this.linkCredits.Location = new System.Drawing.Point(12, 351);
            this.linkCredits.Name = "linkCredits";
            this.linkCredits.Size = new System.Drawing.Size(120, 15);
            this.linkCredits.TabIndex = 15;
            this.linkCredits.TabStop = true;
            this.linkCredits.Text = "Credit - Daniel Nauck";
            this.linkCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCredits_LinkClicked);
            // 
            // linkDeveloper
            // 
            this.linkDeveloper.AutoSize = true;
            this.linkDeveloper.Location = new System.Drawing.Point(12, 382);
            this.linkDeveloper.Name = "linkDeveloper";
            this.linkDeveloper.Size = new System.Drawing.Size(121, 15);
            this.linkDeveloper.TabIndex = 16;
            this.linkDeveloper.TabStop = true;
            this.linkDeveloper.Text = "Developer :- V.S. Saini";
            this.linkDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeveloper_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 429);
            this.Controls.Add(this.linkDeveloper);
            this.Controls.Add(this.linkCredits);
            this.Controls.Add(this.btnValidateLicense);
            this.Controls.Add(this.gbLicenseGenerator);
            this.Controls.Add(this.gbKeysPair);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 441);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licenser";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbKeysPair.ResumeLayout(false);
            this.gbKeysPair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbLicenseGenerator.ResumeLayout(false);
            this.gbLicenseGenerator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicensePath;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox gbKeysPair;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPassPhrase;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbLicenseGenerator;
        private System.Windows.Forms.Button btnGenerateLicenseFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnValidateLicense;
        private System.Windows.Forms.LinkLabel linkCredits;
        private System.Windows.Forms.LinkLabel linkDeveloper;
    }
}

