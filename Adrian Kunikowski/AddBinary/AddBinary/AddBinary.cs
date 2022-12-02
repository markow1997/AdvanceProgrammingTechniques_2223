using System;

namespace AddBinary
{
    internal class Program
    {
        public static string AddBinary(string a, string b)
        {

            string result = "";

            if (a == "0" || a == "")
                return b;
            if (b == "0" || b == "")
                return a;

            if (a.Length > b.Length)
            {
                int zapas = 0;
                double wynik = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    wynik = Char.GetNumericValue(a[a.Length - i - 1]) + Char.GetNumericValue(b[b.Length - i - 1]) + zapas;

                    if (wynik == 0)
                    {
                        result = "0" + result;
                        zapas = 0;
                    }
                    else if (wynik == 1)
                    {
                        result = "1" + result;
                        zapas = 0;
                    }
                    else if (wynik == 2)
                    {
                        result = "0" + result;
                        zapas = 1;
                    }
                    else if (wynik == 3)
                    {
                        result = "1" + result;
                        zapas = 1;
                    }
                }

                for (int i = b.Length; i < a.Length; i++)
                {
                    wynik = Char.GetNumericValue(a[a.Length - i - 1]) + zapas;

                    if (wynik == 0)
                    {
                        result = "0" + result;
                        zapas = 0;
                    }
                    else if (wynik == 1)
                    {
                        result = "1" + result;
                        zapas = 0;
                    }
                    else if (wynik == 2)
                    {
                        result = "0" + result;
                        zapas = 1;
                    }
                }

                if (zapas == 1)
                    result = "1" + result;

                return result;

            }
            else if (a.Length == b.Length)
            {
                int zapas = 0;
                double wynik = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    wynik = Char.GetNumericValue(a[a.Length - i - 1]) + Char.GetNumericValue(b[b.Length - i - 1]) + zapas;

                    if (wynik == 0)
                    {
                        result = "0" + result;
                        zapas = 0;
                    }
                    else if (wynik == 1)
                    {
                        result = "1" + result;
                        zapas = 0;
                    }
                    else if (wynik == 2)
                    {
                        result = "0" + result;
                        zapas = 1;
                    }
                    else if (wynik == 3)
                    {
                        result = "1" + result;
                        zapas = 1;
                    }
                }

                if (zapas == 1)
                    result = "1" + result;

                return result;
            }
            else
                return AddBinary(b, a);

            return result;
        }
        static void Main(string[] args)
        {
            String s1 = "1011";
            String s2 = "0101";

            Console.WriteLine(AddBinary(s1, s2) + "\n");
        }
    }
}
