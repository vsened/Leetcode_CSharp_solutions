using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class RangeSumOfBST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            var sum = 0;
            CheckNode(root, low, high, ref sum);
            return sum;
        }
        private void CheckNode(TreeNode node, int low, int high, ref int sum)
        {
            if (node == null)
                return;
            if (node.val >= low && node.val <= high)
                sum += node.val;
            CheckNode(node.left, low, high, ref sum);
            CheckNode(node.right, low, high, ref sum);
        }
    }
}
