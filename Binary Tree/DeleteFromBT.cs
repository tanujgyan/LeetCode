using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    /// <summary>
    /// Given a binary tree, delete a node from it by making sure that tree shrinks from the bottom 
    /// (i.e. the deleted node is replaced by bottom most and rightmost node). 
    /// This is different from BST deletion. Here we do not have any order among elements, so we replace with last element.
    /// </summary>
    class DeleteFromBT
    {
        TreeNode lastNode;
        TreeNode ToBeDeletedNode;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int lastNodeValue = 0;
        
        ///ALGORITHM...............................................................START
        
        /// <summary>
        /// YOU CANNOT DELTE A ROOT FROM BINARY TREE
        /// TO DELETE YOU NEED TO FIND THE ROOT OF NODE TO BE DELETED AND THEN SET THE RIGHT/LEFT CHILD TO NULL
        /// This algorithm first does a level order traversal and finds the last element and element to be deleted.
        /// Then it does a pre order traversal to actually delete and set the nodes.
        
        /// ///ALGORITHM...............................................................END
        
        /// </summary>
        /// <param name="val"></param>
        /// <param name="root"></param>
        public void DeleteFromBTMethod(int val,TreeNode root)
        {
            GetLastNodeAndNodeToBeDeleted(root,val);
            DeleteLastNodeAndSetTheToBeDeletedNode(root);
        }
        private void GetLastNodeAndNodeToBeDeleted(TreeNode root,int val)
        {
           
            if(root==null)
            {
                return;
            }

        
            queue.Enqueue(root);
            while(queue.Count>0)
            {

                var temp = queue.Dequeue();
                if(temp.val==val)
                {
                    ToBeDeletedNode = temp;
                }
                if(temp.left!=null)
                {
                    queue.Enqueue(temp.left);
                }
                if(temp.right!=null)
                {
                    queue.Enqueue(temp.right);
                }
                if(queue.Count==0)
                {
                    lastNode = temp;
                    lastNodeValue = lastNode.val;
                }
            }
        }
        private void DeleteLastNodeAndSetTheToBeDeletedNode(TreeNode root)
        {
            if(root==null)
            {
                return;
            }
            if(root==ToBeDeletedNode)
            {
                root.val = lastNodeValue;
            }
            if(root.left!=null && root.left==lastNode)
            {
                root.left = null;
            }
            if(root.right!=null && root.right==lastNode)
            {
                root.right = null;
            }
            DeleteLastNodeAndSetTheToBeDeletedNode(root.left);
            DeleteLastNodeAndSetTheToBeDeletedNode(root.right);
        }
    }
}
