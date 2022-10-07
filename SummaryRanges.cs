using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class SummaryRanges
    {
        public IList<string> SummaryRanges1(int[] nums)
        {
            bool isRange = false;
            var result = new List<string>();
            var tmp = "";
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    if (isRange)
                        tmp += $"->{nums[i]}";
                    else
                        tmp = $"{nums[i]}";
                    result.Add(tmp);
                }
                else if (nums[i] == nums[i+1] - 1)
                {
                    if (isRange)
                        continue;
                    else
                    {
                        isRange = true;
                        tmp = $"{nums[i]}";
                    }
                }
                else
                {
                    if (isRange)
                    {
                        tmp += $"->{nums[i]}";
                        isRange = false;
                    }                      
                    else
                        tmp = $"{nums[i]}";
                    result.Add(tmp);
                }
            }
            return result;
        }
    }
}
