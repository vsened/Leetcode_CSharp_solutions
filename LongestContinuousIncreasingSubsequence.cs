using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class LongestContinuousIncreasingSubsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            var max = 0;
            var count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    count++;
                else
                {
                    if (count > max)
                        max = count;
                    count = 1;
                }
            }
            if (count > max)
                max = count;
            return max;
        }
    }
}
