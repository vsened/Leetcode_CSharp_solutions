using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class MissingNumber
    {
        public static int MissingNumber1(int[] nums)
        {
            nums = QuickSort(nums, 0, nums.Length - 1);
            for (int i = 0; i <= nums.Length; i++)
            {
                if (i == nums.Length || nums[i] != i)
                    return i;
            }
            return 0;
        }
        public static int MissingNumber2(int[] nums)
        {
            IEnumerable<int> realSum = Enumerable.Range(0, nums.Length + 1);
            return realSum.Sum() - nums.Sum();
        }
        public static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return array;
            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);
            return array;
        }
        public static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        public static void Swap(ref int left, ref int right)
        {
            int temp = right;
            right = left;
            left = temp;
        }
    }
}
