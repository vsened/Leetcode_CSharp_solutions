using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given head, the head of a linked list, determine if the linked list has a cycle in it.
    /// </summary>
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            var dict = new Dictionary<ListNode, int>();
            var current = head;
            while(current != null)
            {
                if (dict.ContainsKey(current))
                    return true;
                else
                    dict.Add(current, current.val);
                current = current.next;
            }
            return false;
        }
    }
}
