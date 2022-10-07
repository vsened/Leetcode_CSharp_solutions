using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class ContainsDuplicate2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    foreach (var d in dict[nums[i]])
                    {
                        if (i - d <= k)
                            return true;
                    }
                    dict[nums[i]].Add(i);
                }
                else
                    dict.Add(nums[i], new List<int> { i });
            }
            return false;
        }
    }
}
