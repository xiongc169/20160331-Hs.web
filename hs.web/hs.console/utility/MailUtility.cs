using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections;
using System.Net.Mime;

namespace hs.console.utility
{
    public class MailUtility
    {
        #region 私有变量(发送邮件功能)

        /// <summary>
        /// 发件人邮箱
        /// YYWeb@hundsun.com
        /// yyweb@hundsun.cn
        /// yyservice@hundsun.cn
        /// yyservice@rep.hundsun.cn\7PGXz0drbA
        /// </summary>
        private static string fromAddress = "yyservice@rep.hundsun.cn";

        /// <summary>
        /// 邮箱服务器
        /// mail.hundsun.com
        /// smtp.mxhichina.com=smtp.hundsun.cn
        /// smtpdm.aliyun.com
        /// </summary>
        private static string smtpHost = "smtpdm.aliyun.com";

        /// <summary>
        /// 邮箱用户名
        /// YYWeb
        /// yyweb@hundsun.cn
        /// </summary>
        private static string userName = "yyservice@rep.hundsun.cn";

        /// <summary>
        /// 邮箱密码
        /// Ejo@ih67^Gh
        /// hundsun$$600570
        /// </summary>
        private static string password = "7PGXz0drbA";

        #endregion


        /// <summary>
        /// 参数如下
        /// List<string> emailTo, List<string> secretTo, string subject, string context
        /// </summary>
        public static void SendEmailByHS()
        {
            try
            {
                MailMessage mailMsg = new MailMessage();
                //发送人邮箱地址
                mailMsg.From = new MailAddress(fromAddress);
                //收件人邮箱地址
                mailMsg.To.Add("xiongchao17860@hundsun.com");
                //抄送人
                mailMsg.CC.Add("xiongc169@163.com");
                //密件抄送人地址
                mailMsg.Bcc.Add("942131083@qq.com");
                //主题、正文
                string timeStr = DateTime.Now.ToString("yyyyMMddHHmmss");
                mailMsg.Subject = "这是一封测试邮件";

                string body = string.Empty;
                mailMsg.Body = string.Format("云毅网站给您发送了一条系统公告，请注意查收【{0}】", timeStr);
                
                List<AlternateView> alterViewList = new List<AlternateView>();

                //for (int i = 0; i < 10; i++)
                //{
                //    LinkedResource inline = new LinkedResource(@"F:\test.png", MediaTypeNames.Image.Jpeg);
                //    inline.ContentId = Guid.NewGuid().ToString();
                //    string htmlBody = @"<img src='cid:" + inline.ContentId + @"' />";
                //    AlternateView alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
                //    alternateView.LinkedResources.Add(inline);
                //    mailMsg.AlternateViews.Add(alternateView);
                //}

                //smtp服务器名称:smtp.sina.com\smtp.163.com
                SmtpClient smtp = new SmtpClient();
                smtp.Host = smtpHost;
                smtp.Port = 25;
                smtp.UseDefaultCredentials = true;
                smtp.Timeout = 20000;
                //发送人的登录名和密码
                smtp.Credentials = new NetworkCredential(userName, password);
                smtp.Send(mailMsg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        /// <summary>
        /// 发送邮件
        /// http://www.cnblogs.com/xieyue881119/archive/2009/04/04/1429394.html
        /// http://www.cnblogs.com/zhangq723/archive/2010/08/12/1798329.html
        /// https://msdn.microsoft.com/zh-cn/library/system.net.mail.smtpclient(VS.80).aspx
        /// </summary>
        public static void SendEmail()
        {
            try
            {
                MailMessage mailMsg = new MailMessage();
                //发送人邮箱地址
                mailMsg.From = new MailAddress("beartony1991@sina.com");
                //收件人邮箱地址
                mailMsg.To.Add("xiongc169@163.com");
                //密件抄送人地址
                mailMsg.Bcc.Add("942131083@qq.com");
                mailMsg.Bcc.Add("820980363@qq.com");
                //主题、正文
                mailMsg.Subject = "subject";
                mailMsg.Body = "context";

                //添加附件
                //Attachment attach = GetAttachment();
                //mailMsg.Attachments.Add(attach);

                //MailAddress address = new MailAddress("");

                //smtp服务器名称:smtp.sina.com\smtp.163.com
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.sina.com";
                smtp.UseDefaultCredentials = true;
                smtp.Timeout = 20000;
                //发送人的登录名和密码
                //smtp.Credentials = new NetworkCredential("beartony1991@sina.com", "tony&&3045184");
                //smtp.Credentials = new NetworkCredential("xiongc169@163.com", "xtc");
                smtp.Send(mailMsg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 发送个人邮件
        /// </summary>
        /// <param name="receiver">收件人</param>
        /// <param name="subject">邮件主题</param>
        /// <param name="body">邮件内容</param>
        /// <returns></returns>
        public static bool SendEmailIndividual(string receiver, string subject, string body)
        {
            try
            {
                MailMessage mailMsg = new MailMessage();
                //发送人的邮箱地址
                mailMsg.From = new MailAddress(fromAddress);
                //收件地址              
                mailMsg.To.Add(receiver);
                //邮件主题
                mailMsg.Subject = subject;
                //邮件正文
                mailMsg.Body = body;
                //smtp服务器名称
                SmtpClient smtp = new SmtpClient();
                smtp.Host = smtpHost;
                smtp.UseDefaultCredentials = true;
                smtp.Timeout = 20000;
                //发送人的用户名和密码
                smtp.Credentials = new NetworkCredential(userName, password);
                //发送邮件
                smtp.Send(mailMsg);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 获取附件
        /// </summary>
        /// <returns></returns>
        private static Attachment GetAttachment()
        {
            Attachment attachment = new Attachment(@"E:\myWork\20160405-web\wcf上传.jpg");
            return attachment;
        }

        public static void Test()
        {
            List<string> receivers = new List<string>()
            {
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com",
                "xiongc169@163.com"
            };

            StopwatchUtility.Start();
            foreach (string item in receivers)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    SendEmailIndividual(item, "subject", "body");
                }
            }
            long elspsed = StopwatchUtility.Stop();
            Console.WriteLine(elspsed);

            StopwatchUtility.Start();
            Parallel.ForEach(receivers, item =>
            {
                if (!string.IsNullOrEmpty(item))
                {
                    SendEmailIndividual(item, "subject", "body");
                }
            });
            elspsed = StopwatchUtility.Stop();
            Console.WriteLine(elspsed);
        }
    }
}
