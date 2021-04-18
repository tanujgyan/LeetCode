using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// Given the head of a linked list, remove the nth node from the end of the list and return its head.
    /// April 2021, 18 Challenege
    /// </summary>
    class RemoveNthNodeFromLast
    {
        public ListNode l1 = new ListNode();
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var tempList = head;
            ListNode createlist = new ListNode();
            ListNode templist = createlist;
            Queue<int> queue = new Queue<int>();
            int index = 0;
            while (tempList != null)
            {
                queue.Enqueue(tempList.val);
                tempList = tempList.next;
            }
            int indexToRemove = queue.Count - n;
            //remove first item
            if (queue.Count > 0 && index == indexToRemove)
            {
                queue.Dequeue();
                index++;
                //if there is only one item
                if (queue.Count == 0)
                {
                    return null;
                }

            }

            while (queue.Count > 0)
            {
                if (index != indexToRemove)
                {
                    templist.val = queue.Dequeue();
                    index++;
                    //if there are more items to be added and next item is not the item to remove
                    if (queue.Count > 0 && index != indexToRemove)
                    {
                        templist.next = new ListNode();
                        templist = templist.next;
                    }
                }
                else
                {
                    queue.Dequeue();
                    index++;
                    //if there are more items to be added after removing the item that needs to be removed
                    if (queue.Count > 0)
                    {
                        templist.next = new ListNode();
                        templist = templist.next;
                    }
                }
            }

            return createlist;

        }
        public ListNode CreateSampleList(Queue<int> queue, ListNode listNode)
        {

            var templist = listNode;
            while (queue.Count > 0)
            {
                if (templist.val == 0 && templist.next == null)
                {
                    templist.val = queue.Dequeue();
                    if (queue.Count != 0)
                        templist.next = new ListNode();
                    continue;
                }
                templist = templist.next;
                templist.val = queue.Dequeue();
                if (queue.Count != 0)
                    templist.next = new ListNode();
            }
            return listNode;
        }
    }
}
