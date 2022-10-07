using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class DetectCapital
    {
        public static bool DetectCapitalUse(string word)
        {
            var count = 0;
            foreach (var letter in word)
            {
                if (Char.IsUpper(letter))
                    count++;
            }
            if (count == 0)
                return true;
            else if (count == 1)
            {
                if (Char.IsUpper(word[0]))
                    return true;
            }   
            else if (count == word.Length)
                return true;
            return false;
        }

        public bool DetectCapitalUse2(string word)
        {
            var count = 0;
            foreach (var letter in word)
            {
                if (Char.IsUpper(letter))
                    count++;
            }
            return count == 0 ||
                (count == 1 && Char.IsUpper(word[0])) ||
                count == word.Length;
        }
    }
}
