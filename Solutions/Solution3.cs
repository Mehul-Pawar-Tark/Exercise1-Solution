using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution3
    {
        public int minChanges(int[] nums)   //solution3
        {
            int change = 0;

            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[i];
            }
            Array.Sort(arr);

            for (int i = 0; i < nums.Length; i++)
            {
                if (arr[i] != nums[i])
                    change++;
            }



            return change;
        }
    }
}
