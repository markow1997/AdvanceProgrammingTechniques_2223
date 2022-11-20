using System;

namespace UglyNumber
{
    class UglyNumber
    {
        static bool IsUgly(int n)
        {
            if (n > 1)
            {
                while (n > 1)
                {
                    if (n % 5 == 0)
                    {
                        n = n / 5;
                        continue;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n / 3;
                        continue;
                    }
                    else if (n % 2 == 0)
                    {
                        n = n / 2;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (n <= 0)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num = 52038753;
            int num2 = 6;
            if (IsUgly(num))
                Console.WriteLine(num + " is an ugly number\n");
            else
                Console.WriteLine(num + " is NOT an ugly number\n");

            if (IsUgly(num2))
                Console.WriteLine(num2 + " is an ugly number\n");
            else
                Console.WriteLine(num2 + " is NOT an ugly number\n");
        }
    }
}
