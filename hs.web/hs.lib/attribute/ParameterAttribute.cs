using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.attribute
{
    /// <summary>
    /// 参数特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ParameterAttribute : Attribute
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        public string parameterName { get; set; }
    }
}
