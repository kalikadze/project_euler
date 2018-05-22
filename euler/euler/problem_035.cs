using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
	public class problem_035
	{
		public problem_035()
		{
            int sum = 0;
            bool allShiftsFlag = false;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> millionCircularPrimes = new List<int>();
            for (int i = 2; i < 1E6; i++)
            {
                if (Utils.isPrime(i))
                {

                    string primeStr = i.ToString();
                    allShiftsFlag = true;
                    for (int j = 0; j < primeStr.Length - 1; j++)
                    {
                        primeStr = Utils.stringShift(primeStr);
                        if (!Utils.isPrime(long.Parse(primeStr)))
                        {
                            allShiftsFlag = false;
                            break;
                        }
                    }
                    if (allShiftsFlag)
                    {
                        sum++;
                        millionCircularPrimes.Add(i);
                    }

                }
            }

            Console.WriteLine("Problem 059");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}


