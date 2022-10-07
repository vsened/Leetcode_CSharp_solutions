using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
    /// </summary>
    public class HammingDistance
    {
        public static int CheckHammingDistance(int x, int y)
        {

            var count = 0;
            string strX = Convert.ToString(x, 2);
            string strY = Convert.ToString(y, 2);
            if (strX.Length > strY.Length)
            {
                for (int i = strY.Length; i < strX.Length; i++)
                    strY = "0" + strY;
            }
            else if (strY.Length > strX.Length)
            {
                for (int i = strX.Length; i < strY.Length; i++)
                    strX = "0" + strX;
            }
            for (int i = 0; i < strX.Length; i++)
            {
                if (strX[i] != strY[i])
                    count++;
            }
            return count;
        }
    }
}
