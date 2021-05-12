using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SumRootToLeafNodes
    {
        List<string> list = new List<string>();
        public int SumNumbers(TreeNode root)
        {
            SumNumbersHelper(root,"");
            int sum = 0;
            foreach(var l in list)
            {
                sum += Convert.ToInt32(l);
            }
            return sum;
        }
        private void SumNumbersHelper(TreeNode root,string temp)
        {
            
            
            if(root==null)
            {

                return;
            }
            temp += root.val;
            SumNumbersHelper(root.left,temp);
           SumNumbersHelper(root.right,temp);
            if(root.left==null && root.right==null)
            list.Add(temp);
            //return temp;
        }
    }
}
