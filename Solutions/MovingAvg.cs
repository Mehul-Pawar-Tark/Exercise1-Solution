using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class MovingAvg
    {
        int n;
        List<Double> numbers=new List<Double>();

        public void setInput()
        {
            n= 3;
            numbers = [ 6, 2.5, 3.5] ;
        }
        public double difference()
        {
            int len=numbers.Count;
            double sum = 0;
          
            for(int i=0; i<n; i++)
            {
                sum += numbers[i];
            }

            double min = sum / n;
            double max = sum / n;

            for(int i=n; i<len; i++)
            {
                sum += numbers[i] - numbers[i - n];

                if((sum/n)<min)
                    min = sum / n;
            
                if ((sum / n) >max)
                    max = sum / n;
            }
            


            return max-min;
        }
    }
}
