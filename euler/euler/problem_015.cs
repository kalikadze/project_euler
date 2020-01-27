using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace euler
{
    class problem_015
    {
        public problem_015()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            BigInteger res = Utils.Combination(40, 20);

            Console.WriteLine("Problem 015");
            Console.WriteLine(res);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
