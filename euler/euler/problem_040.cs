using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace euler
{
    class problem_040
    {
        public int getChamper(string champer, int pos)
        {
            return int.Parse(champer[pos].ToString());
        }
        public problem_040()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            int res = 1;
            int hilim = 200000;
            StringBuilder champernown = new StringBuilder();
            int pos = 1;
            string champerstr = null;

            for (int i = 1; i < hilim; i++)
            {
                champernown.Append(i.ToString());
            }

            champerstr = champernown.ToString();

            for (int i = 0; i < 7; i++)
            {
                pos = (int)Math.Pow(10, i) - 1;
                res *= getChamper(champerstr, pos);
            }
            
            Console.WriteLine("Problem 040");
            Console.WriteLine(res);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
