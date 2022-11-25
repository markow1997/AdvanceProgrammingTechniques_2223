using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class MergeSortedArray
    {
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int sum = nums1.Count() - 1;
            int i = m - 1; // ostatni skladnik nums1
            int j = n - 1; // ostatni skladnik nums2

            while (sum >= 0)
            {
                if (i >= 0 && j >= 0)
                {
                    if (nums1[i] > nums2[j])
                    {
                        nums1[sum] = nums1[i];
                        sum--;
                        i--;
                    }
                    else
                    {
                        nums1[sum] = nums2[j];
                        sum--;
                        j--;
                    }
                }
                else if (i >= 0)
                {
                    nums1[sum] = nums1[i];
                    sum--;
                    i--;
                }
                else
                {
                    nums1[sum] = nums2[j];
                    sum--;
                    j--;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums1 = new int[] {1, 2, 3, 23 ,0 ,0 };
            int[] nums2 = new int[] {2, 4 };

            Merge(nums1, 4, nums2, 2);

            foreach(int i in nums1)
            {
                Console.Write(i + " ");
            }
            Console.Write('\n');
        }
    }
}

