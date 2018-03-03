using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSACrypto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string privatekey = "<RSAKeyValue><Modulus>wyTyIqopwp7ihJ9LT3q6C864TbpghaInxewqsJTmFqqd9aSkiSRRSW8TGnKzUz204UTCOaltgh26eVRHsizzP8xLk75arIf17EvNC10tjAL0uPeUNNYvmnjugCIXEBl47/sktMxJ8Kq72jD5PyUq+VPfgFEjlnt5pwSyc2Ntvlc=</Modulus><Exponent>AQAB</Exponent><P>7ZLqwwXzxFFUsuj6r/wyAfgGDv5pg/pVgzAqpGtpa6jsXDSOJBEShs2DpdpDkQ/R8APwQI88bBFsivk4hfYS6w==</P><Q>0keUf9cQwEY/K12hZFnnJdfGgmEDCBOLGklTxfUvTxtenJpN76SqUxBmsX4mJ801hdm8wg/7xZRwgPyS8ISvRQ==</Q><DP>iiV9Z+xlJIpaozKA26bd+XEdLMjZ2InQAdoXYcan5Zez4aYZ5XUb/dExtVanJYo6fMP9h70C2KCFKobjTFqcAw==</DP><DQ>VQH2+I97CB/d3awmWKk3lsbaS07oqNUtwNyv7zElhPdtkiWXKDALYzUYLtzuk9yTrJ7Pfixz/fX6XUq+JFmfeQ==</DQ><InverseQ>tEn8zFMAISq4bpDfCTHhuVzdmdX4CBfVznNiFPfYTtwJvl1G8n3CjeF417D7y8IxoMZ8/Hz/c6neXWe7beHQQg==</InverseQ><D>CXT45wUoEO5yO8scczWXXoseE2Y81z0MgGL5jqUooWCTVxwrfRntdomTe2yjlB0hbulOIE09qViXeNnEv7W98/vWXw+8/y9qmw5zvWDiUAaeu3YYiLxO9hrUiMjGZvKH/pcmYeJQDFLK7py1VqJxBI+ltv/PGmKpiNgtDFZHUEE=</D></RSAKeyValue>";
        private string publickey = "<RSAKeyValue><Modulus>wyTyIqopwp7ihJ9LT3q6C864TbpghaInxewqsJTmFqqd9aSkiSRRSW8TGnKzUz204UTCOaltgh26eVRHsizzP8xLk75arIf17EvNC10tjAL0uPeUNNYvmnjugCIXEBl47/sktMxJ8Kq72jD5PyUq+VPfgFEjlnt5pwSyc2Ntvlc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private RSASecurity RsaSecurity = new RSASecurity();
        
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string  plaintext =this.tbxPlaintext.Text;
            if (string.IsNullOrEmpty(plaintext))
            {
                return;
            }
            this.tbxCiphertext.Text = RsaSecurity.Encrypt(plaintext, publickey);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = this.tbxCiphertext.Text;
            this.tbxTarget.Text = RsaSecurity.Decrypt(ciphertext, privatekey);
        }

        /// <summary>
        /// 证书加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnX509CertEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = this.tbxPlaintext1.Text;
            if (string.IsNullOrEmpty(plaintext))
            {
                return;
            }
            string certFile = "KEY/RSAKey.cer";
            this.tbxCiphertext1.Text = RsaSecurity.X509CertEncrypt(plaintext, certFile);
        }

        /// <summary>
        /// 证书解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnX509CertDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = this.tbxCiphertext1.Text;
            string keyfile = "KEY/RSAKey.pfx";
            this.tbxTarget1.Text = RsaSecurity.X509CertDecrypt(ciphertext, keyfile, "888888");
        }
    }
}
