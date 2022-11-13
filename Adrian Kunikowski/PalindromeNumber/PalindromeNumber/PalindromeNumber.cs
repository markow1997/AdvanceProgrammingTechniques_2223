using System;

namespace PalindromeNumber
{
    internal class PalindromeNumber
    {

        static void Main(string[] args)
        {
            int[] testowyInt = new int[7] { 121, -121, 0, 1555352, -252525, 10, -1};

            foreach(int number in testowyInt)
            {
                if (IsPalindrome(number))
                    Console.WriteLine(number + " jest palindromem");
                else
                    Console.WriteLine(number + " nie jest palindromem");
            }
        }

        public static bool IsPalindrome(int x)
        {
            string str = x.ToString();

            int i = 0; int j = str.Length;
            while (i < j - 1)
            {
                if (str[i] != str[j - 1])
                    return false;
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}
