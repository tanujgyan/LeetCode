using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/binary-tree-right-side-view/
/// </summary>
namespace Binary_Tree
{
 /// <summary>
 /// The idea behind this algorithm is to do a BFS and separate the last element of the level by a null
 /// so for example we put root and then put null because root is the last element of its level
 /// When we do a queue peek and see it is null that means the current element is the rightmost element so we add 
 /// it to result.
 /// </summary> 
    class RightSideViewOfBT
    {
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root==null)
            {
                return new List<int>();
            }
            queue.Enqueue(root);
            queue.Enqueue(null);
            while(queue.Count(x=>x!=null)>0)
            {
                var temproot = queue.Dequeue();
                if (temproot != null)
                {
                    if (temproot.left != null)
                    {
                        queue.Enqueue(temproot.left);
                    }
                    if (temproot.right != null)
                    {
                        queue.Enqueue(temproot.right);
                    }
                    //if first element of queue is null 
                    //copy current element to result
                    if (queue.Peek() == null)
                    {
                        result.Add(temproot.val);
                    }
                }
                //if we dequeue a null that means we have processed all results of that level
                //enqueue a null to mark end of level
                else
                {
                    queue.Enqueue(null);
                }
            }
            return result;
        }
    }
}
