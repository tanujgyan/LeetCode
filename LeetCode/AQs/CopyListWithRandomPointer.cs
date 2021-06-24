using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/copy-list-with-random-pointer/
/// </summary>
namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// The idea behind this algorithm is to first create a deep copy list with all the nodes. DONT try and copy random pointers at this time
    /// While creating the list create a dictionary and store the head as key and tempHead as value
    /// When we are done creating the list we will iterate over head again and this time we will see if the head has a random pointer
    /// we will go into dictionary and take the random pointer value from the dictionary which will be nothing but the corrosponding copy head node
    /// </summary>
    class CopyListWithRandomPointer
    {
        Dictionary<Node, Node> randomCache = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {
            var temp = head;
            var copyHead= CopyRandomListHelper(temp);
            var randomtemp = copyHead;
            var copyTemp = copyHead;
            temp = head;
            while (temp != null)
            {
                if(temp.random==null)
                {
                    copyTemp.random = null;
                    temp = temp.next;
                    copyTemp = copyTemp.next;
                    continue;
                }
                copyTemp.random = randomCache[temp.random];//CreateRandomPointerHelper(head, randomtemp,temp.random);
                temp = temp.next;
                copyTemp = copyTemp.next;
            }
            return copyHead;
           
        }
        public Node CreateRandomPointerHelper(Node temp, Node copyTemp, Node targetNode)
        {
            

            while(temp!= targetNode)
            {
                temp = temp.next;
                copyTemp = copyTemp.next;
            }
            return copyTemp;
        }
        public Node CopyRandomListHelper(Node temp,Node copyTemp=null)
        {
            if(temp==null)
            {
                return null;
            }
            copyTemp = new Node(temp.val);
            
            randomCache.Add(temp, copyTemp);
            copyTemp.next = CopyRandomListHelper(temp.next, copyTemp.next);
            return copyTemp;
        }
    }
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
