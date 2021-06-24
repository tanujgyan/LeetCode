using Binary_Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ.Amazon_Tagged
{
    /// <summary>
    /// LCA refers to lowest common ancestor. Here there are two nodes so what we want to find is the node which is the root
    /// for both the nodes. TO do this we run a DFS and if we find the root whose value is equal to p or q we return that
    /// Now the return value will be propagated up automatically and if both left and right returns not null we return the root else 
    /// if left returns null we return right otherwise we return left
    /// </summary>
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
