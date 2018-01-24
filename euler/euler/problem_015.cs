using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace euler
{
    class problem_015
    {
        public problem_015()
        {
            // TODO make a code
            Stopwatch sw = new Stopwatch();
            sw.Start();


            Console.WriteLine("Problem 015");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
