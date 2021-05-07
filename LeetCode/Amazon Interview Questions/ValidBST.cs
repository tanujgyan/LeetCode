using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-search-tree/
    /// </summary>
    class ValidBST
    {

        private bool? result = null;
        public bool IsValidBST(TreeNode root)
        {
            long min = Int64.MinValue;
            long max = Int64.MaxValue;
            if(root==null)
            {
                return false;
            }
            InorderTraversal(root.left, min, root.val);
            InorderTraversal(root.right, root.val, max);
            return result == null ? true : false;
        }
        public void InorderTraversal(TreeNode root, long min,long max)
        {
            if(root==null)
            {
                return;
            }
            if(root.val<=min)
            {
                result = false;
                return;
            }
            if (root.val>= max)
            {
                result = false;
                return;
            }
            InorderTraversal(root.left, min, root.val);
            Console.WriteLine(root.val);
            InorderTraversal(root.right, root.val,max);
        }
    }
}

