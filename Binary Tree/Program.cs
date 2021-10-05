using System;

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
            //DistributeCoinsInBTDriverCode();
            // PrintAllPathsOfATreeDriverCode();
            // RecoverBSTDriverCode();
            //MaximumDepthOfBTDriverCode();
            //BalancedBTDriverCode();
            //PathSumDriverCode();
           // MinDepthClassDriverCode();
            //PopulateNextRightPointersDriverCode();
            //RightSideViewOfBTDriverCode();
            //InvertBTDriverCode();
            KthSmallestElementInBSTDriverCode();
        }

        private static void KthSmallestElementInBSTDriverCode()
        {
            KthSmallestElementInBST kthSmallestElementInBST = new KthSmallestElementInBST();
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.left.right = new TreeNode(2);
            kthSmallestElementInBST.KthSmallest(root,1);
        }

        private static void InvertBTDriverCode()
        {
            InvertBT invertBT = new InvertBT();
            TreeNode treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2);
            treeNode.right = new TreeNode(3);
            treeNode.left.left = new TreeNode(4);
            treeNode.left.right = new TreeNode(5);
            treeNode.right.left = new TreeNode(6);
            //treeNode.right.right = new TreeNode(7);
            invertBT.InvertTree(treeNode);
        }

        private static void RightSideViewOfBTDriverCode()
        {
            RightSideViewOfBT rightSideViewOf = new RightSideViewOfBT();
            TreeNode root = new TreeNode(1);
           
            root.right = new TreeNode(3);
            root.right.right = new TreeNode(5);
            root.right.right.left = new TreeNode(6);
            root.right.right.right = new TreeNode(7);
            rightSideViewOf.RightSideView(root);
        }

        private static void PopulateNextRightPointersDriverCode()
        {
            PopulateNextRightPointers populateNextRightPointers = new PopulateNextRightPointers();
            Node node = new Node(1);
            node.left = new Node(2);
            node.right = new Node(3);
            node.left.left = new Node(4);
            node.left.right = new Node(5);
            node.right.left = new Node(6);
            node.right.right = new Node(7);
            populateNextRightPointers.Connect(node);
        }

        private static void MinDepthClassDriverCode()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            
            MinDepthClass minDepthClass = new MinDepthClass();
            minDepthClass.MinDepth(root);
        }

        private static void PathSumDriverCode()
        {
            PathSum pathSum = new PathSum();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            pathSum.HasPathSum(root, 1);
        }

        private static void BalancedBTDriverCode()
        {
            BalancedBT balancedBT = new BalancedBT();
            TreeNode root = new TreeNode(1);
           // root.left = new TreeNode(2);
            root.right = new TreeNode(3);
           
            //root.left.right = new TreeNode(4);
            //root.left.right.left = new TreeNode(7);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(6);
            balancedBT.IsBalanced(root);
        }

        private static void MaximumDepthOfBTDriverCode()
        {
            MaximumDepthOfBT maximumDepthOfBT = new MaximumDepthOfBT();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);
            maximumDepthOfBT.MaxDepth(root);
        }

        private static void RecoverBSTDriverCode()
        {
            RecoverBST recoverBST = new RecoverBST();
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(3);
            root.right = new TreeNode(1);
            //root.right.left = new TreeNode(2);
            recoverBST.RecoverTree(root);
        }

        private static void PrintAllPathsOfATreeDriverCode()
        {
            PrintAllPathsOfATree printAllPathsOfATree = new PrintAllPathsOfATree();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.left.left = new TreeNode(5);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(8);
            root.left.right.left = new TreeNode(6);
            printAllPathsOfATree.PrintPaths(root);
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
