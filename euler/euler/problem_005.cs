using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace euler
{
    class DivStruct
    {
        public DivStruct(int maxdivisor)
        {
            int[] divisors = new int[maxdivisor];
        }        
    }

    class problem_005
    {
        public problem_005()
        {
            int max_numbers = 20;
            long result = 0;
            List<DivStruct> dp = new List<DivStruct>(max_numbers);
            Stopwatch sw = new Stopwatch();
            sw.Start();
                        
            for (int i = 1; i < 21; i++)
            {
                if (Utils.isPrime(i))
                    //dp.Add(new DivStruct(i, 0));

                for (int j = 1; j < i; j++)
                {
                    //if (i % j == 0)
                }
            }

            Console.WriteLine("Problem 005");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
