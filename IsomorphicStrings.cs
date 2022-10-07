using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dictS = new Dictionary<char, char>();
            var dictT = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dictS.ContainsKey(s[i]))
                    dictS.Add(s[i], t[i]);
                else
                    if (dictS[s[i]] != t[i])
                    return false;
                if (!dictT.ContainsKey(t[i]))
                    dictT.Add(t[i], s[i]);
                else
                    if (dictT[t[i]] != s[i])
                    return false;
            }

            return true;
        }
    }
}
