using hundsun.console.utility;
using hundsun.lib.attribute.TS;
using RSACrypto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace hs.console.utility
{
    /// <summary>
    /// itsm系统接口联调
    /// </summary>
    public class HttpUtility
    {
        #region private 变量

        /// <summary>
        /// itsm新增接口（正式）
        /// </summary>
        private static string urlItsm = "http://hsyunitsm.hundsun.com/addEventAction.action";

        /// <summary>
        /// itsm新增接口（正式）
        /// </summary>
        private static string urlItsm2 = "http://newyunitsm.hundsun.com:8899/itsm2016/addEvent.json";

        /// <summary>
        /// itsm新增接口（测试）
        /// </summary>
        private static string urlItsmTest = "http://192.168.54.27:5181/hsyunitsm/addEventAction.action";

        /// <summary>
        /// 
        /// </summary>
        private static string urlSpringmvc = "http://192.168.226.33:8080/practice-webapp/first/insertReq";

        /// <summary>
        /// 
        /// </summary>
        private static string urlServlet = "http://192.168.0.103:8080/practice-servlet/LoginServlet";

        /// <summary>
        /// 
        /// </summary>
        private static string urlWorkpc = "http://localhost:8080/practice-webapp/first/login";

        #endregion

        #region 对接ITSM系统

        public static void InsultBaidu()
        {
            string url = "http://www.baidu.com";
            string itoyun = "https://www.itoyun.cn/itopc/game/competition_detail.htm?rcd_id=11";

            HttpClientHandler handler = new HttpClientHandler();

            HttpClient client = new HttpClient(handler);
            var task = client.GetStringAsync(itoyun);
            Console.WriteLine(task.Result);
        }

        /// <summary>
        /// HttpWebRequest
        /// http://blog.csdn.net/zhoufoxcn/article/details/6404236
        /// http://blog.itpub.net/25897606/viewspace-764254/
        /// </summary>
        public static void HttpWebRequestDemo()
        {
            string param = GenerateParams();
            byte[] bs = Encoding.UTF8.GetBytes(param.ToString());

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(urlItsmTest);
            //其他http头看情况而定，但是下面俩必须加  
            myReq.Method = "POST";
            myReq.ContentType = "application/x-www-form-urlencoded";
            myReq.ContentLength = bs.Length;

            using (Stream reqStream = myReq.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
                //reqStream.Flush();
                //reqStream.Close();
            }
            byte[] responseByte = new byte[1024];
            using (WebResponse wr = myReq.GetResponse())
            {
                //在这里对接收到的页面内容进行处理
                using (Stream repStream = wr.GetResponseStream())
                {
                    StreamReader sReader = new StreamReader(repStream);
                    string responseStr2 = sReader.ReadToEnd();
                    Console.WriteLine(responseStr2);

                    repStream.Read(responseByte, 0, 1024);
                    string responseStr = Encoding.UTF8.GetString(responseByte);
                    Console.WriteLine(responseStr);
                }
            }
        }

        /// <summary>
        /// WebClient
        /// 
        /// https://msdn.microsoft.com/zh-cn/library/system.net.webclient(VS.80).aspx
        /// http://www.cnblogs.com/gossip/archive/2013/03/04/2943009.html
        /// </summary>
        public static void WebClientDemo()
        {
            WebClient webClient = new WebClient();
            string param = GenerateParams();
            byte[] paramByte = Encoding.UTF8.GetBytes(param);
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            //using (Stream inStream = webClient.OpenRead(urlWorkpc))
            //{
            //    StreamReader reader = new StreamReader(inStream);
            //    string responseStr = reader.ReadToEnd();
            //    Console.WriteLine(responseStr);
            //}
            byte[] responseByte = webClient.UploadData(urlItsmTest, "POST", paramByte);
            string response = Encoding.UTF8.GetString(responseByte);

            Console.WriteLine(response);
        }

        /// <summary>
        /// httpclient demo
        /// http://www.cnblogs.com/TianFang/archive/2012/03/10/2389480.html
        /// http://www.cnblogs.com/chillsrc/p/3446548.html
        /// http://www.cnblogs.com/qingyuan/archive/2012/11/08/2760034.html
        /// </summary>
        public static void HttpClientDemo()
        {
            str = System.Web.HttpUtility.UrlEncode(str);
            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = long.MaxValue;
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            //client.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            string param = GenerateParams();// str;
            byte[] paramByte = Encoding.UTF8.GetBytes(param);
            HttpContent content = new ByteArrayContent(paramByte);
            content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            HttpResponseMessage body = client.PostAsync(urlItsm2, content).Result;
            HttpContent responsebody = body.Content;
            byte[] responseByte = responsebody.ReadAsByteArrayAsync().Result;
            Console.WriteLine(Encoding.UTF8.GetString(responseByte));
        }

        //static string str = "grantId=+++++";

        static string str = "grantId=9bad6513-4c0f-427c-952b-2818d7c711b5&productId=20091004&clientId=59d3c6f47a1d46439dc11026a221a4ed&tproductId=CP-S000128-1.0&contactorId1=4028bc5c1d921a25011dbf7b93717c40&description=MTIzNDU2Nzg5MC1hc2RmZ2hqa2wt54ix5LiK5a+55pa56L+H5ZCO5bCx5ZOt5LqGLTIwMTYtNy03IDE1OjQ2OjUy&completeDate=2016-07-15 00:00:00&isBase64=True";

        /// <summary>
        /// 生成参数
        /// 正确参数形式："key=000000000000000000000000&businessSystemNo=CP-S000241-1.0&createUserNo=05806&reporterName=reporterName&reporterPhone=15067448092&reporterEmail=xucl@hundsun.com&customerNo=999999999&topic=topic&description=description&eventSource=11&type=10&occurDateTime=1461722138980&dealingUserNo=05806&acceptDateTime=1461722138980&createUserNo=05806&outId=201604270956005";
        /// </summary>
        /// <returns></returns>
        public static string GenerateParams()
        {
            string timestamp = GenerateTimeStamp();
            string outId = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            StringBuilder param = new StringBuilder();
            param.Append("key=000000000000000000000000");
            param.Append("&customerNo=999999999");
            param.Append("&reporterName=liangyangyang");
            param.Append("&reporterEmail=xucl@hundsun.com");
            param.Append("&reporterPhone=13000010002");
            param.Append("&businessSystemNo=CP-S000241-1.0");
            param.Append("&topic=Topic");
            param.Append("&description=Description");
            param.Append("&eventSource=11");
            param.Append("&type=10");
            //param.Append("&subType=1001");
            param.AppendFormat("&occurDateTime={0}", timestamp);
            param.Append("&dealingUserNo=05806");
            param.AppendFormat("&acceptDateTime={0}", timestamp);
            param.Append("&createUserNo=05806");
            param.AppendFormat("&outId={0}", outId);

            return param.ToString();
        }

        #endregion

        /// <summary>
        /// 生成时间戳 
        /// 10位、13位时间戳的区别
        /// </summary>
        public static string GenerateTimeStamp()
        {
            //协调世界时
            DateTime utcNow = DateTime.UtcNow;
            //北京时间，两者相差8小时
            DateTime now = DateTime.Now;

            //生成10位时间戳，1461726769
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan ts2 = DateTime.Now - new DateTime(1970, 1, 1, 8, 0, 0, 0);
            string str = Convert.ToInt64(ts.TotalSeconds).ToString();
            string stamp10 = Convert.ToInt64(ts2.TotalSeconds).ToString();
            //Console.WriteLine(str);
            //Console.WriteLine(stamp10);

            //生成13位时间戳
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(2016, 11, 3, 0, 0, 0, 0));
            long stamp13 = (now.Ticks - startTime.Ticks) / 10000; //除10000调整为13位

            //13位时间戳转换为DateTime类型
            DateTime startTime2 = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(2016, 11, 3));
            DateTime time = startTime.AddMilliseconds(stamp13);

            //http://blog.csdn.net/yinyaling/article/details/3722029  DateTime.ToString()格式详解
            //13:37:04
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            //2016年4月25日
            Console.WriteLine(DateTime.Now.ToLongDateString());
            //20160425133704668010
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            return stamp13.ToString();
        }

        #region 对接TS系统

        private static string UserName = "yunyitest";

        private static string Password = "!25sAqe849qwezd";

        private static string PublicKeyJava = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCA5xCau7f76VPU+DNxDBLyJkpCnfT8IxSi024rAqc+psStGWLLMN0LHhet8zdpZ1wtltAycEZLZnwdQiCWCTMdHX7YExWqXBQjQhkJf9njKxom5T9cDIY06Z8Vl+pvLTK4RmjMLLJAcRzu40Ifq8G2jobK3k2g2dUKHFj0sfvjfQIDAQAB";

        private static RSASecurity rsaSecurity = new RSASecurity();

        //029c2374-cbfd-455e-a4d0-34ea4d1ad13d
        private static string grantId = "6e416a4d-5893-4663-9482-1e920fd204fe";

        /// <summary>
        /// 发送请求接口
        /// </summary>
        /// <param name="uri">请求地址</param>
        /// <param name="parameterString">请求参数</param>
        /// <returns></returns>
        private static string ConnectTS(string uri, string parameterString)
        {
            HttpClient client = new HttpClient();
            HttpRequestHeaders headers = client.DefaultRequestHeaders;
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            //client.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            byte[] paramByte = Encoding.UTF8.GetBytes(parameterString);
            HttpContent content = new ByteArrayContent(paramByte);
            content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            HttpResponseMessage body = client.PostAsync(uri, content).Result;
            HttpContent responsebody = body.Content;
            byte[] responseByte = responsebody.ReadAsByteArrayAsync().Result;
            string result = Encoding.UTF8.GetString(responseByte);
            return result;
        }

        /// <summary>
        /// 认证接口
        /// 正确返回结果：{"grantId":"b9bd7c9d-b7f0-42e8-95df-84426432f07c","success":true}
        /// </summary>
        /// <returns></returns>
        public static string GetGrantId()
        {
            string grantUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/logIn.htm";
            string grantUri47 = "http://test47.hundsun.com:8080/TsInterfaceWeb/services/logIn.htm";
            string publicKeyDotnet = KeyConvertor.RSAPublicKeyJava2DotNet(PublicKeyJava);
            string passwordRSA = rsaSecurity.Encrypt(Password, publicKeyDotnet);
            AuthorizationParam authTS = new AuthorizationParam()
            {
                AccountId = UserName,
                AccountPwd = passwordRSA
            };
            string parameterString = ReflectUtility.Class2ParamString(authTS);

            string grantResultStr = ConnectTS(grantUri, parameterString);
            AuthorizationResult grantResult = JsonHelper.Deserialize<AuthorizationResult>(grantResultStr);
            grantId = grantResult.grantId;
            return grantResultStr;
        }

        /// <summary>
        /// 需求新增接口
        /// </summary>
        public static void InsertRequirement()
        {
            string insertUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/insertReq.htm";
            RequirementInsertParam insertParam = new RequirementInsertParam()
            {
                GrantId = grantId,
                ProductId = "20110501",
                ClientId = "d341404c5d5146eb943e962d2112aac1",
                ContactorId1 = "20100427133346361635234745796812",
                Description = "这是需求说明xiongchao17860"
            };
            string paramString = ReflectUtility.Class2ParamString(insertParam);

            string inertResultString = ConnectTS(insertUri, paramString);
            RequirementInsertResult insertResult = JsonHelper.Deserialize<RequirementInsertResult>(inertResultString);
        }

        /// <summary>
        /// 需求查询接口
        /// </summary>
        public static void QueryRequirement()
        {
            string queryUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/getReqList.htm";
            RequirementQueryParam queryParam = new RequirementQueryParam()
            {
                GrantId = grantId,
                Days = "2"
            };
            string paramString = ReflectUtility.Class2ParamString(queryParam);

            string queryResultString = ConnectTS(queryUri, paramString);
            RequirementQueryResult queryResult = JsonHelper.Deserialize<RequirementQueryResult>(queryResultString);
        }

        /// <summary>
        /// 产品查询接口
        /// 正确返回结果：{"resultBOList":[{"aid":"","department":"研发中心","lastModifyDate":"2016-05-27 10:23:41","productId":"20110501","productName":"聚源测试","productShortName":"聚源测试","status":"","tproductId":"CP-S00112-22"}],"success":true}
        /// </summary>
        /// <returns></returns>
        public static string GetAllProducts()
        {
            string productQueryUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/getProductList.htm";

            ProductQueryParam productParam = new ProductQueryParam()
            {
                GrantId = grantId
            };
            string parameterString = ReflectUtility.Class2ParamString(productParam);
            string productInfos = ConnectTS(productQueryUri, parameterString);
            ProductQueryResult queryRes = JsonHelper.Deserialize<ProductQueryResult>(productInfos);
            return productInfos;
        }

        /// <summary>
        /// 客户查询接口
        /// 正确返回结果：{"resultBOList":[{"aid":"","clientId":"d341404c5d5146eb943e962d2112aac1","clientName":"财通证券有限责任公司杭州湖墅路营业部","clientNum":"41821","customerManager":"姜河","customerManager2":"陆云峰","customerManagerEmail":"jianghe08025@hundsun.com","customerManagerEmail2":"luyf08998@hundsun.com","customerManagerId":"08025","customerManagerId2":"08998","days":"","department":"研发中心","lastModifyDate":"2016-05-31 23:41:43","productId":"","status":""},{"aid":"","clientId":"999999999","clientName":"内部客户","clientNum":"999999999","customerManager":"","customerManager2":"","customerManagerEmail":"","customerManagerEmail2":"","customerManagerId":"","customerManagerId2":"","days":"","department":"研发中心","lastModifyDate":"2016-05-31 23:42:26","productId":"","status":""},{"aid":"","clientId":"4028bc5c1dd9362d011e140f123336b1","clientName":"中国东方航空股份有限公司杭州营业部","clientNum":"87119","customerManager":"黄元元","customerManager2":"黄元元","customerManagerEmail":"huangyy07483@hundsun.com","customerManagerEmail2":"huangyy07483@hundsun.com","customerManagerId":"07483","customerManagerId2":"07483","days":"","department":"研发中心","lastModifyDate":"2016-05-31 23:41:51","productId":"","status":""},{"aid":"","clientId":"4028bc5c384b13ea0138b675e9ea525b","clientName":"西安曲江文化产业风险投资有限公司","clientNum":"70495","customerManager":"邹黎明","customerManager2":"张弥华","customerManagerEmail":"zoulm@hundsun.com","customerManagerEmail2":"zhangmh@hundsun.com","customerManagerId":"07802","customerManagerId2":"04719","days":"","department":"研发中心","lastModifyDate":"2016-05-31 23:41:02","productId":"","status":""}],"success":true}
        /// </summary>
        /// <returns></returns>
        public static string GetAllCustomers()
        {
            string customerQueryUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/getClientList.htm";

            CustomerQueryParam customerParam = new CustomerQueryParam()
            {
                GrantId = grantId
            };
            string parameterString = ReflectUtility.Class2ParamString(customerParam);
            string customerInfos = ConnectTS(customerQueryUri, parameterString);
            CustomerQueryResult queryRes = JsonHelper.Deserialize<CustomerQueryResult>(customerInfos);
            return customerInfos;
        }

        /// <summary>
        /// 客户产品查询接口
        /// </summary>
        public static void QueryReCustomerProduct()
        {
            string queryUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/getClientProductList.htm ";
            CustomerQueryParam queryParam = new CustomerQueryParam()
            {
                GrantId = grantId
            };
            string paramString = ReflectUtility.Class2ParamString(queryParam);

            string queryResultString = ConnectTS(queryUri, paramString);
            ReCustomerProductQueryResult queryResult = JsonHelper.Deserialize<ReCustomerProductQueryResult>(queryResultString);
        }

        /// <summary>
        /// 客户销售产品查询接口
        /// </summary>
        public static void QueryReCustomerSaleProduct()
        {
            string queryUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/getClientProductSalList.htm";
            ReCustomerSaleProductQueryParam queryParam = new ReCustomerSaleProductQueryParam()
            {
                GrantId = grantId
            };
            string paramString = ReflectUtility.Class2ParamString(queryParam);

            string queryResultString = ConnectTS(queryUri, paramString);
            ReCustomerSaleProductQueryResult queryResult = JsonHelper.Deserialize<ReCustomerSaleProductQueryResult>(queryResultString);
        }

        /// <summary>
        /// 联系人查询
        /// </summary>
        public static void QueryContactor()
        {
            string queryUri = "http://yusp.hundsun.com:8080/TsInterfaceWeb/services/getContactorList.htm";
            string queryUri47 = "http://test47.hundsun.com:8080/TsInterfaceWeb/services/getContactorList.htm";
            ContactorQueryParam queryParam = new ContactorQueryParam()
            {
                GrantId = grantId
            };
            string paramString = ReflectUtility.Class2ParamString(queryParam);

            string queryResultString = ConnectTS(queryUri, paramString);
            ContactorQueryResult queryResult = JsonHelper.Deserialize<ContactorQueryResult>(queryResultString);
        }
        #endregion


        /// <summary>
        /// 模拟浏览器发送HTTP请求
        /// http://www.cnblogs.com/TianFang/archive/2012/03/10/2389480.html
        /// http://www.cnblogs.com/chillsrc/p/3446548.html
        /// http://www.cnblogs.com/qingyuan/archive/2012/11/08/2760034.html
        /// 
        /// http://blog.csdn.net/superhoy/article/details/7496403
        /// </summary>
        public static void SimulateHttpRequest()
        {
            string url = "https://www.itoyun.cn/itopc/game/competition_detail.htm";
            string baiduUrl = "http://www.bing.com";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baiduUrl);
            request.Method = "POST";
            string postData = string.Format(@"token=e8db50c8d82d4e398db00bf59b45800c&ito_account=hs/xiongchao17860&name=xiongchao17860&isReceiveOrgUser=false&iamgeurl=""&user_src=syn&_gat=1&authen_status=3&_ga=GA1.2.1326744804.1480669984");
            byte[] bytesToPost = Encoding.Default.GetBytes(postData);
            request.ContentLength = bytesToPost.Length;
            //
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //request.Connection = "keep-alive";
            request.Host = "www.itoyun.cn";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.71 Safari/537.36";

            //request.ContentType = "text/html;charset=UTF-8";
            //request.Referer = "http://www.itoyun.cn";

            request.Headers.Set("Accept-Encoding", "gzip,deflate,sdch,br");
            request.Headers.Set("Accept-Language", "zh-CN,zh;q=0.8");
            request.Headers.Set("Cookie", "JSESSIONID=A6E061C83D024FD4897CBC3CFB2B6882");
            //CookieContainer cookieContainer = new CookieContainer();
            //request.CookieContainer = cookieContainer;
            //cookieContainer.SetCookies(new Uri(url, UriKind.Absolute), "JSESSIONID=20DFFCA8D3B00846E1104700E1F4D894");
            //cookieContainer.Add(new Uri(url, UriKind.Absolute), new Cookie("Bt2PxxhZg9", "MDAwM2IyNGM1ZWMwMDAwMDAwMDYwEE13blYxMzM1MjY3ODY4"));

            //request.Headers.Set("Accept-Charset", "GBK,utf-8;q=0.7,*;q=0.3");
            //request.Headers.Set("X-Requested-With", "http://www.itoyun.cn");
            //request.Headers.Set("Origin", "XMLHttpRequest");

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytesToPost, 0, bytesToPost.Length);
            requestStream.Close();
            Stream responseStream;

            try
            {
                responseStream = request.GetResponse().GetResponseStream();//接受请求的结果
                StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("GBK"));
                string result = reader.ReadToEnd();
                Console.WriteLine("this is the result:{0}", result);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff") + ": " + ex.Message);
            }
        }
    }
}
