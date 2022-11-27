using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first anagram to check: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Write second anagram to check: ");
            string word2 = Console.ReadLine();
            List<char> l1 = new List<char>();
            List<char> l2 = new List<char>();
            if(word1.Length != word2.Length)
            {
                Console.WriteLine("It is not an anagram");
            }
            else
            {
                l1 = word1.ToList();
                l2 = word2.ToList();
                l1.Sort();
                l2.Sort();
                bool anagram = true;
                for(int i = 0; i < word1.Length; i++)
                {
                    if(l1[i] != l2[i])
                    {
                        Console.WriteLine("It is not an anagram");
                        anagram = false;
                        break;
                    }
                }
                if (anagram == true)
                {
                    Console.WriteLine("It is an anagram");
                }
            }
            Console.ReadLine();
        }
    }
}
