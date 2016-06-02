using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            /****************************************/
            // 001
            problem_001 p001 = new problem_001();
            // 002
            problem_002 p002 = new problem_002();
            // 003
            problem_003 p003 = new problem_003();
            // 004
            problem_004 p004 = new problem_004();
            // 005
            problem_005 p005 = new problem_005();
            /****************************************/
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("\n\nTime elapsed: {0} ms", ts);
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
