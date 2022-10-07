using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class AverageOfLevelsInBinaryTree
    {
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            var counts = new List<double>();
            GetAverage(root, 1, ref counts, ref result);
            for (int i = 0; i < result.Count; i++)
                result[i] /= counts[i];
            return result;
        }
        private static void GetAverage(TreeNode node, int level, ref List<double> countsList, ref List<double> sumsList)
        {
            if (node == null)
                return;
            if (sumsList.Count <= level - 1)
                sumsList.Add(0);
            if (countsList.Count <= level - 1)
                countsList.Add(0);
            sumsList[level - 1] += node.val;
            countsList[level - 1]++;
            if (node.left != null)
                GetAverage(node.left, level + 1, ref countsList, ref sumsList);
            if (node.right != null)
                GetAverage(node.right, level + 1, ref countsList, ref sumsList);
        }
    }
}
