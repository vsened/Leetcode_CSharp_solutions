using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {
                if (dict.ContainsKey(target - nums[index]))
                    return new int[] { dict[target - nums[index]], index };
                if (!dict.ContainsKey(nums[index]))
                    dict.Add(nums[index], index);
            }
            return new int[2];
        }
    }
}
