using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class LengthOfLastWord
    {
        public int LengthOfLastWord2(string s)
        {
            s = s.Trim();
            var words = s.Split(" ");
            return words.Last().Length;
        }
    }
}
