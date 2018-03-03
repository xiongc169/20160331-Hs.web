using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 产品查询的结果类
    /// </summary>
    public class ProductQueryResult : ResultBase
    {
        /// <summary>
        /// 产品信息
        /// </summary>
        public List<ProductInfo> resultBOList { get; set; }
    }

    /// <summary>
    /// 产品信息
    /// </summary>
    public class ProductInfo
    {
        /// <summary>
        /// 产品编号
        /// </summary>
        public string productId { get; set; }

        /// <summary>
        /// 技术产品编号
        /// </summary>
        public string tproduct_id { get; set; }

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
        /// 最后修改时间
        /// </summary>
        public string lastModifyDate { get; set; }
    }
}
