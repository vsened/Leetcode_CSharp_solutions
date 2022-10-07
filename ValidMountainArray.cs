using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class ValidMountainArray
    {
         
        public bool ValidMountainArray1(int[] arr)
        {
            if (arr.Length < 3)
                return false;
            bool isIncreases = false;
            bool isDecreases = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    if (!isDecreases)
                        return false;
                    else
                        continue;
                else if (arr[i] < arr[i + 1] && i == 0)
                    isIncreases = true;
                else if (arr[i] < arr[i + 1] && isIncreases && isDecreases)
                    return false;
                else if (arr[i] > arr[i + 1] && isIncreases)
                    isDecreases = true;
                else if (arr[i] == arr[i + 1])
                    return false;
                else if (arr[i] > arr[i + 1] && !isIncreases)
                    return false;
            }
            return true;
        }

    }
}
