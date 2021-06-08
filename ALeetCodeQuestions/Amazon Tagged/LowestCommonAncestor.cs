using Binary_Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ.Amazon_Tagged
{
    class LowestCommonAncestor
    {
        public TreeNode FindLCA(TreeNode root, int p,int q)
        {
            if(root==null)
            {
                return null;
            }
            if(root.val==p || root.val==q)
            {
                return root;
            }
            var left = FindLCA(root.left, p, q);
            var right = FindLCA(root.right, p, q);
            if (left != null && right != null)
            {
                return root;
            }
            else
            {
                return left == null ? right : left;
            }
        }
        
    }
}
