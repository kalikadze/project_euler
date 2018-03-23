using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_050
    {
        public problem_050()
        {
            int sum = 0;
            int max = 0;
            int maxlen = 0;
            List<int> primes = new List<int>();
            int border = 1000000;
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 2; i < border; i++)
            {
                if (Utils.isPrime(i))
                    primes.Add(i);
            }
            
            for (int i = 0; i < primes.Count; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    sum = 0;
                    for (int j = k; j < i; j++)
                    {
                        sum += primes[j];
                        if (sum == primes[i])
                        {
                            if (j - k + 1 > maxlen)
                            {
                                maxlen = j - k + 1;
                                max = sum;
                            }

                            if (sum > primes[i])
                                break;
                        }
                    }
                }
            }
            
            Console.WriteLine("Problem 050");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
