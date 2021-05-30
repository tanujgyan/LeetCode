using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class DiameterOfBinTree
    {
        private int result = Int32.MinValue;
        private int maxSumVal = Int32.MinValue;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            DiameterOfBinaryTreeHelper(root);
            return result-1; //we need to count the number of edges so it will be 1 less than number of nodes
        }
        private int DiameterOfBinaryTreeHelper(TreeNode root)
        {
            if(root==null)
            {
                return 0;
            }
            int left = DiameterOfBinaryTreeHelper(root.left);
            int right = DiameterOfBinaryTreeHelper(root.right);
            int temp = 1 + Math.Max(left, right); // if this is not going to be the diameter then we can take one path and send it above
            //if this is the answer it will be this
            int ans = Math.Max(1 + left + right, result);
            result = Math.Max(ans, result); //lets see if this is better than what we had so far
            return temp; //if this is not the answer this is the max it can contribute
        }

        public int MaxSum(TreeNode root)
        {
            MaxSumHelper(root);
            return maxSumVal;
        }
        private int MaxSumHelper(TreeNode root)
        {
            if(root==null)
            {
                return 0;
            }

            int left = MaxSumHelper(root.left);
            int right = MaxSumHelper(root.right);
            //a node is deciding if it has to pass what should it pass
            //its left sum, right sum or itself to handle negative values
            int temp = Math.Max(Math.Max(left, right) + root.val, root.val); 
           //here we decide if we want to keep this root as ans what will it be
            int ans = Math.Max(temp, left + right + root.val);
            //compare and update the final variable holding the answer
            maxSumVal = Math.Max(ans, maxSumVal);
            return temp;//this is the real deal here
        }
    }
}
