using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 客户销售产品查询接口的结果类
    /// </summary>
    public class ReCustomerSaleProductQueryResult : ResultBase
    {
        public List<ReCustomerSaleProduct> resultBOList { get; set; }
    }

    /// <summary>
    /// 客户销售产品信息
    /// </summary>
    public class ReCustomerSaleProduct
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
        /// 销售产品编号
        /// </summary>
        public string productSaleId { get; set; }

        /// <summary>
        /// 销售产品名称
        /// </summary>
        public string productSaleName { get; set; }

        /// <summary>
        /// 销售产品简称
        /// </summary>
        public string productSaleShortName { get; set; }

        /// <summary>
        /// 销售产品部门编号
        /// </summary>
        public string clientDepId { get; set; }

        /// <summary>
        /// 销售产品部门
        /// </summary>
        public string clientDepName { get; set; }

        /// <summary>
        /// 状态	A'启用，‘B’上线前 'D'停用
        /// </summary>
        public string deleteStatus { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string lastModifyDate { get; set; }

        /// <summary>
        /// 所属事业部
        /// </summary>
        public string department { get; set; }
    }
}
