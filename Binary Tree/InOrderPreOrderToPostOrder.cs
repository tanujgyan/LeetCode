using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Tree
{
    class InOrderPreOrderToPostOrder
    {
        Stack<int> s = new Stack<int>();
        TreeNode main = new TreeNode(10);
        public void InOrderPreOrderToPostOrderMethod(int[] inorder, int[] preorder)
        {
           
           var r=  InOrderPreOrderToPostOrderMethodHelper(inorder, preorder) ;
        }
        public TreeNode InOrderPreOrderToPostOrderMethodHelper(int[] inorder, int[] preorder)
        {

            if (inorder.Length == 0)
            {
                return null;
            }
            //find the first element of preorder
            int root = preorder[0];
            TreeNode treeNode = new TreeNode(root);
            
            //s.Push(root);
            int rootIndexInInorder = FindIndex(root, inorder);
            int sizeOfLeftArray = rootIndexInInorder;
            int sizeOfRightArray = preorder.Length - 1 - rootIndexInInorder;

            int[] leftInorderArray = new int[sizeOfLeftArray];
            int[] leftPreorderArray = new int[sizeOfLeftArray];

            int[] rightInorderArray = new int[sizeOfRightArray];
            int[] rightPreorderArray = new int[sizeOfRightArray];

            PopulateArray(inorder, leftInorderArray, 0);
            PopulateArray(inorder, rightInorderArray, rootIndexInInorder + 1);

            PopulateArray(preorder, leftPreorderArray, 1);
            PopulateArray(preorder, rightPreorderArray, sizeOfLeftArray + 1);


            treeNode.left= InOrderPreOrderToPostOrderMethodHelper(leftInorderArray, leftPreorderArray);
         treeNode.right = InOrderPreOrderToPostOrderMethodHelper(rightInorderArray, rightPreorderArray);
           
           return treeNode;
        }

        private int FindIndex(int element, int[] inorder)
        {
            for (int i = 0; i < inorder.Length; i++)
            {
                if (inorder[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }
        private void PopulateArray(int[] source, int[] destination, int startIndex)
        {
            for (int i = 0; i < destination.Length; i++)
            {
                destination[i] = source[startIndex];
                startIndex++;
            }
        }
    }
}
