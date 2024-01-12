using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution1
    {
        public String HuffmanDecoding(String str, Dictionary<String, String> Dictionary)    //solution1
        {
            String answer = "";

            int index = 0;
            int n = str.Length;

            while (index < n)
            {
                string key = "";


                while (index < n)
                {
                    key += str[index++];

                    if (Dictionary.ContainsKey(key))
                    {
                        answer += Dictionary[key];
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
