using System;
using System.Linq;

namespace SearchInsertPosition
{
    class Program
    {

        static public int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            for (i = 0; i < nums.Count(); i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return i;
        }

        static void Main(string[] args)
        {
            int[] tab = new int[4] { 1, 3, 5, 6 };
            int szukaj = 4;
            Console.WriteLine("Gdyby liczba "+szukaj+" byla w tablicy, to bylaby na pozycji "+SearchInsert(tab,szukaj));
        }
    }
}
