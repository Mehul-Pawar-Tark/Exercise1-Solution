using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution6
    {
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        List<string> list3 = new List<string>();
        public void setInput()
        { 
            list1.Add("mouse"); list1.Add("dog"); list1.Add("pig"); list1.Add("cat");
            list2.Add("pig"); list2.Add("dog");
            list3.Add("dog"); list3.Add("cat");
        }

        public String scoreOfAll()
        {
            Console.Write(firstScore(list1, list2, list3) + "/");
            Console.Write(firstScore(list2, list1, list3) + "/");
            Console.WriteLine(firstScore(list3, list2, list1));

            return "";
        }

        public int firstScore(List<String> list1, List<String> list2, List<String> list3)
        {

            int first_score = 0;

            for (int i = 0; i < list1.Count; i++)
            {
                if ((!list2.Contains(list1[i])) && (!list3.Contains(list1[i])))
                {
                    first_score += 3;
                }
                else if ((!list2.Contains(list1[i])) || (!list3.Contains(list1[i])))
                {
                    first_score += 2;
                }
                else
                {
                    first_score++;
                }
            }

            return first_score;
        }
    }
}
