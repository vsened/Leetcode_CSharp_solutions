using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class SortArrayByParity
    {
        public int[] GetSortArrayByParity(int[] nums)
        {
            var maxIndex = nums.Length - 1;
            for (int minIndex = 0; minIndex < maxIndex; minIndex++)
            {
                if (nums[minIndex] % 2 == 0)
                    continue;
                else
                {
                    while (maxIndex > minIndex && nums[maxIndex] % 2 != 0)
                    {
                        maxIndex--;
                    }
                    var temp = nums[maxIndex];
                    nums[maxIndex] = nums[minIndex];
                    nums[minIndex] = temp;
                }
            }
            return nums;
        }
    }
}
