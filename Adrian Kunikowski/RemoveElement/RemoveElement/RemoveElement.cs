using System;

namespace RemoveElement
{
    class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int howMany = nums.Length;
            int tmp;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    howMany--;
                    nums[i] = -1;
                }
            }

            int start = 0, koniec = nums.Length - 1;

            while (start < koniec)
            {
                if (nums[start] == -1 && nums[koniec] != -1)
                {
                    tmp = nums[start];
                    nums[start] = nums[koniec];
                    nums[koniec] = tmp;
                }

                if (nums[koniec] == -1)
                    koniec--;
                if (nums[start] != -1)
                    start++;
            }

            return howMany;
        }
        static void Main(string[] args)
        {
            int[] tab = new int[4] { 1, 2, 3, 2 };
            int ile = RemoveElement(tab, 2);
            Console.WriteLine("Zostalo: "+ile+" elementow");

            if (ile > 0)
            {
                Console.WriteLine("Elementy: ");
                for (int i = 0; i < ile; i++)
                    Console.Write(tab[i]+" ");
            }
        }
    }
}
