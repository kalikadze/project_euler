using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_031
    {
        public problem_031()
        {
            // dumb solution - BF
            int cnt = 0;
            double sum = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int a = 0; a < 2; a++)                                 // 2
                for (int b = 0; b < 3; b++)                             // 1
                    for (int c = 0; c < 5; c++)                         // 0.5
                        for (int d = 0; d < 11; d++)                    // 0.20
                            for (int e = 0; e < 21; e++)                // 0.10
                                for (int f = 0; f < 41; f++)            // 0.05
                                    for (int g = 0; g < 101; g++)       // 0.02
                                        for (int h = 0; h < 201; h++)   // 0.01
                                        {
                                            sum = a * 2 + b * 1 + c * 0.5 + d * 0.2 + e * 0.1 + f * 0.05 + g * 0.02 + h * 0.01;

                                            if (sum > 2)
                                                continue;

                                            if (sum == 2)
                                                cnt++;

                                        }

            Console.WriteLine("Problem 039");
            Console.WriteLine(cnt);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
