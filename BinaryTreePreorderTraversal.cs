using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var values = new List<int>();
            PreorderTraversal(root, ref values);
            return values;
        }
        private void PreorderTraversal(TreeNode node, ref List<int> list)
        {
            if (node == null)
                return;
            list.Add(node.val);
            PreorderTraversal(node.left, ref list);
            PreorderTraversal(node.right, ref list);
        }
    }
}
