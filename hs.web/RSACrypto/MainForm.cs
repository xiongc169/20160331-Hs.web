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

        private string tsPublicKeyJava = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCA5xCau7f76VPU+DNxDBLyJkpCnfT8IxSi024rAqc+psStGWLLMN0LHhet8zdpZ1wtltAycEZLZnwdQiCWCTMdHX7YExWqXBQjQhkJf9njKxom5T9cDIY06Z8Vl+pvLTK4RmjMLLJAcRzu40Ifq8G2jobK3k2g2dUKHFj0sfvjfQIDAQAB";
        private RSASecurity RsaSecurity = new RSASecurity();

        //云毅网站
        private string myNetPrivateKey = "<RSAKeyValue><Modulus>2mILhP5P4q6NDnUCV1+ZNPBT0voHRXezoqQcWikcAX1slrH5uonHdQjFtKG1996K04YFHoOATi/LAEWz/4U9mwXLPXTVA6k4hmabHHM0iwZo+p+oOiTBmhN+WfLxuD2B8GdRM0vbZu9vT6QPc7yyzUL20Gs67xzpAQ96B/G8ZRc=</Modulus><Exponent>AQAB</Exponent><P>9Uom8rm3if+C8HQE6gaP/DDdTUnU1G5NWRjbADGeYqdj91FcUn5YI7sOYqbNx6pNIsXhR/ffZtCGK9H/C5QJcQ==</P><Q>4+shTr80Xb0GL7oFqEcQLZ3FRgDP2sKfIRR/gTuzglE6tOkPA+s39w3d7/bfUe0Hytb6RfnVy80nc5igt2jTBw==</Q><DP>rKGff7zNO8YkNW6x9rLfqzIIzlhj/Y4Tyd0AZMaHHg+I/4q3WyeoiJ0hprSWpytoVkzGHIyLIiUoCLcmtNNfQQ==</DP><DQ>gcxnhJw5q2S6ADY1gJcv7HqcXXia5x/NVh6BWszwNzghceQEbBvqHGWmTkHO/q45sNfrYiydCFrGq/txE+K7ww==</DQ><InverseQ>1UiWh9qcSIbdj+xHn9YYrhTerugTkiq2+GVhJVUS1yPrMhgPCrfqiQc9tWVrexxg68VrlgLne1NOHtS8ZSGlAg==</InverseQ><D>F6TI2X/NN14toHSTqdEMXdptQOjYE7HXjZLWDP7pbNHfCVvAjW0wXp/yA9IESQ9bmXYnpLuZDx4GjQN+7vnGhwh4PeFvJZVJrszKr0ZZyfDTdxfzo+RkIx930QhBzPDmASbP2xtcVWWVlCgzuM1dAoS/Jg81R+Nxf1mhGWcCTrE=</D></RSAKeyValue>";
        private string myNetPublicKey = "<RSAKeyValue><Modulus>2mILhP5P4q6NDnUCV1+ZNPBT0voHRXezoqQcWikcAX1slrH5uonHdQjFtKG1996K04YFHoOATi/LAEWz/4U9mwXLPXTVA6k4hmabHHM0iwZo+p+oOiTBmhN+WfLxuD2B8GdRM0vbZu9vT6QPc7yyzUL20Gs67xzpAQ96B/G8ZRc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        private string myJavaPublicKey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCvN0P3p6E3UVIDgxVVlOMWz1Al0qhhZrXbycCUcoSoq56gZaDVdWdq7oroy5sbQIt1X8zwn5hCbaJSXiM/3EWTWUwWiW90JZ1+Cjsk6iuNkiMhJ7YQeIWNWuI4aTU3ACOdTp4CRYmp5SVcXbdlAdh06pzzunW0xi0xa/GKG2uQrwIDAQAB";
        private string myJavaPrivateKey = "MIICWwIBAAKBgQCvN0P3p6E3UVIDgxVVlOMWz1Al0qhhZrXbycCUcoSoq56gZaDVdWdq7oroy5sbQIt1X8zwn5hCbaJSXiM/3EWTWUwWiW90JZ1+Cjsk6iuNkiMhJ7YQeIWNWuI4aTU3ACOdTp4CRYmp5SVcXbdlAdh06pzzunW0xi0xa/GKG2uQrwIDAQABAoGAKzcSSG7L0Hz6IWufQ3BpYiLXvbxrUzql+AOWwAZOuds6UI1AUeWXEEStdiVhqCMPQm/SeDaksx2fP3mAcCu/7OLnYV/0G5+d2HRtMV+uOg71nwLipHVA0Jj2M7ufAAhEcewZXTesUJbdazfnpWidoBx3Zjgqf7vshXouWz0pb6ECQQDm/0APVlO3i1VzfVE/ABKGIWl9h8mDedqJ4fhhwUqc1F1OTV9lUT0xlNrHK3XMhBOvnVq+LNuwELBX4rtituTTAkEAwi5cmdA3fnSatfKBjWa/07Frwz3O+QRB1YSUIUGxGnLhuhIGYiDaoLev8JX8gf/LkCZDJvi2A9zAUqai9C5rNQJAOrw8danlr43mNG9w8Sv7ic+FGz4jpyKcxuKGXZTge/AjqX1S/Fgjzy+iUXJjiZUrzEOehyywz5vuuuoT643FsQJAZ21AP2ELHdzHxt+7J3Cx/fSDXIPgaPxegHbUW35c8aR9HJmbMssjB/WuzatlymxPpaDrpadVc2syOROuufa7fQJAIaHn8fSrxXO7r9fijrudmfJP9jY78Aa/2Vkb7AN+VtXoRHELF9w4EQctYSz9cj4ys0MnXSAy4QTHE1+7rBLDfQ==";
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string tsPublicKeDotNet = KeyConvertor.RSAPublicKeyJava2DotNet(tsPublicKeyJava);
            string plaintext = this.tbxPlaintext.Text;
            if (string.IsNullOrEmpty(plaintext))
            {
                return;
            }
            this.tbxCiphertext.Text = RsaSecurity.Encrypt(plaintext, tsPublicKeDotNet);

            //RSA加密、解密测试(RSA生成的.net密钥)
            string password = RsaSecurity.Encrypt("yunyi@2016", myNetPublicKey);
            string text = RsaSecurity.Decrypt(password, myNetPrivateKey);

            string test = KeyConvertor.RSAPrivateKeyDotNet2Java(myNetPrivateKey);

            //RSA加密、解密测试(openssl.exe生成的java密钥)
            string myJavaPublicKeyNet = KeyConvertor.RSAPublicKeyJava2DotNet(myJavaPublicKey);
            string myJavaPrivateKeyNet = KeyConvertor.RSAPrivateKeyJava2DotNet2(myJavaPrivateKey);//抛异常！！！
            string password2 = RsaSecurity.Encrypt("hundsun$$600570", myJavaPublicKeyNet);
            string text2 = RsaSecurity.Decrypt(password, myJavaPrivateKeyNet);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            RSAKey rsaKey = RsaSecurity.GenerateRSAKey();
        }
    }
}
