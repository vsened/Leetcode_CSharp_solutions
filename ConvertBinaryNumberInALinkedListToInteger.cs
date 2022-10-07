using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class ConvertBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            var result = "";
            while (head != null)
            {
                result += head.val.ToString();
                head = head.next;
            }
            return Convert.ToInt32(result, 2);
        }
    }
}
