using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class RemoveDuplicatesFromSortedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            var dict = new Dictionary<int, int>();
            var current = head;
            var root = new ListNode(head.val);
            var currRoot = root;
            dict.Add(head.val, 1);
            while (current != null)
            {
                if (!dict.ContainsKey(current.val))
                {
                    dict.Add(current.val, 1);
                    currRoot.next = new ListNode(current.val);
                    currRoot = currRoot.next;
                    current = current.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return root;
        }
    }
}
