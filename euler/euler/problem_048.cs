using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Numerics;

namespace euler
{
    class problem_048
    {
        public problem_048()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BigInteger sum = 0;
            BigInteger power;

            for (int i = 1; i < 1001; i++)
            {
                power = BigInteger.Pow(i, i);
                sum += power;
            }

            string result = sum.ToString().Substring(sum.ToString().Length - 10);

            Console.WriteLine("Problem 059");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
