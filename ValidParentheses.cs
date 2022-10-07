using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push('(');
                        break;
                    case '{':
                        stack.Push('{');
                        break;
                    case '[':
                        stack.Push('[');
                        break;
                    case ')':
                        stack.TryPeek(out var t);
                        if (t == '(')
                            t = stack.Pop();
                        else
                            return false;
                        break;
                    case '}':
                        stack.TryPeek(out var b);
                        if (b == '{')
                            b = stack.Pop();
                        else
                            return false;
                        break;
                    case ']':
                        stack.TryPeek(out var m);
                        if (m == '[')
                            m = stack.Pop();
                        else
                            return false;
                        break;
                }
            }
            return stack.Count == 0;
        }
    }
}
