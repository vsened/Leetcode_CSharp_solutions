using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// A phrase is a palindrome if, after converting all uppercase letters into lowercase 
    /// letters and removing all non-alphanumeric characters, it reads the same forward and 
    /// backward. Alphanumeric characters include letters and numbers.
    /// Given a string s, return true if it is a palindrome, or false otherwise.
    /// </summary>
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    s = s.Replace(c.ToString(), "");
            }
            s = s.ToLower();
            var min = 0;
            var max = s.Length - 1;
            while(min <= max)
            {
                if (s[min] != s[max])
                    return false;
                min++;
                max--;
            }
            return true;
        }
        public static bool IsPalindrome2(string s)
        {
            var min = 0;
            var max = s.Length - 1;
            while (min <= max)
            {
                if (!Char.IsLetterOrDigit(s[min]))
                {
                    min++;
                    continue;
                }
                if (!Char.IsLetterOrDigit(s[max]))
                {
                    max--;
                    continue;
                }
                if (Char.ToLower(s[min]) != Char.ToLower(s[max]))
                    return false;
                min++;
                max--;
            }
            return true;
        }
    }
}
