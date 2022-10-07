using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if (list1 == null && list2 == null)
                return list1;
            if (list1 == null || list2 == null)
                return list1 == null ? list2 : list1;

            ListNode head = new ListNode();
            var current = head;
            if (list1.val <= list2.val)
            {
                current.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                current.val = list2.val;
                list2 = list2.next;
            }

            while (true)
            {
                if (list1 == null && list2 == null)
                    break;
                if (list1 == null)
                {
                    current.next = list2;
                    current = current.next;
                    list2 = list2.next;
                }
                else if (list2 == null)
                {
                    current.next = list1;
                    current = current.next;
                    list1 = list1.next;
                }
                else if (list1.val <= list2.val)
                {
                    current.next = list1;
                    current = current.next;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    current = current.next;
                    list2 = list2.next;
                }
            }

            return head;
        }
    }
}
