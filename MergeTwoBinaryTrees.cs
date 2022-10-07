using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            return MergeNode(root1, root2);
        }

        private TreeNode MergeNode(TreeNode node1, TreeNode node2)
        {
            if (node1 != null)
            {
                node1.val += node2?.val ?? 0;
                node1.left = MergeNode(node1.left, node2?.left);
                node1.right = MergeNode(node1.right, node2?.right);
                return node1;
            }
            else if (node2 != null)
            {
                return node2;
            }
            else
            {
                return null;
            }
        }
        public static TreeNode MergeTrees1(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null)
            {
                if (root1 == null)
                    return root2;
                else
                    return root1;
            }
            var queue = new Queue<TreeNode>();
            var rootMergeTrees = new TreeNode();
            queue.Enqueue(root1);
            queue.Enqueue(root2);
            queue.Enqueue(rootMergeTrees);
            while (queue.Count > 0)
            {
                var currentFirstTree = queue.Dequeue();
                var currentSecondTree = queue.Dequeue();
                var currentMergeTrees = queue.Dequeue();
                currentMergeTrees.val = currentFirstTree.val + currentSecondTree.val;
                if (currentFirstTree.left != null && currentSecondTree.left != null)
                {
                    queue.Enqueue(currentFirstTree.left);
                    queue.Enqueue(currentSecondTree.left);
                    currentMergeTrees.left = new TreeNode();
                    queue.Enqueue(currentMergeTrees.left);                   
                }
                if (currentFirstTree.right != null && currentSecondTree.right != null)
                {
                    queue.Enqueue(currentFirstTree.right);
                    queue.Enqueue(currentSecondTree.right);
                    currentMergeTrees.right = new TreeNode();
                    queue.Enqueue(currentMergeTrees.right);
                }
                if (currentFirstTree.left != null && currentSecondTree.left == null)
                {
                    queue.Enqueue(currentFirstTree.left);
                    currentSecondTree.left = new TreeNode();
                    queue.Enqueue(currentSecondTree.left);
                    currentMergeTrees.left = new TreeNode();
                    queue.Enqueue(currentMergeTrees.left);
                }
                if (currentFirstTree.right != null && currentSecondTree.right == null)
                {
                    queue.Enqueue(currentFirstTree.right);
                    currentSecondTree.right = new TreeNode();
                    queue.Enqueue(currentSecondTree.right);
                    currentMergeTrees.right = new TreeNode();
                    queue.Enqueue(currentMergeTrees.right);
                }
                if (currentFirstTree.left == null && currentSecondTree.left != null)
                {
                    currentFirstTree.left = new TreeNode();
                    queue.Enqueue(currentFirstTree.left);
                    queue.Enqueue(currentSecondTree.left);
                    currentMergeTrees.left = new TreeNode();
                    queue.Enqueue(currentMergeTrees.left);
                }
                if (currentFirstTree.right == null && currentSecondTree.right != null)
                {
                    currentFirstTree.right = new TreeNode();
                    queue.Enqueue(currentFirstTree.right);
                    queue.Enqueue(currentSecondTree.right);
                    currentMergeTrees.right = new TreeNode();
                    queue.Enqueue(currentMergeTrees.right);
                }
            }
            return rootMergeTrees;
        }

    }
}
