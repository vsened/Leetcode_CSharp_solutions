using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class NthTribonacciNumber
    {
        public int Tribonachi(int n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                case 2: return 1;
            }
            var sequence = new int[n+1];
            sequence[0] = 0;
            sequence[1] = 1;
            sequence[2] = 1;
            for (int i = 3; i < n; i++)
            {
                sequence[i] = sequence[i-3] + sequence[i-2] + sequence[i-1];
            }
            return sequence.Last();
        }
        public int Tribonachi2(int n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1:
                case 2: return 1;
            }
            var first = 0;
            var second = 1;
            var third = 1;
            var current = 0;
            for (int i = 3; i <= n; i++)
            {
                current = first + second + third;
                (first, second, third) = (second, third, current);
            }
            return current;
        }
    }
}
