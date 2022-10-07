using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// </summary>
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return head;
            ListNode prev = null;
            ListNode current = head;
            ListNode next = head.next;
            while (current.next != null)
            {
                current.next = prev;
                prev = current;
                current = next;
                next = next.next;
            }
            current.next = prev;
            return current;
        }
    }
}
