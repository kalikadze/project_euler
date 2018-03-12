using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace euler
{
    class problem_021
    {
        public problem_021()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();


            long sum_amicable = 0;

            bool[] check = new bool[10000];
            for (int i = 0; i < 10000; i++)
                check[i] = true;

            for (int a = 1; a < 10000; a++)
            {
                if (check[a])
                {
                    List<long> aa = Utils.getDivList(a);
                    long b = 0;
                    for (int j = 0; j < aa.Count - 1; j++)
                    {
                        b += aa[j];
                    }

                    if (b > a)
                    {
                        long sumb = 0;
                        List<long> bb = Utils.getDivList(b);
                        for (int j = 0; j < bb.Count - 1; j++)
                        {
                            sumb += bb[j];
                        }

                        if (sumb == a && b != a)
                        {
                            sum_amicable += (a + b);
                            check[a] = false;
                        }
                    }
                }
            }

            Console.WriteLine("Problem 021");
            Console.WriteLine(sum_amicable);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
