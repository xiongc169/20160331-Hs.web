using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility.quartz
{
    public class MyJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("this is execute method" + DateTime.Now);
        }
    }
}
