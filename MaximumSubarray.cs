using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            var maxSum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j + i <= nums.Length; j++)
                {
                    var slice = new ArraySegment<int>(nums).Slice(i, j);
                    if (maxSum < slice.Sum())
                    {
                        maxSum = slice.Sum();
                    }
                }
            }
            return maxSum;
        }

        public static int MaxSubArray2(int[] nums)
        {
            int maxSum = 0;
            int curSum = 0;
            int start = 0;
            int end = 0;
            int current = 0;
            while (current < nums.Length)
            {
                curSum += nums[current];
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    end = current;
                }                
                if (curSum < 0)
                {
                    curSum = 0;
                    start = current+1;
                    end = current+1;
                }  
            }
            return maxSum;
        }
    }
}
