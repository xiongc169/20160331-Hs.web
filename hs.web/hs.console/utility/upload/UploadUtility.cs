using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace hs.console.utility.upload
{
    public class UploadUtility
    {

        /// <summary>
        /// 上传图片
        /// http://www.cnblogs.com/skykang/archive/2011/05/17/2048924.html
        /// </summary>
        /// <param name="url">上传到目的服务的地址</param>
        /// <param name="url">上传到目的服务器的图片相对目录(如：aa/bb/cc/)</param>
        /// <param name="filename">扩展名</param>
        /// <param name="filename">上传文件的数据</param>
        /// <returns>图片地址</returns>
        public static string upLoadPic(string url, string directory, string extension, byte[] data)
        {
            WebClient myWebClient = new WebClient();
            myWebClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            myWebClient.QueryString["directory"] = directory;
            myWebClient.QueryString["extension"] = extension;
            byte[] responseArray = myWebClient.UploadData(url, "POST", data);
            return Encoding.GetEncoding("gb2312").GetString(responseArray);
        }

        /// <summary>
        /// 上传图片
        /// http://www.cnblogs.com/skykang/archive/2011/05/17/2048924.html
        /// </summary>
        /// <param name="url">上传到目的服务的地址</param>
        /// <param name="url">上传到目的服务器的图片相对目录(如：aa/bb/cc/)</param>
        /// <param name="filename">上传的文件名的完整路径</param>
        /// <returns>图片地址</returns>
        public static string upLoadPic(string url, string directory, string fileName)
        {
            WebClient myWebClient = new WebClient();
            myWebClient.Credentials = new NetworkCredential("admin", "123456");
            myWebClient.QueryString["directory"] = directory;
            byte[] responseArray = myWebClient.UploadFile(url, "POST", fileName);
            string result = Encoding.UTF8.GetString(responseArray);
            return result;
        }

        /// <summary>
        /// 上传客户事件的附件
        /// http://www.cnblogs.com/binlyzhuo/p/5969850.html
        /// </summary>
        public static void uploadAttach()
        {
            string url = "http://192.168.230.177:8081/dockingAPI/addFile.api";
            string fileName = "F:/photo.jpg";
            string fileName2 = "F:/qq_sign.png";

            Dictionary<string, string> textMap = new Dictionary<string, string>();
            // 可以设置多个input的name，value
            textMap.Add("objType", "event");
            textMap.Add("objId", "201702171459555826978291");
            // 设置file的name，路径
            Dictionary<string, string> fileMap = new Dictionary<string, string>();
            fileMap.Add("upfile", fileName);
            fileMap.Add("upfile2", fileName2);

            string res = "";
            // boundary就是request头和上传文件内容的分隔符
            string boundary = "---------------------------123821742118716";

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;

            NameValueCollection formData = new NameValueCollection();
            formData.Clear();
            formData["objType"] = "event";
            formData["objId"] = "201702171459555826978291";

        }
    }
}
