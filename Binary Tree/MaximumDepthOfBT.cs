using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/maximum-depth-of-binary-tree/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// The algorithm here is the standard DFS code with preorder traversal
    /// </summary>
    class MaximumDepthOfBT
    {
        private int maxDepth = 0;
        public int MaxDepth(TreeNode root)
        {
            MaxDepthHelper(root, 0);
            return maxDepth;

        }
        private void MaxDepthHelper(TreeNode root, int tempDepth)
        {
            if (root == null)
            {
                return;
            }
            tempDepth++;
            if (root.left == null && root.right == null)
            {
                maxDepth = Math.Max(tempDepth, maxDepth);
            }
            MaxDepthHelper(root.left, tempDepth);
            MaxDepthHelper(root.right, tempDepth);
        }
    }
}
