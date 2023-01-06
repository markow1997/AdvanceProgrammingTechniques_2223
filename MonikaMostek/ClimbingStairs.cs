using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Projects
{
    internal class ClimbingStairs
    {
        public void calculate()
        {
            int number;
            Console.WriteLine("Write number of steps: ");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Wynik: "+countStairs(number));
        }
        
        public int fib(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            return fib(x - 1)+fib(x-2);
        }

        public int countStairs(int x)
        {
            return fib(x + 1);
        }
    }
}
