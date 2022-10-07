using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(p);
            queue.Enqueue(q);
            while (queue.Count > 0)
            {
                var first = queue.Dequeue();
                var second = queue.Dequeue();
                    
                if ((first.left != null && second.left == null) ||
                    (first.right != null && second.right == null) ||
                    (first.left == null && second.left != null) ||
                    (first.right == null && second != null) || 
                    (first.val != second.val))
                        return false;
                if (first.left != null)
                {
                    queue.Enqueue(first.left);
                    queue.Enqueue(second.left);
                }
                if (first.right != null)
                {
                    queue.Enqueue(first.right);
                    queue.Enqueue(second.right);
                }
            }
            return true;
        }
    }
}
