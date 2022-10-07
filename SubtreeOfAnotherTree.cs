using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            var nodes = FindNode(root, subRoot);
            var subList = new List<int>();
            InorderTraversal(subRoot, ref subList);
            foreach (var node in nodes)
            {
                var nodeList = new List<int>();
                InorderTraversal(node, ref nodeList);
                if (nodeList.SequenceEqual(subList))
                    return true;
            }
            return false; ;
        }

        private List<TreeNode> FindNode(TreeNode node, TreeNode sub)
        {
            var queue = new Queue<TreeNode>();
            var list = new List<TreeNode>();
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current.val == sub.val)
                    list.Add(current);
                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }
            return list;
        }
        private void InorderTraversal(TreeNode node, ref List<int> list)
        {
            if (node == null)
                return;
            InorderTraversal(node.left, ref list);
            list.Add(node.val);
            InorderTraversal(node.right, ref list);
        }
        public bool IsSubtree2(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;
            Stack<TreeNode> nodeStack = new Stack<TreeNode>();
            nodeStack.Push(root);

            while (nodeStack.Any())
            {
                TreeNode tempNode = nodeStack.Pop();

                if (tempNode.left != null)
                    nodeStack.Push(tempNode.left);

                if (tempNode.right != null)
                    nodeStack.Push(tempNode.right);

                if (tempNode.val == subRoot.val)
                    if (isSame(tempNode, subRoot)) return true;
            }
            return false;
        }

        private bool isSame(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null) return true;
            else if (root != null && subRoot != null && root.val == subRoot.val)
            {
                return isSame(root.left, subRoot.left) && isSame(root.right, subRoot.right);
            }
            else
            {
                return false;
            }
        }
    }
}
