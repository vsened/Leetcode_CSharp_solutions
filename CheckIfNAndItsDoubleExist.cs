using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given an array arr of integers, check if there exists two integers N and M such that N is the double of M ( i.e. N = 2 * M).
    ///More formally check if there exists two indices i and j such that :
    /// i != j
    /// 0 <= i, j<arr.length
    /// arr[i] == 2 * arr[j]
    /// </summary>
    public class CheckIfNAndItsDoubleExist
    {
        public static bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;
                    if(arr[j]*2 == arr[i])
                        return true;
                }
            }
            return false;
        }

        public static bool CheckIfExist2(int[] arr)
        {
            var set = new HashSet<int>();
            foreach (int i in arr)
            {
                if (set.Contains(i*2) || set.Contains(i / 2))
                    return true;
                set.Add(i);
            }
            return false;
        }
    


    }
}
