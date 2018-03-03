using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility
{
    public class StopwatchUtility
    {
        public static Stopwatch watch = new Stopwatch();

        public static void Start()
        {
            watch.Restart();
        }

        public static long Stop()
        {
            watch.Stop();
            long elspsed = watch.ElapsedMilliseconds;
            return elspsed;
        }
    }
}
