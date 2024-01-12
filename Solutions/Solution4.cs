using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution4
    {
        public String decodedString(String str, int[] position, int[] lengths)   //solution4
        {
            for (int i = 0; i < position.Length; i++)
            {
                string temp = str.Substring(position[i], lengths[i]);
                String revers = "";
                if (temp.Length > 1)
                {
                    for (int j = temp.Length - 1; j >= 0; j--)
                    {
                        revers += temp[j];
                    }
                }
                else
                    revers = temp;



                str = str.Substring(0, (position[i] + lengths[i])) + revers + str.Substring(position[i] + lengths[i]);

                Console.WriteLine(str);
            }

            return str;
        }
    }
}
