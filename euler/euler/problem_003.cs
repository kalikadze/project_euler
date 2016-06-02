using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace euler
{
    class problem_003
    {
        public problem_003()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            long num = 600851475143, i = 0;

            for (i = (long)Math.Sqrt(num); i > 0 ; i -- )
            {
                if (num % i == 0 && Utils.isPrime(i))
                    break;
            }
                
            Console.WriteLine("Problem 003");
            Console.WriteLine(i);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
