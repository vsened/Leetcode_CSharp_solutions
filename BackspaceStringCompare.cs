using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given two strings s and t, return true if they are equal when both are typed into empty text editors.
    /// '#' means a backspace character.
    /// </summary>
    public class BackspaceStringCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            var stackS = new Stack<char>();
            var stackT = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '#')
                    stackS.TryPop(out char o);
                else
                    stackS.Push(c);
            }
            foreach (var c in t)
            {
                if (c == '#')
                    stackT.TryPop(out char o);
                else
                    stackT.Push(c);
            }
            if (stackS.Count != stackT.Count)
                return false;
            else
            {
                while (stackS.Count > 0)
                {
                    if (stackS.Pop() != stackT.Pop())
                        return false;
                }
            }
            return true;
        }
    }
}
