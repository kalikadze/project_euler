using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace euler
{
    class problem_042
    {
        public problem_042()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string line = null;
            List<int> nums = new List<int>();
            List<string> importedWords = new List<string>();
            string f = @"..\..\problem_042.in";
            int counter = 0;

            using (StreamReader r = new StreamReader(f))
            {
                line = r.ReadLine();
            }
            //importedWordsAsNums = line.Split(',').ToString().Trim('"').Select(Utils.sumWord(l))
            importedWords = line.Split(',').ToList();

            foreach (string w in importedWords)
            {
                int tempySum = Utils.sumWord(w.Trim('"'));
                nums.Add(tempySum);
                if (Utils.isTriangle(tempySum))
                    counter++;
            }

            Console.WriteLine("Problem 042");
            Console.WriteLine(counter + "\n"); // place result here
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
