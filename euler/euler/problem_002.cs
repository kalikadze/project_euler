using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    class problem_002
    {
        public problem_002()
        {
            List<int> members = new List<int>();
            long sum = 0;

            for (int i = 0; i < 1000000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    members.Add(i);
                    sum += i;
                }
            }
            Console.WriteLine("***************");
            Console.WriteLine("Problem 001");
            Console.WriteLine(sum);
            Console.WriteLine("***************");

        }
    }
}
