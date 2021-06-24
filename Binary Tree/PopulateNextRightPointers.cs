using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
/// </summary>
namespace Binary_Tree
{
    /// <summary>
    /// The idea here is to run BFS (level order traversal) and populate the next pointer
    /// </summary>
    class PopulateNextRightPointers
    {
        public Node Connect(Node root)
        {
            if(root==null)
            {
                return root;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while(queue.Count(x=>x!=null) >0)
            {
                var temproot = queue.Dequeue();
                if (temproot != null)
                {
                    temproot.next = queue.Peek();
                    if (temproot.left != null)
                    {
                        queue.Enqueue(temproot.left);
                    }
                    if (temproot.right != null)
                    {
                        queue.Enqueue(temproot.right);
                    }
                }
                else
                {
                    queue.Enqueue(null);
                }
            }
            return root;
        }
    }
}
