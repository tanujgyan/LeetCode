using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class DistributeCoinsInBT
    {
        private int count = 0;
        public int DistributeCoins(TreeNode root)
        {
           var count= DistributeCoinsHelper(root);
            return count;
        }
        private int DistributeCoinsHelper(TreeNode root)
        {
            if(root==null)
            {
                return 0;
            }
           
            int left= DistributeCoinsHelper(root.left);
            int right = DistributeCoinsHelper(root.right);
            //ans will be calculated as what left can return + what right can return
            count += Math.Abs(left) + Math.Abs(right);
            //every node will calculate its value and return it
            //the value calculation will be done as what left can return + what right can return and root will keep 1 
            return root.val + left + right - 1;
            
        }
    }
}
