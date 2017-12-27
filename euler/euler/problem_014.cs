using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace euler
{
    class problem_014
    {
        public problem_014()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            ulong max = 0, tempy = 0, starter = 0;
            ulong start = 1000000;

            for (ulong i = start; i > 0; i--)
            {
                tempy = Utils.collatz(i);
                if (tempy > max)
                {
                    max = tempy;
                    starter = i;
                }
            }

            Console.WriteLine("Problem 014");
            Console.WriteLine(starter);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
