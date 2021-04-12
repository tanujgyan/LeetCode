using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class SameTreeClass
    {


        public bool IsSameTree(TreeNode rootNode1, TreeNode rootNode2)
        {
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            if (rootNode1 == null && rootNode2 == null)
                return true;
            else if (rootNode1 != null && rootNode2 == null)
                return false;
            else if (rootNode1 == null && rootNode2 != null)
                return false;
            else
            {
                if(rootNode1.val==rootNode2.val)
                {
                    queue1.Enqueue(rootNode1.right);
                    queue1.Enqueue(rootNode1.left);
                    queue2.Enqueue(rootNode2.right);
                    queue2.Enqueue(rootNode2.left);

                    while(queue1.Count(x=>x!=null)> 0 || queue2.Count(x => x != null) > 0)
                    {
                        var child1 = queue1.Dequeue();
                        var child2 = queue2.Dequeue();
                        if((child1!=null && child2==null) || (child1 == null && child2 != null))
                        {
                            return false;
                        }
                        
                        if((child1 != null && child2 != null) && child1.val!=child2.val)
                        {
                            return false;
                        }
                       
                        else
                        {
                            if (child1 != null)
                            {
                                queue1.Enqueue(child1.right);
                                queue1.Enqueue(child1.left);
                            }
                            if (child2 != null)
                            {
                                queue2.Enqueue(child2.right);
                                queue2.Enqueue(child2.left);
                            }
                        }
                    }
                    if(queue1.Count(x => x != null) != 0 || queue2.Count(x => x != null) != 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
