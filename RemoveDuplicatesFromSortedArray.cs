using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int slow = 0;
            for (int fast = 1; fast < nums.Length; fast++)
            {
                if (nums[slow] == nums[fast])
                    continue;
                else
                {
                    var temp = nums[++slow];
                    nums[slow] = nums[fast];
                    nums[fast] = temp;

                }
            }
            return slow + 1;
        }
    }
}
