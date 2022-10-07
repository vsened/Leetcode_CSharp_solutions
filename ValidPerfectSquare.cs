using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class ValidPerfectSquare
    {
        public static bool IsPerfectSquareBrutForce(int num)
        {
            for (int i = 1; i <= num/2; i++)
            {
                if (i * i == num) 
                    return true;
            }
            return false;
        }

        public static bool IsPerfectSquare(int num)
        {
            if (num == 1)
                return true;
            return BinarySearch((long)1, (long)num / 2, (long)num, (long)num);
        }

        public static bool IsPerfectSquare2(int num)
        {
            if (num == 1)
                return true;
            long left = 1;
            long right = num / 2;
            while(left <= right)
            {
                long mid = (left + right) / 2;
                if (mid * mid == (long)num)
                    return true;
                if (mid * mid < (long)num)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return false;
        }

        static bool BinarySearch(long min, long mid, long max, long number)
        {
            if (mid == min || mid == max)
            {
                if (max * max == number)
                    return true;
                else if (min * min == number)
                    return true;
                return false;
            }
            else if (mid * mid > number)
                return BinarySearch(min, mid - (mid - min) / 2, mid, number);
            else if (mid * mid < number)
                return BinarySearch(mid, mid + (max - mid) / 2, max, number);
            else if (mid * mid == number)
                return true;
            return false;
        }

    }
}
