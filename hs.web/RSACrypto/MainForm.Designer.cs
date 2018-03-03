namespace RSACrypto
{
    partial class MainForm
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
            this.tbxPlaintext = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbxCiphertext = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbxTarget = new System.Windows.Forms.TextBox();
            this.btnX509CertEncrypt = new System.Windows.Forms.Button();
            this.btnX509CertDecrypt = new System.Windows.Forms.Button();
            this.tbxTarget1 = new System.Windows.Forms.TextBox();
            this.tbxCiphertext1 = new System.Windows.Forms.TextBox();
            this.tbxPlaintext1 = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPlaintext
            // 
            this.tbxPlaintext.Location = new System.Drawing.Point(21, 16);
            this.tbxPlaintext.Multiline = true;
            this.tbxPlaintext.Name = "tbxPlaintext";
            this.tbxPlaintext.Size = new System.Drawing.Size(291, 100);
            this.tbxPlaintext.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(145, 122);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbxCiphertext
            // 
            this.tbxCiphertext.Location = new System.Drawing.Point(21, 160);
            this.tbxCiphertext.Multiline = true;
            this.tbxCiphertext.Name = "tbxCiphertext";
            this.tbxCiphertext.Size = new System.Drawing.Size(291, 100);
            this.tbxCiphertext.TabIndex = 2;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(145, 271);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbxTarget
            // 
            this.tbxTarget.Location = new System.Drawing.Point(21, 308);
            this.tbxTarget.Multiline = true;
            this.tbxTarget.Name = "tbxTarget";
            this.tbxTarget.Size = new System.Drawing.Size(291, 100);
            this.tbxTarget.TabIndex = 4;
            // 
            // btnX509CertEncrypt
            // 
            this.btnX509CertEncrypt.Location = new System.Drawing.Point(470, 122);
            this.btnX509CertEncrypt.Name = "btnX509CertEncrypt";
            this.btnX509CertEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnX509CertEncrypt.TabIndex = 5;
            this.btnX509CertEncrypt.Text = "证书加密";
            this.btnX509CertEncrypt.UseVisualStyleBackColor = true;
            this.btnX509CertEncrypt.Click += new System.EventHandler(this.btnX509CertEncrypt_Click);
            // 
            // btnX509CertDecrypt
            // 
            this.btnX509CertDecrypt.Location = new System.Drawing.Point(470, 271);
            this.btnX509CertDecrypt.Name = "btnX509CertDecrypt";
            this.btnX509CertDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnX509CertDecrypt.TabIndex = 6;
            this.btnX509CertDecrypt.Text = "证书解密";
            this.btnX509CertDecrypt.UseVisualStyleBackColor = true;
            this.btnX509CertDecrypt.Click += new System.EventHandler(this.btnX509CertDecrypt_Click);
            // 
            // tbxTarget1
            // 
            this.tbxTarget1.Location = new System.Drawing.Point(373, 308);
            this.tbxTarget1.Multiline = true;
            this.tbxTarget1.Name = "tbxTarget1";
            this.tbxTarget1.Size = new System.Drawing.Size(291, 100);
            this.tbxTarget1.TabIndex = 9;
            // 
            // tbxCiphertext1
            // 
            this.tbxCiphertext1.Location = new System.Drawing.Point(373, 160);
            this.tbxCiphertext1.Multiline = true;
            this.tbxCiphertext1.Name = "tbxCiphertext1";
            this.tbxCiphertext1.Size = new System.Drawing.Size(291, 100);
            this.tbxCiphertext1.TabIndex = 8;
            // 
            // tbxPlaintext1
            // 
            this.tbxPlaintext1.Location = new System.Drawing.Point(373, 16);
            this.tbxPlaintext1.Multiline = true;
            this.tbxPlaintext1.Name = "tbxPlaintext1";
            this.tbxPlaintext1.Size = new System.Drawing.Size(291, 100);
            this.tbxPlaintext1.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(145, 454);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 520);
            this.Controls.Add(this.tbxTarget1);
            this.Controls.Add(this.tbxCiphertext1);
            this.Controls.Add(this.tbxPlaintext1);
            this.Controls.Add(this.btnX509CertDecrypt);
            this.Controls.Add(this.btnX509CertEncrypt);
            this.Controls.Add(this.tbxTarget);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.tbxCiphertext);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbxPlaintext);
            this.Name = "MainForm";
            this.Text = "RSA加解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPlaintext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbxCiphertext;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbxTarget;
        private System.Windows.Forms.Button btnX509CertEncrypt;
        private System.Windows.Forms.Button btnX509CertDecrypt;
        private System.Windows.Forms.TextBox tbxTarget1;
        private System.Windows.Forms.TextBox tbxCiphertext1;
        private System.Windows.Forms.TextBox tbxPlaintext1;
        private System.Windows.Forms.Button btnTest;
    }
}