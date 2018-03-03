using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 联系人查询接口的结果类
    /// </summary>
    public class ContactorQueryResult : ResultBase
    {
        /// <summary>
        /// 联系人信息
        /// </summary>
        public List<ContactorInfo> resultBOList { get; set; }
    }

    /// <summary>
    /// 联系人信息
    /// </summary>
    public class ContactorInfo
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
        /// 联系人Id
        /// </summary>
        public string contactorId { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        public string contactorName { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string contactorEmail { get; set; }

        /// <summary>
        /// 联系人邮箱2
        /// </summary>
        public string contactorEmail2 { get; set; }

        /// <summary>
        /// 联系人邮箱3
        /// </summary>
        public string contactorEmail3 { get; set; }

        /// <summary>
        /// 联系人联系电话
        /// </summary>
        public string contactorPhone { get; set; }

        /// <summary>
        /// 联系人移动电话
        /// </summary>
        public string contactorMobilePhone { get; set; }

        /// <summary>
        /// 删除标示	A'启用，'D'停用
        /// </summary>
        public string deleteStatus { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string lastModifyDate { get; set; }

    }
}
