using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 需求查询的参数类
    /// </summary>
    public class RequirementQueryParam
    {
        /// <summary>
        /// 授权码，必填信息
        /// </summary>
        [ParameterAttribute(parameterName = "grantId")]
        public string GrantId { get; set; }

        /// <summary>
        /// 需求Id
        /// </summary>
        [ParameterAttribute(parameterName = "reqId")]
        public string ReqId { get; set; }

        /// <summary>
        /// 需求编号
        /// </summary>
        [ParameterAttribute(parameterName = "reqNum")]
        public string ReqNum { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [ParameterAttribute(parameterName = "productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// 销售产品编号
        /// </summary>
        [ParameterAttribute(parameterName = "productSaleId")]
        public string ProductSaleId { get; set; }

        /// <summary>
        /// 需求状态，"A"正常 "D"删除
        /// </summary>
        [ParameterAttribute(parameterName = "deleteStatus")]
        public string DeleteStatus { get; set; }

        /// <summary>
        /// 技术产品编号
        /// </summary>
        [ParameterAttribute(parameterName = "tproductId")]
        public string TproductId { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [ParameterAttribute(parameterName = "clientNum")]
        public string ClientNum { get; set; }

        /// <summary>
        /// 查询天数
        /// </summary>
        [ParameterAttribute(parameterName = "days")]
        public string Days { get; set; }
    }
}
