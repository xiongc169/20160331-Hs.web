using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 产品查询的参数类
    /// </summary>
    public class ProductQueryParam
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
        /// 产品编号
        /// </summary>
        [Parameter(parameterName = "productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// 技术产品编号
        [Parameter(parameterName = "tProductId")]
        /// </summary>
        public string TProductId { get; set; }
    }
}
