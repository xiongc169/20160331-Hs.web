using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.ITSM
{
    /// <summary>
    /// 新增客户事件的参数类，封装了客户事件的相关信息
    /// </summary>
    public class CustomerEventInsertParam
    {
        [ParameterAttribute(parameterName = "key")]
        public string Key { get; set; }

        [ParameterAttribute(parameterName = "customerNo")]
        public string CustomerNo { get; set; }

        [ParameterAttribute(parameterName = "reporterName")]
        public string ReporterName { get; set; }

        [ParameterAttribute(parameterName = "reporterEmail")]
        public string ReporterEmail { get; set; }

        [ParameterAttribute(parameterName = "reporterPhone")]
        public string ReporterPhone { get; set; }

        [ParameterAttribute(parameterName = "businessSystemNo")]
        public string BusinessSystemNo { get; set; }

        [ParameterAttribute(parameterName = "topic")]
        public string Topic { get; set; }

        [ParameterAttribute(parameterName = "description")]
        public string Description { get; set; }

        [ParameterAttribute(parameterName = "eventSource")]
        public string EventSource { get; set; }

        [ParameterAttribute(parameterName = "type")]
        public string Type { get; set; }

        [ParameterAttribute(parameterName = "subType")]
        public string SubType { get; set; }

        [ParameterAttribute(parameterName = "occurDateTime")]
        public string OccurDateTime { get; set; }

        [ParameterAttribute(parameterName = "dealingUserNo")]
        public string DealingUserNo { get; set; }

        [ParameterAttribute(parameterName = "acceptDateTime")]
        public string AcceptDateTime { get; set; }

        [ParameterAttribute(parameterName = "createUserNo")]
        public string CreateUserNo { get; set; }

        [ParameterAttribute(parameterName = "outId")]
        public string OutId { get; set; }
    }
}
