using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 认证接口的结果类
    /// </summary>
    public class AuthorizationResult : ResultBase
    {
        /// <summary>
        /// 授权码
        /// </summary>
        public string grantId { get; set; }
    }
}
