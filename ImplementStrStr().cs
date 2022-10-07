using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class ImplementStrStr__
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length == needle.Length)
                return haystack.Equals(needle) ? 0 : -1;
            if (needle.Length > 1)
            {
                for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
                {
                    var temp = haystack.Substring(i, needle.Length);
                    if (temp.Equals(needle))
                        return i;
                }
                return -1;
            }
            else
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i].ToString() == needle)
                        return i;
                }
                return -1;
            }
        }
    }
}
