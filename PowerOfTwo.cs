using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given an integer n, return true if it is a power of two. Otherwise, return false.
    /// </summary>
    public class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            var str = Convert.ToString(n, 2);
            if (n < 0)
                return str.Replace("1", "") == "0" && str[0] == '0';
            else
                return str.Replace("0", "") == "1" && str[0] == '1';
        }
    }
}

