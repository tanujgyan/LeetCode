using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    /// </summary>
    class SortedArraytoBSTClass
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
           var tree=  SortedArrayToBSTHelper(nums);
            return tree;
        }
        private TreeNode SortedArrayToBSTHelper(int[] nums)
        {
            int high = nums.Length;
            int low = 0;
            if(low>=high)
            {
                return null;
            }
            int mid = (low + high) / 2;
            int root = nums[mid];
            TreeNode tree = new TreeNode(root);
            tree.left = SortedArrayToBSTHelper(CreateArrayForLeftTree(nums,mid));
            tree.right = SortedArrayToBSTHelper(CreateArrayForRightTree(nums,mid));
            return tree;
        }
        private int[] CreateArrayForLeftTree(int[] nums, int mid)
        {
            
            int[] arr = new int[mid];
            Array.Copy(nums,0,arr,0,mid);
            return arr;
        }
        private int[] CreateArrayForRightTree(int[] nums,int mid)
        {
            int[] arr = new int[nums.Length-mid-1];
            Array.Copy(nums, mid+1, arr, 0, nums.Length - mid - 1);
            return arr;
        }
    }
}
