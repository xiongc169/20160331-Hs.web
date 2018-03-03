using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 客户查询的参数类
    /// </summary>
    public class CustomerQueryParam
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [Parameter(parameterName = "grantId")]
        public string GrantId { get; set; }

        /// <summary>
        /// 事业部名称
        /// </summary>
        [Parameter(parameterName = "department")]
        public string Department { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [Parameter(parameterName = "clientNum")]
        public string ClientNum { get; set; }

        /// <summary>
        /// 产品编号
        [Parameter(parameterName = "productId")]
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 查询天数
        [Parameter(parameterName = "days")]
        /// </summary>
        public string Days { get; set; }
    }
}
