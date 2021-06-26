using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/invert-binary-tree/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// The idea here is to do a simple DFS and go to the leafmost node of tree
    /// At the leaf node when there is no left and right we return
    /// then we go one level up as stack starts unraveling itself and we swap the left and right child
    /// we keep going up and swap keeps happening till we reach the root and get the inverted tree
    /// </summary>
    class InvertBT
    {
        /// <summary>
        /// Space Complexity is O(n) since we have to store every node in stack once
        /// Time complexity is O(n) since we have to visit n nodes
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree(TreeNode root)
        {
            InvertTreeHelper(root);
            return root;
        }
        private void InvertTreeHelper(TreeNode root)
        {
            if(root==null)
            {
                return;
            }
            if(root.left==null && root.right==null)
            {
                return;
            }
            InvertTreeHelper(root.left);
            InvertTreeHelper(root.right);
            TreeNode temproot = root.left;
            root.left = root.right;
            root.right = temproot;
        }
    }
}
