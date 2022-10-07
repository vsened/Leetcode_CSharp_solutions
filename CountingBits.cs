using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class CountingBits
    {
        public static int[] CountBits(int number)
        {
            var result = new int[number + 1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new List<char>(Convert.ToString(i, 2).ToArray()).Where(x => x == '1').Count();
            }
            return result;
        }

        public static int[] CountBits1(int number)
        {
            var result = new int[number + 1];
            for (int i = 0; i < result.Length; i++)
            {
                string currentNumber = Convert.ToString(i, 2);
                int currentCount = 0;
                foreach (char digit in currentNumber)
                {
                    if (digit == '1')
                        currentCount++;
                }
                result[i] = currentCount;
            }
            return result;
        }
        public static int[] CountBits2(int number)
        {
            var result = new int[number + 1];
            for (int i = 0; i < result.Length; i++)
            {
                int countOnes = 0;
                int temp = i;
                while (true)
                {
                    countOnes += temp & 1;
                    temp >>= 1;
                    if (temp == 0)
                        break;
                }
                result[i] = countOnes;
            }
            return result;
        }
    }
}
