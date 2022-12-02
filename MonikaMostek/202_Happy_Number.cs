using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe:");
            string number;
            number = Console.ReadLine();
            int sum;

            while (true)
            {
                sum = 0;
                for(int i=0; i<number.Length; i++)
                {
                    sum+=Int32.Parse(number[i].ToString()) * Int32.Parse(number[i].ToString());
                }
                if(sum == 1)
                {
                    Console.WriteLine("To jest szczęśliwa liczba");
                    break;
                }
               number = sum.ToString();
                if(number.Length == 1 && Int32.Parse(number)!=7)
                {
                    Console.WriteLine("To NIE jest szczęśliwa liczba");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
