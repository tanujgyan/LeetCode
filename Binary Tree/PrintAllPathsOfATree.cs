using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class PrintAllPathsOfATree
    {
        List<TreeNode> l = new List<TreeNode>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        public void PrintPaths(TreeNode root)
        {
            if (root != null)
            {
                queue.Enqueue(root);
            }
            while (queue.Count > 0)
            {
                var r = queue.Dequeue();
                if (r.left != null)
                    PrintPathsHelper(r.left); //yaha se inorder m chalao and sare nodes leke ao
                if (r.right != null)
                    PrintPathsHelper(r.right); ////yaha se inorder m chalao and sare nodes leke ao
            }

        }
        private void PrintPathsHelper(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            l.Add(root);
            if (root.left == null && root.right == null && l.Count > 0)
            {
                foreach (var e in l)
                {
                    Console.Write(e.val + "_");
                }
                Console.WriteLine("----------");
                //remove leaf node
                l.RemoveAt(l.Count - 1);
                return;
            }

            PrintPathsHelper(root.left);
            PrintPathsHelper(root.right);
            //remove processed root node
            l.RemoveAt(l.Count - 1);

        }
    }
}
