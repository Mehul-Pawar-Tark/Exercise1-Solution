using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class SortingSubsets
    {
        List<int> nums = new List<int>();
        public void setInput()
        {

            nums = [ 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 ];

        }
        public int getMinimalSize()   
        {
            int change = 0;
            int length= nums.Count;


            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = nums[i];
            }
            Array.Sort(arr);

            for (int i = 0; i <length; i++)
            {
                if (arr[i] != nums[i])
                    change++;
            }



            return change;
        }
    }
}
