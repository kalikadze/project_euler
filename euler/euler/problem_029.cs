using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_029
    {
        public problem_029()
        {
            int cnt = 0;
            int abrd = 100;
            int bbrd = 100;
            List<double> results = new List<double>();
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int a = 2; a <= abrd; a++)
            {
                for (int b = 2; b <= bbrd; b++)
                {
                    results.Add(Math.Pow((double)a, (double)b));
                }
            }

            results = results.Distinct().ToList();
            cnt = results.Count();

            Console.WriteLine("Problem 029");
            Console.WriteLine(cnt);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
