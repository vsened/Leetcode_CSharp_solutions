using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var result = new int[m + n];
            var nums1CurrentIndex = 0;
            var nums2CurrentIndex = 0;
            var resultIndex = 0;
            while (resultIndex < result.Length)
            {
                if (nums2CurrentIndex == n)
                    result[resultIndex++] = nums1[nums1CurrentIndex++];
                else if (nums1CurrentIndex == m)
                    result[resultIndex++] = nums2[nums2CurrentIndex++];
                else if (nums1[nums1CurrentIndex] > nums2[nums2CurrentIndex])
                    result[resultIndex++] = nums2[nums2CurrentIndex++];
                else
                    result[resultIndex++] = nums1[nums1CurrentIndex++];
            }
            Array.Copy(result, nums1, nums1.Length);
        }
    }
}
