using Binary_Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ.Amazon_Tagged
{
    class DistanceBWTwoNodesOfBT
    {
        public int findDistance(TreeNode root, int p, int q)
        {
            LowestCommonAncestor lowestCommonAncestor = new LowestCommonAncestor();
            var lca = lowestCommonAncestor.FindLCA(root, p, q);
            var totalDistance = getDistanceFromLCA(lca, p) + getDistanceFromLCA(lca, q);
            return totalDistance;

        }
        public int getDistanceFromLCA(TreeNode root, int x)
        {
            if(root==null)
            {
                return -1;
            }
            else if(root.val==x)
            {
                return 0;
            }
            var leftDistance = getDistanceFromLCA(root.left, x);
            var rightDistance = getDistanceFromLCA(root.right, x);
            int subDistance = Math.Max(leftDistance, rightDistance);
            return subDistance >= 0 ? subDistance + 1: -1;
        }
    }
}
