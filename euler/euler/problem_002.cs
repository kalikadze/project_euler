using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace euler
{
    class problem_002
    {
        public problem_002()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> members = new List<int>();
            long fib1 = 1, fib2 = 2, fib3 = 3;
            long sum = 2;


            while (fib3 < 4000000)
            {
                fib3 = fib1 + fib2;
                if (fib3 % 2 == 0)
                    sum += fib3;

                fib1 = fib2;
                fib2 = fib3;
            }
            Console.WriteLine("Problem 002");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);

        }
    }
}
