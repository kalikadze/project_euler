using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace euler
{
    class problem_004
    {
        public problem_004()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            long result = 0;
            List<long> palins = new List<long>();

            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j-- )
                {
                    result = i * j;
                    if (Utils.isPalindrome(result.ToString()))
                    {
                        palins.Add(result);
                    }
                }
            }

            Console.WriteLine("Problem 004");
            Console.WriteLine(palins.Max());
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
