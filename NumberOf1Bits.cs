using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            var number = Convert.ToString(n, 2);
            var count = 0;
            foreach (var b in number)
            {
                if (b == '1')
                    count++;
            }
            return count;
        }
    }
}
