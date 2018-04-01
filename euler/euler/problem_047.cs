using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_047
    {
        public problem_047()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<long> primes = new List<long>();
            int conseq = 0;
            int first = 0;

            for (int i = 999; i < 10000000; i++)
            {
                primes = Utils.getPrimeDivList(i);
                primes = primes.Distinct().ToList();

                if (primes.Count > 3)
                {
                    conseq++;
                }
                else
                    conseq = 0;

                if (conseq == 4)
                {
                    first = i - 3;
                    break;
                }
                primes.Clear();
            }


            Console.WriteLine("Problem 047");
            Console.WriteLine(first);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
