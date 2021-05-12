using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    class LevelOrderTraversalOfBT
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Queue<TreeNode> levelOrderQueue = new Queue<TreeNode>();
            if(root!=null)
            {
                levelOrderQueue.Enqueue(root);
                //null marks the demarcation line of level
                levelOrderQueue.Enqueue(null);
                result.Add(new List<int>());
            }
            else
            {
                return result; 
            }
            while (levelOrderQueue.Count(x => x != null) > 0)
            {
                if (levelOrderQueue.Peek() != null)
                {
                    root = levelOrderQueue.Peek();
                    result.Last().Add(levelOrderQueue.Dequeue().val);
                   
                    if (root.left != null)
                        levelOrderQueue.Enqueue(root.left);
                    if (root.right != null)
                        levelOrderQueue.Enqueue(root.right);
                }
                //if we encounter a null that means we are moving down to another level
                else if(levelOrderQueue.Peek()==null)
                {
                   
                    levelOrderQueue.Dequeue();
                    levelOrderQueue.Enqueue(null);
                    result.Add(new List<int>());
                }

            }
            return result;
        }
    }
    //public class TreeNode
    //{
    //    public int val;
    //    public TreeNode left;
    //    public TreeNode right;
    //    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    //    {
    //        this.val = val;
    //        this.left = left;
    //        this.right = right;
    //    }
    //}
}
