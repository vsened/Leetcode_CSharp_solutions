using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class VerifyingAnAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            if (words.Length == 1)
                return true;
            var dict = new Dictionary<char, int>();
            var count = 1;
            foreach (var letter in order)
            {
                dict.Add(letter, count++);
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                var temp = 0;
                while (temp < words[i].Length && temp < words[i + 1].Length)
                {
                    if (dict[words[i][temp]] > dict[words[i + 1][temp]])
                        return false;
                    else if (dict[words[i][temp]] == dict[words[i + 1][temp]])
                    {
                        if (temp != words[i].Length - 1 && temp != words[i + 1].Length - 1)
                        {
                            temp++;
                            continue;
                        }
                        else if (temp != words[i].Length - 1 && temp == words[i + 1].Length - 1)
                            return false;
                        else
                            break;
                    }
                    else
                        break;
                }
            }
            return true;
        }
    }
}
