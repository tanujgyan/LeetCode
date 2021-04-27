using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MyQueue
    {
        Stack<int> inbox;
        Stack<int> outbox;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            inbox = new Stack<int>();
            outbox = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            inbox.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            while(inbox.Count>0)
            {
                outbox.Push(inbox.Pop());
            }
            var ret = outbox.Pop();
            while(outbox.Count>0)
            {
                inbox.Push(outbox.Pop());
            }
            return ret;
        }

        /** Get the front element. */
        public int Peek()
        {
            while (inbox.Count > 0)
            {
                outbox.Push(inbox.Pop());
            }
            var ret = outbox.Peek();
            while (outbox.Count > 0)
            {
                inbox.Push(outbox.Pop());
            }
            return ret;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            if (inbox.Count == 0)
                return true;
            return false;
        }
    }
}
