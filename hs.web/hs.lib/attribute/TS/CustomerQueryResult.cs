using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 客户查询的结果类
    /// </summary>
    public class CustomerQueryResult : ResultBase
    {
        /// <summary>
        /// 客户信息
        /// </summary>
        public List<CustomerInfo> resultBOList { get; set; }
    }

    /// <summary>
    /// 客户信息
    /// </summary>
    public class CustomerInfo
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
        /// 客户经理ID
        /// </summary>
        public string customerManagerId { get; set; }

        /// <summary>
        /// 客户经理名称
        /// </summary>
        public string customerManager { get; set; }

        /// <summary>
        /// 客户经理邮箱
        /// </summary>
        public string customerManagerEmail { get; set; }

        /// <summary>
        /// 客户经理ID2
        /// </summary>
        public string customerManagerId2 { get; set; }

        /// <summary>
        /// 客户经理名称2
        /// </summary>
        public string customerManager2 { get; set; }

        /// <summary>
        /// 客户经理邮箱2
        /// </summary>
        public string customerManagerEmail2 { get; set; }

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
