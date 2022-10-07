using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class TwoSum4InputIsABST
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var dict = new Dictionary<int, int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (dict.ContainsKey(k - current.val))
                    return true;
                dict.Add(current.val, 1);
                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }
            return false;
        }
    }
}
