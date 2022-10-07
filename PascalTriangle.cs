using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given an integer numRows, return the first numRows of Pascal's triangle.
    /// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
    /// </summary>
    public class PascalTriangle
    {
        public static List<List<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                triangle.Add(new int[i + 1]);
                triangle[i][0] = 1;
                triangle[i][triangle.Count - 1] = 1;
                for (int j = 1; j < triangle.Count - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            return (List<List<int>>)triangle;
        }

        public IList<IList<int>> Generate2(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                triangle.Add(new List<int>());
                triangle[i].Add(1);
                for (int j = 1; j < triangle.Count - 1; j++)
                {
                    triangle[i].Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                }
                if (i > 0)
                    triangle[i].Add(1);
            }
            return triangle;
        }
    }
}
