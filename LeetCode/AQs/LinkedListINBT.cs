using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    public class LinkedListINBT
    {
        Stack<string> s = new Stack<string>();
        bool matchFound = false;

        public bool IsLinkedListInBT(TreeNode treeNode, ListNode listNode )
        {
            int[] l = ConvertListToString(listNode);
            IsLinkedListInBTHelper(treeNode, "", listNode, l);
            return matchFound;
        }
        private void IsLinkedListInBTHelper(TreeNode treeNode, string temp, ListNode listNode, int[] l)
        {
            if (!matchFound)
            {
                if (treeNode == null)
                {
                    return;
                }

                temp += treeNode.val + "_";
                IsLinkedListInBTHelper(treeNode.left, temp, listNode, l);
                IsLinkedListInBTHelper(treeNode.right, temp, listNode, l);

                if (treeNode.left == null && treeNode.right == null)
                {
                    s.Push(temp);
                    matchFound = PopAndCompare(listNode, l);
                }
            }
        }
        private bool PopAndCompare(ListNode list, int[] l)
        {
            bool matchFound = false;
            while (s.Count > 0)
            {
                var sb = s.Pop().ToString();
                string[] arr = sb.Split("_");
                if (LengthOfLongestCommonSubstring(l, arr))
                {
                    matchFound = true;
                    break;
                }
            }
            return matchFound;


        }
        private bool LengthOfLongestCommonSubstring(int[] target, string[] arr)
        {
            int inputLength = arr.Length;
            int targetLength = target.Length;
            bool result = false;
            //check for edge cases

            if (inputLength < targetLength)
            {
                return false;
            }
            int[][] dpMatrix = new int[inputLength + 1][];
            //initialize dpMatrix
            for (int i = 0; i < inputLength + 1; i++)
            {
                dpMatrix[i] = new int[targetLength + 1];
                for (int j = 0; j < targetLength + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dpMatrix[i][j] = 0;
                    }
                }
            }

            //fill up the matrix
            for (int i = 1; i < inputLength + 1; i++)
            {
                for (int j = 1; j < targetLength + 1; j++)
                {
                    if (arr[i - 1] == Convert.ToString(target[j - 1]))
                    {
                        if (i - 2 >= 0 && j - 2 >= 0)
                        {
                            if (arr[i - 2] == Convert.ToString(target[j - 2]))
                            {
                                dpMatrix[i][j] = 1 + dpMatrix[i - 1][j - 1];
                            }
                            else
                            {
                                dpMatrix[i][j] = Math.Max(dpMatrix[i - 1][j], dpMatrix[i][j - 1]);
                            }
                        }
                        else
                        {
                            dpMatrix[i][j] = 1 + dpMatrix[i - 1][j - 1];
                        }
                    }
                    else
                    {
                        dpMatrix[i][j] = Math.Max(dpMatrix[i - 1][j], dpMatrix[i][j - 1]);
                    }
                }
            }
            if (dpMatrix[inputLength][targetLength] == targetLength)
            {
                result = true;
            }

            return result;
        }
        private int[] ConvertListToString(ListNode head)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            return list.ToArray();
        }

    }
}
