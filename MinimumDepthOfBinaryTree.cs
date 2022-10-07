using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given a binary tree, find its minimum depth
    /// </summary>
    internal class MinimumDepthOfBinaryTree
    {
        public static int MinDepth(TreeNode root)
        {
            var nodeDict = new Dictionary<int, int>();
            var nodeQueue = new Queue<TreeNode>();
            var depths = new List<int>();
            nodeDict.Add(root.val, 1);
            nodeQueue.Enqueue(root);
            while (nodeQueue.Count > 0)
            {
                var current = nodeQueue.Dequeue();
                if (current.right == null && current.left == null)
                    depths.Add(nodeDict[current.val]);
                else
                {
                    if (current.left != null)
                    {
                        nodeDict.Add(current.left.val, nodeDict[current.val] + 1);
                        nodeQueue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        nodeDict.Add(current.right.val, nodeDict[current.val] + 1);
                        nodeQueue.Enqueue(current.right);
                    }
                }
            }
            return depths.Min();
        }

        public static int MinDepth2(TreeNode root)
        {
            var depths = new List<int>();
            CheckDepth(root, ref depths, 1);
            return depths.Min();
        }

        public static void CheckDepth (TreeNode node, ref List<int> depths, int depth)
        {
            if (node.right == null && node.left == null)
                depths.Add(depth);   
            if (node.left != null)
                CheckDepth(node.left, ref depths, depth+1);
            if (node.right != null)
                CheckDepth(node.right, ref depths, depth+1);
        }
    }
}
