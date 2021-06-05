using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/intersection-of-two-linked-lists/
/// </summary>
namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// My solution is not right
    /// 
//    The correct solution is below
//        1. Get the length of the two lists.

//2, Align them to the same start point.

//3, Move them together until finding the intersection point, or the end null


//    /// public ListNode getIntersectionNode(ListNode headA, ListNode headB) {
//    int lenA = length(headA), lenB = length(headB);
//    // move headA and headB to the same start point
//    while (lenA > lenB) {
//        headA = headA.next;
//        lenA--;
//    }
//while (lenA < lenB)
//{
//    headB = headB.next;
//    lenB--;
//}
//// find the intersection until end
//while (headA != headB)
//{
//    headA = headA.next;
//    headB = headB.next;
//}
//return headA;
//}

//private int length(ListNode node)
//{
//    int length = 0;
//    while (node != null)
//    {
//        node = node.next;
//        length++;
//    }
//    return length;
//}
/// </summary>
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
