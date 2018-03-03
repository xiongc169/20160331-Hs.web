using FastDFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility.upload
{
    public class FastDFSUtility
    {
        public string trackerServer = "192.168.75.129:22122";

        public string trackerServer2 = "192.168.40.130:22122";

        public FastDFSClient fdfsClient = null;

        public FastDFSUtility()
        {
            if (fdfsClient == null)
            {
                fdfsClient = FastDFSClient.Instance();
                fdfsClient.Initialize(trackerServer2);
            }
        }

        public string Upload()
        {
            try
            {
                string storageUrl = string.Empty;
                fdfsClient.UploadFile(@"F:\sourceFile\kugou_8.0.46.18705_setup.1461223065.exe", ref storageUrl);
                Console.WriteLine(storageUrl);
                return storageUrl;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return string.Empty;
        }
    }
}
