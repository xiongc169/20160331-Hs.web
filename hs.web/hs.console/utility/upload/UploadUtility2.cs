using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Specialized;

namespace hs.console.utility.upload
{
    /// <summary>
    /// 上传客户事件的附件
    /// http://www.cnblogs.com/binlyzhuo/p/5969850.html
    /// </summary>
    class UploadUtility2
    {
        public static void Upload()
        {
            string URL = "http://192.168.230.177:8081/dockingAPI/addFile.api";
            string boundary = "---------------------------123821742118716";
            WebRequest webRequest = WebRequest.Create(URL);
            webRequest.Method = "POST";
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;

            string FilePath = @"F:\photo.jpg";
            NameValueCollection formData = new NameValueCollection();
            formData.Clear();
            formData["objType"] = "event";
            formData["objId"] = "201702171459555826978291";

            Stream postDataStream = GetPostStream(FilePath, formData, boundary);

            webRequest.ContentLength = postDataStream.Length;
            Stream reqStream = webRequest.GetRequestStream();

            postDataStream.Position = 0;

            byte[] buffer = new byte[1024];
            int bytesRead = 0;

            while ((bytesRead = postDataStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                reqStream.Write(buffer, 0, bytesRead);
            }

            postDataStream.Close();
            reqStream.Close();

            StreamReader sr = new StreamReader(webRequest.GetResponse().GetResponseStream());
            string Result = sr.ReadToEnd();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="formData"></param>
        /// <param name="boundary"></param>
        /// <returns></returns>
        private static Stream GetPostStream(string filePath, NameValueCollection formData, string boundary)
        {
            Stream postDataStream = new MemoryStream();

            //adding form data
            string formDataHeaderTemplate = Environment.NewLine + "--" + boundary
                + Environment.NewLine + "Content-Disposition: form-data; name=\"{0}\";"
                + Environment.NewLine + Environment.NewLine + "{1}";
            foreach (string key in formData.Keys)
            {
                string header = string.Format(formDataHeaderTemplate, key, formData[key]);
                byte[] headerBytes = Encoding.UTF8.GetBytes(header);
                postDataStream.Write(headerBytes, 0, headerBytes.Length);
            }

            //adding file data
            FileInfo fileInfo = new FileInfo(filePath);
            string fileHeaderTemplate = Environment.NewLine + "--" + boundary
                + Environment.NewLine + "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\""
                + Environment.NewLine + "Content-Type: multipart/form-data"
                + Environment.NewLine + Environment.NewLine;
            string fileHeader = string.Format(fileHeaderTemplate, fileInfo.Name, fileInfo.FullName);
            byte[] fileHeaderBytes = Encoding.UTF8.GetBytes(fileHeader);
            postDataStream.Write(fileHeaderBytes, 0, fileHeaderBytes.Length);

            FileStream fileStream = fileInfo.OpenRead();
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                postDataStream.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();

            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
            postDataStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);

            return postDataStream;
        }
    }
}
