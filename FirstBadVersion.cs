using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class FirstBadVersion
    {
        //public int FirstBadVersion2(int n)
        //{
        //    int min = 0;
        //    while (min <= n)
        //    {
        //        var mid = n - ((n - min) / 2);
        //        if (IsBadVersion(mid) && !IsBadVersion(mid - 1))
        //        {
        //            return mid;
        //        }
        //        else if (IsBadVersion(mid) && IsBadVersion(mid - 1))
        //        {
        //            n = mid - 1;
        //        }
        //        else if (!IsBadVersion(mid) && !IsBadVersion(mid - 1))
        //        {
        //            min = mid + 1;
        //        }
        //    }
        //    return n;
        //}

        //public int FirstBadVersion(int n)
        //{
        //    int left = 1;
        //    int right = n;
        //    while (left < right)
        //    {
        //        int mid = left + (right - left) / 2;
        //        if (IsBadVersion(mid))
        //        {
        //            right = mid;
        //        }
        //        else
        //        {
        //            left = mid + 1;
        //        }
        //    }
        //    return left;
        //}
    }
}
