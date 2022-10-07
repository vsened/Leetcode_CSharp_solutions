using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class ContainsDublicate
    {
        public static bool IsDuplicateWithSetLinq(int[] nums)
        {
            if (nums.Length == new List<int>(nums).Distinct().Count())
                return false;
            return true;
        }

        public bool IsDuplicateWithSet(int[] nums)
        {
            var s = new HashSet<int>(nums);
            return s.Count < nums.Length;
        }
    }
}
