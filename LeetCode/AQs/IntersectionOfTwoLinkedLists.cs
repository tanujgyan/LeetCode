using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class IntersectionOfTwoLinkedLists
    {
        public ListNode nodeA = new ListNode();
       public ListNode nodeB = new ListNode();

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var tempListA = headA;
            var tempListB = headB;
            ListNode intersectedList = null;
            ListNode savePoint = null;
            while (tempListA.next != null)
            {
                while (tempListB != null)
                {
                    if (tempListB.val == tempListA.val)
                    {
                        if (intersectedList == null)
                        {
                            intersectedList = tempListB.next;
                            savePoint = tempListA;
                        }
                        tempListA = tempListA.next;
                        tempListB = tempListB.next;
                    }
                    else
                    {
                        tempListB = tempListB.next;
                    }
                }
                if(tempListA==null)
                {
                    break;
                }
                else
                {
                    if (savePoint != null)
                    {
                        tempListA = savePoint;
                        tempListA = tempListA.next;
                    }
                    else
                    {
                        tempListA = tempListA.next;
                    }
                    tempListB = headB;
                    intersectedList = null;
                }
            }
            return intersectedList;
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
