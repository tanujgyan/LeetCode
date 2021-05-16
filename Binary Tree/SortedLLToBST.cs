using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
    /// </summary>
    class SortedLLToBST
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            var tree = SortedListToBSTHelper(head);
            return tree;
        }
        private TreeNode SortedListToBSTHelper(ListNode head)
        {
            var mid = GetMidElementFromLinkedList(head);
            ListNode leftList;
            ListNode rightList;
            GetSubtrees(head, mid, out leftList, out rightList);
            if (head == null || mid == null)
            {
                return null;
            }
            TreeNode tree = new TreeNode(mid.val);

            tree.left = SortedListToBSTHelper(leftList);

            tree.right = SortedListToBSTHelper(rightList);
            return tree;
        }
        private ListNode GetMidElementFromLinkedList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        private void GetSubtrees(ListNode head, ListNode mid, out ListNode leftList, out ListNode rightList)
        {
            if (head == null || mid == null)
            {
                leftList = null;
                rightList = null;
                return;
            }
            //handle when only when item is present
            if(head==mid && head.next==null)
            {
                leftList = null;
                rightList = null;
                return;
            }
            leftList = head;
            while (leftList != null && leftList.next != null && leftList.next != mid)
            {
                leftList = leftList.next;
            }
            if (leftList.next != null)
            {
                rightList = leftList.next.next;
            }
            else
            {
                rightList = null;
            }
            leftList.next = null;
            leftList = head;
        }
    }
}
