using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_024
    {
        public problem_024()
        {
            int iteration = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //Utils.heapPermutation(arr, arr.Length, arr.Length, true);
            Utils.lexicoPermutation(arr,  false);

            Console.WriteLine("Problem 023");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
