using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility.descrypt
{
    /// <summary>
    /// http://www.cnblogs.com/heimalang/p/6502003.html
    /// </summary>
    class DESHelper3
    {
        /// <summary>
        /// 生成key
        /// </summary>
        public static void Generator(out string key)
        {
            DESCryptoServiceProvider des = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create("DES");
            key = ASCIIEncoding.ASCII.GetString(des.Key);
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="password"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DESEncrypt(string password, string key)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
            ICryptoTransform desEncrypt = DES.CreateEncryptor();
            byte[] result = desEncrypt.TransformFinalBlock(data, 0, data.Length);
            return BitConverter.ToString(result);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="password"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DESDecrypt(string password, string key)
        {
            string[] sinput = password.Split("-".ToCharArray());
            byte[] data = new byte[sinput.Length];
            for (int i = 0; i < sinput.Length; i++)
            {
                data[i] = byte.Parse(sinput[i], NumberStyles.HexNumber);
            }
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
            ICryptoTransform desencrypt = DES.CreateDecryptor();
            byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
            return Encoding.UTF8.GetString(result);
        }

        /// <summary>   
        /// 加密数据   MD5方式
        /// </summary>   
        /// <param name="str"></param>   
        /// <param name="key">加密密钥</param>   
        /// <returns></returns>   
        public static string DESEncryptMD5(string str, string key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray;
            inputByteArray = Encoding.Default.GetBytes(str);
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5").Substring(0, 8));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
                ret.AppendFormat("{0:X2}", b);
            return ret.ToString();
        }

        /// <summary>   
        /// 解密数据   MD5方式
        /// </summary>   
        /// <param name="str"></param>   
        /// <param name="key">加密密钥</param>   
        /// <returns></returns>   
        public static string DESDecryptMD5(string str, string key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = str.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(str.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5").Substring(0, 8));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }
    }
}
