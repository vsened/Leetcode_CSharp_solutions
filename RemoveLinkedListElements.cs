using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class RemoveLinkedListElements
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode newList = new ListNode(0);
            newList.next = head;
            ListNode prev = newList;
            while (prev.next != null)
            {
                if (prev.next.val == val)
                {
                    prev.next = prev.next.next;
                }
                else
                    prev = prev.next;
            }
            return newList.next;
        }
    }
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next; 
        }
    }
}
