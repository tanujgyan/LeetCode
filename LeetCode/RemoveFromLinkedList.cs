using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/remove-linked-list-elements/
    /// </summary>
    class RemoveFromLinkedList
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }
            var temp = head;
            while (temp.next != null)
            {
                //if first element is the element to remove
                if(temp.val==val)
                {
                    head = head.next;
                    temp = head;
                    continue;
                }
                //check the element next to one you are standing on is the element to remove
                if (temp.next.val == val)
                {
                    temp.next = temp.next.next;
                }
                //move pointer
                else
                {
                    temp = temp.next;
                }
            }
            if(head.val==val)
            {
                return null;
            }
            return head;
        }
    }
}
