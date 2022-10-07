using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class TwoSum2InputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var nums = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (nums.ContainsKey(target - numbers[i]))
                    return new int[2] { nums[target - numbers[i]], i + 1 };
                if (!nums.ContainsKey(numbers[i]))
                    nums.Add(numbers[i], i + 1);
            }
            return null;
        }
        public int[] TwoSum2(int[] numbers, int target)
        {
            int j = numbers.Length - 1;
            int i = 0;
            while (numbers[i] + numbers[j] != target)
            {
                if (numbers[i] + numbers[j] > target)
                    j--;
                else
                    i++;
            }
            return new int[] { i + 1, j + 1 };
        }
    }
}
