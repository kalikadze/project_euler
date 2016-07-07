using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace euler
{
    class problem_007
    {
        public problem_007()
        {

            long result = 0, i = 1;
            int n = 10001;
            //int n = 6;
            List<long> primes = new List<long>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            do
            {
                i++;
                if (Utils.isPrime(i))
                    primes.Add(i);
            } while (primes.Count != n);

            result = primes[primes.Count - 1];
            Console.WriteLine("Problem 007");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
