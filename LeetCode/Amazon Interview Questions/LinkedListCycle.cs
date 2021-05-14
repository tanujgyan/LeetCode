using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class LinkedListCycle
    {
        /// <summary>
        /// https://leetcode.com/problems/linked-list-cycle/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            if(head==null)
            {
                return true;
            }
            var p1 = head;
            var p2 = head;
            while(p1.next!=null && p1.next.val!=Int32.MinValue)
            {
                p1.val = Int32.MinValue;
                p1 = p1.next;
            }
            if(p1.next==null)
            {
                return false;
            }
            return true;

        }
    }
}
