﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution8
    {
        public string str="";

        

        public void setInput()
        {
            this.str = "((((";
        }
        public int beautyOfString()
        {
            int beauty = 0;

            int start = 0;
            int end = 0;
            int count= 0;

            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == '(')
                    start++;
                
                if (str[i]==')')
                    end++;
                    
            }
            count=start<end?start:end;

            beauty=(count*(count+1))/2;

            return beauty;
        }
    }
}
