using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class RemoveElement
    {
        public static int RemoveElement1(int[] nums, int val)
        {
            var minI = 0;
            var maxI = nums.Length;
            while (minI < maxI)
            {
                if (nums[minI] == val)
                {
                    nums[minI] = nums[maxI - 1];
                    maxI--;
                }
                else
                    minI++;
            }
            return maxI;
        }
    }
}
