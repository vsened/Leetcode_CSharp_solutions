using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class LicenseKeyFormatting
    {
        public string CheckLicenseKeyFormatting(string s, int k)
        {
            s = s.Replace("-", "");
            var result = "";
            var count = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i == 0 && count % k == 0)
                {
                    result = Char.ToUpper(s[i]) + result;
                    count++;
                }
                else if (count % k == 0)
                {
                    result = $"-{Char.ToUpper(s[i])}" + result;
                    count++;
                }
                else
                {
                    result = Char.ToUpper(s[i]) + result;
                    count++;
                }
            }
            return result;
        }
    }
}
