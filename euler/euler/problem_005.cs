using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace euler
{
    class DivPair
    {
        int num;
        int count;

        public DivPair(int n, int c)
        {
            this.num = n;
            this.count = c;
        }        
    }

    class problem_005
    {
        public problem_005()
        {
            long result = 0;
            List<DivPair> dp = new List<DivPair>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
                        
            for (int i = 1; i < 21; i++)
            {
                if (Utils.isPrime(i))
                    dp.Add(new DivPair(i, 0));

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
