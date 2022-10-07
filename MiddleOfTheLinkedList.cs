using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MiddleOfTheLinkedList
    {
        /// <summary>
        /// Given the head of a singly linked list, return the middle node of the linked list.
        /// If there are two middle nodes, return the second middle node.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode MiddleNode(ListNode head)
        {
            var mid = head;
            var current = head;
            int count = 1;
            while (current != null)
            {
                if (count % 2 == 1 && count > 2)
                {
                    mid = mid.next;
                }
                current = current.next;
                count++;
            }
            if (count % 2 == 1)
                mid = mid.next;
            return mid;
        }
        public ListNode MiddleNode2(ListNode head)
        {
            ListNode p1 = head;
            ListNode p2 = head;

            while (p2 != null && p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
            }

            return p1;
        }
    }

    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}
}
