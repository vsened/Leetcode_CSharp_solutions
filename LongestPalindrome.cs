using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class LongestPalindrome
    {
        public int GetLongestPalindrome(string s)
        {
            var length = 0;
            var dict = new Dictionary<char, int>();
            foreach (var letter in s)
            {
                if (dict.ContainsKey(letter))
                    dict[letter] += 1;
                else
                    dict.Add(letter, 1);
            }
            foreach (var key in dict.Keys)
            {
                if (dict[key] % 2 == 0 || dict[key] > 2)
                {
                    length += 2 * (dict[key] / 2);
                    dict[key] -= 2 * (dict[key] / 2);
                }
                if (dict[key] == 0)
                    dict.Remove(key);
            }
            if (dict.Count > 0)
                return length + 1;
            return length;
        }
    }
}
