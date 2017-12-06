using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace euler
{
    class problem_012
    {
        public problem_012()
        {
            long result = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            long i = 1;
            long triangNum = 0;
            long divCount = 0;

            do
            {
                for (int ii = 1; ii <= i; ii++)
                    triangNum += ii;
                divCount = Utils.getDiv(triangNum);
                if (divCount > 500)
                {
                    result = triangNum;
                    break;
                }
                i++;
                triangNum = 0;
            } while (true);

            Console.WriteLine("Problem 012");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
