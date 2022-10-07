using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            while (k > 0)
            {
                var temp = nums[nums.Length - 1];
                var currentTemp = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        currentTemp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                    }
                    else
                    {
                        temp = currentTemp;
                        currentTemp = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
                k--;
            }
        }
        public static void Rotate2(int[] nums, int k)
        {
            var arr = new int[nums.Length];
            for (int i = k; i < arr.Length; i++)
            {
                arr[i] = nums[i - k];
            }
            for (int j = 0; j < k; j++)
            {
                arr[j] = nums[nums.Length - k + j];
            }
            Array.Copy(arr, nums, nums.Length);
        }
    }
}
