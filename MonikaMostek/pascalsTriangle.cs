using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Projects
{
    internal class PascalsTriangle
    {
        public List<List<int>> Generate()
        {
            int numRows = 0;
            Console.WriteLine("Write lehth: ");
            numRows = Int32.Parse(Console.ReadLine());
            List<List<int>> result = new List<List<int>>();
            List<int> currentList = new List<int>();
            List<int> tmpList = new List<int>();
            int calculate = 0;
            for (int i = 1; i <= numRows; i++)
            {
                result.Add(new List<int>());
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i-1 || i==1 || i==2)
                    {
                        currentList.Add(1);
                    }
                    else
                    {
                        calculate = tmpList[j - 1];
                        if (j<i-1)
                        {
                            calculate+=tmpList[j];
                        }
                        currentList.Add(calculate);
                    }
                }
                tmpList = currentList.ToList<int>(); 
                currentList.Clear();
                result.Add(tmpList.ToList<int>());
            }

            foreach(List<int> list in result)
            {
                foreach(int item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            return result;
        }
    }
}
