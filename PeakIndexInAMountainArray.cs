using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class PeakIndexInAMountainArray
    {
        public static int PeakIndexInMountainArray1(int[] arr)
        {
            int minIndex = 0;
            int maxIndex = arr.Length - 1;
            while (minIndex <= maxIndex)
            {
                var mid = maxIndex - (maxIndex - minIndex) / 2;
                if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                    return mid;
                else if (arr[mid] > arr[mid - 1] && arr[mid] < arr[mid + 1])
                    minIndex = mid + 1;
                else if (arr[mid] < arr[mid - 1] && arr[mid] > arr[mid + 1])
                    maxIndex = mid - 1;
            }
            return -1;
        }

    }
}
