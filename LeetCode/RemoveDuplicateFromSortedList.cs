using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveDuplicateFromSortedList
    {
        public ListNode_RemoveDuplicate l = new ListNode_RemoveDuplicate();

        public ListNode_RemoveDuplicate CreateSampleList(Queue<int> queue, ListNode_RemoveDuplicate listNode)
        {

            var templist = listNode;
            while (queue.Count > 0)
            {
                if (templist.val == -301 && templist.next == null)
                {
                    templist.val = queue.Dequeue();
                    templist.next = new ListNode_RemoveDuplicate();
                    continue;
                }
                templist = templist.next;
                templist.val = queue.Dequeue();
                if (queue.Count != 0)
                    templist.next = new ListNode_RemoveDuplicate();
            }
            return listNode;
        }
        public ListNode_RemoveDuplicate DeleteDuplicates(ListNode_RemoveDuplicate head)
        {
            ListNode_RemoveDuplicate listNode = new ListNode_RemoveDuplicate();
            var tempList = listNode;
            if (head == null)
            {
                return null;
            }
            tempList.val = head.val;
            tempList.next = new ListNode_RemoveDuplicate();
            do
            {
                if (tempList.val != head.val)
                {
                    tempList = tempList.next;
                    tempList.val = head.val;
                    tempList.next = new ListNode_RemoveDuplicate();
                }
                head = head.next;
            } while (head != null);
            tempList.next = null;
            return listNode;
        }

    }
    public class ListNode_RemoveDuplicate
    {
        public int val;
        public ListNode_RemoveDuplicate next;
        public ListNode_RemoveDuplicate(int val = -301, ListNode_RemoveDuplicate next = null)
        {
            this.val = val;
            this.next = next;
        }

    }

}


