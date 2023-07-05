using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashVerifier
{
    public partial class MainForm : Form
    {
        private string selectedFilePath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                lblSelectedFile.Text = Path.GetFileName(selectedFilePath);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file.");
                return;
            }

            if (string.IsNullOrEmpty(txtHash.Text))
            {
                MessageBox.Show("Please enter the hash value.");
                return;
            }

            string hashAlgorithm = GetSelectedHashAlgorithm();

            using (var hashAlgorithmInstance = GetHashAlgorithmInstance(hashAlgorithm))
            {
                string computedHash = ComputeFileHash(selectedFilePath, hashAlgorithmInstance);

                if (txtHash.Text.Equals(computedHash, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Hash verification successful.");
                }
                else
                {
                    MessageBox.Show("Hash verification failed.");
                }
            }
        }

        private string GetSelectedHashAlgorithm()
        {
            if (rbMD5.Checked)
            {
                return "MD5";
            }
            else if (rbSHA1.Checked)
            {
                return "SHA1";
            }
            else if (rbSHA256.Checked)
            {
                return "SHA256";
            }

            throw new Exception("No hash algorithm selected.");
        }

        private HashAlgorithm GetHashAlgorithmInstance(string hashAlgorithm)
        {
            switch (hashAlgorithm)
            {
                case "MD5":
                    return MD5.Create();
                case "SHA1":
                    return SHA1.Create();
                case "SHA256":
                    return SHA256.Create();
                default:
                    throw new Exception("Invalid hash algorithm.");
            }
        }

        private string ComputeFileHash(string filePath, HashAlgorithm hashAlgorithm)
        {
            using (var stream = File.OpenRead(filePath))
            {
                byte[] hash = hashAlgorithm.ComputeHash(stream);
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hash)
                {
                    hashString.Append(b.ToString("X2"));
                }
                return hashString.ToString();
            }
        }
        private void Check_Length(object sender, EventArgs e)
        {
            int md5 = 32;
            int sha1 = 40;
            int sha256 = 64;
            if (txtHash.Text.Length == md5)
            {
                rbMD5.Checked=true;
            }
            else if (txtHash.Text.Length == sha1)
            {

                rbSHA1.Checked = true;
            }
            else if (txtHash.Text.Length == sha256)
            {
                
                rbSHA256.Checked = true;
            }
            else
            {
                rbMD5.Checked = false;
                rbSHA1.Checked = false;
                rbSHA256.Checked = false;
            }
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtHash.Text = Clipboard.GetText();
        }

    }
}

