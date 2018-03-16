using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_023
    {
        public problem_023()
        {
            List<bool> abund_list = new List<bool>();
            List<long> nonabund_list = new List<long>();
            bool isabusum;
            long sum = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            abund_list.Add(false);

            for (int i = 1; i < 28124; i++)
            {
                if (Utils.isAbundant(i))
                    abund_list.Add(true);
                else
                    abund_list.Add(false);
            }


            for (int i = 1; i < 28124; i++)
            {
                isabusum = false;

                for (int j = 1; j <= i / 2; j++)
                {
                    if (abund_list[j] && abund_list[i - j])
                    {
                        isabusum = true;
                        break;
                     }
                }
                if (isabusum == false)
                    nonabund_list.Add(i);
            }

            sum = nonabund_list.Take(nonabund_list.Count).Sum();

            Console.WriteLine("Problem 023");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
