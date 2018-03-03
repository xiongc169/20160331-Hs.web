using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 新增需求的结果类
    /// </summary>
    public class RequirementInsertResult : ResultBase
    {
        /// <summary>
        /// 需求ID
        /// </summary>
        public string reqId { get; set; }

        /// <summary>
        /// 需求编号
        /// </summary>
        public string reqNum { get; set; }
    }
}
