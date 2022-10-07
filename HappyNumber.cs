using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class HappyNumber
    {
        public bool IsHappy(int n)
        {
            var dict = new Dictionary<int, int>();
            while (n != 1 && !dict.ContainsKey(n))
            {
                dict.Add(n, 1);
                n = GetNumber(n);
            }
            return n == 1;
        }
        private int GetNumber(int n)
        {
            var temp = 0;
            while (n > 0)
            {
                int x = n % 10;
                n /= 10;
                temp += x * x;
            }
            return temp;
        }
    }
}
