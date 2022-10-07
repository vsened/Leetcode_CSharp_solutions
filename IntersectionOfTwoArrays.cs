using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var result = new HashSet<int>();
            foreach (var num in nums1)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 1);
            }
            foreach (var num in nums2)
            {
                if (dict.ContainsKey(num))
                    result.Add(num);
            }
            return result.ToArray();
        }
        public int[] Intersection2(int[] nums1, int[] nums2)
        {
            var nums1Set = new HashSet<int>(nums1);
            var nums2Set = new HashSet<int>(nums2);

            return nums1Set.Intersect(nums2Set).ToArray();
        }
    }
}
