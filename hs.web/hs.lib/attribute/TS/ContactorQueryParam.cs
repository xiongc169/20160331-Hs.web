using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 联系人查询接口参数类
    /// </summary>
    public class ContactorQueryParam
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [Parameter(parameterName = "grantId")]
        public string GrantId { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [Parameter(parameterName = "clientNum")]
        public string ClientNum { get; set; }

        /// <summary>
        /// 联系人ID
        /// </summary>
        [Parameter(parameterName = "contactorId")]
        public string ContactorId { get; set; }

        /// <summary>
        /// 查询天数
        /// </summary>
        [Parameter(parameterName = "days")]
        public string Days { get; set; }
    }
}
