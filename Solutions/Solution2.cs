using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution2

    {
        public String replaceString(String s, String t) //solution2
        {
            String answer = "";
            char[] S = s.ToCharArray();
            char[] T = t.ToCharArray();

            for (int i = 0; i < S.Length; i++)
            {

                int max = -1;

                for (int j = 0; j < T.Length; j++)
                {
                    if (T[j] != '-' && T[j] > S[i])
                    {
                        max = j;
                    }
                    if (max != -1 && T[j] > T[max])
                    {
                        max = j;
                    }
                }

                if (max != -1)
                {
                    S[i] = T[max];
                    T[max] = '-';
                }

                answer += S[i];
            }
            return answer;
        }

    }
}
