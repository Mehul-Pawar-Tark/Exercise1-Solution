using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution1
    {
        String str = "";
        Dictionary<string, string> Dictionary;

        public void setinput()
        {
            str = "101101";

            Dictionary = new Dictionary<string, string>(){{"00", "A"},
                                                          {"10", "B"},
                                                          {"01", "C"},
                                                          {"11", "D" } };
        }
        public String HuffmanDecoding()    
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
