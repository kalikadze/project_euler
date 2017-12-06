using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace euler
{
    class problem_008
    {
        public problem_008()
        {
            long result = 1, max = 1;
            int length = 13;

            string numbers;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (TextReader reader = File.OpenText(@"d:\PROJECTS\Project_Euler\euler\euler\problem_008.in"))
            {
                numbers = reader.ReadToEnd();
            }
            numbers = numbers.Replace("\r\n", string.Empty);

            for (int i = 0; i < numbers.Length - length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    max *= (long)char.GetNumericValue(numbers[i + j]);
                }
                if (max > result)
                {
                    result = max;
                }
                max = 1;
            }

            Console.WriteLine("Problem 008");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
