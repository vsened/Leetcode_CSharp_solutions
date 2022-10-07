using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    /// You must implement a solution with a linear runtime complexity and use only constant extra space.
    /// </summary>
    public class SingleNumber
    {
        public static int SingleNumber1(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                    dict[num] += 1;
                else
                    dict.Add(num, 1);
            }
            foreach (var key in dict.Keys)
            {
                if (dict[key] == 1)
                    return key;
            }
            return int.MinValue;
        }
        public static int SingleNumber2(int[] nums)
        {
            var answer = 0;
            foreach(var num in nums)
            {
                answer ^= num;
            }
            return answer;
        }
    }
}
