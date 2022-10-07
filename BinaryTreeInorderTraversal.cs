using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class BinaryTreeInorderTraversal
    {
        public IList<int> GetInorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            InorderTraversal(root, ref result);
            return result;
        }
        public static void InorderTraversal(TreeNode node, ref List<int> list)
        {
            if (node == null)
                return;
            InorderTraversal(node.left, ref list);
            list.Add(node.val);
            InorderTraversal(node.right,ref list);
        }
    }
}
