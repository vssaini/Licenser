using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Licenser.Code;
using Portable.Licensing.Security.Cryptography;

namespace Licenser
{
    // Reference : https://github.com/dnauck/Portable.Licensing
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var defaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderBrowserDialog.SelectedPath = txtLicensePath.Text = defaultFolder;
            Utility.LicensePath = string.Format(@"{0}\License.lic", defaultFolder);
        }

        private void txtPassPhrase_TextChanged(object sender, EventArgs e)
        {
            Utility.ErrorShowed(txtPassPhrase, errorProvider);
        }

        private void txtPublicKey_TextChanged(object sender, EventArgs e)
        {
            Utility.PublicKey = txtPublicKey.Text.Trim();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            if (Utility.ErrorShowed(txtPassPhrase, errorProvider)) return;

            Utility.PassPhrase = txtPassPhrase.Text.Trim();

            try
            {
                var keyGenerator = KeyGenerator.Create();
                var keyPair = keyGenerator.GenerateKeyPair();
                txtPrivateKey.Text = Utility.PrivateKey = keyPair.ToEncryptedPrivateKeyString(Utility.PassPhrase);
                txtPublicKey.Text = keyPair.ToPublicKeyString();
                SetStatus(Category.Success, "Keys pair generated successfully!");
            }
            catch (Exception exc)
            {
                SetStatus(Category.Error, string.Format("Error: {0}", exc.Message));
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog().Equals(DialogResult.OK))
                txtLicensePath.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnGenerateLicenseFile_Click(object sender, EventArgs e)
        {
            if (Utility.ErrorShowed(txtLicensePath, errorProvider)) return;

            try
            {
                Utility.LicensePath = Path.Combine(txtLicensePath.Text, "License.lic");
                if (Utility.GenerateLicense())
                    SetStatus(Category.Success, "License file saved successfully!");
            }
            catch (Exception exc)
            {
                SetStatus(Category.Error, string.Format("Error: {0}", exc.Message));
            }
        }

        private void btnValidateLicense_Click(object sender, EventArgs e)
        {
            string validationMessage;
            Utility.IsValidLicense(out validationMessage);

            if (!string.IsNullOrEmpty(validationMessage))
                SetStatus(Category.Error, string.Format("Error: {0}", validationMessage));
            else
                SetStatus(Category.Success, "Congrats! You are a genuine license holder.");

        }

        private void linkCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/dnauck/Portable.Licensing");
        }

        private void linkDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://lnkd.in/bJ3eyHY");
        }

        /// <summary>
        /// Set status and color accordingly.
        /// </summary>
        private void SetStatus(Category category, string message)
        {
            switch (category)
            {
                case Category.Error:
                    lblStatus.ForeColor = Color.Red;

                    break;
                case Category.Success:
                    lblStatus.ForeColor = Color.DarkGreen;
                    break;
            }

            lblStatus.Text = message;
        }
    }
}
