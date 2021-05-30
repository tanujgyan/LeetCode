using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
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
