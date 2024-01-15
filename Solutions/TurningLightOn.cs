using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class TurningLightOn
    {
        List<String> pannel=new List<String>();
        public void setInput()
        {
            pannel = ["0101","1010","0101","1010"];

        }

        public int minFlips()
        {
           int flips = 0;

            for (int row = pannel.Count-1; row>=0; row--)
            {
                for(int col = pannel[row].Length-1; col>=0; col--)
                {
                    if (pannel[row][col] == '0')
                    {
                        flip(row, col);
                        flips++;
                    }
                }
            }
           return flips;
        }

        public void print(List<String> pannel)
        {
            for(int row = 0; row<pannel.Count; row++)
            {
                String bulbs = pannel[row];
                
                Console.WriteLine(bulbs);
            }
        }

        public void flip(int Row, int Col) 
        { 
            for(int row=0; row<=Row; row++)
            {
                
                String bubles= pannel[row];
                String flipedbubles = "";

                for(int col=0; col<bubles.Length; col++)
                {
                   if(col<=Col)
                   {
                        if (bubles[col]=='0')
                            flipedbubles += "1";
                        else
                            flipedbubles += "0";
                   }
                   else
                    {
                        flipedbubles+= bubles[col];
                    }
                }

                pannel[row] = flipedbubles;
            }
        }
    }
}
