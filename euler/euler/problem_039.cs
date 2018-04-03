using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_039
    {
        class triangles
        {
            public int a, b, c;
            public triangles(int aa, int bb, int cc)
            {
                a = aa;
                b = bb;
                c = cc;
            }
        }
        public problem_039()
        {
            int max = 0;
            double da, dc;
            int a, b, c, pmax = 0;
            bool distinct = false;
            List<triangles> results = new List<triangles>();
            List<triangles> maxresults = new List<triangles>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int p = 3; p < 1000; p++)
            {
                for (b = 1; b < (p-2); b++)
                {
                    //calc a
                    da = (2 * b * p - p * p) / (2*(b - p));
                    if (da < 1)
                        continue;
                    // check if a is int
                    if ((da % 1) == 0)
                    {
                        a = (int)da;
                    }
                    else
                        continue;
                    
                    dc = Math.Sqrt(a * a + b * b);

                    if ((dc % 1) == 0)
                    {
                        c = (int)dc;
                    }
                    else
                        continue;

                    distinct = true;
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].a == b)
                            distinct = false;
                    }
                    if (distinct)
                        results.Add(new triangles(a, b, c));
                }

                if (results.Count > max)
                {
                    max = results.Count;
                    maxresults.Clear();
                    maxresults = results.ToList();
                    pmax = p;
                }

                results.Clear();
            }


            Console.WriteLine("Problem 039");
            Console.WriteLine(pmax);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
