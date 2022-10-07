using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    internal class AddTwoNumbers
    {
        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            var first = "";
            var second = "";
            var result = new ListNode();
            var current = result;
            while (l1.next != null)
            {
                first = l1.val.ToString() + first;
                l1 = l1.next;
            }
            first = l1.val.ToString() + first;
            while (l2.next != null)
            {
                second = l2.val.ToString() + second;
                l2 = l2.next;
            }
            second = l2.val.ToString() + second;
            var isIncrease = false;
            var number = "";
            for (int i = 0; i < (first.Length > second.Length ? first.Length : second.Length); i++)
            {
                if (i < second.Length && i < first.Length)
                {
                    if (isIncrease)
                    {
                        var temp = int.Parse(first[first.Length - 1 - i].ToString())
                            + int.Parse(second[second.Length - 1 - i].ToString()) + 1;
                        number = (temp > 9 ? temp % 10 : temp).ToString() + number;
                        isIncrease = temp > 9 ? true : false;
                    }
                    else
                    {
                        var temp = int.Parse(first[first.Length - 1 - i].ToString())
                            + int.Parse(second[second.Length - 1 - i].ToString());
                        number = (temp > 9 ? temp % 10 : temp).ToString() + number;
                        isIncrease = temp > 9 ? true : false;
                    }
                }
                else if (i >= first.Length)
                {
                    if (isIncrease)
                    {
                        var temp = int.Parse(second[second.Length - 1 - i].ToString()) + 1;
                        number = (temp > 9 ? temp % 10 : temp).ToString() + number;
                        isIncrease = temp > 9 ? true : false;
                    }
                    else
                    {
                        var temp = int.Parse(second[second.Length - 1 - i].ToString());
                        number = (temp > 9 ? temp % 10 : temp).ToString() + number;
                        isIncrease = temp > 9 ? true : false;
                    }
                }
                else if (i >= second.Length)
                {
                    if (isIncrease)
                    {
                        var temp = int.Parse(first[first.Length - 1 - i].ToString()) + 1;
                        number = (temp > 9 ? temp % 10 : temp).ToString() + number;
                        isIncrease = temp > 9 ? true : false;
                    }
                    else
                    {
                        var temp = int.Parse(first[first.Length - 1 - i].ToString());
                        number = (temp > 9 ? temp % 10 : temp).ToString() + number;
                        isIncrease = temp > 9 ? true : false;
                    }
                }
            }
            if (isIncrease)
                number = "1" + number;
            for (int i = 0; i < number.Length; i++)
            {
                if (i == number.Length - 1)
                {
                    current.val = Convert.ToInt32(number[number.Length - 1 - i].ToString());
                }
                else
                {
                    current.val = Convert.ToInt32(number[number.Length - 1 - i].ToString());
                    current.next = new ListNode();
                    current = current.next;
                }
            }
            return result;
        }

    }
}
