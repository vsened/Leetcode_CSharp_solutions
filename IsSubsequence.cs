using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class IsSubsequence
    {
        public static bool IsSubsequences(string s, string t)
        {
            if (s.Length == 0)
                return true;
            var indexS = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s[indexS] == t[i])
                    indexS++;
                if (indexS == s.Length)
                    return true;
            }
            return indexS == s.Length;
        }
        public static bool IsSubsequencesStack(string s, string t)
        {
            if (s.Length == 0)
                return true;
            var stack = new Stack<char>(s.ToArray<char>().Reverse());
            foreach (char letter in t)
            {
                if (stack.Count == 0)
                    return true;
                if (stack.Peek() == letter)
                    stack.Pop();
            }
            return stack.Count == 0;
        }
    }
}
