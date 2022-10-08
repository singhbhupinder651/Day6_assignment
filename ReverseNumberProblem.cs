using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class ReverseNumberProblem
    {
        public void ReverseNumber()
        {
            int reverse = 0;
            int remainder = 0;

            Console.WriteLine("Enter the number to Reverse");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Reversed number is :" + reverse);
        }
    }
}
