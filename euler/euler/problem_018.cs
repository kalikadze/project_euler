using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_018
    {
        /// <summary>
        /// divide & weigth recursive function
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        /// <param name="data">triangle structure</param>
        /// <returns>-1 - error, 0 - end, 1 - left, 2 - right</returns>
        int weight(int x, int y, List<List<int>> data)
        {
            if (y == data.Count)
            {
                return 0;
            }
            else
            {
                return data[y][x] + /weight(x, y + 1, data) + weight(x + 1, y + 1, data);            
            }
        }

        public problem_018()
        {
            string f = @"..\..\problem_018.in";
            List<int> linenum = new List<int>();
            List<List<int>> nums = new List<List<int>>();
            int Sum = 0;

            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != "END")
                {
                    linenum = Array.ConvertAll<string, int>( line.Split(' '), int.Parse).ToList();
                    nums.Add(linenum);
                }
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            Sum = nums[0][0];

            for (int i = 0; i < nums.Count - 1; i++)
            {
                int left = weight(i, i + 1, nums);
                int right = weight(i + 1, i + 1, nums);

                if ( left > right)
                {
                    Sum += nums[i + 1][i];
                }
                else
                {
                    Sum += nums[i + 1][i + 1];
                }
            }

            Console.WriteLine("Problem 018");
            Console.WriteLine(Sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}

