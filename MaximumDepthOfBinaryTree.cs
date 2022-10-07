using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            var maxDepth = new List<int>();
            CheckDepth(root, 1, ref maxDepth);
            return maxDepth.Max();
        }
        private void CheckDepth(TreeNode node, int depth, ref List<int> maxDepth)
        {
            if (node == null)
                return;
            maxDepth.Add(depth);
            CheckDepth(node.left, depth + 1, ref maxDepth);
            CheckDepth(node.right, depth + 1, ref maxDepth);
        }
    }
}
