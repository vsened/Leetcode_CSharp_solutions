using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class IntersectionOfTwoArrays_II
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var list = new List<int>();
            foreach (var num in nums1)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict.Add(num, 1);
            }
            foreach (var n in nums2)
            {
                if (dict.ContainsKey(n) && dict[n] > 0)
                {
                    list.Add(n);
                    dict[n]--;
                }
            }
            return list.ToArray();
        }
    }
}
