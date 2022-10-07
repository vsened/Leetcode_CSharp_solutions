using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class PalindromeNumber
    {
        public static bool IsPalindromeWithString(int x)
        {
            string number = x.ToString();
            int maxIndex = number.Length - 1;
            for (int minIndex = 0; minIndex <= maxIndex; minIndex++)
            {
                if (number[minIndex] != number[maxIndex])
                    return false;
                maxIndex--;
            }
            return true;
        }
        public static bool IsPalindromeWithDivMode(int x)
        {
            int input = x;
            int number = 0;
            while (x > 0)
            {
                int remainder = x % 10;
                x /= 10;
                number = number * 10 + remainder;  
            }
            return input == number;
        }
    }
}
