using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);
            return nums;
        }
        public int[] SortedSquares2(int[] nums)
        {
            var result = new int[nums.Length];
            var minI = 0;
            var maxI = nums.Length - 1;
            int index = maxI;
            while (minI <= maxI)
            {
                if (nums[minI] * nums[minI] > nums[maxI] * nums[maxI])
                {
                    result[index] = nums[minI] * nums[minI];
                    index--;
                    minI++;
                }
                else
                {
                    result[index] = nums[maxI] * nums[maxI];
                    index--;
                    maxI--;
                }
            }
            return result;
        }
    }
}
