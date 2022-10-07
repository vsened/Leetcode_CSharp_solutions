using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            var prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                var currentPrefix = "";
                for (int charIndex = 0; charIndex < strs[i].Length; charIndex++)
                {
                    if (charIndex >= prefix.Length)
                    {
                        break;
                    }
                    if (strs[i][charIndex] != prefix[charIndex])
                    {
                        break;
                    }
                    else
                    {
                        currentPrefix += prefix[charIndex];
                    }
                }
                prefix = currentPrefix;
            }
            return prefix;
        }
    }
}
