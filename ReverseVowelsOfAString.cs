using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class ReverseVowelsOfAString
    {
        public static string ReverseVowels(string s)
        {
            var vowels = "aeiouAEIOU";
            var result = "";
            int j = s.Length - 1;
            for (int i = 0; i < s.Length ; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    while (j > -1)
                    {
                        if (vowels.Contains(s[j]))
                            break;
                        j--;
                    }
                    result += s[j];
                    j--;
                }
                else
                    result += s[i];
            }
            return result;
        }
    }
}
