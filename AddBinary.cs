using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class AddBinary
    {
        public static string GetAddBinary(string a, string b)
        {
            var result = "";
            bool isIncrease = false;
            for (int index = 0; index < (a.Length >= b.Length ? a.Length : b.Length); index++)
            {
                if (index > a.Length - 1)
                {
                    if (isIncrease)
                    {
                        var t = b[b.Length - 1 - index] == '1' ? "0" : "1";
                        result = t + result;
                        isIncrease = b[b.Length - 1 - index] == '1' ? true : false;
                    }
                    else
                        result = b[b.Length - 1 - index] + result;
                }
                else if (index > b.Length - 1)
                {
                    if (isIncrease)
                    {
                        var t = a[a.Length - 1 - index] == '1' ? "0" : "1";
                        result = t + result;
                        isIncrease = a[a.Length - 1 - index] == '1' ? true : false;
                    }
                    else
                        result += a[a.Length - index];
                }
                else
                {
                    var sum = int.Parse(a[a.Length - 1 - index].ToString()) + int.Parse(b[b.Length - 1 - index].ToString());
                    if (isIncrease)
                    {
                        sum++;
                        isIncrease = false;
                    }
                    if (sum == 2)
                    {
                        result = "0" + result;
                        isIncrease = true;
                    }
                    else if (sum == 3)
                    {
                        result = "1" + result;
                        isIncrease = true;
                    }
                    else
                        result = sum.ToString() + result;

                }
            }
            return isIncrease ? "1" + result : result;
        }
    }
}
