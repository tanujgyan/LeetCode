using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class PathSum
    {
        private bool sumFound = false;
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            HasPathSumHelper(root, targetSum, 0);
            return sumFound;
        }
        private void HasPathSumHelper(TreeNode root, int targetSum, int currentSum)
        {
            if (root == null || sumFound)
            {
                return;
            }

            currentSum += root.val;

            HasPathSumHelper(root.left, targetSum, currentSum);
            HasPathSumHelper(root.right, targetSum, currentSum);
            if (currentSum == targetSum && root.left == null && root.right == null)
            {
                sumFound = true;
            }
        }
    }
}
