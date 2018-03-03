using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 客户产品查询的结果类
    /// </summary>
    public class ReCustomerProductQueryResult : ResultBase
    {
        /// <summary>
        /// 
        /// </summary>
        List<ReCustomerProduct> resultBOList { get; set; }
    }

    /// <summary>
    /// 客户产品类
    /// </summary>
    public class ReCustomerProduct
    {
        /// <summary>
        /// 客户ID
        /// </summary>
        public string clientId { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public string clientName { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        public string clientNum { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string productId { get; set; }

        /// <summary>
        /// 技术产品编号
        /// </summary>
        public string tproductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        /// 产品简称
        /// </summary>
        public string productShortName { get; set; }

        /// <summary>
        /// 所属事业部
        /// </summary>
        public string department { get; set; }

        /// <summary>
        /// 状态，'A'启用，‘B’上线前 'D'停用
        /// </summary>
        public string deleteStatus { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string lastModifyDate { get; set; }
    }
}
