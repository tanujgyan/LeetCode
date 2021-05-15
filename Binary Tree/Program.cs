using System;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeleteFromBTDriverCode();
            InOrderPreOrderToPostOrderDriverCode();
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
