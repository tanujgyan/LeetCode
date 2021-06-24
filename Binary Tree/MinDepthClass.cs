    using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class MinDepthClass
    {
        private int minDepth = int.MaxValue;
        public int MinDepth(TreeNode root)
        {
            if(root==null)
            {
                return 0;
            }
            MinDepthHelper(root, 0);
            return minDepth;
        }
        private void MinDepthHelper(TreeNode root, int tempDepth)
        {
            if (root == null)
            {
                return;
            }
            tempDepth++;
            if (root.left == null && root.right == null)
            {
                minDepth = Math.Min(tempDepth, minDepth);
            }
            MinDepthHelper(root.left, tempDepth);
            MinDepthHelper(root.right, tempDepth);
        }
    }
}
