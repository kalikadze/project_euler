using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
namespace euler
{
    class problem_036
    {
        public problem_036()
        {
            int sum = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 1E+6; i++)
            {
                if (Utils.isPalindrome(i.ToString()) && Utils.isPalindrome(Utils.binaryString(i)))
                {
                    sum += i;
                }
            }

            Console.WriteLine("Problem 028");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
