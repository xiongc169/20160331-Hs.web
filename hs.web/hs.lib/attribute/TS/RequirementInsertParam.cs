using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 新增需求的参数类
    /// </summary>
    public class RequirementInsertParam
    {
        /// <summary>
        /// 授权码，必填信息
        /// </summary>
        [ParameterAttribute(parameterName = "grantId")]
        public string GrantId { get; set; }

        /// <summary>
        /// 产品编号，必填信息
        /// </summary>
        [ParameterAttribute(parameterName = "productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// 客户编号，必填信息
        /// </summary>
        [ParameterAttribute(parameterName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// 技术产品编号
        /// </summary>
        [ParameterAttribute(parameterName = "tproductId")]
        public string TproductId { get; set; }

        /// <summary>
        /// 联系人1，必填信息
        /// </summary>
        [ParameterAttribute(parameterName = "contactorId1")]
        public string ContactorId1 { get; set; }

        /// <summary>
        /// 联系人2
        /// </summary>
        [ParameterAttribute(parameterName = "contactorId2")]
        public string ContactorId2 { get; set; }

        /// <summary>
        /// 内部联系人
        /// </summary>
        [ParameterAttribute(parameterName = "contactorId3")]
        public string ContactorId3 { get; set; }

        /// <summary>
        /// 需求说明，必填信息
        /// </summary>
        [ParameterAttribute(parameterName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// 客户当前版本
        /// </summary>
        [ParameterAttribute(parameterName = "clientProductVer")]
        public string ClientProductVer { get; set; }

        /// <summary>
        /// 所属子系统
        /// </summary>
        [ParameterAttribute(parameterName = "subSystem")]
        public string SubSystem { get; set; }

        /// <summary>
        /// 提交人
        /// </summary>
        [ParameterAttribute(parameterName = "commiter")]
        public string Commiter { get; set; }

        /// <summary>
        /// 关联需求编号
        /// </summary>
        [ParameterAttribute(parameterName = "relateReqNum")]
        public string RelateReqNum { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [ParameterAttribute(parameterName = "memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterAttribute(parameterName = "synId")]
        public string SynId { get; set; }

        /// <summary>
        /// 服务阶段
        /// </summary>
        [ParameterAttribute(parameterName = "phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 操作来源
        /// </summary>
        [ParameterAttribute(parameterName = "actionType")]
        public string ActionType { get; set; }

        /// <summary>
        /// 要求完成日期
        /// </summary>
        [ParameterAttribute(parameterName = "completeDate")]
        public string CompleteDate { get; set; }

        /// <summary>
        /// 销售产品编号
        /// </summary>
        [ParameterAttribute(parameterName = "productSaleId")]
        public string ProductSaleId { get; set; }

        /// <summary>
        /// 销售产品部门
        /// </summary>
        [ParameterAttribute(parameterName = "clientDepId")]
        public string ClientDepId { get; set; }

        /// <summary>
        /// 解码标示
        /// </summary>
        [ParameterAttribute(parameterName = "isBase64")]
        public string IsBase64 { get; set; }
    }
}
