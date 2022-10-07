using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MajorityElement
    {
        public int GetMajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach(var num in nums)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict.Add(num, 1);
            }
            var max = int.MinValue;
            var number = 0;
            foreach (var key in dict.Keys)
            {
                if (dict[key] > max)
                {
                    max = dict[key];
                    number = key;
                }
            }
            return number;
        }
    }
}
