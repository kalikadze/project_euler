using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_022
    {
        public problem_022()
        {
            string f = @"..\..\problem_022.in";
            List<int> linenum = new List<int>();
            List<List<int>> nums = new List<List<int>>();
            List<List<int>> sumnums;

            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != "END")
                {
                    linenum = Array.ConvertAll<string, int>(line.Split(' '), int.Parse).ToList();
                    nums.Add(linenum);
                }
            }

        }
    }
}
