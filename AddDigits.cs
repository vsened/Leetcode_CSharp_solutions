using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    // Given an integer num, repeatedly add all its digits until the
    // result has only one digit, and return it.
    public class AddDigits
    {
        public static int AddDigitsMethod(int num)
        {
            while(num > 10)
            {
                num = num % 10 + num / 10;
            }
            return num;
        }

        public static int AddDigitsRecursion(int num)
        {
            if (num <= 9)
                return num;
            return AddDigitsRecursion(num % 10 + num / 10);
        }
    }
}
