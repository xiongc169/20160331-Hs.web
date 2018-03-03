using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility.descrypt
{
    class DESHelper5
    {

        /// <summary>  
        /// 默认使用ECB模式进行加密   
        /// </summary>  
        /// <param name="strToEncrypt"></param>  
        /// <param name="sKey"></param>  
        /// <param name="paddingMode"></param>  
        /// <returns>返回的是二进制数据转换为Base64字符串</returns>  
        public static string DESEncrypt(string strToEncrypt, string sKey, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            var result = string.Empty;
            using (var objDesCryptoServiceProvider = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(strToEncrypt);
                objDesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(sKey);
                objDesCryptoServiceProvider.Mode = CipherMode.ECB;
                objDesCryptoServiceProvider.Padding = paddingMode;
                byte[] bysEncrypted =
                    objDesCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(inputByteArray, 0, inputByteArray.Length);
                result = Convert.ToBase64String(bysEncrypted);
            }
            return result;
        }


        /// <summary>  
        /// 默认使用ECB模式进行解密  
        /// </summary>  
        /// <param name="strToDecrypt">输入的是Base64字符串的密文</param>  
        /// <param name="sKey"></param>  
        /// <param name="paddingMode"></param>  
        /// <returns></returns>  
        public static string DESDecrypt(string strToDecrypt, string sKey, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            var result = string.Empty;
            using (var objDesCryptoServiceProvider = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Convert.FromBase64String(strToDecrypt);
                objDesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(sKey);
                objDesCryptoServiceProvider.Mode = CipherMode.ECB;
                objDesCryptoServiceProvider.Padding = paddingMode;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, objDesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(inputByteArray, 0, inputByteArray.Length);
                        cs.FlushFinalBlock();
                        result = Encoding.UTF8.GetString(ms.ToArray()).Replace('\0', ' ');//Zeros模式下去掉多余的补位  
                    }
                }
            }
            return result;
        }

    }
}
