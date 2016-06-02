using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace euler
{
    class problem_001
    {
        public problem_001()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> members = new List<int>();
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    members.Add(i);
                    sum += i;
                }
            }
            Console.WriteLine("Problem 001");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
