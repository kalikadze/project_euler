using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace euler
{
    class problem_011
    {
        public problem_011()
        {
            long result = 1, max = 1;
            string numbers;
            int i = 0, j = 0;
            int[,] nums = new int[20, 20];

            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (TextReader reader = File.OpenText(@"d:\PROJECTS\Project_Euler\euler\euler\problem_011.in"))
            {
                numbers = reader.ReadToEnd();
            }

            foreach (var row in numbers.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    nums[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }

            for (i = 0; i < nums.GetUpperBound(0) + 1; i++)
                for (j = 0; j < nums.GetUpperBound(1) + 1; j++)
                {
                    max = Utils.findIn4directions(nums, 4, i, j);
                    if (max > result)
                        result = max;
                }

            Console.WriteLine("Problem 011");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
