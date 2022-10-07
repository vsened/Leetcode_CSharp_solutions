using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class MoveZeroes
    {
        public static void MoveZerosQuickSort(int[] nums)
        {
            int minIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    continue;
                else
                {
                    (nums[minIndex], nums[i]) = (nums[i], nums[minIndex++]);
                }
            }
        }
    }
}
