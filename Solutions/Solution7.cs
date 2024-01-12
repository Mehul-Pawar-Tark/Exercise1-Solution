using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution7
    {
        public String largestSubString(String str)
        {
            String answer = "";
            int n = str.Length;


            int index = 0;

            while (index < n)
            {
                int max = index;
                int i = index + 1;

                while (i < n)
                {
                    if (str[i] > str[max])
                        max = i;

                    i++;
                }

                answer += str[max];
                index = max + 1;
            }

            return answer;
        }

    }
}
