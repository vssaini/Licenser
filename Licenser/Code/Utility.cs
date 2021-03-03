using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Licenser.Properties;
using Portable.Licensing;
using Portable.Licensing.Validation;

namespace Licenser.Code
{
    enum Category { Error, Success }

    class Utility
    {
        #region Properties

        /// <summary>
        /// Get or set private key
        /// </summary>
        public static string PrivateKey { get; set; }

        /// <summary>
        /// Get or set public key
        /// </summary>
        public static string PublicKey { get; set; }

        /// <summary>
        /// Get or set pass phrase
        /// </summary>
        public static string PassPhrase { get; set; }

        /// <summary>
        /// Get or set license path
        /// </summary>
        public static string LicensePath { get; set; }

        #endregion

        /// <summary>
        /// Show error on respective textbox control if blank value provided.
        /// </summary>
        /// <param name="textBox">The textbox control</param>
        /// <param name="errorProvider">The error provider control</param>
        /// <returns>Return true if error is showed else false.</returns>
        public static bool ErrorShowed(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Value can't be left blank.");
                return true;
            }

            errorProvider.SetError(textBox, null);
            return false;
        }

        /// <summary>
        /// Check if license is valid or not.
        /// </summary>
        /// <returns>Return true if license is valid.</returns>
        public static bool IsValidLicense(out string validationMessage)
        {
            bool isValid = false;
            string validationMsg = null;
            try
            {
                //var licenseContent = File.ReadAllText(LicensePath);

                var licenseContent = string.Format(Settings.Default.LicenseContent, Settings.Default.Signature);
                PublicKey = Settings.Default.PublicKey;

                //var validationFailures = license.Validate().ExpirationDate()
                //    .When(lic => lic.Type == LicenseType.Trial)
                //    .And()
                //    .Signature(PublicKey)
                //    .AssertValidLicense();

                var license = License.Load(licenseContent);

                var validationFailures = license.Validate().Signature(PublicKey)
                    .When(lic => lic.Type == LicenseType.Standard)
                    .AssertValidLicense();

                foreach (var failure in validationFailures.ToList())
                {
                    validationMsg += failure.GetType().Name + ": " + failure.Message + " - " + failure.HowToResolve;
                }

                // if (license.Customer.Email.Contains("vs00saini@gmail.com") && string.IsNullOrEmpty(validationMsg))
                if (string.IsNullOrEmpty(validationMsg))
                    isValid = true;
            }
            catch (Exception)
            {
                isValid = false;
                validationMsg = "Invalid license file.";
            }

            validationMessage = validationMsg;
            return isValid;
        }

        /// <summary>
        /// Generate license file
        /// </summary>
        /// <returns></returns>
        public static bool GenerateLicense()
        {
            // Create license
            //var license = License.New()
            //    .WithUniqueIdentifier(Guid.NewGuid())
            //    .As(LicenseType.Trial)
            //    .ExpiresAt(DateTime.Now.AddDays(30))
            //    .WithMaximumUtilization(5)
            //    .LicensedTo("Vikram Singh Saini", "vs00saini@gmail.com")
            //    .CreateAndSignWithPrivateKey(PrivateKey, PassPhrase);

            var license = License.New()
                .WithUniqueIdentifier(Guid.NewGuid())
                .As(LicenseType.Standard)
                .CreateAndSignWithPrivateKey(PrivateKey, PassPhrase);

            // Save license content into license file
            File.WriteAllText(LicensePath, license.ToString(), Encoding.UTF8);
            return true;
        }
    }
}
