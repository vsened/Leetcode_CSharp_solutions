using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int minIndex = 0;
            int midIndex = nums.Length / 2;
            int maxIndex = nums.Length - 1;
            while (true)
            {
                if (maxIndex - minIndex == 1)
                {
                    if (nums[minIndex] == target)
                        return minIndex;
                    else if (nums[maxIndex] == target)
                        return maxIndex;
                    else
                        return -1;
                }
                else if (nums[midIndex] < target)
                {
                    minIndex = midIndex + 1;
                    midIndex = maxIndex - ((maxIndex - minIndex) / 2);
                }
                else if (nums[midIndex] > target)
                {
                    maxIndex = midIndex - 1;
                    midIndex = midIndex - ((midIndex - minIndex) / 2);
                }
                else if (nums[midIndex] == target)
                    return midIndex;
            } 
        }
        public static int Search2(int[] nums, int target)
        {
            int minIndex = 0;
            int maxIndex = nums.Length - 1;
            while (minIndex <= maxIndex)
            {
                var mid = maxIndex - (maxIndex - minIndex) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    maxIndex = mid - 1;
                else
                    minIndex = mid + 1;
            }
            return -1;
        }
    }
}
