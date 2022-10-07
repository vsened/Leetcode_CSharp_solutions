using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class CanPlaceFlowers
    {
        public static bool CanPlaceFlowers1(int[] flowerbed, int n)
        {
            var count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                    continue;
                else if (i == 0) 
                {
                    if (flowerbed[i] == 0 && (flowerbed.Length == 1 || flowerbed[i + 1] == 0))
                    {
                        flowerbed[i] = 1;
                        count++;
                    }     
                }
                else if (i == flowerbed.Length - 1)
                {
                    if (flowerbed[i - 1] == 0 && flowerbed[i] == 0)
                    {
                        flowerbed[i] = 1;
                        count++;
                    }  
                }
                else if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }
            return count >= n;
        }
        public static bool CanPlaceFlowers2(int[] flowerbed, int n)
        {
            int total = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {

                // Decide if we can plant at index I

                int canPlant =
                    // Check if prev element
                    ((i - 1 < 0 ? 0 : flowerbed[i - 1])
                           // Check current element
                           + flowerbed[i]
                           // Check next element
                           + (i + 1 >= flowerbed.Length ? 0 : flowerbed[i + 1]))

                    == 0 ? 1 : 0;
                if (canPlant == 1)
                {
                    flowerbed[i] = 1;
                    total++;
                }
            }
            return total >= n;

        }
    }
}
