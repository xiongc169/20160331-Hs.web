using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility
{
    /// <summary>
    /// Base64帮助类
    /// </summary>
    public class Base64Helper
    {
        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="codeName">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string EncodeBase64(Encoding encode, string source)
        {
            string ciphertext = source;
            byte[] bytes = encode.GetBytes(source);
            try
            {
                ciphertext = Convert.ToBase64String(bytes);
            }
            catch
            {
            }
            return ciphertext;
        }

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string EncodeBase64(string source)
        {
            return EncodeBase64(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="codeName">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="ciphertext">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(Encoding encode, string ciphertext)
        {
            string source = ciphertext;
            try
            {
                byte[] bytes = Convert.FromBase64String(ciphertext);
                source = encode.GetString(bytes);
            }
            catch
            {
            }
            return source;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="ciphertext">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(string ciphertext)
        {
            return DecodeBase64(Encoding.UTF8, ciphertext);
        }
    }
}
