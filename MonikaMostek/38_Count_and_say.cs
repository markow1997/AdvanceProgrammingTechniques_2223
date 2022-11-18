using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Count_and_say
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Specify number:");
            string n1 = Console.ReadLine();
            int n = Int32.Parse(n1);

            string number = "1";
            int count = 0;
            var myList = new List<Tuple<int, int>>();
            Tuple<int, int> result = new Tuple<int, int>(1, 1);


            for (int i = 0; i < n; i++)
            {
                count = 1;
                for (int j = 0; j < number.Length; j++)
                {
                   
                    if (j + 1 < number.Length && (number[j] == number[j + 1])) //if the same
                    {
                        count++;
                    }
                    else if (j + 1 < number.Length && (number[j] != number[j + 1])) // if diffrent
                    {
                        result = new Tuple<int, int>(count, int.Parse(number[j].ToString()));
                        myList.Add(result);
                        count = 1;
                    }
                    else if (j + 1 >= number.Length) //if end of the string
                    {
                        result = new Tuple<int, int>(count, int.Parse(number[j].ToString()));
                        myList.Add(result);
                    }

                    
                }
                number = "";
                foreach (Tuple<int, int> item in myList)
                {
                    number += item.Item1 + "" + item.Item2;
                }
                Console.WriteLine(number);
                myList.Clear();
            }

            Console.ReadKey();

        }
        
    }
}
