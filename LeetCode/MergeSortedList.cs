using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MergeSortedList
    {
        public ListNode l1 = new ListNode();
        public ListNode l2 = new ListNode();

        /// <summary>
        /// if both list are null return null
        /// if one list is not null return list
        /// if both lists are not null, compare them and store the smaller value in queue. move the pointer
        /// when the lists are empty start dequeing from the queue and create a new list that will become return value
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            Queue<int> queue = new Queue<int>();
            ListNode l3 = new ListNode();
            if (l1 == null && l2 == null)
            {
                return null;
            }
            else if (l1 == null && l2 != null)
            {
                return l2;
            }
            else if (l1 != null && l2 == null)
            {
                return l1;
            }
            while (l1 != null || l2 != null)
            {
                if (l1 == null && l2 != null)
                {
                    queue.Enqueue(l2.val);
                    l2 = l2.next;
                    continue;
                }
                if (l1 != null && l2 == null)
                {
                    queue.Enqueue(l1.val);
                    l1 = l1.next;
                    continue;
                }
                if (l1.val <= l2.val)
                {
                    queue.Enqueue(l1.val);
                    l1 = l1.next;

                }
                else if (l2.val < l1.val)
                {
                    queue.Enqueue(l2.val);
                    l2 = l2.next;
                }

            }
            var templist = l3;
            while (queue.Count > 0)
            {
                if (templist.val == 0 && templist.next == null)
                {
                    templist.val = queue.Dequeue();
                    templist.next = new ListNode();
                    continue;
                }
                templist = templist.next;
                templist.val = queue.Dequeue();
                if (queue.Count != 0)
                    templist.next = new ListNode();
            }
            return l3;
        }

        public ListNode MergeTwoListsWithoutQueue(ListNode l1, ListNode l2)
        {
            var pointer1 = l1;
            ListNode result = new ListNode();
            var temp = result;
            if (l1 == null && l2 != null)
            {
                return l2;
            }
            if (l1 != null && l2 == null)
            {
                return l1;
            }
            if(l1.val<=l2.val)
            {
                result.val = l1.val;
                l1 = l1.next;
                
            }
            else
            {
                result.val = l2.val;
                l2 = l2.next;
            }
            while(l1!=null && l2!=null)
            {
                if(l1.val<l2.val)
                {
                    result.next = new ListNode(l1.val);
                    result = result.next;
                    l1 = l1.next;
                }
                else if(l1.val>l2.val)
                {
                    result.next = new ListNode(l2.val);
                    result = result.next;
                    l2 = l2.next;
                }
                else if(l1.val==l2.val)
                {
                    result.next = new ListNode(l1.val);
                    l1 = l1.next;
                    result = result.next;
                    result.next = new ListNode(l2.val);
                    l2 = l2.next;
                    result = result.next;
                }
            }
            if (l1 != null)
            {
                result.next = l1;
            }
            else if(l2!=null)
            {
                result.next = l2;
            }
            return temp;
        }

        public ListNode CreateSampleList(Queue<int> queue, ListNode listNode)
        {

            var templist = listNode;
            while (queue.Count > 0)
            {
                if (templist.val == 0 && templist.next == null)
                {
                    templist.val = queue.Dequeue();
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
