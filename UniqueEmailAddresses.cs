using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class UniqueEmailAddresses
    {
        public static int UniqueEmailAddressesCount(string[] emails)
        {
            var result = new List<string>();
            foreach (string email in emails)
            {
                string name = "";
                string domain = "";
                bool plusFlag = false;
                bool domainFlag = false;
                foreach (char c in email)
                {
                    if (c != '.' && c != '+' && c != '@' && !domainFlag && !plusFlag)
                        name += c;
                    else if (c == '+')
                        plusFlag = true;
                    else if (c == '@')
                        domainFlag = true;
                    else if (domainFlag)
                        domain += c;
                }
                string clearEmail = name + '@' + domain;
                if (!result.Contains(clearEmail))
                    result.Add(clearEmail);
            }
            return result.Count();
        }

        public static int UniqueEmailAddressesCountSplitStrings(string[] emails)
        {
            var result = new List<string>();
            foreach (string email in emails)
            {
                var curEmail = email.Split('@');
                string name = curEmail[0];
                string domain = curEmail[1];
                name = name.Replace(".", "");
                name = name.Split('+')[0];
                result.Add($"{name}@{domain}");
            }
            return result.Distinct().Count();
        }
    }
}
