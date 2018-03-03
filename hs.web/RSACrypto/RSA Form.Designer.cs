namespace RSACrypto
{
    partial class RSA_Form
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbxCiphertext = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbxPlaintext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(210, 149);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "<< 解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbxCiphertext
            // 
            this.tbxCiphertext.Location = new System.Drawing.Point(301, 13);
            this.tbxCiphertext.Multiline = true;
            this.tbxCiphertext.Name = "tbxCiphertext";
            this.tbxCiphertext.Size = new System.Drawing.Size(174, 251);
            this.tbxCiphertext.TabIndex = 6;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(210, 101);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "加密 >>";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbxPlaintext
            // 
            this.tbxPlaintext.Location = new System.Drawing.Point(8, 13);
            this.tbxPlaintext.Multiline = true;
            this.tbxPlaintext.Name = "tbxPlaintext";
            this.tbxPlaintext.Size = new System.Drawing.Size(181, 251);
            this.tbxPlaintext.TabIndex = 4;
            // 
            // RSA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 280);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.tbxCiphertext);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbxPlaintext);
            this.Name = "RSA_Form";
            this.Text = "RSA_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbxCiphertext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbxPlaintext;
    }
}