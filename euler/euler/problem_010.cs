using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace euler
{
    class problem_010
    {
        public problem_010()
        {
            long result = 0;
            List<int> primes = new List<int>();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 2; i < 2000000; i++)
            {
                if (Utils.isPrime(i))
                {
                    primes.Add(i);
                    result += i;
                }
            }

            Console.WriteLine("Problem 010");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);

        }
    }
}
