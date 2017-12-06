using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace euler
{

    class problem_005
    {
        public problem_005()
        {
            long result = 1;
            int[,] divMat = new int[22, 22];
            int[] maxMat =  new int[22];

            Stopwatch sw = new Stopwatch();
            sw.Start();
                        
            for (int i = 2; i < 21; i++)
            {
                if (Utils.isPrime(i))
                    divMat[i, i]++;
                else
                    Utils.getPrimeDiv(i, i, divMat);
            }

            for (int i = 2; i < 22; i++)
                for (int j = 2; j < 21; j++)
                {
                    if (divMat[i, j] > maxMat[j])
                        maxMat[j] = divMat[i, j];
                }
            
            for (int i = 0; i < 22; i ++)
               result *= (long)Math.Pow(i, maxMat[i]);

            Console.WriteLine("Problem 005");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
