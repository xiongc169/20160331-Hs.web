using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.mef
{
    /// <summary>
    /// 基类
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// http://www.cnblogs.com/ulex/p/4186881.html
        /// MEF的核心包括一个catalog和一个CompositionContainer。
        /// category用于发现扩展，container用于协调创建和梳理依赖性。
        /// </summary>
        public BaseClass()
        {
            var catalog = new AggregateCatalog();
            //把从Program所在程序集中发现的部件添加到目录中
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            //遍历运行目录下的Addin文件夹，查找所需的插件
            //catalog.Catalogs.Add(new DirectoryCatalog("Addin")); 

            //加载完部件之后，放到一个CompositionContainer容器中
            var container = new CompositionContainer(catalog);
            //调用容器的ComposeParts()方法可以把容器中的部件组合
            container.ComposeParts(this);
        }
    }
}
