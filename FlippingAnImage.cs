using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image[i].Length / 2; j++)
                {
                    var temp = image[i][image[i].Length - 1 - j]^1;
                    image[i][image[i].Length - 1 - j] = image[i][j]^1;
                    image[i][j] = temp;
                }
                if (image[i].Length % 2 == 1)
                    image[i][image[i].Length / 2] = image[i][image[i].Length / 2] == 0 ? 1 : 0;
            }
            return image;
        }
        public int[][] FlipAndInvertImage2(int[][] image)
        {
            var result = new int[image.Length][];
            for (int i = 0; i < image.Length; i++)
            {
                result[i] = new int[image[i].Length];
                for (int j = image[i].Length - 1; j >= 0; j--)
                {
                    result[i][image[i].Length - 1 - j] = image[i][j] == 0 ? 1 : 0;
                }
            }
            return result;
        }
    }
}
