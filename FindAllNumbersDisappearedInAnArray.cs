using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class FindAllNumbersDisappearedInAnArray
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 1);
            }
            IEnumerable<int> range = Enumerable.Range(1, nums.Length);
            foreach (var num in range)
            {
                if (!dict.ContainsKey(num))
                    result.Add(num);
            }
            return result;
        }
        public IList<int> FindDisappearedNumbers2(int[] nums)
        {
            var result = new List<int>();
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 1);
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!dict.ContainsKey(i))
                    result.Add(i);
            }
            return result;
        }
        public IList<int> FindDisappearedNumbers3(int[] nums)
        {
            var result = new HashSet<int>(Enumerable.Range(1, nums.Length));
            var input = new HashSet<int>(nums);
            result.ExceptWith(input);
            return new List<int>(result);
        }

    }
}
