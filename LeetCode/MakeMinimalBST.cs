using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MakeMinimalBST
    {
        public void Minimal(int[] arr)
        {
            TreeNode tree = new TreeNode();
           var r = MinimalHelper(arr,0,arr.Length-1);
        }
        private TreeNode MinimalHelper(int[] arr,int low,int high)
        {
            if( low>high)
            {
                return null;
            }
            int mid = (low + high) / 2;
            TreeNode root = new TreeNode();
            root.val = arr[mid];

            root.left=MinimalHelper(arr, low, mid-1);
            root.right=MinimalHelper(arr, mid+1, high);
            return root;
        }
    }
}
