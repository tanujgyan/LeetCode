using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PalindromicLinkedList
    {
        ReverseLinkedList reverse;

        public PalindromicLinkedList(ReverseLinkedList reverse)
        {
            this.reverse = reverse;
        }

        public bool IsPalindrome(ListNode head)
        {
            //1. define two pointers fast and slow
            var current = head;
            var fast = current;
            var slow = current;

            //2. move fast by 2 steps and slow by 1 step
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            slow = reverse.ReverseLL(slow);
            fast = head;
            while (slow != null)
            {
                if (fast.val != slow.val)
                {
                    return false;
                }
                fast = fast.next;
                slow = slow.next;
            }

            return true;
        }
    }
}
