using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// You are given a large integer represented as an integer array digits, where each digits[i] 
    /// is the ith digit of the integer. The digits are ordered from most significant to least significant 
    /// in left-to-right order. The large integer does not contain any leading 0's.
    /// Increment the large integer by one and return the resulting array of digits.
    /// </summary>
    public class PlusOne
    {
        public static int[] PlusOneMethod(int[] digits)
        {
            int[] result;
            if (Array.FindAll(digits, x => x == 9).Length == digits.Length)
            {
                result = new int[digits.Length + 1];
                result[0] = 1;
                for (int i = 1; i < digits.Length; i++)
                    result[i] = 0;
                return result;
            }
            else
                result = new int[digits.Length];
            bool flag = true;
            for (int i = digits.Length-1; i >= 0; i--)
            {
                if (flag)
                {
                    result[i] = digits[i] + 1;
                    if (result[i] > 9)
                    {
                        result[i] = 0;
                    }
                    else
                        flag = false;
                }
                else
                    result[i] = digits[i];
            }

            return result;
        }
        public static int[] Method2(int[] digits)
        {
            int len = digits.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] newDigits = new int[len + 1];
            newDigits[0] = 1;
            return newDigits;
        }
    }
}
