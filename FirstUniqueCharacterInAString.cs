using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, List<int>>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]].Add(i);
                else
                    dict.Add(s[i], new List<int> { i });
            }
            foreach (var key in dict.Keys)
            {
                if (dict[key].Count == 1)
                    return dict[key][0];
            }
            return -1;
        }
    }
}

