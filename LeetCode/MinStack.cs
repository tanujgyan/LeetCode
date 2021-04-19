﻿using System.Collections.Generic;
/// <summary>
/// https://leetcode.com/problems/min-stack/
/// </summary>
public class MinStack
{
    List<int> stacklist;
    /** initialize your data structure here. */
    public MinStack()
    {
        stacklist = new List<int>();
    }

    public void Push(int val)
    {
        stacklist.Insert(0, val);
    }

    public void Pop()
    {
        stacklist.RemoveAt(0);
    }

    public int Top()
    {
        return stacklist[0];
    }

    public int GetMin()
    {
        int min = stacklist[0];
        for (int i = 1; i < stacklist.Count; i++)
        {
            if (stacklist[i] < min)
            {
                min = stacklist[i];
            }
            // stacklist.Remove(stacklist[i]);
        }
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */