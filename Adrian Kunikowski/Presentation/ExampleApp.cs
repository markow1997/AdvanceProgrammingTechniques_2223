using System;

namespace ExampleApp
{
    internal class ExampleApp
    {
        static void Main(string[] args)
        {
            int num = 2;
            Func1(num);
            Func2(num);
            Func3(num);
            Console.WriteLine("\nProgram zakonczony");
        }
        private static void Func1(int num)
        {
            Console.WriteLine("Wszedlem w func1!");
            while (num > 2)
            {
               num = num / 2;
            }
            Console.WriteLine("Wyszedlem z func1!");
        }
        private static void Func2(int num)
        {
            Console.WriteLine("\nWszedlem w func2!");
            while (num > 3)
            {
                num = num / 3;
            }
            Console.WriteLine("Wyszedlem z func2!");
        }
        private static void Func3(int num)
        {
            Console.WriteLine("\nWszedlem w func3!");
            while (num < 4)
            {
                num = num / 4;
            }
            Console.WriteLine("Wyszedlem z func3!");
        }
    }
}
