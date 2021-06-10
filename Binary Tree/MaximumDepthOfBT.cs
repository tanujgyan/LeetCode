using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/maximum-depth-of-binary-tree/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// The algorithm here is the standard DFS and backtracking code with preorder traversal
    /// </summary>
    class MaximumDepthOfBT
    {
        private int maxDepth = 0;
        public int MaxDepth(TreeNode root)
        {
            List<TreeNode> list = new List<TreeNode>();
            MaxDepthHelper(root, list);
            return maxDepth;

        }
        private void MaxDepthHelper(TreeNode root, List<TreeNode> list)
        {
            if(root==null)
            {
                return;
            }
            list.Add(root);
            if(root.left==null && root.right==null && list.Count>0)
            {
                maxDepth = Math.Max(list.Count, maxDepth);
            }
            MaxDepthHelper(root.left, list);
            MaxDepthHelper(root.right, list);
            list.RemoveAt(list.Count - 1);
        }
    }
}
