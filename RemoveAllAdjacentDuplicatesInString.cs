using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// You are given a string s consisting of lowercase English letters. A duplicate 
    /// removal consists of choosing two adjacent and equal letters and removing them.
    /// We repeatedly make duplicate removals on s until we no longer can.
    /// 
    /// Return the final string after all such duplicate removals have been made.It can 
    /// be proven that the answer is unique.
    /// </summary>
    public class RemoveAllAdjacentDuplicatesInString
    {
        public static string RemoveDuplicates(string s)
        {
            while (true)
            {
                var start = s.Length;
                for (int i = 0; i < s.Length-1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        s = s.Remove(i, 2);
                        break;
                    }     
                }
                var finish = s.Length;
                if (start == finish)
                    break;
            }
            return s;
        }
        public static string RemoveDuplicates2(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                var flag = false;
                while (stack.Count > 0 && stack.Peek() == c)
                {
                    flag = true;
                    stack.Pop();
                }
                if(!flag)
                    stack.Push(c);
            }
            return string.Join("", stack);
        }

        public static string RemoveDuplicates3(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (stack.Count > 0 && stack.Peek() == c)
                    stack.Pop();
                else
                    stack.Push(c);
            }
            return string.Join("", stack);
        }
    }
}
