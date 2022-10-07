using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var max = 0;
            var count = 0;
            foreach (var num in nums)
            {
                if (num == 1)
                    count++;
                else
                {
                    if (count > max)
                        max = count;
                    count = 0;
                }
            }
            if (count > max)
                max = count;
            return max;
        }
    }
}
