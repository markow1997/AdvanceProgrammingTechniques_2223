using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Projects
{
    internal class CanPlaceFlowers
    {
        public void canPlaceFlowers()
        {
            int[] flowerBed = new int[] { 1, 0, 0, 0, 0, 0, 1 };
            //int[] flowerBed = new int[] { 1, 0, 0, 0, 1 };
            int n = 34;

            int counter = 0;
            for(int i = 0; i < flowerBed.Length; i++)
            {
                if(flowerBed[i] == 0)
                {
                    if (counter > 1)
                    {
                        n--;
                        counter = 0;
                    }
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                
                if (n == 0)
                {
                    break;
                }
            }

            if(n == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}

