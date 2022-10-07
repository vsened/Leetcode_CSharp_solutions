using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var numbers = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int result = 0;
            int temp = 0;
            int index = 0;
            while (index < s.Length)
            {
                if (index != s.Length - 1)
                {
                    if (numbers[s[index]] < numbers[s[index + 1]])
                    {
                        result += numbers[s[index + 1]] - numbers[s[index]];
                        index += 2;
                    }
                    else if (numbers[s[index]] == numbers[s[index + 1]])
                    {
                        if (numbers[s[index]] == numbers[s[index + 2]])
                        {
                            result += 3 * numbers[s[index]];
                            index += 3;
                        }
                        else
                        {
                            result += 2 * numbers[s[index]];
                            index += 2;
                        }
                    }
                    else
                    {
                        result += numbers[s[index++]];
                    }
                }
                else
                {
                    result += numbers[s[index++]];
                }
            }
            return result;
        }
    }
}
