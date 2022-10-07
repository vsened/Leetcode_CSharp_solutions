using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var jewelsDict = new Dictionary<char, int>();
            var count = 0;
            foreach (var jewel in jewels)
            {
                jewelsDict.Add(jewel, 1);
            }
            foreach (var stone in stones)
            {
                if (jewelsDict.ContainsKey(stone))
                    count++;
            }
            return count;
        }
    }
}
