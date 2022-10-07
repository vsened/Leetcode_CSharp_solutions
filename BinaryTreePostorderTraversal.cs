using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class BinaryTreePostorderTraversal
    {
        public static List<int> Start(int[] numbers)
        {
            var binaryTree = new BinaryTree(new TreeNode(numbers[0]));
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == null)
                    continue;
                binaryTree.Add(new TreeNode(numbers[i]));
            }
            return binaryTree.PostorderTraversal();
        }
    }

    public class BinaryTree
    {
        public TreeNode Root { get; private set; }
        public BinaryTree(TreeNode root)
        {
            Root = root;
        }
        public void Add(TreeNode node)
        {
            var current = Root;
            while (true)
            {
                if (current.val > node.val)
                {
                    if (current.left != null)
                        current = current.left;
                    else
                    {
                        current.left = node;
                        break;
                    }
                }
                else if (current.val < node.val)
                {
                    if (current.right != null)
                        current = current.right;
                    else
                    {
                        current.right = node;
                        break;
                    }
                }
            }
        }
        public List<int> PostorderTraversal()
        {
            var result = new List<int>();
            var current = Root;
            PostorderRecursion(current, ref result);
            return result;
        }
        private void PostorderRecursion(TreeNode current, ref List<int> result)
        {
            if (current == null)
            {
                return;
            }
            PostorderRecursion(current.left, ref result);
            PostorderRecursion(current.right, ref result);
            result.Add(current.val);
        }
        private void PostorderIterative(TreeNode current, List<int> result)
        {

        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
