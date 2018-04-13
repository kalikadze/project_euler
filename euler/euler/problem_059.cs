using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_059
    {
        public problem_059()
        {
            string f = @"..\..\problem_059_cipher.in";

            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != "END")
                {
                    linenum = Array.ConvertAll<string, int>(line.Split(' '), int.Parse).ToList();
                    nums.Add(linenum);
                }
            }



            Console.WriteLine("Problem 059");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
