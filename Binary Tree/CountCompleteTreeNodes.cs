using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/count-complete-tree-nodes/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// The idea behind algorithm is to utilize the formula for calculating the height of PBT is 2^h-1
    /// and PBT is a special case of complete binary tree. 
    /// A CBT can contain several PBTs within it. So what we do is we will calculate the left and right height of tree
    /// if they are equal it means its a PBT so we use the formula. 
    /// If its not we make left child as root and check again and right tree as root and check again
    /// In this way we keep doing a binary search in tree to check for PBTs and calculating the number of nodes.
    /// Recursion will keep on adding the results 
    /// Time Complexity 
    /// </summary>
    class CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            int count = CountNodesHelper(root);
            return count;
        }
        public int CountNodesHelper(TreeNode root)
        {
            int leftHeight = HeightOfLeftTree(root);
            int rightHeight = HeightOfRightTree(root);
            if (leftHeight == rightHeight)
            {
                return (int)(Math.Pow(2, leftHeight) - 1);
            }
            return CountNodesHelper(root.left) + CountNodesHelper(root.right) + 1;
        }
        public int HeightOfLeftTree(TreeNode root, int height = 0)
        {
            if (root == null)
            {
                return height;
            }
            height++;
            return HeightOfLeftTree(root.left, height);
        }
        public int HeightOfRightTree(TreeNode root, int height = 0)
        {
            if (root == null)
            {
                return height;
            }
            height++;
            return HeightOfRightTree(root.right, height);
        }
    }
}


