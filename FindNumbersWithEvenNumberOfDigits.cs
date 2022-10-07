using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class FindNumbersWithEvenNumberOfDigits
    {
        public static int FindNumbersNumbers(int[] nums)
        {
            int count = 0;
            foreach(int num in nums)
            {
                var digits = 0;
                var temp = num;
                while (temp != 0)
                {
                    temp /= 10;
                    digits++;
                }
                if (digits % 2 == 0)
                    count++;
            }
            return count;
        }
        public static int FindNumbersStrings(int[] nums)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num.ToString().Length % 2 == 0)
                    count++;
            }
            return count;
        }
    }
}
