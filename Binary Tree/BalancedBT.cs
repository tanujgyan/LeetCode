using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/balanced-binary-tree/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// The idea behind this algorithm is two steps
    /// 1. Use Traversal method to go to leaf node first and then ask Am i balanced by calling IsBalancedHelper
    /// 2. Is Balanced method checks the height of left and right tree and sets isBalanced variable
    /// 3. Once isBalanced is determined to be false we can stop checking 
    /// </summary>
    class BalancedBT
    {
        private bool isBalanced = true;

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            Traversal(root);
            return isBalanced;
        }
        private int IsBalancedHelper(TreeNode root, int count)
        {
            if(!isBalanced)
            {
                return 0;
            }
            if (root == null)
            {
                return 0;
            }
            count++;
            if (root.left == null && root.right == null)
            {
                return count;
            }

            return Math.Max(IsBalancedHelper(root.left, count), IsBalancedHelper(root.right, count));
        }
        private TreeNode Traversal(TreeNode root)
        {
            if (!isBalanced)
            {
                return null;
            }
            if (root == null)
            {
                return null;
            }
            var left = Traversal(root.left);
            var right = Traversal(root.right);
            //Am i balanced
            if (Math.Abs(IsBalancedHelper(left, 0) - IsBalancedHelper(right, 0)) <= 1)
            {
                isBalanced = false;
            }
            return root;
        }
    }
}
