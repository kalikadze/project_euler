using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace euler
{
    class problem_025
    {
        public problem_025()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<string> Fiblist = new List<string>();
            Fiblist.Add("1");
            Fiblist.Add("1");
            string digs = "";
            int sum = 0;
            int i = 2;

            do
            {
                i++;
                Fiblist.Add(Utils.bigsum(Fiblist[Fiblist.Count - 1], Fiblist[Fiblist.Count - 2]));
                digs = Fiblist[Fiblist.Count - 1];
                sum = digs.Length;
            } while (sum < 1000);

            Console.WriteLine("Problem 025");
            Console.WriteLine(i);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
