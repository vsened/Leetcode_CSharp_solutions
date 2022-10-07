using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class ConvertSortedArrayToBinarySearchTree
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length <= 1)
            {
                if (nums.Length == 1)
                    return new TreeNode(nums[0]);
                else
                    return new TreeNode();
            }
            int pivotIndex = (nums.Length-1) / 2;
            TreeNode root = new TreeNode(nums[pivotIndex]);
            BinaryAdd(ref root, nums, 0, pivotIndex - 1);
            BinaryAdd(ref root, nums, pivotIndex+1 , nums.Length - 1);
            return root;
        }

        private static void BinaryAdd(ref TreeNode root, int[] nums, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                Add(ref root, nums, minIndex);
                return;
            }
            int pivotIndex = minIndex + (maxIndex - minIndex) / 2;
            Add(ref root, nums, pivotIndex);
            BinaryAdd(ref root, nums, minIndex, pivotIndex - 1);
            BinaryAdd(ref root, nums, pivotIndex+1, maxIndex);

        }
        private static void Add(ref TreeNode node, int[] nums, int index)
        {
            if (node.val == nums[index])
                return;
            else if (node.val > nums[index])
            {
                if (node.left != null)
                    Add(ref node.left, nums, index);
                else
                    node.left = new TreeNode(nums[index]);
            }
            else
            {
                if (node.right != null)
                    Add(ref node.right, nums, index);
                else
                    node.right = new TreeNode(nums[index]);
            }
            return;
        }
        public static TreeNode SortedArrayToBST1(int[] nums)
        {
            TreeNode root = new TreeNode(nums[0]);
            var current = root;
            for (int i = 1; i < nums.Length; i++)
            {
                var next = new TreeNode(nums[i]);
                if (current.val > next.val)
                    current.left = next;
                else
                    current.right = next;
                BalanceTree(ref root);
                current = next;
            }
            return root;
        }


        public static void BalanceTree(ref TreeNode node)
        {
            if (node == null)
                return;
            if (node.left != null)
                BalanceTree(ref node.left);
            if (node.right != null)
                BalanceTree(ref node.right);
            var leftHeight = GetHeight(node.left);
            var rightHeight = GetHeight(node.right);
            if (leftHeight - rightHeight == 2 ||
                rightHeight - leftHeight == 2)
                node = BalanceNode(ref node, leftHeight, rightHeight);
            return;
        }

        public static int GetHeight(TreeNode node)
        {
            if (node == null)
                return 0;
            if (node.right == null && node.left == null)
                return 1;
            var left = GetHeight(node.left);
            var right = GetHeight(node.right);
            return left >= right ? left + 1 : right + 1;
        }

        public static TreeNode BalanceNode(ref TreeNode node, int left, int right)
        {
            if (left < right)
            {
                var rightSubTree = node.right;
                if (GetHeight(rightSubTree.left) <= GetHeight(rightSubTree.right))
                    LittleLeftRotate(ref node, ref rightSubTree);
                else
                    BigLeftRotate(ref node, ref rightSubTree, ref rightSubTree.right);
            }
            else
            {
                var leftSubTree = node.left;
                if (GetHeight(leftSubTree.right) <= GetHeight(leftSubTree.left))
                    LittleRightRotate(ref node, ref leftSubTree);
                else
                    BigRightRotate(ref node, ref leftSubTree, ref leftSubTree.left);
            }
            return node;
        }

        private static void LittleRightRotate(ref TreeNode nodeX, ref TreeNode nodeY)
        {
            var temp = nodeX;
            nodeX = nodeY;
            var temp2 = nodeX.right;
            nodeX.right = temp;
            temp.left = temp2;
        }

        private static void LittleLeftRotate(ref TreeNode nodeX, ref TreeNode nodeY)
        {
            var temp = nodeX;
            nodeX = nodeY;
            var temp2 = nodeX.left;
            nodeX.left = temp;
            temp.right = temp2;
        }

        private static void BigRightRotate(ref TreeNode nodeX, ref TreeNode nodeY, ref TreeNode nodeZ)
        {
            var temp = nodeX;
            nodeX = nodeZ;
            nodeY.right = nodeZ.left;
            nodeZ.left = nodeY;
            temp.left = nodeZ.right;
            nodeZ.right = temp;
        }

        private static void BigLeftRotate(ref TreeNode nodeX, ref TreeNode nodeY, ref TreeNode nodeZ)
        {
            var temp = nodeX;
            nodeX = nodeZ;
            nodeY.left = nodeZ.right;
            nodeZ.right = nodeY;
            temp.right = nodeZ.left;
            nodeZ.left = temp;
        }
    }
}
