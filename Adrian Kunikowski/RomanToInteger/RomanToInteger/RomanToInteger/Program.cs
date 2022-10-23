internal class Program
{
    private static int Main(string[] args)
    {
        string input = "III";
        string input2 = "LVIII";
        string input3 = "MCMXCIV";

        int RomanToInt(string s)
        {
            int amountInt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'M')
                {
                    amountInt += 1000;
                }
                else if (s[i] == 'D')
                {
                    amountInt += 500;
                }
                else if (s[i] == 'C')
                {
                    if (i + 1 != s.Length)
                    {
                        if (s[i + 1] == 'M')
                        {
                            i++;
                            amountInt += 900;
                        }
                        else if (s[i + 1] == 'D')
                        {
                            i++;
                            amountInt += 400;
                        }
                        else
                            amountInt += 100;
                    }
                    else
                        amountInt += 100;
                }
                else if (s[i] == 'L')
                {
                    amountInt += 50;
                }
                else if (s[i] == 'X')
                {
                    if (i + 1 != s.Length)
                    {
                        if (s[i + 1] == 'C')
                        {
                            i++;
                            amountInt += 90;
                        }
                        else if (s[i + 1] == 'L')
                        {
                            i++;
                            amountInt += 40;
                        }
                        else
                            amountInt += 10;
                    }
                    else
                        amountInt += 10;
                }
                else if (s[i] == 'V')
                {
                    amountInt += 5;
                }
                else if (s[i] == 'I')
                {
                    if (i + 1 != s.Length)
                    {
                        if (s[i + 1] == 'X')
                        {
                            i++;
                            amountInt += 9;
                        }
                        else if (s[i + 1] == 'V')
                        {
                            i++;
                            amountInt += 4;
                        }
                        else
                            amountInt += 1;
                    }
                    else
                        amountInt += 1;
                }

            }

            return amountInt;
        }

        Console.WriteLine(input + " = " + RomanToInt(input).ToString());
        Console.WriteLine(input2 + " = " + RomanToInt(input2).ToString());
        Console.WriteLine(input3 + " = " + RomanToInt(input3).ToString());

        Console.WriteLine("Press any key to stop the program");
        Console.ReadKey(true);

        return 0;
    }
}