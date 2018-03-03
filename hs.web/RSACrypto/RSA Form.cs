using RSACrypto;
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
    public partial class RSA_Form : Form
    {
        private RSASecurity RsaSecurity = new RSASecurity();

        /// <summary>
        /// 私钥
        /// </summary>
        private string myNetPrivateKey = "<RSAKeyValue><Modulus>2mILhP5P4q6NDnUCV1+ZNPBT0voHRXezoqQcWikcAX1slrH5uonHdQjFtKG1996K04YFHoOATi/LAEWz/4U9mwXLPXTVA6k4hmabHHM0iwZo+p+oOiTBmhN+WfLxuD2B8GdRM0vbZu9vT6QPc7yyzUL20Gs67xzpAQ96B/G8ZRc=</Modulus><Exponent>AQAB</Exponent><P>9Uom8rm3if+C8HQE6gaP/DDdTUnU1G5NWRjbADGeYqdj91FcUn5YI7sOYqbNx6pNIsXhR/ffZtCGK9H/C5QJcQ==</P><Q>4+shTr80Xb0GL7oFqEcQLZ3FRgDP2sKfIRR/gTuzglE6tOkPA+s39w3d7/bfUe0Hytb6RfnVy80nc5igt2jTBw==</Q><DP>rKGff7zNO8YkNW6x9rLfqzIIzlhj/Y4Tyd0AZMaHHg+I/4q3WyeoiJ0hprSWpytoVkzGHIyLIiUoCLcmtNNfQQ==</DP><DQ>gcxnhJw5q2S6ADY1gJcv7HqcXXia5x/NVh6BWszwNzghceQEbBvqHGWmTkHO/q45sNfrYiydCFrGq/txE+K7ww==</DQ><InverseQ>1UiWh9qcSIbdj+xHn9YYrhTerugTkiq2+GVhJVUS1yPrMhgPCrfqiQc9tWVrexxg68VrlgLne1NOHtS8ZSGlAg==</InverseQ><D>F6TI2X/NN14toHSTqdEMXdptQOjYE7HXjZLWDP7pbNHfCVvAjW0wXp/yA9IESQ9bmXYnpLuZDx4GjQN+7vnGhwh4PeFvJZVJrszKr0ZZyfDTdxfzo+RkIx930QhBzPDmASbP2xtcVWWVlCgzuM1dAoS/Jg81R+Nxf1mhGWcCTrE=</D></RSAKeyValue>";

        /// <summary>
        /// 公钥
        /// </summary>
        private string myNetPublicKey = "<RSAKeyValue><Modulus>2mILhP5P4q6NDnUCV1+ZNPBT0voHRXezoqQcWikcAX1slrH5uonHdQjFtKG1996K04YFHoOATi/LAEWz/4U9mwXLPXTVA6k4hmabHHM0iwZo+p+oOiTBmhN+WfLxuD2B8GdRM0vbZu9vT6QPc7yyzUL20Gs67xzpAQ96B/G8ZRc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";


        public RSA_Form()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = this.tbxPlaintext.Text;
            if (string.IsNullOrEmpty(plaintext))
            {
                return;
            }

            try
            {
                //RSA加密测试(RSA生成的.net密钥)
                string cipherText = RsaSecurity.Encrypt(plaintext, myNetPublicKey);
                this.tbxCiphertext.Text = cipherText;
            }
            catch (Exception ex)
            {
                this.tbxCiphertext.Text = string.Format("加密异常：{0}", ex.Message); ;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = this.tbxCiphertext.Text;
            if (string.IsNullOrEmpty(cipherText))
            {
                return;
            }

            try
            {
                //RSA解密测试(RSA生成的.net密钥)
                string plaintext = RsaSecurity.Decrypt(cipherText, myNetPrivateKey);
                this.tbxPlaintext.Text = plaintext;
            }
            catch (Exception ex)
            {
                this.tbxCiphertext.Text = string.Format("解密异常：{0}", ex.Message); ;
            }
        }
    }
}
