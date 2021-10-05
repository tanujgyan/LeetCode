using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// This is a simple algorithm and we just have to do inorder traversal on BST
    /// and return k-1 element
    /// </summary>
    class KthSmallestElementInBST
    {
        List<int> list = new List<int>();
        public int KthSmallest(TreeNode root, int k)
        {
           KthSmallestHelper(root);
            return list[k - 1];
        }
        private void KthSmallestHelper(TreeNode root)
        {
            if(root==null)
            {
                return;
            }
            
            KthSmallestHelper(root.left);
            list.Add(root.val);
            KthSmallestHelper(root.right);
            
        }
    }
}
