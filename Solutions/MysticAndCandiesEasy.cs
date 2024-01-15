using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class MysticAndCandiesEasy
    {
        int C;
        int X;
        List<int> high=new List<int>();
        public void setInput()
        {
            //C = 10;
            //X=10;
            //high = [20];

            C = 10;
            X = 7;
            high = [3,3,3,3,3];

            //C = 326;
            //X = 109;
            //high = [9,13,6,6,6,16,16,16,10,16,4,3,10,8,11,17,12,5,7,8,7,4,15,7,14,2,2,1,17,1,7,7,12,17,2,9,7,1,8,16,7,4,16,2,13,3,13,1,17,6];

            //C = 19;
            //X = 12;
            //high = [12,9,15,1,6,4,9,10,10,10,14,14,1,1,12,10,9,2,3,6,1,7,3,4,10,3,14];

            //C = 100;
            //X = 63;
            //high = [12, 34, 23, 45, 34];

        }

        public int minBoxes()
        {
           
            high.Sort();
            int len=high.Count;

            int index = 0;

            while(index<len)
            {
                C -= high[index];

                if(C<X)
                    return (len-index);
                
                index++;
            }

            return 0;
        }

        
    }
}
