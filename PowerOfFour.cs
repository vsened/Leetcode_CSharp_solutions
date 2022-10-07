using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given an integer n, return true if it is a power of four. Otherwise, return false.
    ///An integer n is a power of four, if there exists an integer x such that n == 4x.
    /// </summary>
    public class PowerOfFour
    {
        public static bool IsPowerOfFour(int n)
        {
            return (Convert.ToString(n, 2).Replace("0", "").Length == 1) && 
                (Convert.ToString(n, 2).Length % 2 == 1);
        }
    }
}
