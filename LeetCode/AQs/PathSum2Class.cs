using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/reorganize-string/
    /// </summary>
    class PathSum2Class
    {
        IList<string> totalList = new List<string>();
        /// <summary>
        /// Take the total list and do processing on it to convert it to return object
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            IList<IList<int>> finalList = new List<IList<int>>();
            if (root == null)
            {
                return finalList;
            }
            RecursiveCalls(root, targetSum);
           
            foreach (var s in totalList)
            {
                var arr = s.Split("_");

                List<int> retList = new List<int>();
                for (int i = 1; i < arr.Length; i++)
                {
                    retList.Add(Convert.ToInt32(arr[i]));
                }
                finalList.Add(retList);
            }
            return finalList;
        }
        /// <summary>
        /// Recursively go through the tree
        /// Earch node parsed should be added to a string with delimiter "_"
        /// Once target sum is achieved add the potential list to total list.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <param name="sum"></param>
        /// <param name="potentialList"></param>
        /// <returns></returns>
        public string RecursiveCalls(TreeNode root, int targetSum,int sum=0,string potentialList="")
        {
            if(root==null)
            {
                return null;
            }
            
            sum += root.val;
            if (sum==targetSum && root.left==null && root.right==null)
            {
                potentialList += "_" + root.val;
               
                totalList.Add(potentialList);
                potentialList = null;
                return potentialList;
            }
            if(sum != targetSum && root.left == null && root.right == null)
            {
                return potentialList;
            }
            
            potentialList += "_" + root.val;
            RecursiveCalls(root.left, targetSum, sum, potentialList);
            RecursiveCalls(root.right, targetSum, sum, potentialList);
            return null;
        }
    }
}
