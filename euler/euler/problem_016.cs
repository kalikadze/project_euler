using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace euler
{
    class problem_016
    {
        public problem_016()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string result = "2";
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                result = Utils.bigMply(result, "2");
            }

            for (int i = 0; i < result.Length; i++)
                sum += int.Parse(result[i].ToString());


            Console.WriteLine("Problem 016");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
