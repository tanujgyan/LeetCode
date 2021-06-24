using Binary_Tree;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.ca/2020-07-02-1676-Lowest-Common-Ancestor-of-a-Binary-Tree-IV/
/// </summary>
namespace ALQ.Amazon_Tagged
{
    /// <summary>
    /// This builds upon the classic LCA problem here we have to search through a list of nodes and not just two nodes
    /// like the classic problem. The idea is same run a DFS and let it keep going till the end of every leaf
    /// we keep checking if the node that is coming is in the list of nodes or not if yes we will return it otherwise we follow the same path
    /// </summary>
    class LowestCommonAncestorIV
    {
        public TreeNode FindLCAForAll(TreeNode root, TreeNode[] nodes)
        {
            if (root == null || nodes==null ||nodes.Length==0)
            {
                return null;
            }
            HashSet<TreeNode> set = new HashSet<TreeNode>();
            foreach(var node in nodes)
            {
                set.Add(node);
            }
            var lcaNode = FindLCAForAllHelper(root, set);
            return lcaNode;
        }
        private TreeNode FindLCAForAllHelper(TreeNode root, HashSet<TreeNode> set)
        {
            if(root==null || set.Contains(root))
            {
                return root;
            }
            var left = FindLCAForAllHelper(root.left, set);
            var right = FindLCAForAllHelper(root.right, set);
            if(left!=null && right!=null)
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
