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
            string f = @"..\..\problem_022.txt";
            List<string> names = new List<string>();
            long sumname = 0;
            long sumnames = 0;

            long ascii_ofs = 64;

            StreamReader r = new StreamReader(f);
            string line;
            line = r.ReadLine();
            names = line.Split(',').ToList();
            names = names.OrderBy(a => a).ToList();

            for (int i = 0; i < names.Count; i++)
            {
                names[i] = names[i].Trim('\"',' ');

                for (int j = 0; j < names[i].Length; j++)
                {
                    sumname += names[i][j] - ascii_ofs; 
                }
                sumnames += sumname * (i + 1);
                sumname = 0;
            }
        }
    }
}
