
namespace HashVerifier
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.rbMD5 = new System.Windows.Forms.RadioButton();
            this.rbSHA1 = new System.Windows.Forms.RadioButton();
            this.rbSHA256 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Info2 = new System.Windows.Forms.Label();
            this.lbl_Info3 = new System.Windows.Forms.Label();
            this.lbl_Info4 = new System.Windows.Forms.Label();
            this.btn_Paste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(145, 42);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(240, 47);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(90, 13);
            this.lblSelectedFile.TabIndex = 1;
            this.lblSelectedFile.Text = "Nothing selected!";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(145, 146);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtHash
            // 
            this.txtHash.AccessibleDescription = "Insert the HASH";
            this.txtHash.Location = new System.Drawing.Point(145, 97);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(389, 20);
            this.txtHash.TabIndex = 3;
            this.txtHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHash.TextChanged += new System.EventHandler(this.Check_Length);
            // 
            // rbMD5
            // 
            this.rbMD5.AutoSize = true;
            this.rbMD5.Location = new System.Drawing.Point(145, 123);
            this.rbMD5.Name = "rbMD5";
            this.rbMD5.Size = new System.Drawing.Size(48, 17);
            this.rbMD5.TabIndex = 4;
            this.rbMD5.TabStop = true;
            this.rbMD5.Text = "MD5";
            this.rbMD5.UseVisualStyleBackColor = true;
            // 
            // rbSHA1
            // 
            this.rbSHA1.AutoSize = true;
            this.rbSHA1.Location = new System.Drawing.Point(199, 123);
            this.rbSHA1.Name = "rbSHA1";
            this.rbSHA1.Size = new System.Drawing.Size(53, 17);
            this.rbSHA1.TabIndex = 5;
            this.rbSHA1.TabStop = true;
            this.rbSHA1.Text = "SHA1";
            this.rbSHA1.UseVisualStyleBackColor = true;
            // 
            // rbSHA256
            // 
            this.rbSHA256.AutoSize = true;
            this.rbSHA256.Location = new System.Drawing.Point(258, 123);
            this.rbSHA256.Name = "rbSHA256";
            this.rbSHA256.Size = new System.Drawing.Size(65, 17);
            this.rbSHA256.TabIndex = 6;
            this.rbSHA256.TabStop = true;
            this.rbSHA256.Text = "SHA256";
            this.rbSHA256.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "1. Select a File -->";
            // 
            // lbl_Info2
            // 
            this.lbl_Info2.AutoSize = true;
            this.lbl_Info2.Location = new System.Drawing.Point(12, 74);
            this.lbl_Info2.Name = "lbl_Info2";
            this.lbl_Info2.Size = new System.Drawing.Size(107, 13);
            this.lbl_Info2.TabIndex = 8;
            this.lbl_Info2.Text = "2. Paste the Hash -->";
            // 
            // lbl_Info3
            // 
            this.lbl_Info3.AutoSize = true;
            this.lbl_Info3.Location = new System.Drawing.Point(12, 125);
            this.lbl_Info3.Name = "lbl_Info3";
            this.lbl_Info3.Size = new System.Drawing.Size(129, 13);
            this.lbl_Info3.TabIndex = 9;
            this.lbl_Info3.Text = "3. Check the Algorithm -->";
            // 
            // lbl_Info4
            // 
            this.lbl_Info4.AutoSize = true;
            this.lbl_Info4.Location = new System.Drawing.Point(12, 151);
            this.lbl_Info4.Name = "lbl_Info4";
            this.lbl_Info4.Size = new System.Drawing.Size(103, 13);
            this.lbl_Info4.TabIndex = 10;
            this.lbl_Info4.Text = "4. Press to verify! -->";
            // 
            // btn_Paste
            // 
            this.btn_Paste.Location = new System.Drawing.Point(145, 69);
            this.btn_Paste.Name = "btn_Paste";
            this.btn_Paste.Size = new System.Drawing.Size(75, 23);
            this.btn_Paste.TabIndex = 11;
            this.btn_Paste.Text = "Paste";
            this.btn_Paste.UseVisualStyleBackColor = true;
            this.btn_Paste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 204);
            this.Controls.Add(this.btn_Paste);
            this.Controls.Add(this.lbl_Info4);
            this.Controls.Add(this.lbl_Info3);
            this.Controls.Add(this.lbl_Info2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbSHA256);
            this.Controls.Add(this.rbSHA1);
            this.Controls.Add(this.rbMD5);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashVerifier (by Sergio Inga)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.RadioButton rbMD5;
        private System.Windows.Forms.RadioButton rbSHA1;
        private System.Windows.Forms.RadioButton rbSHA256;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Info2;
        private System.Windows.Forms.Label lbl_Info3;
        private System.Windows.Forms.Label lbl_Info4;
        private System.Windows.Forms.Button btn_Paste;
    }
}

