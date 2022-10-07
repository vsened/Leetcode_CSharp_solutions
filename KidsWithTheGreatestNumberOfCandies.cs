using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            var max = int.MinValue;
            for (int i = 0; i < candies.Length; i++)
                if (candies[i] > max)
                    max = candies[i];

            foreach (var c in candies)
                result.Add(c + extraCandies >= max);

            return result;
        }
    }
}
