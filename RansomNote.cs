using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char, int>();
            foreach (var letter in magazine)
            {
                if (dict.ContainsKey(letter))
                    dict[letter]++;
                else
                    dict.Add(letter, 1);
            }
            foreach (var c in ransomNote)
            {
                if (dict.ContainsKey(c) && dict[c] > 0)
                    dict[c]--;
                else
                    return false;
            }
            return true;
        }
    }
}
