using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class SqrtX
    {
        public static int MySqrt(int x)
        {
            if (x <= 1)
                return x;
            int min = 0;
            int max = x / 2;
            int mid = 0;
            while (min <= max)
            {
                mid = (max + min) / 2;
                long midSqrt = (long)mid * (long)mid;
                if (midSqrt == x)
                    return mid;
                else if (midSqrt > x)
                    max = mid - 1;
                else if (midSqrt < x)
                    min = mid + 1;
            }
            return mid * mid > x ? mid - 1 : mid;
        }
    }
}
