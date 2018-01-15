using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_018
    {
        public problem_018()
        {
            string f = @"..\..\problem_018.in";
            List<int> linenum = new List<int>();
            List<List<int>> nums = new List<List<int>>();
            List<List<int>> sumnums;

            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != "END")
                {
                    linenum = Array.ConvertAll<string, int>( line.Split(' '), int.Parse).ToList();
                    nums.Add(linenum);
                }
            }
            sumnums = new List<List<int>>(nums);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int n = nums.Count - 1; n > 0; n--)
                for (int m = nums[n].Count -1; m > 0; m--)
                {
                    if (nums[n][m] > nums[n][m - 1])
                        nums[n - 1][m - 1] += nums[n][m];
                    else
                        nums[n - 1][m - 1] += nums[n][m - 1];
                }

            Console.WriteLine("Problem 018");
            Console.WriteLine(nums[0][0]);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}

