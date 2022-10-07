using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            while (true)
            {
                if (root.val != val && root.left == null && root.right == null)
                    return null;
                if (root.val == val)
                    return root;
                else if (root.val > val && root.left != null)
                    root = root.left;
                else if (root.val < val && root.right != null)
                    root = root.right;
                else
                    return null;
            }
            return null;
        }
        public TreeNode SearchBST2(TreeNode root, int val)
        {
            if (root == null || root.val == val) return root;
            if (root.val > val) return SearchBST(root.left, val);
            else return SearchBST(root.right, val);
            return null;
        }
    }
}
