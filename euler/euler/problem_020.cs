using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace euler
{
    class problem_020
    {
        public problem_020()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string result = "1";
            int sum = 0;

            for (int i = 100; i > 0; i--)
            {
                result = Utils.bigMply(result, i.ToString());
            }

            for (int i = 0; i < result.Length; i++)
                sum += int.Parse(result[i].ToString());

            Console.WriteLine("Problem 020");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
