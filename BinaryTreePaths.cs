using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given the root of a binary tree, return all root-to-leaf paths in any order.
    /// </summary>
    public class BinaryTreePaths
    {
        public IList<string> FindBinaryTreePaths(TreeNode root)
        {
            var paths = new List<string>();
            var str = "";
            CheckPath(root, str, ref paths);
            return paths;
        }
        public static void CheckPath(TreeNode node, string str, ref List<string> list)
        {
            str += node.val.ToString();
            if (node.left == null && node.right == null)
                list.Add(str);
            if (node.left != null)
                CheckPath(node.left, str + "->", ref list);
            if (node.right != null)
                CheckPath(node.right, str + "->", ref list);
        }
    }
}
