using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ReverseLinkedList
    {
        public ListNode ReverseLL(ListNode head)
        {
            dynamic prevNode = null;
            var current = head;
            while(current!=null)
            {
                var nextNode = current.next;
                current.next = prevNode;
                prevNode = current;
                current = nextNode;
            }
            return prevNode;
            
        }
        
    }
}
