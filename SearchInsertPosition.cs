using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            if (target > nums[right])
                return right + 1;
            else if (target < nums[left])
            {
                return left;
            }
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else if (nums[mid] > target)
                    right = mid - 1;
            }
            return right + 1;
        }
    }
}
