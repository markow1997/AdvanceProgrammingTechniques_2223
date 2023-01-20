using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Projects
{
    internal class BaseballGame
    {
        public void game()
        {
            List<string> list = new List<string>();
            List<int> resultList = new List<int>();
            /*list.Add("5");
            list.Add("2");
            list.Add("c");
            list.Add("d");
            list.Add("+");*/

            list.Add("5");
            list.Add("-2");
            list.Add("4");
            list.Add("c");
            list.Add("d");
            list.Add("9");
            list.Add("+");
            list.Add("+");

            int result = 0;
            int resultListLength = 0;
            int n;

            for (int i=0; i < list.Count; i++)
            {
                resultListLength = resultList.Count;
                if (int.TryParse(list[i], out n))
                {
                    resultList.Add(Int32.Parse(list[i].ToString()));
                }
                else if (list[i].Equals("+"))
                {
                    if (list.Count > 2)
                    {
                       
                        resultList.Add(resultList[resultListLength-1] + resultList[resultListLength - 2]);
                    }
                }
                else if (list[i].Equals("d"))
                {
                    if (list.Count > 0)
                    {
                        resultList.Add(resultList[resultListLength-1] * 2);
                    }
                }
                else if (list[i].Equals("c"))
                {
                    if (list.Count > 0)
                    {
                        resultList.RemoveAt(resultListLength-1);
                    }
                }
            }
            foreach(int i in resultList)
            {
                Console.WriteLine(i);
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
