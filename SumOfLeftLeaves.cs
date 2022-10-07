using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class SumOfLeftLeaves
    {
        public int GetSumOfLeftLeaves(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int sum = 0;
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.left != null)
                {
                    if (current.left.left == null && current.left.right == null)
                        sum += current.left.val;
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                    queue.Enqueue(current.right);
            }
            return sum;
        }
    }
}
