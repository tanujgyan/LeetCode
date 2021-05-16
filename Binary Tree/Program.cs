﻿using System;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeleteFromBTDriverCode();
            // InOrderPreOrderToPostOrderDriverCode();
            //SortedArraytoBSTClassDriverCode();
            //SortedLLToBSTDriverCode();
            DistributeCoinsInBTDriverCode();
        }

        private static void DistributeCoinsInBTDriverCode()
        {
            DistributeCoinsInBT distributeCoinsInBT = new DistributeCoinsInBT();
            TreeNode treeNode = new TreeNode(0);
            treeNode.left = new TreeNode(3);
            treeNode.right = new TreeNode(0);
            //treeNode.left.left = new TreeNode(3);
            //treeNode.left.right = new TreeNode(2);
            distributeCoinsInBT.DistributeCoins(treeNode);
        }

        private static void SortedLLToBSTDriverCode()
        {
            SortedLLToBST sortedLLToBST = new SortedLLToBST();
            ListNode head = new ListNode(-10);
            head.next = new ListNode(-3);
            head.next.next = new ListNode(0);
            head.next.next.next = new ListNode(5);
            head.next.next.next.next = new ListNode(9);
            sortedLLToBST.SortedListToBST(head);
        }

        private static void SortedArraytoBSTClassDriverCode()
        {
            SortedArraytoBSTClass sortedArraytoBSTClass = new SortedArraytoBSTClass();
            sortedArraytoBSTClass.SortedArrayToBST(new int[] { 1,3 });
        }

        private static void InOrderPreOrderToPostOrderDriverCode()
        {
            InOrderPreOrderToPostOrder inOrderPreOrderToPostOrder = new InOrderPreOrderToPostOrder();
            inOrderPreOrderToPostOrder.InOrderPreOrderToPostOrderMethod(new int[] { 4, 2, 5, 1, 3, 6 }, new int[] { 1, 2, 4, 5, 3, 6 });
        }
    
        private static void DeleteFromBTDriverCode()
        {
            DeleteFromBT deleteFromBT = new DeleteFromBT();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.right = new TreeNode(3);
            root.right.right = new TreeNode(5);
            deleteFromBT.DeleteFromBTMethod( 2, root);
        }
    }
}
