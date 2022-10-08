using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class FibonacciSeriesProblem
    {
        public void FibonacciSeries()
        {

            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the Number of Elements");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 + " " + n2 + "");
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
