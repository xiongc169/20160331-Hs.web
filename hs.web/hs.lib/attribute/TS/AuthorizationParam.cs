using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute.TS
{
    /// <summary>
    /// 认证接口的参数类
    /// </summary>
    public class AuthorizationParam
    {
        /// <summary>
        /// 账户名
        /// </summary>
        [Parameter(parameterName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Parameter(parameterName = "accountPwd")]
        public string AccountPwd { get; set; }
    }
}
