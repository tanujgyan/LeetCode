using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
/// </summary>
namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// The ide of this algorithm is to traverse the tree in preorder and store all nodes in a queue
    /// Once the traversal is done start dequeuing the queue while setting the left to null and right to next
    /// </summary>
    class FlattenBinaryTreetoDLL
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        public void Flatten(TreeNode root)
        {

            TreeNode temp = root;
            FlattenHelper(root);
           
            while(q.Count>0)
            {
                temp.val = q.Dequeue().val;
                temp.left = null;
                if (q.Count > 0)
                {
                    temp.right = new TreeNode();
                    temp = temp.right;
                }

            }
            
            
        }
        private void FlattenHelper(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            q.Enqueue(root);
            FlattenHelper(root.left);
            FlattenHelper(root.right);
        }
    }
}
