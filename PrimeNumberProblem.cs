using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class PrimeNumberProblem
    {
        public void PrimeNumber()
        {
            int n = 0;
            int temp = 0;

            Console.WriteLine("Enter the number to check prime");
            n = Convert.ToInt32(Console.ReadLine());
            int m = n / 2;

            for (int i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Enter number is not Prime");
                    temp = 1;
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Enter number is Prime");
            }
        }
    }
}
