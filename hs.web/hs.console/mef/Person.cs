using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hs.console.mef
{
    public class Person : BaseClass
    {
        //[Import("1")]
        //IGreet greet;

        [ImportMany]
        IEnumerable<IGreet> greets;

        //public Person()
        //{
        //    this.ComposePartsSelf();
        //}

        public void SayHello(string msg)
        {
            //greet.SayHello(msg);
        }

        public void SayManyHello(string msg)
        {
            foreach (IGreet item in greets)
            {
                item.SayHello(msg);
            }
        }
    }
}
