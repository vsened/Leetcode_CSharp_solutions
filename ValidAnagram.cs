using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var shash = new Dictionary<char, int>();
            var thash = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (shash.ContainsKey(s[i]))
                    shash[s[i]] += 1;
                else
                    shash.Add(s[i], 1);
                if (thash.ContainsKey(s[i]))
                    thash[s[i]] += 1;
                else
                    thash.Add(s[i], 1);
            }
            foreach (var key in shash.Keys)
            {
                
                if (thash.TryGetValue(key, out int result))
                {
                    if (result == shash[key])
                        return false;
                    else
                        thash.Remove(key);
                }
                else
                    return false;
            }
            return thash.Count == 0 ? true : false;
        }
    }
}
