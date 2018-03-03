using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// TS查询结果的基类
    /// </summary>
    public class ResultBase
    {
        /// <summary>
        /// 成功标识
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 错误编号
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string errMsg { get; set; }

    }
}
