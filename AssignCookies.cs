using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class AssignCookies
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            var list = new List<int>(s);
            var count = 0;
            foreach (var c in g)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (c <= list[i])
                    {
                        count++;
                        list.Remove(list[i]);
                        break;
                    }
                }
            }
            return count;
        }
    }
}
