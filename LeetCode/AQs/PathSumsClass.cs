using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class PathSumsClass
    {
        bool? targetAchieved=null;
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.left == null && root.right == null && targetSum - root.val == 0)
            {
                return true;
            }
            else
            {
                var a = HasPathSum(root.left, targetSum - root.val);
                var b = HasPathSum(root.right, targetSum - root.val);
                return a || b;
            }
        }

        public bool HasPathSum2(TreeNode treeNode, int targetSum)
        {

            var result = RecursiveCalls(treeNode.left, treeNode.val, targetSum);

            if (!result)
                result = RecursiveCalls(treeNode.right, treeNode.val, targetSum);

            return result;
        }
        public bool RecursiveCalls(TreeNode root, int sum, int targetSum)
        {
            if(targetAchieved!=null)
            {
                return (bool)targetAchieved;
            }

                if (root == null)
                {
                    return false;
                }
                sum += root.val;

                if (root.left == null && root.right == null)
                {
                    if (sum == targetSum)
                    {
                        targetAchieved = true;
                        return true;

                    }


                }

                 RecursiveCalls(root.left, sum, targetSum);
                    RecursiveCalls(root.right, sum, targetSum);
            
            return targetAchieved??false;
           
        }

    }



}
