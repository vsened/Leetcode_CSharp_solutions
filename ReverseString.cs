using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class ReverseString
    {
        public void ReverseString1(char[] s)
        {
            Array.Reverse(s);
        }
        public void ReverseString2(char[] s)
        {
            var temp = '1';
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = s[i];
                s[i] = temp;
            }
        }
    }
}
