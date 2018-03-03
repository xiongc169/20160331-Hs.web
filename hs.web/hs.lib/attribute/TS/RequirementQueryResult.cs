using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 需求查询的结果类
    /// </summary>
    public class RequirementQueryResult : ResultBase
    {
        /// <summary>
        /// 需求列表
        /// </summary>
        public List<RequirementQuery> resultBOList { get; set; }
    }

    /// <summary>
    /// 需求信息类
    /// </summary>
    public class RequirementQuery
    {
        /// <summary>
        /// 需求ID
        /// </summary>
        public string reqId { get; set; }

        /// <summary>
        /// 需求编号
        /// </summary>
        public string reqNum { get; set; }

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
        /// 客户编号
        /// </summary>
        public string clientId { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public string clientName { get; set; }

        /// <summary>
        /// 联系人ID1
        /// </summary>
        public string contactorId1 { get; set; }

        /// <summary>
        /// 联系人名称1
        /// </summary>
        public string contactorName1 { get; set; }

        /// <summary>
        /// 联系人邮箱1
        /// </summary>
        public string contactorEmail1 { get; set; }

        /// <summary>
        /// 联系人电话1
        /// </summary>
        public string contactorMobileTel1 { get; set; }

        /// <summary>
        /// 联系人ID2
        /// </summary>
        public string contactorId2 { get; set; }

        /// <summary>
        /// 联系人名称2
        /// </summary>
        public string contactorName2 { get; set; }

        /// <summary>
        /// 联系人邮箱2
        /// </summary>
        public string contactorEmail2 { get; set; }

        /// <summary>
        /// 联系人电话2
        /// </summary>
        public string contactorMobileTel2 { get; set; }

        /// <summary>
        /// 内部联系人编号
        /// </summary>
        public string contactorId3 { get; set; }

        /// <summary>
        /// 内部联系人名称
        /// </summary>
        public string contactorName3 { get; set; }

        /// <summary>
        /// 内部联系人邮箱
        /// </summary>
        public string contactorEmail3 { get; set; }

        /// <summary>
        /// 内部联系人电话
        /// </summary>
        public string contactorMobileTel3 { get; set; }

        /// <summary>
        /// 销售产品编号
        /// </summary>
        public string productSaleId { get; set; }

        /// <summary>
        /// 销售产品名称
        /// </summary>
        public string productSaleName { get; set; }

        /// <summary>
        /// 销售产品部门编号
        /// </summary>
        public string clientDeptId { get; set; }

        /// <summary>
        /// 销售产品部门
        /// </summary>
        public string clientDeptName { get; set; }

        /// <summary>
        /// 需求说明
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 处理意见
        /// </summary>
        public string dealDesc { get; set; }

        /// <summary>
        /// 受理结果编号
        /// </summary>
        public string dealResult { get; set; }

        /// <summary>
        /// 受理结果
        /// </summary>
        public string dealResultName { get; set; }

        /// <summary>
        /// 提交日期
        /// </summary>
        public string commitDate { get; set; }

        /// <summary>
        /// 要求完成日期
        /// </summary>
        public string completeDate { get; set; }

        /// <summary>
        /// 承诺发放日期
        /// </summary>
        public string promiseDate { get; set; }

        /// <summary>
        /// 需求回复日期
        /// </summary>
        public string reqReplyDate { get; set; }

        /// <summary>
        /// 再次回复期限
        /// </summary>
        public string reReplyDate { get; set; }

        /// <summary>
        /// 需求状态编号
        /// </summary>
        public string reqStatus { get; set; }

        /// <summary>
        /// 需求状态
        /// </summary>
        public string reqStatusName { get; set; }

        /// <summary>
        /// 发布发放状态编号
        /// </summary>
        public string publishStatus { get; set; }

        /// <summary>
        /// 发布发放状态
        /// </summary>
        public string publishStatusName { get; set; }

        /// <summary>
        /// 需求来源编号
        /// </summary>
        public string reqSource { get; set; }

        /// <summary>
        /// 需求来源名称
        /// </summary>
        public string reqSourceName { get; set; }

        /// <summary>
        /// 处理人编号
        /// </summary>
        public string opinionAuthor { get; set; }

        /// <summary>
        /// 处理人名称
        /// </summary>
        public string opinionAuthorName { get; set; }

        /// <summary>
        /// 删除标示，"A"正常 "D"删除
        /// </summary>
        public string deleteStatus { get; set; }

        /// <summary>
        /// 最后修改日期
        /// </summary>
        public string lastModifyDate { get; set; }
    }
}
