using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
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
