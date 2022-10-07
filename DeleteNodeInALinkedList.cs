using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Write a function to delete a node in a singly-linked list. You will not be 
    /// given access to the head of the list, instead you will be given access to 
    /// the node to be deleted directly.
    /// </summary>
    internal class DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            while (node.next.next != null)
            {
                node.val = node.next.val;
                node = node.next;
            }
            node.val = node.next.val;
            node.next = null;
        }
    }
}
