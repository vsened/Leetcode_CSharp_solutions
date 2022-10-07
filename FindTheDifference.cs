using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class FindTheDifference
    {
        public static char FindTheDifference1(string s, string t)
        {
            foreach (char c in s)
                t = t.Remove(t.IndexOf(c), 1);
            return t[0];
        }

        public static char FindTheDifference2(string s, string t)
        {
            var tdict = new Dictionary<char, int>();
            var sdict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (sdict.ContainsKey(c))
                    sdict[c] += 1;
                else
                    sdict.Add(c, 1);
            }
            foreach (var c in t)
            {
                if (tdict.ContainsKey(c))
                    tdict[c] += 1;
                else
                    tdict.Add(c, 1);
            }
            foreach(var c in tdict.Keys)
            {
                if (!sdict.ContainsKey(c))
                    return c;
                else if (sdict[c] < tdict[c])
                    return c;
            }
            return 'q';
        } 
    }
}
