using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution4
    {
        String str = "";
        List<int> position=new List<int>();
        List<int> lengths=new List<int>();

        public void setInput()
        {
            str = "misip";

            position = [ 2, 3, 1, 7 ];
            lengths = [ 1, 1, 2, 2 ];

        }
        public String decodedString()   //solution4
        {
            for (int i = 0; i < position.Count; i++)
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

                
            }

            return str;
        }
    }
}
