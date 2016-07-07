using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace euler
{
    class problem_006
    {
        public problem_006()
        {
            long result = 0;
            int n = 100;
            long sumOfSquares = 0;
            long squaresOfSum = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 1; i < n + 1; i++)
            {
                sumOfSquares += (long)Math.Pow(i, 2);
                squaresOfSum += i;
            }

            squaresOfSum = (long)Math.Pow(squaresOfSum, 2);
            result = squaresOfSum - sumOfSquares;

            Console.WriteLine("Problem 006");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
