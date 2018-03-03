using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.mef
{
    [Export(typeof(IGreet))]
    public class Greet : IGreet
    {
        public void SayHello(string msg)
        {
            Console.WriteLine("Hello,This is Greet,{0}", msg);
        }
    }
}