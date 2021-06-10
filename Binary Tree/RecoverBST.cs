using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/recover-binary-search-tree/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// The idea of this algorithm is to first get the inorder traversal of tree
    /// Then sort the traversal to get the expected inorder traversal
    /// Compare the two traversals to find the out of order element
    /// Replace the elements by running inorder traversal again
    /// </summary>
    class RecoverBST
    {

        public void RecoverTree(TreeNode root)
        {
            List<int> temp = new List<int>();
            InorderTraversal(root, temp);
            List<int> inorderList = new List<int>(temp);
            temp.Sort();
            List<int> sortedInorderList = new List<int>(temp);
            var comparisonResults= CompareTwoList(inorderList, sortedInorderList);
            ReplaceNodes(root, comparisonResults);
        }
        private void InorderTraversal(TreeNode root, List<int> inorderList)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversal(root.left, inorderList);
            inorderList.Add(root.val);
            InorderTraversal(root.right, inorderList);
        }
        private void ReplaceNodes(TreeNode root, int[] replacementNodes)
        {
            if(root==null)
            {
                return;
            }
            if(root.val==replacementNodes[0])
            {
                root.val = replacementNodes[1];
            }
            else if(root.val==replacementNodes[1])
            {
                root.val = replacementNodes[0];
            }
            ReplaceNodes(root.left,replacementNodes);
            ReplaceNodes(root.right,replacementNodes);
        }
        private int[] CompareTwoList(List<int> inorder, List<int> sortedinorder)
        {
            int[] result = new int[2];
            for (int i = 0; i < inorder.Count; i++)
            {
                if(inorder[i]!=sortedinorder[i])
                {
                    result[0] = inorder[i];
                    result[1] = sortedinorder[i];
                }
            }
            return result;
        }
    }
}
