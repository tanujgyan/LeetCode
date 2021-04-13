using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SymmetricTreeClass
    {
        public bool IsSymmetric(TreeNode root)
        {
            return isMirror(root, root);
        }
        public bool isMirror(TreeNode treeNode1, TreeNode treeNode2)
        {
            if(treeNode1==null && treeNode2==null)
            {
                return true;
            }
            else
            {
                if(treeNode1!=null && treeNode2!=null && treeNode1.val==treeNode2.val)
                {
                    return isMirror(treeNode1.left, treeNode2.right) && isMirror(treeNode1.right, treeNode2.left);
                }
            }
            return false;
        }
    }
}
