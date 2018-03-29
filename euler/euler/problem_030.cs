using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_030
    {
        public problem_030()
        {
            int sum = 0;
            List<int> results = new List<int>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 1; i < 1E6; i++)
            {
                string num = i.ToString();
                for (int j = 0; j < num.Length; j++)
                {
                    sum += (int)Math.Pow((double)(num[j] - 48), 5);
                }
                if (sum == i)
                    results.Add(i);
                sum = 0;
            }

            sum = results.Take(results.Count).Sum();
            
            Console.WriteLine("Problem 029");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
