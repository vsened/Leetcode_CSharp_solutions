using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
    /// </summary>
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            q.Enqueue(root.left);
            q.Enqueue(root.right);
            while (q.Count != 0)
            {
                TreeNode tempLeft = q.Dequeue();
                TreeNode tempRight = q.Dequeue();

                if (tempLeft == null && tempRight == null)
                    continue;

                if ((tempLeft == null && tempRight != null) ||
                    (tempLeft != null && tempRight == null))
                    return false;

                if (tempLeft.val != tempRight.val)
                    return false;

                q.Enqueue(tempLeft.left);
                q.Enqueue(tempRight.right);
                q.Enqueue(tempLeft.right);
                q.Enqueue(tempRight.left);

            }
            return true;
        }
        public bool IsSymmetric2(TreeNode root)
        {
            return utility(root.left, root.right);
        }
        public static bool utility(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return true;
            if (root1 != null && root2 != null)
                return root1.val == root2.val && utility(root1.left, root2.right) && utility(root1.right, root2.left);
            return false;
        }
        public bool IsSymmetric3(TreeNode root)
        {
            if (root == null)
                return true;

            if (root.left == null && root.right == null)
                return true;

            var q = new Queue<TreeNode>();

            q.Enqueue(root);
            q.Enqueue(root);

            TreeNode leftNode, rightNode;

            while (q.Count > 0)
            {
                leftNode = q.Dequeue();
                rightNode = q.Dequeue();

                if (leftNode.val != rightNode.val)
                    return false;


                if (leftNode.left != null && rightNode.right != null)
                {
                    q.Enqueue(leftNode.left);
                    q.Enqueue(rightNode.right);
                }
                else if (leftNode.left != null || rightNode.right != null)
                    return false;


                if (leftNode.right != null && rightNode.left != null)
                {
                    q.Enqueue(leftNode.right);
                    q.Enqueue(rightNode.left);
                }
                else if (leftNode.right != null || rightNode.left != null)
                    return false;
            }
            return true;
        }
    }
}
