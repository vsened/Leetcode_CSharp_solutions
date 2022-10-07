using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MonotonicArray
    {
        public bool IsMonotonic(int[] nums)
        {
            var isIncrease = false;
            var isDecrease = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i] && !isDecrease)
                {
                    if (isIncrease)
                        continue;
                    else
                        isIncrease = true;
                }
                else if (nums[i - 1] > nums[i] && !isIncrease)
                {
                    if (isDecrease)
                        continue;
                    else
                        isDecrease = true;
                }
                else if (nums[i - 1] == nums[i])
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}
