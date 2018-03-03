using hundsun.lib.attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility
{
    /// <summary>
    /// 反射工具类
    /// is\as\typeof运算符
    /// Type\Reflect类
    /// </summary>
    public class ReflectUtility
    {
        #region 常量

        /// <summary>
        /// 问号，?
        /// </summary>
        private const char QUESTION_MARK = '?';

        /// <summary>
        /// &
        /// </summary>
        private const char AMPERSAND = '&';

        /// <summary>
        /// HTTP请求的参数格式，key=value&
        /// </summary>
        private const string PARAMETER_FORMAT = "{0}={1}&";

        #endregion

        /// <summary>
        /// 类实例转换为参数串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Class2ParamString<T>(T t)
        {
            StringBuilder parameter = new StringBuilder();
            //parameter.Append(QUESTION_MARK);
            Type type = typeof(T);

            Assembly assembly = type.Assembly;
            ConstructorInfo[] constructInfos = type.GetConstructors();
            FieldInfo[] fieldInfos = type.GetFields();
            PropertyInfo[] props = type.GetProperties();
            MemberInfo[] memInfos = type.GetMembers();
            MethodInfo[] methodInfos = type.GetMethods();

            StopwatchUtility.Start();
            foreach (PropertyInfo prop in props)
            {
                PropertyAttributes attrs = prop.Attributes;
                IEnumerable<Attribute> custAttr = prop.GetCustomAttributes();
                foreach (Attribute item in custAttr)
                {
                    if (item is ParameterAttribute)
                    {
                        ParameterAttribute paraAttr = (ParameterAttribute)item;
                        string name = paraAttr.parameterName;
                        object value = prop.GetValue(t);
                        if (value != null)
                        {
                            parameter.AppendFormat(PARAMETER_FORMAT, name, value);
                        }
                    }
                }
            }
            long tick = StopwatchUtility.Stop();

            foreach (MemberInfo memInfo in memInfos)
            {
                Attribute[] attrs = Attribute.GetCustomAttributes(memInfo);
            }
            return parameter.ToString().TrimEnd(AMPERSAND);
        }

        public static List<string> GetAllProperty<T>()
        {
            List<string> propList = new List<string>();
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo item in props)
            {
                string propName = item.Name;
                propList.Add(propName);
            }
            return propList;
        }
    }
}
