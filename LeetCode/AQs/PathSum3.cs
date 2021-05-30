using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class PathSum3
    {
        private int totalcount = 0;
        private Stack<int> s = new Stack<int>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        private int max = 0;
        List<int> list = new List<int>();
        //public int PathSum(TreeNode root, int targetSum)
        //{
        //    q.Enqueue(root);
        //    while (q.Count > 0)
        //    {
        //        var r = q.Dequeue();
        //        if (r.left != null)
        //        {
        //            q.Enqueue(r.left);
        //        }
        //        if (r.right != null)
        //        {
        //            q.Enqueue(r.right);
        //        }
        //        PathSumHelper(r, targetSum, "");
        //    }
        //    while (s.Count > 0)
        //    {
        //        string[] temp = s.Pop().Split("_");
        //        int sum = 0;
        //        foreach (var e in temp)
        //        {
        //            Int32.TryParse(e, out int r);
        //            sum += r;
        //        }
        //        list.Add(sum);
        //    }
        //    return totalcount;
        //}
        //private void PathSumHelper(TreeNode root, int targetSum, string currentsum)
        //{
        //    if (root == null)
        //    {
        //        return;
        //    }
        //    currentsum += "_" + root.val;
        //    s.Push(currentsum);
        //    PathSumHelper(root.left, targetSum, currentsum);
        //    PathSumHelper(root.right, targetSum, currentsum);
        //    //if(root.left==null && root.right==null)
        //    //{
        //    //    s.Push(currentsum);
        //    //}

        //}

        public int PathSum(TreeNode root, int targetSum)
        {
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var r = q.Dequeue();
                if (r.left != null)
                {
                    q.Enqueue(r.left);
                }
                if (r.right != null)
                {
                    q.Enqueue(r.right);
                }
                PathSumHelper(r, targetSum, 0);
            }

            return totalcount = s.Count(x => x == targetSum);
        }
        private void PathSumHelper(TreeNode root, int targetSum, int currentsum)
        {
            if (root == null)
            {
                return;
            }
            currentsum += root.val;
            s.Push(currentsum);
            PathSumHelper(root.left, targetSum, currentsum);
            PathSumHelper(root.right, targetSum, currentsum);
        }
        public int CalculateUnivaluePath(TreeNode root)
        {
            var r = CalculateUnivaluePathHelper(root);
            return r;
        }
        //this is DP for trees
        //so we will have to see if a tree can be the one with max univalue
        //when we have to return to parent we check and return the max of left subtree or right subtree because parent can take
        //only one node
        private int CalculateUnivaluePathHelper(TreeNode root, int result = 0)
        {
            if (root == null)
            {
                return 0;
            }

            int left = CalculateUnivaluePathHelper(root.left);
            int right = CalculateUnivaluePathHelper(root.right);
            int leftlength = 0;
            int rightlength = 0;

            
            if (root.left != null && root.left.val == root.val)
            {
                leftlength += left + 1;
            }

            if (root.right != null && root.right.val == root.val)
            {
                rightlength += right + 1;
            }

            max = Math.Max(max, leftlength + rightlength);

            return Math.Max(leftlength, rightlength);


        }
    }
}
