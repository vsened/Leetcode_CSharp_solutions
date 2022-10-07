using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            Invert(root);
            return root;
        }
        private void Invert(TreeNode node)
        {
            if (node == null)
                return;
            var temp = node.left;
            node.left = node.right;
            node.right = temp;
            Invert(node.left);
            Invert(node.right);
        }
    }
}
