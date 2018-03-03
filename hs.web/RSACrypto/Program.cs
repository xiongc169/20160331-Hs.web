/****************************************************************************************************
 * 
 * 描述：RSA加密、解密
 * 
 * 作者：chaoxiong
 * 
 * 日期：2016-5-31
 * 
 * 备注：参考 http://www.cnblogs.com/chenyt/archive/2012/09/19/2691505.html
 *          http://www.lxway.com/96811092.htm JAVA，NET RSA密钥格式转换
 *          http://www.bkjia.com/C_jc/943259.html
 * 
 * **************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RSACrypto
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new RSA_Form());
        }
    }
}
