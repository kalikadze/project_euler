using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace euler
{
    class problem_009
    {
        public problem_009()
        {
            int result = 0;
            int a2, b2, c2;
            int bound = 1000;
            bool stop = false;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int c;
            for (int a = 1; a < (int)(bound * 1/3); a++)
            {
                for (int b = 2; b < (int)(bound * 2 / 3); b++)
                {
                    {
                        c = 1000 - a - b;
                        a2 = (int)Math.Pow(a, 2);
                        b2 = (int)Math.Pow(b, 2);
                        c2 = (int)Math.Pow(c, 2);

                        if ((a2 + b2 == c2) && (a + b + c) == 1000)
                        {
                            result = a * b * c;
                            stop = true;
                            break;
                        }
                    }
                    if (stop)
                        break;
                }
                if (stop)
                    break;
            }

            Console.WriteLine("Problem 009");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }

    }
}
